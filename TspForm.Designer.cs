
namespace Tsp
{
    partial class TspForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.populationSizeTextBox = new System.Windows.Forms.TextBox();
            this.PopulationSizeLabel = new System.Windows.Forms.Label();
            this.lastIterationLabel = new System.Windows.Forms.Label();
            this.lastIterationValue = new System.Windows.Forms.Label();
            this.lastTourLabel = new System.Windows.Forms.Label();
            this.lastFitnessValue = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.maxGenerationLabel = new System.Windows.Forms.Label();
            this.maxGenerationTextBox = new System.Windows.Forms.TextBox();
            this.groupSizeLabel = new System.Windows.Forms.Label();
            this.groupSizeTextBox = new System.Windows.Forms.TextBox();
            this.randomSeedTextBox = new System.Windows.Forms.TextBox();
            this.randomSeedLabel = new System.Windows.Forms.Label();
            this.openCityListButton = new System.Windows.Forms.Button();
            this.clearCityListButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.mutationTextBox = new System.Windows.Forms.TextBox();
            this.mutationLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NumberCitiesLabel = new System.Windows.Forms.Label();
            this.NumberCitiesValue = new System.Windows.Forms.Label();
            this.NumberCloseCitiesTextBox = new System.Windows.Forms.TextBox();
            this.NumberCloseCitiesLabel = new System.Windows.Forms.Label();
            this.CloseCityOddsTextBox = new System.Windows.Forms.TextBox();
            this.CloseCityOddsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lenghts_text_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.is_e = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tourDiagram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // populationSizeTextBox
            // 
            this.populationSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.populationSizeTextBox.Location = new System.Drawing.Point(736, 49);
            this.populationSizeTextBox.Name = "populationSizeTextBox";
            this.populationSizeTextBox.Size = new System.Drawing.Size(116, 21);
            this.populationSizeTextBox.TabIndex = 1;
            this.populationSizeTextBox.Text = "10000";
            // 
            // PopulationSizeLabel
            // 
            this.PopulationSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopulationSizeLabel.AutoSize = true;
            this.PopulationSizeLabel.Location = new System.Drawing.Point(736, 33);
            this.PopulationSizeLabel.Name = "PopulationSizeLabel";
            this.PopulationSizeLabel.Size = new System.Drawing.Size(116, 13);
            this.PopulationSizeLabel.TabIndex = 0;
            this.PopulationSizeLabel.Text = "Размер популяции";
            // 
            // lastIterationLabel
            // 
            this.lastIterationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastIterationLabel.AutoSize = true;
            this.lastIterationLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastIterationLabel.Location = new System.Drawing.Point(12, 718);
            this.lastIterationLabel.Name = "lastIterationLabel";
            this.lastIterationLabel.Size = new System.Drawing.Size(156, 16);
            this.lastIterationLabel.TabIndex = 0;
            this.lastIterationLabel.Text = "Количество итераций";
            // 
            // lastIterationValue
            // 
            this.lastIterationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastIterationValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastIterationValue.Location = new System.Drawing.Point(168, 721);
            this.lastIterationValue.Name = "lastIterationValue";
            this.lastIterationValue.Size = new System.Drawing.Size(117, 13);
            this.lastIterationValue.TabIndex = 0;
            // 
            // lastTourLabel
            // 
            this.lastTourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastTourLabel.AutoSize = true;
            this.lastTourLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastTourLabel.Location = new System.Drawing.Point(356, 718);
            this.lastTourLabel.Name = "lastTourLabel";
            this.lastTourLabel.Size = new System.Drawing.Size(228, 16);
            this.lastTourLabel.TabIndex = 0;
            this.lastTourLabel.Text = "Последняя максимальная длина";
            // 
            // lastFitnessValue
            // 
            this.lastFitnessValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastFitnessValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastFitnessValue.Location = new System.Drawing.Point(590, 721);
            this.lastFitnessValue.Name = "lastFitnessValue";
            this.lastFitnessValue.Size = new System.Drawing.Size(85, 13);
            this.lastFitnessValue.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(758, 594);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(87, 34);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(733, 301);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(133, 13);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "Файл с городами XML";
            this.fileNameLabel.Click += new System.EventHandler(this.fileNameLabel_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Location = new System.Drawing.Point(736, 317);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(116, 21);
            this.fileNameTextBox.TabIndex = 6;
            this.fileNameTextBox.Text = "../../Cities.xml";
            // 
            // maxGenerationLabel
            // 
            this.maxGenerationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxGenerationLabel.AutoSize = true;
            this.maxGenerationLabel.Location = new System.Drawing.Point(733, 144);
            this.maxGenerationLabel.Name = "maxGenerationLabel";
            this.maxGenerationLabel.Size = new System.Drawing.Size(142, 13);
            this.maxGenerationLabel.TabIndex = 0;
            this.maxGenerationLabel.Text = "Количество поколений";
            // 
            // maxGenerationTextBox
            // 
            this.maxGenerationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxGenerationTextBox.Location = new System.Drawing.Point(736, 160);
            this.maxGenerationTextBox.Name = "maxGenerationTextBox";
            this.maxGenerationTextBox.Size = new System.Drawing.Size(116, 21);
            this.maxGenerationTextBox.TabIndex = 4;
            this.maxGenerationTextBox.Text = "10000000";
            // 
            // groupSizeLabel
            // 
            this.groupSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSizeLabel.AutoSize = true;
            this.groupSizeLabel.Location = new System.Drawing.Point(736, 109);
            this.groupSizeLabel.Name = "groupSizeLabel";
            this.groupSizeLabel.Size = new System.Drawing.Size(94, 13);
            this.groupSizeLabel.TabIndex = 0;
            this.groupSizeLabel.Text = "Размер группы";
            // 
            // groupSizeTextBox
            // 
            this.groupSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSizeTextBox.Location = new System.Drawing.Point(736, 123);
            this.groupSizeTextBox.Name = "groupSizeTextBox";
            this.groupSizeTextBox.Size = new System.Drawing.Size(116, 21);
            this.groupSizeTextBox.TabIndex = 3;
            this.groupSizeTextBox.Text = "5";
            this.groupSizeTextBox.TextChanged += new System.EventHandler(this.groupSizeTextBox_TextChanged);
            // 
            // randomSeedTextBox
            // 
            this.randomSeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedTextBox.Location = new System.Drawing.Point(736, 277);
            this.randomSeedTextBox.Name = "randomSeedTextBox";
            this.randomSeedTextBox.Size = new System.Drawing.Size(116, 21);
            this.randomSeedTextBox.TabIndex = 5;
            this.randomSeedTextBox.Text = "0";
            // 
            // randomSeedLabel
            // 
            this.randomSeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedLabel.AutoSize = true;
            this.randomSeedLabel.Location = new System.Drawing.Point(736, 261);
            this.randomSeedLabel.Name = "randomSeedLabel";
            this.randomSeedLabel.Size = new System.Drawing.Size(88, 13);
            this.randomSeedLabel.TabIndex = 0;
            this.randomSeedLabel.Text = "Затравка ГСЧ";
            // 
            // openCityListButton
            // 
            this.openCityListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openCityListButton.Location = new System.Drawing.Point(725, 478);
            this.openCityListButton.Name = "openCityListButton";
            this.openCityListButton.Size = new System.Drawing.Size(146, 23);
            this.openCityListButton.TabIndex = 8;
            this.openCityListButton.Text = "Обработать города";
            this.openCityListButton.UseVisualStyleBackColor = true;
            this.openCityListButton.Click += new System.EventHandler(this.openCityListButton_Click);
            // 
            // clearCityListButton
            // 
            this.clearCityListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCityListButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearCityListButton.Location = new System.Drawing.Point(742, 565);
            this.clearCityListButton.Name = "clearCityListButton";
            this.clearCityListButton.Size = new System.Drawing.Size(113, 23);
            this.clearCityListButton.TabIndex = 9;
            this.clearCityListButton.Text = "Очистить карту";
            this.clearCityListButton.UseVisualStyleBackColor = true;
            this.clearCityListButton.Click += new System.EventHandler(this.clearCityListButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 747);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(528, 52);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Выберете города на карте при помощи мыши или загрузите файл. Количество городов д" +
    "олжно быть больше 5.";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileButton.Location = new System.Drawing.Point(725, 449);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(146, 23);
            this.selectFileButton.TabIndex = 7;
            this.selectFileButton.Text = "Загрузить города";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // mutationTextBox
            // 
            this.mutationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mutationTextBox.Location = new System.Drawing.Point(736, 87);
            this.mutationTextBox.Name = "mutationTextBox";
            this.mutationTextBox.Size = new System.Drawing.Size(116, 21);
            this.mutationTextBox.TabIndex = 2;
            this.mutationTextBox.Text = "3";
            // 
            // mutationLabel
            // 
            this.mutationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mutationLabel.AutoSize = true;
            this.mutationLabel.Location = new System.Drawing.Point(733, 73);
            this.mutationLabel.Name = "mutationLabel";
            this.mutationLabel.Size = new System.Drawing.Size(152, 13);
            this.mutationLabel.TabIndex = 10;
            this.mutationLabel.Text = "Вероятность мутации, %";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(69, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(589, 16);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "Решение задачи коммивояжера с использованием генетического алгоритма";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // NumberCitiesLabel
            // 
            this.NumberCitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCitiesLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberCitiesLabel.Location = new System.Drawing.Point(684, 757);
            this.NumberCitiesLabel.Name = "NumberCitiesLabel";
            this.NumberCitiesLabel.Size = new System.Drawing.Size(146, 22);
            this.NumberCitiesLabel.TabIndex = 12;
            this.NumberCitiesLabel.Text = "Количество городов";
            this.NumberCitiesLabel.Click += new System.EventHandler(this.NumberCitiesLabel_Click);
            // 
            // NumberCitiesValue
            // 
            this.NumberCitiesValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCitiesValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumberCitiesValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NumberCitiesValue.Location = new System.Drawing.Point(837, 759);
            this.NumberCitiesValue.Name = "NumberCitiesValue";
            this.NumberCitiesValue.Size = new System.Drawing.Size(48, 13);
            this.NumberCitiesValue.TabIndex = 13;
            this.NumberCitiesValue.Click += new System.EventHandler(this.NumberCitiesValue_Click);
            // 
            // NumberCloseCitiesTextBox
            // 
            this.NumberCloseCitiesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCloseCitiesTextBox.Location = new System.Drawing.Point(736, 197);
            this.NumberCloseCitiesTextBox.Name = "NumberCloseCitiesTextBox";
            this.NumberCloseCitiesTextBox.Size = new System.Drawing.Size(116, 21);
            this.NumberCloseCitiesTextBox.TabIndex = 15;
            this.NumberCloseCitiesTextBox.Text = "4";
            // 
            // NumberCloseCitiesLabel
            // 
            this.NumberCloseCitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCloseCitiesLabel.AutoSize = true;
            this.NumberCloseCitiesLabel.Location = new System.Drawing.Point(736, 181);
            this.NumberCloseCitiesLabel.Name = "NumberCloseCitiesLabel";
            this.NumberCloseCitiesLabel.Size = new System.Drawing.Size(120, 13);
            this.NumberCloseCitiesLabel.TabIndex = 14;
            this.NumberCloseCitiesLabel.Text = "N городов-соседей";
            // 
            // CloseCityOddsTextBox
            // 
            this.CloseCityOddsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseCityOddsTextBox.Location = new System.Drawing.Point(736, 237);
            this.CloseCityOddsTextBox.Name = "CloseCityOddsTextBox";
            this.CloseCityOddsTextBox.Size = new System.Drawing.Size(116, 21);
            this.CloseCityOddsTextBox.TabIndex = 18;
            this.CloseCityOddsTextBox.Text = "90";
            // 
            // CloseCityOddsLabel
            // 
            this.CloseCityOddsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseCityOddsLabel.AutoSize = true;
            this.CloseCityOddsLabel.Location = new System.Drawing.Point(733, 221);
            this.CloseCityOddsLabel.Name = "CloseCityOddsLabel";
            this.CloseCityOddsLabel.Size = new System.Drawing.Size(149, 13);
            this.CloseCityOddsLabel.TabIndex = 17;
            this.CloseCityOddsLabel.Text = "Шанс города-соседа, %";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Файл с расстояниями ";
            // 
            // lenghts_text_box
            // 
            this.lenghts_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lenghts_text_box.Location = new System.Drawing.Point(736, 368);
            this.lenghts_text_box.Name = "lenghts_text_box";
            this.lenghts_text_box.Size = new System.Drawing.Size(120, 21);
            this.lenghts_text_box.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(725, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Загрузить расстояния";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.selectFileButton_Click2);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.button2.Location = new System.Drawing.Point(725, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Обработать расстояния";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // is_e
            // 
            this.is_e.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.is_e.AutoSize = true;
            this.is_e.Checked = true;
            this.is_e.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_e.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.is_e.Location = new System.Drawing.Point(739, 645);
            this.is_e.Name = "is_e";
            this.is_e.Size = new System.Drawing.Size(129, 20);
            this.is_e.TabIndex = 23;
            this.is_e.Text = "Евклидов граф";
            this.is_e.UseVisualStyleBackColor = true;
            this.is_e.CheckedChanged += new System.EventHandler(this.is_e_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(719, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Загрузить изображение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tourDiagram
            // 
            this.tourDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourDiagram.BackColor = System.Drawing.Color.White;
            this.tourDiagram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tourDiagram.Location = new System.Drawing.Point(12, 49);
            this.tourDiagram.Name = "tourDiagram";
            this.tourDiagram.Size = new System.Drawing.Size(693, 661);
            this.tourDiagram.TabIndex = 0;
            this.tourDiagram.TabStop = false;
            this.tourDiagram.Click += new System.EventHandler(this.tourDiagram_Click);
            this.tourDiagram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tourDiagram_MouseDown);
            // 
            // TspForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 797);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.is_e);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lenghts_text_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseCityOddsTextBox);
            this.Controls.Add(this.CloseCityOddsLabel);
            this.Controls.Add(this.NumberCloseCitiesTextBox);
            this.Controls.Add(this.NumberCloseCitiesLabel);
            this.Controls.Add(this.NumberCitiesValue);
            this.Controls.Add(this.NumberCitiesLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.mutationTextBox);
            this.Controls.Add(this.mutationLabel);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.clearCityListButton);
            this.Controls.Add(this.openCityListButton);
            this.Controls.Add(this.randomSeedTextBox);
            this.Controls.Add(this.randomSeedLabel);
            this.Controls.Add(this.groupSizeTextBox);
            this.Controls.Add(this.groupSizeLabel);
            this.Controls.Add(this.maxGenerationTextBox);
            this.Controls.Add(this.maxGenerationLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.lastFitnessValue);
            this.Controls.Add(this.lastTourLabel);
            this.Controls.Add(this.lastIterationValue);
            this.Controls.Add(this.lastIterationLabel);
            this.Controls.Add(this.PopulationSizeLabel);
            this.Controls.Add(this.populationSizeTextBox);
            this.Controls.Add(this.tourDiagram);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TspForm";
            this.Text = "Ariadne\'s thread";
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox populationSizeTextBox;
        private System.Windows.Forms.Label PopulationSizeLabel;
        private System.Windows.Forms.Label lastIterationLabel;
        private System.Windows.Forms.Label lastIterationValue;
        private System.Windows.Forms.Label lastTourLabel;
        private System.Windows.Forms.Label lastFitnessValue;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label maxGenerationLabel;
        private System.Windows.Forms.TextBox maxGenerationTextBox;
        private System.Windows.Forms.Label groupSizeLabel;
        private System.Windows.Forms.TextBox groupSizeTextBox;
        private System.Windows.Forms.TextBox randomSeedTextBox;
        private System.Windows.Forms.Label randomSeedLabel;
        private System.Windows.Forms.Button openCityListButton;
        private System.Windows.Forms.Button clearCityListButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox mutationTextBox;
        private System.Windows.Forms.Label mutationLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NumberCitiesLabel;
        private System.Windows.Forms.Label NumberCitiesValue;
        private System.Windows.Forms.TextBox NumberCloseCitiesTextBox;
        private System.Windows.Forms.Label NumberCloseCitiesLabel;
        private System.Windows.Forms.TextBox CloseCityOddsTextBox;
        private System.Windows.Forms.Label CloseCityOddsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lenghts_text_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox tourDiagram;
        private System.Windows.Forms.CheckBox is_e;
        private System.Windows.Forms.Button button3;
    }
}

