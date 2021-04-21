using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenterProgram
{
    class Call : CallStats
    {
        //classes
        call_DataAccess CallDB = new call_DataAccess();

        //fields
        private DateTime initialTimeStamp;
        private DateTime finalTimeStamp;
        private string callReport;
        private string problemInfo;
        private string workRequest;
        private string faultReport;


        //properties
        public string CallReport { get => callReport; set => callReport = value; }
        public string ProblemInfo { get => problemInfo; set => problemInfo = value; }
        public string WorkRequest { get => workRequest; set => workRequest = value; }
        public string FaultReport { get => faultReport; set => faultReport = value; }

        //constructor
        public Call()
        {

        }

        //methods
        public void createInitialTimestamp()
        {
            initialTimeStamp = CreateTimestamp();
        }
        public void createFinalTimestamp()
        {
            finalTimeStamp = CreateTimestamp();
        }
        public void CrossReference()
        {
            //ask about this.
            MessageBox.Show("Added call to old system.");
        }
        public int RecordCallStats()
        {
            int timeDiff = 0;

            //Use dateDiff to calculate time difference between final and initial timestamps.
            System.TimeSpan dtDiff = finalTimeStamp.Subtract(initialTimeStamp);
            timeDiff = dtDiff.Seconds;

            return timeDiff;
        }
        public DateTime CreateTimestamp()
        {
            DateTime timeStamp = DateTime.Now;
            return timeStamp;
        }
        public void InsertCallIntoDB()
        {
            //vars 
            int callDuration = RecordCallStats(); //use RecordCallStats()

            //method
            CallDB.InsertCall(initialTimeStamp, finalTimeStamp, FaultReport, CallReport,ProblemInfo,WorkRequest,callDuration);
        }
    }
}
