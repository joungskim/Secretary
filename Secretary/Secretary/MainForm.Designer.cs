namespace Secretary
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DateUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.minusButton = new System.Windows.Forms.Button();
            this.DateTimeTextBox = new System.Windows.Forms.TextBox();
            this.ClockIn = new System.Windows.Forms.RadioButton();
            this.ClockOut = new System.Windows.Forms.RadioButton();
            this.ClockInListView = new System.Windows.Forms.ListBox();
            this.hoursRemainingTextBox = new System.Windows.Forms.TextBox();
            this.clockOutTime = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // DateUpdateTimer
            // 
            this.DateUpdateTimer.Enabled = true;
            this.DateUpdateTimer.Interval = 1000;
            this.DateUpdateTimer.Tick += new System.EventHandler(this.DateUpdateTimer_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.GreenYellow;
            this.richTextBox1.Location = new System.Drawing.Point(12, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1077, 603);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.GreenYellow;
            this.listView1.Location = new System.Drawing.Point(1095, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 309);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(790, 707);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(28, 23);
            this.minusButton.TabIndex = 3;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // DateTimeTextBox
            // 
            this.DateTimeTextBox.BackColor = System.Drawing.Color.Black;
            this.DateTimeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DateTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeTextBox.ForeColor = System.Drawing.Color.White;
            this.DateTimeTextBox.Location = new System.Drawing.Point(1251, 700);
            this.DateTimeTextBox.Name = "DateTimeTextBox";
            this.DateTimeTextBox.ReadOnly = true;
            this.DateTimeTextBox.Size = new System.Drawing.Size(265, 30);
            this.DateTimeTextBox.TabIndex = 4;
            // 
            // ClockIn
            // 
            this.ClockIn.AutoSize = true;
            this.ClockIn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClockIn.ForeColor = System.Drawing.Color.White;
            this.ClockIn.Location = new System.Drawing.Point(1342, 736);
            this.ClockIn.Name = "ClockIn";
            this.ClockIn.Size = new System.Drawing.Size(78, 21);
            this.ClockIn.TabIndex = 5;
            this.ClockIn.TabStop = true;
            this.ClockIn.Text = "Clock In";
            this.ClockIn.UseVisualStyleBackColor = false;
            this.ClockIn.CheckedChanged += new System.EventHandler(this.ClockIn_CheckedChanged_1);
            // 
            // ClockOut
            // 
            this.ClockOut.AutoSize = true;
            this.ClockOut.BackColor = System.Drawing.Color.Red;
            this.ClockOut.ForeColor = System.Drawing.Color.White;
            this.ClockOut.Location = new System.Drawing.Point(1426, 736);
            this.ClockOut.Name = "ClockOut";
            this.ClockOut.Size = new System.Drawing.Size(90, 21);
            this.ClockOut.TabIndex = 6;
            this.ClockOut.TabStop = true;
            this.ClockOut.Text = "Clock Out";
            this.ClockOut.UseVisualStyleBackColor = false;
            // 
            // ClockInListView
            // 
            this.ClockInListView.BackColor = System.Drawing.Color.Black;
            this.ClockInListView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockInListView.ForeColor = System.Drawing.Color.White;
            this.ClockInListView.FormattingEnabled = true;
            this.ClockInListView.ItemHeight = 24;
            this.ClockInListView.Location = new System.Drawing.Point(1095, 406);
            this.ClockInListView.Name = "ClockInListView";
            this.ClockInListView.Size = new System.Drawing.Size(421, 292);
            this.ClockInListView.TabIndex = 7;
            // 
            // hoursRemainingTextBox
            // 
            this.hoursRemainingTextBox.BackColor = System.Drawing.Color.Black;
            this.hoursRemainingTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hoursRemainingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursRemainingTextBox.ForeColor = System.Drawing.Color.White;
            this.hoursRemainingTextBox.Location = new System.Drawing.Point(824, 700);
            this.hoursRemainingTextBox.Name = "hoursRemainingTextBox";
            this.hoursRemainingTextBox.ReadOnly = true;
            this.hoursRemainingTextBox.Size = new System.Drawing.Size(265, 30);
            this.hoursRemainingTextBox.TabIndex = 8;
            // 
            // clockOutTime
            // 
            this.clockOutTime.BackColor = System.Drawing.Color.Black;
            this.clockOutTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.clockOutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockOutTime.ForeColor = System.Drawing.Color.White;
            this.clockOutTime.Location = new System.Drawing.Point(824, 728);
            this.clockOutTime.Name = "clockOutTime";
            this.clockOutTime.ReadOnly = true;
            this.clockOutTime.Size = new System.Drawing.Size(265, 30);
            this.clockOutTime.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1095, 707);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(28, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1528, 827);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.clockOutTime);
            this.Controls.Add(this.hoursRemainingTextBox);
            this.Controls.Add(this.ClockInListView);
            this.Controls.Add(this.ClockOut);
            this.Controls.Add(this.ClockIn);
            this.Controls.Add(this.DateTimeTextBox);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Secretary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer DateUpdateTimer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.TextBox DateTimeTextBox;
        private System.Windows.Forms.RadioButton ClockIn;
        private System.Windows.Forms.RadioButton ClockOut;
        private System.Windows.Forms.ListBox ClockInListView;
        private System.Windows.Forms.TextBox hoursRemainingTextBox;
        private System.Windows.Forms.TextBox clockOutTime;
        private System.Windows.Forms.Button addButton;
    }
}

