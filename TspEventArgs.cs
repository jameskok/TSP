
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Tsp
{
    /// <summary>
    /// draw a tour.
    /// </summary>
    public class TspEventArgs : EventArgs
    {
        /// <summary>
        /// Default 
        /// </summary>
        public TspEventArgs()
        {
        }

        /// <summary>
        /// all  properties.
        /// </summary>
       
        public TspEventArgs(Cities cityList, Tour bestTour, int generation, bool complete)
        {
            this.cityList = cityList;
            this.bestTour = bestTour;
            this.generation = generation;
            this.complete = complete;
        }

        /// <summary>
        /// Private copy  of cities
        /// </summary>
        private Cities cityList;
        /// <summary>
        /// Public cities
        /// </summary>
        public Cities CityList
        {
            get
            {
                return cityList;
            }
        }

        /// <summary>
        /// Private copy of tour
        /// </summary>
        private Tour bestTour;
        /// <summary>
        /// Public tour 
        /// </summary>
        public Tour BestTour
        {
            get
            {
                return bestTour;
            }
        }

        /// <summary>
        /// Private generation 
        /// </summary>
        private int generation;
        /// <summary>
        /// Public generation 
        /// </summary>
        public int Generation
        {
            get
            {
                return generation;
            }
            set
            {
                generation = value;
            }
        }

        /// <summary>
        /// Private complete
        /// </summary>
        private bool complete = false;
        /// <summary>
        /// Public complete
        /// </summary>
        public bool Complete
        {
            get
            {
                return complete;
            }
            set
            {
                complete = value;
            }
        }
    }
}