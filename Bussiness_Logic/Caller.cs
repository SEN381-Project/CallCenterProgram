using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Caller : Employee
    {
        private int stationNumber ;

        public int StationNumber { get => stationNumber; set => stationNumber = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Display()
        {
            //method for displaying
        }
    }
}
