using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Secretary.Logic;
using PlatformSpellCheck;

namespace Secretary
{
    public partial class MainForm : Form
    {
        CRMLogic crmLogic = new CRMLogic();
        private bool countdown;
        private bool textChanged;
        private SpellChecker spChecker;
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
            hoursWorkedTextBox.Text = countdown ? crmLogic.AddHoursWorkedToday() : crmLogic.GetHoursWorkedToday();
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

        private void calculateHoursButton_Click(object sender, EventArgs e)
        {
            totalHoursWorkedTextBox.Text = crmLogic.ClockedHoursByList(int.Parse(daysAgoTextBox.Text));
        }

        private void decrementDaysAgoButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(daysAgoTextBox.Text) > 0)
            {
                daysAgoTextBox.Text = (int.Parse(daysAgoTextBox.Text) - 1).ToString();
            }
        }

        private void incrementDaysAgoButton_Click(object sender, EventArgs e)
        {
            daysAgoTextBox.Text = (int.Parse(daysAgoTextBox.Text) + 1).ToString();
        }

        private void ClockInListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text.Equals(""))
                    richTextBox1.Text = ClockInListView.SelectedItem.ToString();
            }
            catch
            {
                //ignore
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveMyFile();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadMyFile();
        }


        public void SaveMyFile()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog
            {
                DefaultExt = "*.rtf",
                Filter = "RTF Files|*.rtf"
            };

            // Initialize the SaveFileDialog to specify the RTF extension for the file.

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        public void LoadMyFile()
        {
            CheckTextChanged();
            if (textChanged) return;
                // Create an OpenFileDialog object.
                var openFile1 = new OpenFileDialog {Filter = "Text Files|*.txt"};

                // Initialize the filter to look for text files.

                // If the user selected a file, load its contents into the RichTextBox. 
                if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    richTextBox1.LoadFile(openFile1.FileName,
                        RichTextBoxStreamType.PlainText);
            textChanged = false;
        }

        public void ClearRTB()
        {
            CheckTextChanged();
            if (textChanged) return;
            richTextBox1.Clear();
            ClockInListView.ClearSelected();
            textChanged = false;
        }

        public void CheckTextChanged()
        {
            if (!textChanged) return;
            var result = MessageBox.Show("Changes Have not been saved do you wish to proceed anyway?",
                "Unsaved Changes", MessageBoxButtons.YesNo);
            textChanged = result != DialogResult.Yes;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textChanged)
            {
                textChanged = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearRTB();
        }
    }
}
