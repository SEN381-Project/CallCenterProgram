using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;
using CallCenterProgram;

namespace CallCenterProgram.Bussiness_Logic
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
        private int stationNumber;
        private int clientID;


        //properties
        public string CallReport { get => callReport; set => callReport = value; }
        public string ProblemInfo { get => problemInfo; set => problemInfo = value; }
        public string WorkRequest { get => workRequest; set => workRequest = value; }
        public string FaultReport { get => faultReport; set => faultReport = value; }
        public int StationNumber { get => stationNumber; set => stationNumber = value; }
        public int ClientID { get => clientID; set => clientID = value; }

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
        public int GetCallDuration()
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
        public void InsertCallIntoDB(int clientID)
        {
            //vars 
            int callDuration = GetCallDuration(); //use RecordCallStats()

            //method
            CallDB.InsertCall(clientID, initialTimeStamp, finalTimeStamp, FaultReport, CallReport,ProblemInfo,WorkRequest,callDuration);
        }
    }
}
