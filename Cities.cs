
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Globalization;

namespace Tsp
{
    /// <summary>
    /// list of cities
    /// </summary>
    public class Cities : List<City>
    {
        int i = 0, j = 0;
        /// <summary>
        /// number of cities.
        /// </summary>
        public static double num_of_c;
        /// <summary>
        /// matrix
        /// </summary>
        public static double[,] aa = new double[400, 400];
        /// <summary>
        /// is evkid
        /// </summary>
        public static bool is_ev = true;

        /// <summary>
        /// Determine 
        /// </summary>
   
        public void CalculateCityDistances( int numberOfCloseCities )
        {
            if (is_ev)
            {
                foreach (City city in this)
                {
                    city.Distances.Clear();

                    for (int i = 0; i < Count; i++)
                    {
                        city.Distances.Add(Math.Sqrt(Math.Pow((double)(city.Location.X - this[i].Location.X), 2D) +
                                           Math.Pow((double)(city.Location.Y - this[i].Location.Y), 2D)));
                    }
                }
            }


            else
            {

                 for (i = 0; i < num_of_c; i++)
                      for (j = 0; j < num_of_c; j++)
                      {
                          this[i].Distances.Add(aa[i, j]);
                      }

              
            }

                
                foreach (City city in this)
                {
                    city.FindClosestCities(numberOfCloseCities);
                }
                
            
            
        }

        /// <summary>
        /// Open the XML 
        /// </summary>
        
        public void OpenCityList(string fileName)
        {
            DataSet cityDS = new DataSet();

            try
            {
                this.Clear();

                cityDS.ReadXml(fileName);

                DataRowCollection cities = cityDS.Tables[0].Rows;

                foreach (DataRow city in cities)
                {
                    this.Add(new City(Convert.ToInt32(city["X"], CultureInfo.CurrentCulture), Convert.ToInt32(city["Y"], CultureInfo.CurrentCulture)));
                }
            }
            finally
            {
                cityDS.Dispose();
            }
        }



    }
}
