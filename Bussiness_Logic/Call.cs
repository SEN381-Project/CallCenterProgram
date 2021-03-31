using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Call : CallStats
    {
        //classes
        call_DataAccess CallDB = new call_DataAccess();
        FaultInfo faultInfo = new FaultInfo();

        //vars
        private DateTime initialTimeStamp;
        private DateTime finalTimeStamp;
        //methods
        public void MakeCall()
        {
            initialTimeStamp = CreateTimestamp();
        }

        public void TakeCall()
        {
            initialTimeStamp = CreateTimestamp();
        }
        public void EndCall()
        {
            finalTimeStamp = CreateTimestamp();
        }
        public void CrossReference()
        {
            Console.WriteLine("Added call to old system.");
        }
        public void RecordCallStats()
        {

        }
        public DateTime CreateTimestamp()
        {
            DateTime timeStamp = DateTime.Now;
            return timeStamp;
        }
        public void GenerateCallReport()
        {

        }
        public void InsertCallIntoDB()
        {
            float callTime = 0f;
            string faultReport = faultInfo.ReportFault();
            string callReport = "";
            string problemInfo = "";
            string workRequest = "";
            int callDuration = 0;

            CallDB.InsertCall(callTime, initialTimeStamp, finalTimeStamp, faultReport,callReport,problemInfo,workRequest,callDuration);
        }
    }
}
