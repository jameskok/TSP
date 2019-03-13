
using System;
using System.Collections.Generic;
using System.Text;

namespace Tsp
{
    /// <summary>
    ///  link 
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Connection
        /// </summary>
        private int connection1;
        /// <summary>
        /// Connection
        /// </summary>
        public int Connection1
        {
            get
            {
                return connection1;
            }
            set
            {
                connection1 = value; ;
            }
        }

        /// <summary>
        /// Connection
        /// </summary>
        private int connection2;
        /// <summary>
        /// Connection
        /// </summary>
        public int Connection2
        {
            get
            {
                return connection2;
            }
            set
            {
                connection2 = value;
            }
        }
    }
}
