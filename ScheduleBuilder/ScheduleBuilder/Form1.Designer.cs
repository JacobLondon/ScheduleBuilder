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
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.EventDGV = new System.Windows.Forms.DataGridView();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.NewEventButton = new System.Windows.Forms.Button();
            this.CalendarTabControl = new System.Windows.Forms.TabControl();
            this.EventTabPage = new System.Windows.Forms.TabPage();
            this.EventLabel = new System.Windows.Forms.Label();
            this.DayTabPage = new System.Windows.Forms.TabPage();
            this.DayNextButton = new System.Windows.Forms.Button();
            this.DayPrevButton = new System.Windows.Forms.Button();
            this.DayLabel = new System.Windows.Forms.Label();
            this.DayDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekTabPage = new System.Windows.Forms.TabPage();
            this.WeekDGV = new System.Windows.Forms.DataGridView();
            this.TimeWeekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SundayWeekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayWeekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayWeekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayWeekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayWeekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayWeekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaturdayWeekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.WeekNextButton = new System.Windows.Forms.Button();
            this.WeekPrevButton = new System.Windows.Forms.Button();
            this.MonthTabPage = new System.Windows.Forms.TabPage();
            this.MonthDGV = new System.Windows.Forms.DataGridView();
            this.SundayMonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayMonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayMonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayMonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayMonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayMonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaturdayMonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.MonthNextButton = new System.Windows.Forms.Button();
            this.MonthPrevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventDGV)).BeginInit();
            this.UserGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.CalendarTabControl.SuspendLayout();
            this.EventTabPage.SuspendLayout();
            this.DayTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayDGV)).BeginInit();
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
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Current User";
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(522, 9);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(197, 20);
            this.Time.TabIndex = 3;
            this.Time.ValueChanged += new System.EventHandler(this.DayDateTimePicker_ValueChanged);
            // 
            // EventDGV
            // 
            this.EventDGV.AllowUserToAddRows = false;
            this.EventDGV.AllowUserToDeleteRows = false;
            this.EventDGV.AllowUserToResizeRows = false;
            this.EventDGV.BackgroundColor = System.Drawing.Color.White;
            this.EventDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeColumn,
            this.EventColumn});
            this.EventDGV.Location = new System.Drawing.Point(6, 39);
            this.EventDGV.MultiSelect = false;
            this.EventDGV.Name = "EventDGV";
            this.EventDGV.RowHeadersVisible = false;
            this.EventDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventDGV.Size = new System.Drawing.Size(824, 484);
            this.EventDGV.TabIndex = 1;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TimeColumn.Width = 250;
            // 
            // EventColumn
            // 
            this.EventColumn.HeaderText = "Events";
            this.EventColumn.Name = "EventColumn";
            this.EventColumn.ReadOnly = true;
            this.EventColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EventColumn.Width = 565;
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
            this.UserGroupBox.TabIndex = 4;
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
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(6, 49);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(242, 27);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserDGV
            // 
            this.UserDGV.AllowUserToAddRows = false;
            this.UserDGV.AllowUserToDeleteRows = false;
            this.UserDGV.AllowUserToResizeRows = false;
            this.UserDGV.BackgroundColor = System.Drawing.Color.White;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameColumn});
            this.UserDGV.Location = new System.Drawing.Point(6, 82);
            this.UserDGV.MultiSelect = false;
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.RowHeadersVisible = false;
            this.UserDGV.Size = new System.Drawing.Size(242, 434);
            this.UserDGV.TabIndex = 2;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.HeaderText = "User Name";
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.ReadOnly = true;
            this.UserNameColumn.Width = 238;
            // 
            // UserComboBox
            // 
            this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(100, 6);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(242, 24);
            this.UserComboBox.TabIndex = 1;
            this.UserComboBox.SelectedIndexChanged += new System.EventHandler(this.UserComboBox_SelectedChanged);
            // 
            // NewEventButton
            // 
            this.NewEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEventButton.Location = new System.Drawing.Point(348, 5);
            this.NewEventButton.Name = "NewEventButton";
            this.NewEventButton.Size = new System.Drawing.Size(168, 27);
            this.NewEventButton.TabIndex = 2;
            this.NewEventButton.Text = "Create New Event";
            this.NewEventButton.UseVisualStyleBackColor = true;
            this.NewEventButton.Click += new System.EventHandler(this.NewEventButton_Click);
            // 
            // CalendarTabControl
            // 
            this.CalendarTabControl.Controls.Add(this.EventTabPage);
            this.CalendarTabControl.Controls.Add(this.DayTabPage);
            this.CalendarTabControl.Controls.Add(this.WeekTabPage);
            this.CalendarTabControl.Controls.Add(this.MonthTabPage);
            this.CalendarTabControl.Location = new System.Drawing.Point(264, 38);
            this.CalendarTabControl.Name = "CalendarTabControl";
            this.CalendarTabControl.SelectedIndex = 0;
            this.CalendarTabControl.Size = new System.Drawing.Size(844, 555);
            this.CalendarTabControl.TabIndex = 5;
            // 
            // EventTabPage
            // 
            this.EventTabPage.Controls.Add(this.EventLabel);
            this.EventTabPage.Controls.Add(this.EventDGV);
            this.EventTabPage.Location = new System.Drawing.Point(4, 22);
            this.EventTabPage.Name = "EventTabPage";
            this.EventTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EventTabPage.Size = new System.Drawing.Size(836, 529);
            this.EventTabPage.TabIndex = 0;
            this.EventTabPage.Text = "Events";
            this.EventTabPage.UseVisualStyleBackColor = true;
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLabel.Location = new System.Drawing.Point(321, 11);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(161, 16);
            this.EventLabel.TabIndex = 0;
            this.EventLabel.Text = "date here change on load";
            // 
            // DayTabPage
            // 
            this.DayTabPage.Controls.Add(this.DayNextButton);
            this.DayTabPage.Controls.Add(this.DayPrevButton);
            this.DayTabPage.Controls.Add(this.DayLabel);
            this.DayTabPage.Controls.Add(this.DayDGV);
            this.DayTabPage.Location = new System.Drawing.Point(4, 22);
            this.DayTabPage.Name = "DayTabPage";
            this.DayTabPage.Size = new System.Drawing.Size(836, 529);
            this.DayTabPage.TabIndex = 3;
            this.DayTabPage.Text = "Day View";
            this.DayTabPage.UseVisualStyleBackColor = true;
            // 
            // DayNextButton
            // 
            this.DayNextButton.Location = new System.Drawing.Point(723, 6);
            this.DayNextButton.Name = "DayNextButton";
            this.DayNextButton.Size = new System.Drawing.Size(107, 27);
            this.DayNextButton.TabIndex = 2;
            this.DayNextButton.Text = ">>>";
            this.DayNextButton.UseVisualStyleBackColor = true;
            this.DayNextButton.Click += new System.EventHandler(this.DayNextButton_Click);
            // 
            // DayPrevButton
            // 
            this.DayPrevButton.Location = new System.Drawing.Point(6, 6);
            this.DayPrevButton.Name = "DayPrevButton";
            this.DayPrevButton.Size = new System.Drawing.Size(107, 27);
            this.DayPrevButton.TabIndex = 0;
            this.DayPrevButton.Text = "<<<";
            this.DayPrevButton.UseVisualStyleBackColor = true;
            this.DayPrevButton.Click += new System.EventHandler(this.DayPrevButton_Click);
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.Location = new System.Drawing.Point(321, 11);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(161, 16);
            this.DayLabel.TabIndex = 1;
            this.DayLabel.Text = "date here change on load";
            // 
            // DayDGV
            // 
            this.DayDGV.AllowUserToAddRows = false;
            this.DayDGV.AllowUserToDeleteRows = false;
            this.DayDGV.AllowUserToResizeRows = false;
            this.DayDGV.BackgroundColor = System.Drawing.Color.White;
            this.DayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DayDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DayDGV.Location = new System.Drawing.Point(6, 39);
            this.DayDGV.MultiSelect = false;
            this.DayDGV.Name = "DayDGV";
            this.DayDGV.RowHeadersVisible = false;
            this.DayDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DayDGV.Size = new System.Drawing.Size(824, 484);
            this.DayDGV.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Events";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 715;
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
            this.WeekDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.WeekDGV.BackgroundColor = System.Drawing.Color.White;
            this.WeekDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeWeekColumn,
            this.SundayWeekColumn,
            this.MondayWeekColumn,
            this.TuesdayWeekColumn,
            this.WednesdayWeekColumn,
            this.ThursdayWeekColumn,
            this.FridayWeekColumn,
            this.SaturdayWeekColumn});
            this.WeekDGV.Location = new System.Drawing.Point(6, 39);
            this.WeekDGV.MultiSelect = false;
            this.WeekDGV.Name = "WeekDGV";
            this.WeekDGV.ReadOnly = true;
            this.WeekDGV.RowHeadersVisible = false;
            this.WeekDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.WeekDGV.Size = new System.Drawing.Size(824, 484);
            this.WeekDGV.TabIndex = 3;
            // 
            // TimeWeekColumn
            // 
            this.TimeWeekColumn.HeaderText = "Time";
            this.TimeWeekColumn.Name = "TimeWeekColumn";
            this.TimeWeekColumn.ReadOnly = true;
            this.TimeWeekColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SundayWeekColumn
            // 
            this.SundayWeekColumn.HeaderText = "Sunday";
            this.SundayWeekColumn.Name = "SundayWeekColumn";
            this.SundayWeekColumn.ReadOnly = true;
            this.SundayWeekColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SundayWeekColumn.Width = 103;
            // 
            // MondayWeekColumn
            // 
            this.MondayWeekColumn.HeaderText = "Monday";
            this.MondayWeekColumn.Name = "MondayWeekColumn";
            this.MondayWeekColumn.ReadOnly = true;
            this.MondayWeekColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MondayWeekColumn.Width = 103;
            // 
            // TuesdayWeekColumn
            // 
            this.TuesdayWeekColumn.HeaderText = "Tuesday";
            this.TuesdayWeekColumn.Name = "TuesdayWeekColumn";
            this.TuesdayWeekColumn.ReadOnly = true;
            this.TuesdayWeekColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TuesdayWeekColumn.Width = 103;
            // 
            // WednesdayWeekColumn
            // 
            this.WednesdayWeekColumn.HeaderText = "Wednesday";
            this.WednesdayWeekColumn.Name = "WednesdayWeekColumn";
            this.WednesdayWeekColumn.ReadOnly = true;
            this.WednesdayWeekColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WednesdayWeekColumn.Width = 103;
            // 
            // ThursdayWeekColumn
            // 
            this.ThursdayWeekColumn.HeaderText = "Thursday";
            this.ThursdayWeekColumn.Name = "ThursdayWeekColumn";
            this.ThursdayWeekColumn.ReadOnly = true;
            this.ThursdayWeekColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThursdayWeekColumn.Width = 103;
            // 
            // FridayWeekColumn
            // 
            this.FridayWeekColumn.HeaderText = "Friday";
            this.FridayWeekColumn.Name = "FridayWeekColumn";
            this.FridayWeekColumn.ReadOnly = true;
            this.FridayWeekColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FridayWeekColumn.Width = 103;
            // 
            // SaturdayWeekColumn
            // 
            this.SaturdayWeekColumn.HeaderText = "Saturday";
            this.SaturdayWeekColumn.Name = "SaturdayWeekColumn";
            this.SaturdayWeekColumn.ReadOnly = true;
            this.SaturdayWeekColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaturdayWeekColumn.Width = 103;
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLabel.Location = new System.Drawing.Point(321, 11);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(161, 16);
            this.WeekLabel.TabIndex = 1;
            this.WeekLabel.Text = "date here change on load";
            // 
            // WeekNextButton
            // 
            this.WeekNextButton.Location = new System.Drawing.Point(723, 6);
            this.WeekNextButton.Name = "WeekNextButton";
            this.WeekNextButton.Size = new System.Drawing.Size(107, 27);
            this.WeekNextButton.TabIndex = 2;
            this.WeekNextButton.Text = ">>>";
            this.WeekNextButton.UseVisualStyleBackColor = true;
            this.WeekNextButton.Click += new System.EventHandler(this.WeekNextButton_Click);
            // 
            // WeekPrevButton
            // 
            this.WeekPrevButton.Location = new System.Drawing.Point(6, 6);
            this.WeekPrevButton.Name = "WeekPrevButton";
            this.WeekPrevButton.Size = new System.Drawing.Size(107, 27);
            this.WeekPrevButton.TabIndex = 0;
            this.WeekPrevButton.Text = "<<<";
            this.WeekPrevButton.UseVisualStyleBackColor = true;
            this.WeekPrevButton.Click += new System.EventHandler(this.WeekPrevButton_Click);
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
            this.SundayMonthColumn,
            this.MondayMonthColumn,
            this.TuesdayMonthColumn,
            this.WednesdayMonthColumn,
            this.ThursdayMonthColumn,
            this.FridayMonthColumn,
            this.SaturdayMonthColumn});
            this.MonthDGV.Location = new System.Drawing.Point(6, 39);
            this.MonthDGV.MultiSelect = false;
            this.MonthDGV.Name = "MonthDGV";
            this.MonthDGV.ReadOnly = true;
            this.MonthDGV.RowHeadersVisible = false;
            this.MonthDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MonthDGV.Size = new System.Drawing.Size(824, 484);
            this.MonthDGV.TabIndex = 3;
            // 
            // SundayMonthColumn
            // 
            this.SundayMonthColumn.HeaderText = "Sunday";
            this.SundayMonthColumn.Name = "SundayMonthColumn";
            this.SundayMonthColumn.ReadOnly = true;
            this.SundayMonthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SundayMonthColumn.Width = 117;
            // 
            // MondayMonthColumn
            // 
            this.MondayMonthColumn.HeaderText = "Monday";
            this.MondayMonthColumn.Name = "MondayMonthColumn";
            this.MondayMonthColumn.ReadOnly = true;
            this.MondayMonthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MondayMonthColumn.Width = 117;
            // 
            // TuesdayMonthColumn
            // 
            this.TuesdayMonthColumn.HeaderText = "Tuesday";
            this.TuesdayMonthColumn.Name = "TuesdayMonthColumn";
            this.TuesdayMonthColumn.ReadOnly = true;
            this.TuesdayMonthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TuesdayMonthColumn.Width = 117;
            // 
            // WednesdayMonthColumn
            // 
            this.WednesdayMonthColumn.HeaderText = "Wednesday";
            this.WednesdayMonthColumn.Name = "WednesdayMonthColumn";
            this.WednesdayMonthColumn.ReadOnly = true;
            this.WednesdayMonthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WednesdayMonthColumn.Width = 117;
            // 
            // ThursdayMonthColumn
            // 
            this.ThursdayMonthColumn.HeaderText = "Thursday";
            this.ThursdayMonthColumn.Name = "ThursdayMonthColumn";
            this.ThursdayMonthColumn.ReadOnly = true;
            this.ThursdayMonthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThursdayMonthColumn.Width = 117;
            // 
            // FridayMonthColumn
            // 
            this.FridayMonthColumn.HeaderText = "Friday";
            this.FridayMonthColumn.Name = "FridayMonthColumn";
            this.FridayMonthColumn.ReadOnly = true;
            this.FridayMonthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FridayMonthColumn.Width = 117;
            // 
            // SaturdayMonthColumn
            // 
            this.SaturdayMonthColumn.HeaderText = "Saturday";
            this.SaturdayMonthColumn.Name = "SaturdayMonthColumn";
            this.SaturdayMonthColumn.ReadOnly = true;
            this.SaturdayMonthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SaturdayMonthColumn.Width = 118;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(341, 11);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(170, 16);
            this.MonthLabel.TabIndex = 1;
            this.MonthLabel.Text = "month here change on load";
            // 
            // MonthNextButton
            // 
            this.MonthNextButton.Location = new System.Drawing.Point(723, 6);
            this.MonthNextButton.Name = "MonthNextButton";
            this.MonthNextButton.Size = new System.Drawing.Size(107, 27);
            this.MonthNextButton.TabIndex = 2;
            this.MonthNextButton.Text = ">>>";
            this.MonthNextButton.UseVisualStyleBackColor = true;
            this.MonthNextButton.Click += new System.EventHandler(this.MonthNextButton_Click);
            // 
            // MonthPrevButton
            // 
            this.MonthPrevButton.Location = new System.Drawing.Point(6, 6);
            this.MonthPrevButton.Name = "MonthPrevButton";
            this.MonthPrevButton.Size = new System.Drawing.Size(107, 27);
            this.MonthPrevButton.TabIndex = 0;
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
            this.Controls.Add(this.Time);
            this.Controls.Add(this.CalendarTabControl);
            this.Controls.Add(this.NewEventButton);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.UserLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Schedule Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventDGV)).EndInit();
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.CalendarTabControl.ResumeLayout(false);
            this.EventTabPage.ResumeLayout(false);
            this.EventTabPage.PerformLayout();
            this.DayTabPage.ResumeLayout(false);
            this.DayTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayDGV)).EndInit();
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
        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.DataGridView UserDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button NewEventButton;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.DataGridView EventDGV;
        private System.Windows.Forms.TabControl CalendarTabControl;
        private System.Windows.Forms.TabPage EventTabPage;
        private System.Windows.Forms.TabPage WeekTabPage;
        private System.Windows.Forms.DataGridView WeekDGV;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Button WeekNextButton;
        private System.Windows.Forms.Button WeekPrevButton;
        private System.Windows.Forms.TabPage MonthTabPage;
        private System.Windows.Forms.DataGridView MonthDGV;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Button MonthNextButton;
        private System.Windows.Forms.Button MonthPrevButton;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.TabPage DayTabPage;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.DataGridView DayDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayMonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayMonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayMonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayMonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayMonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayMonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayMonthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeWeekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SundayWeekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayWeekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayWeekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayWeekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayWeekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayWeekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaturdayWeekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventColumn;
        private System.Windows.Forms.Button DayNextButton;
        private System.Windows.Forms.Button DayPrevButton;
    }
}

