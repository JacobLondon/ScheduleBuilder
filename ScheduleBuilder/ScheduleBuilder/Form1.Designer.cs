namespace ScheduleBuilder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddUserTextBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.DayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DayDGV = new System.Windows.Forms.DataGridView();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NewEventButton = new System.Windows.Forms.Button();
            this.CalendarTabControl = new System.Windows.Forms.TabControl();
            this.DayTabPage = new System.Windows.Forms.TabPage();
            this.WeekTabPage = new System.Windows.Forms.TabPage();
            this.WeekDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.WeekNextButton = new System.Windows.Forms.Button();
            this.WeekPrevButton = new System.Windows.Forms.Button();
            this.MonthTabPage = new System.Windows.Forms.TabPage();
            this.MonthDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.MonthNextButton = new System.Windows.Forms.Button();
            this.MonthPrevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DayDGV)).BeginInit();
            this.UserGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.CalendarTabControl.SuspendLayout();
            this.DayTabPage.SuspendLayout();
            this.WeekTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeekDGV)).BeginInit();
            this.MonthTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserTextBox
            // 
            this.AddUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserTextBox.Location = new System.Drawing.Point(6, 21);
            this.AddUserTextBox.Name = "AddUserTextBox";
            this.AddUserTextBox.Size = new System.Drawing.Size(242, 22);
            this.AddUserTextBox.TabIndex = 0;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(1, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(82, 16);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Current User";
            // 
            // DayDateTimePicker
            // 
            this.DayDateTimePicker.Location = new System.Drawing.Point(6, 6);
            this.DayDateTimePicker.Name = "DayDateTimePicker";
            this.DayDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.DayDateTimePicker.TabIndex = 1;
            // 
            // DayDGV
            // 
            this.DayDGV.BackgroundColor = System.Drawing.Color.White;
            this.DayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DayDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeColumn,
            this.EventColumn});
            this.DayDGV.Location = new System.Drawing.Point(209, 6);
            this.DayDGV.Name = "DayDGV";
            this.DayDGV.RowHeadersVisible = false;
            this.DayDGV.Size = new System.Drawing.Size(618, 517);
            this.DayDGV.TabIndex = 0;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            // 
            // EventColumn
            // 
            this.EventColumn.HeaderText = "Events";
            this.EventColumn.Name = "EventColumn";
            this.EventColumn.ReadOnly = true;
            this.EventColumn.Width = 243;
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.DeleteUserButton);
            this.UserGroupBox.Controls.Add(this.AddUserButton);
            this.UserGroupBox.Controls.Add(this.UserDGV);
            this.UserGroupBox.Controls.Add(this.AddUserTextBox);
            this.UserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGroupBox.Location = new System.Drawing.Point(4, 36);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(254, 557);
            this.UserGroupBox.TabIndex = 1;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Manage Users";
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(6, 522);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(242, 27);
            this.DeleteUserButton.TabIndex = 3;
            this.DeleteUserButton.Text = "Delete Selected User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(6, 49);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(242, 27);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // UserDGV
            // 
            this.UserDGV.BackgroundColor = System.Drawing.Color.White;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameColumn});
            this.UserDGV.Location = new System.Drawing.Point(6, 82);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.RowHeadersVisible = false;
            this.UserDGV.Size = new System.Drawing.Size(242, 434);
            this.UserDGV.TabIndex = 2;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.HeaderText = "User Name";
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.Width = 238;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // NewEventButton
            // 
            this.NewEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEventButton.Location = new System.Drawing.Point(348, 5);
            this.NewEventButton.Name = "NewEventButton";
            this.NewEventButton.Size = new System.Drawing.Size(168, 27);
            this.NewEventButton.TabIndex = 5;
            this.NewEventButton.Text = "Create New Event";
            this.NewEventButton.UseVisualStyleBackColor = true;
            this.NewEventButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalendarTabControl
            // 
            this.CalendarTabControl.Controls.Add(this.DayTabPage);
            this.CalendarTabControl.Controls.Add(this.WeekTabPage);
            this.CalendarTabControl.Controls.Add(this.MonthTabPage);
            this.CalendarTabControl.Location = new System.Drawing.Point(264, 38);
            this.CalendarTabControl.Name = "CalendarTabControl";
            this.CalendarTabControl.SelectedIndex = 0;
            this.CalendarTabControl.Size = new System.Drawing.Size(844, 555);
            this.CalendarTabControl.TabIndex = 3;
            // 
            // DayTabPage
            // 
            this.DayTabPage.Controls.Add(this.DayDGV);
            this.DayTabPage.Controls.Add(this.DayDateTimePicker);
            this.DayTabPage.Location = new System.Drawing.Point(4, 22);
            this.DayTabPage.Name = "DayTabPage";
            this.DayTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DayTabPage.Size = new System.Drawing.Size(836, 529);
            this.DayTabPage.TabIndex = 0;
            this.DayTabPage.Text = "Day View";
            this.DayTabPage.UseVisualStyleBackColor = true;
            // 
            // WeekTabPage
            // 
            this.WeekTabPage.Controls.Add(this.WeekDGV);
            this.WeekTabPage.Controls.Add(this.WeekLabel);
            this.WeekTabPage.Controls.Add(this.WeekNextButton);
            this.WeekTabPage.Controls.Add(this.WeekPrevButton);
            this.WeekTabPage.Location = new System.Drawing.Point(4, 22);
            this.WeekTabPage.Name = "WeekTabPage";
            this.WeekTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.WeekTabPage.Size = new System.Drawing.Size(836, 529);
            this.WeekTabPage.TabIndex = 1;
            this.WeekTabPage.Text = "Week View";
            this.WeekTabPage.UseVisualStyleBackColor = true;
            // 
            // WeekDGV
            // 
            this.WeekDGV.AllowUserToAddRows = false;
            this.WeekDGV.AllowUserToDeleteRows = false;
            this.WeekDGV.AllowUserToResizeRows = false;
            this.WeekDGV.BackgroundColor = System.Drawing.Color.White;
            this.WeekDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.WeekDGV.Location = new System.Drawing.Point(6, 39);
            this.WeekDGV.Name = "WeekDGV";
            this.WeekDGV.ReadOnly = true;
            this.WeekDGV.RowHeadersVisible = false;
            this.WeekDGV.Size = new System.Drawing.Size(824, 484);
            this.WeekDGV.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Sundary";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Monday";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLabel.Location = new System.Drawing.Point(203, 11);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(170, 16);
            this.WeekLabel.TabIndex = 10;
            this.WeekLabel.Text = "month here change on load";
            // 
            // WeekNextButton
            // 
            this.WeekNextButton.Location = new System.Drawing.Point(723, 6);
            this.WeekNextButton.Name = "WeekNextButton";
            this.WeekNextButton.Size = new System.Drawing.Size(107, 27);
            this.WeekNextButton.TabIndex = 9;
            this.WeekNextButton.Text = ">>>";
            this.WeekNextButton.UseVisualStyleBackColor = true;
            // 
            // WeekPrevButton
            // 
            this.WeekPrevButton.Location = new System.Drawing.Point(6, 6);
            this.WeekPrevButton.Name = "WeekPrevButton";
            this.WeekPrevButton.Size = new System.Drawing.Size(107, 27);
            this.WeekPrevButton.TabIndex = 8;
            this.WeekPrevButton.Text = "<<<";
            this.WeekPrevButton.UseVisualStyleBackColor = true;
            // 
            // MonthTabPage
            // 
            this.MonthTabPage.Controls.Add(this.MonthDGV);
            this.MonthTabPage.Controls.Add(this.MonthLabel);
            this.MonthTabPage.Controls.Add(this.MonthNextButton);
            this.MonthTabPage.Controls.Add(this.MonthPrevButton);
            this.MonthTabPage.Location = new System.Drawing.Point(4, 22);
            this.MonthTabPage.Name = "MonthTabPage";
            this.MonthTabPage.Size = new System.Drawing.Size(836, 529);
            this.MonthTabPage.TabIndex = 2;
            this.MonthTabPage.Text = "Month View";
            this.MonthTabPage.UseVisualStyleBackColor = true;
            // 
            // MonthDGV
            // 
            this.MonthDGV.AllowUserToAddRows = false;
            this.MonthDGV.AllowUserToDeleteRows = false;
            this.MonthDGV.AllowUserToResizeRows = false;
            this.MonthDGV.BackgroundColor = System.Drawing.Color.White;
            this.MonthDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonthDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.MonthDGV.Location = new System.Drawing.Point(6, 39);
            this.MonthDGV.Name = "MonthDGV";
            this.MonthDGV.ReadOnly = true;
            this.MonthDGV.RowHeadersVisible = false;
            this.MonthDGV.Size = new System.Drawing.Size(824, 484);
            this.MonthDGV.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Sundary";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Monday";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(218, 8);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(170, 16);
            this.MonthLabel.TabIndex = 13;
            this.MonthLabel.Text = "month here change on load";
            // 
            // MonthNextButton
            // 
            this.MonthNextButton.Location = new System.Drawing.Point(723, 6);
            this.MonthNextButton.Name = "MonthNextButton";
            this.MonthNextButton.Size = new System.Drawing.Size(107, 27);
            this.MonthNextButton.TabIndex = 12;
            this.MonthNextButton.Text = ">>>";
            this.MonthNextButton.UseVisualStyleBackColor = true;
            // 
            // MonthPrevButton
            // 
            this.MonthPrevButton.Location = new System.Drawing.Point(6, 6);
            this.MonthPrevButton.Name = "MonthPrevButton";
            this.MonthPrevButton.Size = new System.Drawing.Size(107, 27);
            this.MonthPrevButton.TabIndex = 11;
            this.MonthPrevButton.Text = "<<<";
            this.MonthPrevButton.UseVisualStyleBackColor = true;
            this.MonthPrevButton.Click += new System.EventHandler(this.MonthPrevButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 597);
            this.Controls.Add(this.UserGroupBox);
            this.Controls.Add(this.CalendarTabControl);
            this.Controls.Add(this.NewEventButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.UserLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Schedule Builder";
            ((System.ComponentModel.ISupportInitialize)(this.DayDGV)).EndInit();
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.CalendarTabControl.ResumeLayout(false);
            this.DayTabPage.ResumeLayout(false);
            this.WeekTabPage.ResumeLayout(false);
            this.WeekTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeekDGV)).EndInit();
            this.MonthTabPage.ResumeLayout(false);
            this.MonthTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddUserTextBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.DataGridView UserDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button NewEventButton;
        private System.Windows.Forms.DateTimePicker DayDateTimePicker;
        private System.Windows.Forms.DataGridView DayDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventColumn;
        private System.Windows.Forms.TabControl CalendarTabControl;
        private System.Windows.Forms.TabPage DayTabPage;
        private System.Windows.Forms.TabPage WeekTabPage;
        private System.Windows.Forms.DataGridView WeekDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Button WeekNextButton;
        private System.Windows.Forms.Button WeekPrevButton;
        private System.Windows.Forms.TabPage MonthTabPage;
        private System.Windows.Forms.DataGridView MonthDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Button MonthNextButton;
        private System.Windows.Forms.Button MonthPrevButton;
    }
}

