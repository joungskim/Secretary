using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Secretary.Logic;

namespace Secretary
{
    public partial class MainForm : Form
    {
        CRMLogic crmLogic = new CRMLogic();
        private bool countdown;
        public MainForm()
        {
            InitializeComponent();
            countdown = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void DateUpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTimeTextBox.Text = crmLogic.GetDateTimeString(DateTime.Now);
            hoursRemainingTextBox.Text = countdown ? crmLogic.SubtractSecondsFromRemainingTime() : crmLogic.GetHoursRemaining();
            clockOutTime.Text = crmLogic.GetClockOutTime();
        }

        private void ClockIn_CheckedChanged_1(object sender, EventArgs e)
        {
            ClockInListView.Items.Add(ClockIn.Checked
                ? crmLogic.AddTimeList(DateTime.Now, true)
                : crmLogic.AddTimeList(DateTime.Now, false));
            countdown = ClockIn.Checked;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            hoursRemainingTextBox.Text = crmLogic.SubtractHoursUntilLeave();
            clockOutTime.Text = crmLogic.GetClockOutTime();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            hoursRemainingTextBox.Text = crmLogic.AddHoursUntilLeave();
            clockOutTime.Text = crmLogic.GetClockOutTime();
        }
    }
}
