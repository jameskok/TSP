
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Globalization;

namespace Tsp
{
    /// <summary>
    /// Main form for the Travelling Salesman Problem
    /// </summary>
    public partial class TspForm : Form
    {
        /// <summary>
        /// number of cities.
        /// </summary>
        /// <summary>
        /// The list of cities where we are trying to find the best tour.
        /// </summary>
        Cities cityList = new Cities();

        /// <summary>
        /// The class that does all the work in the TSP algorithm.
        /// If this is not null, then the algorithm is still running.
        /// </summary>
        Tsp tsp;
        Bitmap pic;
        PointF ulCorner = new PointF(0.0F, 0.0F);
        /// <summary>
        /// The image that we draw the tour on.
        /// </summary>
        Image cityImage;

        /// <summary>
        /// The graphics object for the image that we draw the tour on.
        /// </summary>
        Graphics cityGraphics;

        /// <summary>
        /// Delegate for the thread that runs the TSP algorithm.
        /// We use a separate thread so the GUI can redraw as the algorithm runs.
        /// </summary>
        /// <param name="sender">Object that generated this event.</param>
        /// <param name="e">Event arguments.</param>
        public delegate void DrawEventHandler(Object sender, TspEventArgs e);

        /// <summary>
        /// Default constructor.
        /// </summary>
        public TspForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// TSP algorithm raised an event that a new best tour was found.
        /// We need to do an invoke on the GUI thread before doing any draw code.
        /// </summary>
        /// <param name="sender">Object that generated this event.</param>
        /// <param name="e">Event arguments.</param>
        private void tsp_foundNewBestTour(object sender, TspEventArgs e)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new DrawEventHandler(DrawTour), new object[] { sender, e });
                    return;
                }
                catch (Exception)
                {
                    // This will fail when run as a control in IE due to a security exception.
                }
            }

            DrawTour(sender, e);
        }

        /// <summary>
        /// A new "best" tour from the TSP algorithm has been received.
        /// Draw the tour on the form, and update a couple of status labels.
        /// </summary>
        /// <param name="sender">Object that generated this event.</param>
        /// <param name="e">Event arguments.</param>
        public void DrawTour(object sender, TspEventArgs e)
        {
            this.lastFitnessValue.Text = Math.Round(e.BestTour.Fitness, 2).ToString(CultureInfo.CurrentCulture);
            this.lastIterationValue.Text = e.Generation.ToString(CultureInfo.CurrentCulture);

            if (cityImage == null)
            {
                cityImage = new Bitmap(tourDiagram.Width, tourDiagram.Height);
                cityGraphics = Graphics.FromImage(cityImage);
            }

            int lastCity = 0;
            int nextCity = e.BestTour[0].Connection1;

            cityGraphics.FillRectangle(Brushes.White, 0, 0, cityImage.Width, cityImage.Height);
            if(pic_d)
            cityGraphics.DrawImage(pic, ulCorner);

            foreach (City city in e.CityList)
            {
                // Draw a circle for the city.
                cityGraphics.DrawEllipse(Pens.Red, city.Location.X - 2, city.Location.Y - 2, 5, 5);

                // Draw the line connecting the city.
                cityGraphics.DrawLine(Pens.Red, cityList[lastCity].Location, cityList[nextCity].Location);

                // figure out if the next city in the list is [0] or [1]
                if (lastCity != e.BestTour[nextCity].Connection1)
                {
                    lastCity = nextCity;
                    nextCity = e.BestTour[nextCity].Connection1;
                }
                else
                {
                    lastCity = nextCity;
                    nextCity = e.BestTour[nextCity].Connection2;
                }
            }

            this.tourDiagram.Image = cityImage;

            if (e.Complete)
            {
                StartButton.Text = "Начать";
                StatusLabel.Text = "Выберете города на карте при помощи мыши или загрузите файл. Количество городов должно быть больше 5.";
                StatusLabel.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Draw just the list of cities.
        /// </summary>
        /// <param name="cityList">The list of cities to draw.</param>
        private void DrawCityList(Cities cityList)
        {
            Image cityImage = new Bitmap(tourDiagram.Width, tourDiagram.Height);
            Graphics graphics = Graphics.FromImage(cityImage);
            if(pic_d)
            graphics.DrawImage(pic, ulCorner);
            foreach (City city in cityList)
            {
                // Draw a circle for the city.
                graphics.DrawEllipse(Pens.Red, city.Location.X - 2, city.Location.Y - 2, 5, 5);
            }

            this.tourDiagram.Image = cityImage;

            updateCityCount();
        }

        /// <summary>
        /// User clicked the start button to start the TSP algorithm.
        /// If it is already running, then this button will say stop and we will stop the TSP.
        /// Otherwise, 
        /// </summary>
        /// <param name="sender">Object that generated this event.</param>
        /// <param name="e">Event arguments.</param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            // we are already running, so tell the tsp thread to halt.
            if (tsp != null)
            {
                tsp.Halt = true;
                return;
            }

            int populationSize = 0;
            int maxGenerations = 0;
            int mutation = 0;
            int groupSize = 0;
            int numberOfCloseCities = 0;
            int chanceUseCloseCity = 0;
            int seed = 0;

            try
            {
                populationSize = Convert.ToInt32(populationSizeTextBox.Text, CultureInfo.CurrentCulture);
                maxGenerations = Convert.ToInt32(maxGenerationTextBox.Text, CultureInfo.CurrentCulture);
                mutation = Convert.ToInt32(mutationTextBox.Text, CultureInfo.CurrentCulture);
                groupSize = Convert.ToInt32(groupSizeTextBox.Text, CultureInfo.CurrentCulture);
                numberOfCloseCities = Convert.ToInt32(NumberCloseCitiesTextBox.Text, CultureInfo.CurrentCulture);
                chanceUseCloseCity = Convert.ToInt32(CloseCityOddsTextBox.Text, CultureInfo.CurrentCulture);
                seed = Convert.ToInt32(randomSeedTextBox.Text, CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
            }

            if (populationSize <= 0)
            {
                MessageBox.Show("Укажите размер популяции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (maxGenerations <= 0)
            {
                MessageBox.Show("Задайте максимальное число поколений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if ((mutation < 0) || (mutation > 100))
            {
                MessageBox.Show("Шанс мутаций должно быть между 0 и 100", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if ((groupSize < 2) || (groupSize > populationSize))
            {
                MessageBox.Show("Размер рабочей группы задается между 2 и размером популяций.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if ((numberOfCloseCities < 3) || (numberOfCloseCities >= cityList.Count))
            {
                MessageBox.Show("Число городов-соседей для создания начальной популяции должно быть между 3 и числом городов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if ((chanceUseCloseCity < 0) || (chanceUseCloseCity > 95))
            {
                MessageBox.Show("Вероятность использования города-соседа при создании начальной популяции лежит между 0 и 100", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (seed < 0)
            {
                MessageBox.Show("Затравка датчика случайных чисел не может быть менее нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (cityList.Count < 5)
            {
                MessageBox.Show("Выберете города на карте при помощи мыши или загрузите файл. Количество городов должно быть больше 5. ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (lenghts_text_box.Text == "" && Cities.is_ev == false)
            {
                MessageBox.Show("При работе с не евкидовым графом необходимо загрусть файл с матрицей смежности ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            if (is_loaded_lenghts == false && Cities.is_ev == false)
            {
                MessageBox.Show("При работе с не евкидовым графом необходимо загрусть файл с матрицей смежности и обработать его ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            this.StartButton.Text = "Стоп";
            ThreadPool.QueueUserWorkItem(new WaitCallback(BeginTsp));
        }

        /// <summary>
        /// Starts up the TSP class.
        /// This function executes on a thread pool thread.
        /// </summary>
        /// <param name="stateInfo">Not used</param>
        private void BeginTsp(Object stateInfo)
        {
            // Assume the StartButton_Click did all the error checking
            int populationSize = Convert.ToInt32(populationSizeTextBox.Text, CultureInfo.CurrentCulture);
            int maxGenerations = Convert.ToInt32(maxGenerationTextBox.Text, CultureInfo.CurrentCulture); ;
            int mutation = Convert.ToInt32(mutationTextBox.Text, CultureInfo.CurrentCulture);
            int groupSize = Convert.ToInt32(groupSizeTextBox.Text, CultureInfo.CurrentCulture);
            int seed = Convert.ToInt32(randomSeedTextBox.Text, CultureInfo.CurrentCulture);
            int numberOfCloseCities = Convert.ToInt32(NumberCloseCitiesTextBox.Text, CultureInfo.CurrentCulture);
            int chanceUseCloseCity = Convert.ToInt32(CloseCityOddsTextBox.Text, CultureInfo.CurrentCulture);

            cityList.CalculateCityDistances(numberOfCloseCities);

            tsp = new Tsp();
            tsp.foundNewBestTour += new Tsp.NewBestTourEventHandler(tsp_foundNewBestTour);
            tsp.Begin(populationSize, maxGenerations, groupSize, mutation, seed, chanceUseCloseCity, cityList);
            tsp.foundNewBestTour -= new Tsp.NewBestTourEventHandler(tsp_foundNewBestTour);
            tsp = null;
        }

        /// <summary>
        /// User is selecting a new city list XML file.
        /// Not allowed if running the TSP algorithm.
        /// </summary>
        /// <param name="sender">Object that generated this event.</param>
        /// <param name="e">Event arguments.</param>
        /// 

        private void selectFileButton_Click2(object sender, EventArgs e)
        {
            OpenFileDialog fileOpenDialog = new OpenFileDialog();
            fileOpenDialog.Filter = "TXT(*.txt)|*.txt";
            fileOpenDialog.InitialDirectory = ".";
            fileOpenDialog.ShowDialog();
            lenghts_text_box.Text = fileOpenDialog.FileName;
        }


        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpenDialog = new OpenFileDialog();
            fileOpenDialog.Filter = "XML(*.xml)|*.xml";
            fileOpenDialog.InitialDirectory = ".";
            fileOpenDialog.ShowDialog();
            fileNameTextBox.Text = fileOpenDialog.FileName;
        }


        /// <summary>
        /// User has chosen to open the 
        /// Not allowed if running the TSP algorithm.
        /// </summary>
        /// <param name="sender">Object that generated this event.</param>
        /// <param name="e">Event arguments.</param>
        private void openCityListButton_Click(object sender, EventArgs e)
        {
            string fileName = "";

            try
            {
                if (tsp != null)
                {
                    StatusLabel.Text = "Нельзя изменить список городов во время работы программы.";
                    StatusLabel.ForeColor = Color.Red;
                    return;
                }

                fileName = this.fileNameTextBox.Text;

                cityList.OpenCityList(fileName);
                DrawCityList(cityList);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден: " + fileName, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Плохой формат XML-файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Не выбран файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// User has selected to clear the city list.
        /// Not allowed if running the TSP algorithm.
        /// </summary>
        /// <param name="sender">Object that generated this event.</param>
        /// <param name="e">Event arguments.</param>
        private void clearCityListButton_Click(object sender, EventArgs e)
        {
            if (tsp != null)
            {
                StatusLabel.Text = "Нельзя изменить список городов во время работы программы.";
                StatusLabel.ForeColor = Color.Red;
                return;
            }

            cityList.Clear();
            this.DrawCityList(cityList);
        }

        /// <summary>
        /// User clicked a point on the city map.
        /// As long as we aren't running the TSP algorithm,
        /// place a new city on the map and add it to the city list.
        /// </summary>
        /// <param name="sender">Object that generated this event.</param>
        /// <param name="e">Event arguments.</param>
        private void tourDiagram_MouseDown(object sender, MouseEventArgs e)
        {
            if (tsp != null)
            {
                StatusLabel.Text = "Нельзя изменить список городов во время работы программы.";
                StatusLabel.ForeColor = Color.Red;
                return;
            }

            cityList.Add(new City(e.X, e.Y));

            DrawCityList(cityList);
          
        }

        /// <summary>
        /// Display the number of cities on the form.
        /// </summary>
        private void updateCityCount()
        {
            this.NumberCitiesValue.Text = cityList.Count.ToString();
        }



        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void fileNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumberCitiesLabel_Click(object sender, EventArgs e)
        {

        }


        private void open_lenghts_click(object sender, EventArgs e)
        {
            string fileName = "";

            try
            {
                if (tsp != null)
                {
                    StatusLabel.Text = "Нельзя изменить расстояния между городами во время работы программы.";
                    StatusLabel.ForeColor = Color.Red;
                    return;
                }

                fileName = lenghts_text_box.Text;

                //cityList.OpenCityList(fileName);
                //DrawCityList(cityList);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден: " + fileName, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Плохой формат TXT-файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Не выбран файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tourDiagram_Click(object sender, EventArgs e)
        {

        }
        bool is_loaded_lenghts = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if(lenghts_text_box.Text == "")
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            is_loaded_lenghts = true;
                int now, i = 0, j = 0;
                double tmp = 0;
                
                string way = lenghts_text_box.Text;
                string[] texts = File.ReadAllLines(way, Encoding.Default);
                foreach (string text in texts)
                {
                    j = 0;
                    for (now = 0; now < text.Length; now++)
                    {
                        if (char.GetNumericValue(text[now]) >= 0 && char.GetNumericValue(text[now]) <= 9)
                        {
                            tmp = tmp * 10 + char.GetNumericValue(text[now]);
                        }
                        else
                        {
                        Cities.aa[i, j] = tmp;
                            j++;
                            tmp = 0;
                        }
                    }
                Cities.aa[i, j] = tmp;
                    tmp = 0;
                    i++;
                }
            double n = 0;
            string s = NumberCitiesValue.Text;
            for (i = 0; i < s.Length; i++)
            {
                n = n * 10 + char.GetNumericValue(s[i]);
            }

            Cities.num_of_c = n;




        }

        private void NumberCitiesValue_Click(object sender, EventArgs e)
        {

        }

        private void is_e_CheckedChanged(object sender, EventArgs e)
        {
            if (is_e.Checked)
            {
                Cities.is_ev = true;
                StatusLabel.Text = "Выберете города на карте при помощи мыши или загрузите файл. Количество городов должно быть больше 5.";
            }
            else
            {
                Cities.is_ev = false;
                StatusLabel.Text = "Загрузите матрицу смежности чтобы задать расстояния между городами.Если между точками нет дороги, то вес такого ребра должен быть много больше других";
            }
        }
        bool pic_d = false;
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_d = new OpenFileDialog();
            open_d.Filter = "Image Files(*.BMP;*.JPG,*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_d.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pic_d = true;
                    pic = new Bitmap(open_d.FileName);
                    //cityGraphics.DrawImage(pic, ulCorner);
                }
                catch
                {
                    DialogResult rez = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
            tourDiagram.Image = pic;
        }

        private void groupSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}




