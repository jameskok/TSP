
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Tsp
{
    /// <summary>
    ///  City 
    /// </summary>
    public class City
    {

        /// <param name="x">X position of the city.</param>
        /// <param name="y">Y position of the city.</param>
        public City(int x, int y)
        {
            Location = new Point(x, y);
        }

        /// <summary>
        /// Private copy of the location 
        /// </summary>
        private Point location;
        /// <summary>
        /// The location 
        /// </summary>
        public Point Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        /// <summary>
        /// Private copy of the distance 

        /// </summary>
        private List<double> distances = new List<double>();
        /// <summary>
        /// The distance
        /// </summary>
        public List<double> Distances
        {
            get
            {
                return distances;
            }
            set
            {
                distances = value;
            }
        }

        /// <summary>
        /// Private copy 
        /// </summary>
        private List<int> closeCities = new List<int>();
        /// <summary>
        /// A list of the cities 
        /// </summary>
        public List<int> CloseCities
        {
            get
            {
                return closeCities;
            }
        }

        /// <summary>
        /// Find the cities 
        /// </summary>
        public void FindClosestCities( int numberOfCloseCities )
        {
            double shortestDistance;
            int shortestCity = 0;
            double[] dist = new double[Distances.Count];
            Distances.CopyTo(dist);

            if (numberOfCloseCities > Distances.Count - 1)
            {
                numberOfCloseCities = Distances.Count - 1;
            }

            closeCities.Clear();

            for (int i = 0; i < numberOfCloseCities; i++)
            {
                shortestDistance = Double.MaxValue;
                for (int cityNum = 0; cityNum < Distances.Count; cityNum++)
                {
                    if (dist[cityNum] < shortestDistance)
                    {
                        shortestDistance = dist[cityNum];
                        shortestCity = cityNum;
                    }
                }
                closeCities.Add(shortestCity);
                dist[shortestCity] = Double.MaxValue;
            }
        }
    }
}