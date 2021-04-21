using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram.Business_Logic
{
    class Technicians : Employee
    {
        private string abilities;
        private string qualification;
  

        public string Abilities { get => abilities; set => abilities = value; }
        public string Qualification { get => qualification; set => qualification = value; }
       

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
