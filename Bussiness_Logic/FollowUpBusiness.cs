using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;

namespace CallCenterProgram.Bussiness_Logic
{
    class FollowUpBusiness
    {
        FollowUp_DataAccess FollowUpData = new FollowUp_DataAccess();
        FollowUp PopUp = new FollowUp();
        BindingSource src = new BindingSource();

        public void InsertReminder(int reminderId, string reminder, DateTime reminderDate)
        {

            FollowUpData.InsertSetReminder(reminderId, reminder, reminderDate);
        }
        public void UpdateReminder(int reminderId, string reminder, DateTime reminderDate)
        {

            FollowUpData.UpdateSetReminder(reminderId, reminder, reminderDate);
        }

        public void RemoveReminder(int reminderId)
        {

            FollowUpData.DeleteSetReminder(reminderId);
        }



        public void AddFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            FollowUpData.InsertFollowUp(followUpId, status, followUpDate);

        }

        public void UpdateFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            FollowUpData.UpdateFollowUp(followUpId, status, followUpDate);

        }

        public void RemoveFollowUp(int followUpId)
        {
            FollowUpData.DeleteFollowUp(followUpId);

        }

        public void AddFeedback(int feedbackId, string problem, bool helpedOnTime, string comment, DateTime feedbackDate)
        {
            FollowUpData.InsertFeedback(feedbackId, problem, helpedOnTime, comment, feedbackDate);

        }

        public BindingSource ViewFollowUps()
        {
            src.DataSource = FollowUpData.DisplayFollowUps();
            return src;
            
        }

        
        public BindingSource ViewFeedback()
        {
            src.DataSource = FollowUpData.DisplayFeedbacks();
            return src;
        }
        public BindingSource ViewSetReminder()
        {
           
            src.DataSource = FollowUpData.DisplayReminder();
            return src;
          
        }

      
    }
}
