using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class IndividualClient : Client
    {
        private bool isCurrentClient;

        public bool IsCurrentClient { get => isCurrentClient; set => isCurrentClient = value; }

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
