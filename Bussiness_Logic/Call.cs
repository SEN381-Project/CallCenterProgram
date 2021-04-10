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
            //use a thread to track the calls duration
        }
        public DateTime CreateTimestamp()
        {
            DateTime timeStamp = DateTime.Now;
            return timeStamp;
        }
        public List<string> GenerateCallReport()
        {
            List<string> reports = new List<string>();

            //call report
            reports.Add(Console.ReadLine());
            //problem info
            reports.Add(Console.ReadLine());
            //work request
            reports.Add(Console.ReadLine());

            return reports;
        }
        public void InsertCallIntoDB()
        {
            //lists
            List<string> reports = GenerateCallReport();
            //vars
            float callTime = 0f;
            string faultReport = faultInfo.ReportFault();
            string callReport = reports[0];
            string problemInfo = reports[1];
            string workRequest = reports[2];
            int callDuration = 0; //use RecordCallStats()

            //method
            CallDB.InsertCall(initialTimeStamp, finalTimeStamp, faultReport,callReport,problemInfo,workRequest,callDuration);
        }
    }
}
