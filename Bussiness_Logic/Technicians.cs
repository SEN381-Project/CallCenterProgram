using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Technicians : Employee
    {
        private String abbilities;
        private int qualificationLevel;

        public String Abbilities { get => abbilities; set => abbilities = value; }
        public int QualificationLevel { get => qualificationLevel; set => qualificationLevel = value; }

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
