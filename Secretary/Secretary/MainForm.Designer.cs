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
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.calculateHoursButton = new System.Windows.Forms.Button();
            this.totalHoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.decrementDaysAgoButton = new System.Windows.Forms.Button();
            this.incrementDaysAgoButton = new System.Windows.Forms.Button();
            this.daysAgoTextBox = new System.Windows.Forms.TextBox();
            this.daysAgoLabel = new System.Windows.Forms.Label();
            this.hoursWorkedTodayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
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
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1077, 682);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.GreenYellow;
            this.listView1.Location = new System.Drawing.Point(1095, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 305);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusButton.ForeColor = System.Drawing.Color.White;
            this.minusButton.Location = new System.Drawing.Point(1095, 700);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(28, 30);
            this.minusButton.TabIndex = 3;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
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
            this.ClockInListView.Location = new System.Drawing.Point(1095, 402);
            this.ClockInListView.Name = "ClockInListView";
            this.ClockInListView.Size = new System.Drawing.Size(421, 292);
            this.ClockInListView.TabIndex = 7;
            this.ClockInListView.SelectedIndexChanged += new System.EventHandler(this.ClockInListView_SelectedIndexChanged);
            // 
            // hoursRemainingTextBox
            // 
            this.hoursRemainingTextBox.BackColor = System.Drawing.Color.Black;
            this.hoursRemainingTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hoursRemainingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursRemainingTextBox.ForeColor = System.Drawing.Color.White;
            this.hoursRemainingTextBox.Location = new System.Drawing.Point(824, 699);
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
            this.clockOutTime.Location = new System.Drawing.Point(824, 735);
            this.clockOutTime.Name = "clockOutTime";
            this.clockOutTime.ReadOnly = true;
            this.clockOutTime.Size = new System.Drawing.Size(265, 30);
            this.clockOutTime.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(1129, 700);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(28, 30);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.BackColor = System.Drawing.Color.Black;
            this.hoursWorkedTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hoursWorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedTextBox.ForeColor = System.Drawing.Color.White;
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(824, 771);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.ReadOnly = true;
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(265, 30);
            this.hoursWorkedTextBox.TabIndex = 11;
            // 
            // calculateHoursButton
            // 
            this.calculateHoursButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calculateHoursButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateHoursButton.ForeColor = System.Drawing.Color.White;
            this.calculateHoursButton.Location = new System.Drawing.Point(678, 807);
            this.calculateHoursButton.Name = "calculateHoursButton";
            this.calculateHoursButton.Size = new System.Drawing.Size(140, 30);
            this.calculateHoursButton.TabIndex = 13;
            this.calculateHoursButton.Text = "Calculate Hours";
            this.calculateHoursButton.UseVisualStyleBackColor = false;
            this.calculateHoursButton.Click += new System.EventHandler(this.calculateHoursButton_Click);
            // 
            // totalHoursWorkedTextBox
            // 
            this.totalHoursWorkedTextBox.BackColor = System.Drawing.Color.Black;
            this.totalHoursWorkedTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.totalHoursWorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursWorkedTextBox.ForeColor = System.Drawing.Color.White;
            this.totalHoursWorkedTextBox.Location = new System.Drawing.Point(824, 807);
            this.totalHoursWorkedTextBox.Name = "totalHoursWorkedTextBox";
            this.totalHoursWorkedTextBox.ReadOnly = true;
            this.totalHoursWorkedTextBox.Size = new System.Drawing.Size(265, 30);
            this.totalHoursWorkedTextBox.TabIndex = 14;
            // 
            // decrementDaysAgoButton
            // 
            this.decrementDaysAgoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.decrementDaysAgoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decrementDaysAgoButton.ForeColor = System.Drawing.Color.White;
            this.decrementDaysAgoButton.Location = new System.Drawing.Point(1095, 807);
            this.decrementDaysAgoButton.Name = "decrementDaysAgoButton";
            this.decrementDaysAgoButton.Size = new System.Drawing.Size(28, 30);
            this.decrementDaysAgoButton.TabIndex = 17;
            this.decrementDaysAgoButton.Text = "-";
            this.decrementDaysAgoButton.UseVisualStyleBackColor = false;
            this.decrementDaysAgoButton.Click += new System.EventHandler(this.decrementDaysAgoButton_Click);
            // 
            // incrementDaysAgoButton
            // 
            this.incrementDaysAgoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.incrementDaysAgoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.incrementDaysAgoButton.ForeColor = System.Drawing.Color.White;
            this.incrementDaysAgoButton.Location = new System.Drawing.Point(1129, 807);
            this.incrementDaysAgoButton.Name = "incrementDaysAgoButton";
            this.incrementDaysAgoButton.Size = new System.Drawing.Size(28, 30);
            this.incrementDaysAgoButton.TabIndex = 18;
            this.incrementDaysAgoButton.Text = "+";
            this.incrementDaysAgoButton.UseVisualStyleBackColor = false;
            this.incrementDaysAgoButton.Click += new System.EventHandler(this.incrementDaysAgoButton_Click);
            // 
            // daysAgoTextBox
            // 
            this.daysAgoTextBox.BackColor = System.Drawing.Color.Black;
            this.daysAgoTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.daysAgoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysAgoTextBox.ForeColor = System.Drawing.Color.White;
            this.daysAgoTextBox.Location = new System.Drawing.Point(1163, 807);
            this.daysAgoTextBox.Name = "daysAgoTextBox";
            this.daysAgoTextBox.ReadOnly = true;
            this.daysAgoTextBox.Size = new System.Drawing.Size(41, 30);
            this.daysAgoTextBox.TabIndex = 19;
            this.daysAgoTextBox.Text = "0";
            // 
            // daysAgoLabel
            // 
            this.daysAgoLabel.AutoSize = true;
            this.daysAgoLabel.ForeColor = System.Drawing.Color.White;
            this.daysAgoLabel.Location = new System.Drawing.Point(1210, 814);
            this.daysAgoLabel.Name = "daysAgoLabel";
            this.daysAgoLabel.Size = new System.Drawing.Size(100, 17);
            this.daysAgoLabel.TabIndex = 20;
            this.daysAgoLabel.Text = "Last Days Ago";
            // 
            // hoursWorkedTodayLabel
            // 
            this.hoursWorkedTodayLabel.AutoSize = true;
            this.hoursWorkedTodayLabel.ForeColor = System.Drawing.Color.White;
            this.hoursWorkedTodayLabel.Location = new System.Drawing.Point(675, 781);
            this.hoursWorkedTodayLabel.Name = "hoursWorkedTodayLabel";
            this.hoursWorkedTodayLabel.Size = new System.Drawing.Size(143, 17);
            this.hoursWorkedTodayLabel.TabIndex = 21;
            this.hoursWorkedTodayLabel.Text = "Hours Worked Today";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(675, 745);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "ClockOut Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(675, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hours Until ClockOut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1206, 707);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Time:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(12, 699);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(93, 699);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 30);
            this.loadButton.TabIndex = 27;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(174, 699);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 30);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1528, 889);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursWorkedTodayLabel);
            this.Controls.Add(this.daysAgoLabel);
            this.Controls.Add(this.daysAgoTextBox);
            this.Controls.Add(this.incrementDaysAgoButton);
            this.Controls.Add(this.decrementDaysAgoButton);
            this.Controls.Add(this.totalHoursWorkedTextBox);
            this.Controls.Add(this.calculateHoursButton);
            this.Controls.Add(this.hoursWorkedTextBox);
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
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Button calculateHoursButton;
        private System.Windows.Forms.TextBox totalHoursWorkedTextBox;
        private System.Windows.Forms.Button decrementDaysAgoButton;
        private System.Windows.Forms.Button incrementDaysAgoButton;
        private System.Windows.Forms.TextBox daysAgoTextBox;
        private System.Windows.Forms.Label daysAgoLabel;
        private System.Windows.Forms.Label hoursWorkedTodayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button clearButton;
    }
}

