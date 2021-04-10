using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Technicians : Employee
    {
        private string abilities;
        private int qualification;
      


        public String Abilities { get => abilities; set => abilities = value; }
        public int Qualification { get => qualification; set => qualification = value; }
       

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
