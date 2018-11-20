namespace ScheduleBuilder
{
    partial class ViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.AllDayCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RepeatCheckBox = new System.Windows.Forms.CheckBox();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FinishLabel = new System.Windows.Forms.Label();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.FinishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RemoveEventButton = new System.Windows.Forms.Button();
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.FinishTextBox = new System.Windows.Forms.TextBox();
            this.RepeatOccurrencesTextBox = new System.Windows.Forms.TextBox();
            this.PriorityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AllDayCheckBox
            // 
            this.AllDayCheckBox.AutoSize = true;
            this.AllDayCheckBox.Enabled = false;
            this.AllDayCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllDayCheckBox.Location = new System.Drawing.Point(348, 8);
            this.AllDayCheckBox.Name = "AllDayCheckBox";
            this.AllDayCheckBox.Size = new System.Drawing.Size(69, 20);
            this.AllDayCheckBox.TabIndex = 41;
            this.AllDayCheckBox.Text = "All-day";
            this.AllDayCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Priority";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "every";
            // 
            // RepeatCheckBox
            // 
            this.RepeatCheckBox.AutoSize = true;
            this.RepeatCheckBox.Enabled = false;
            this.RepeatCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatCheckBox.Location = new System.Drawing.Point(189, 98);
            this.RepeatCheckBox.Name = "RepeatCheckBox";
            this.RepeatCheckBox.Size = new System.Drawing.Size(110, 20);
            this.RepeatCheckBox.TabIndex = 36;
            this.RepeatCheckBox.Text = "Event repeats";
            this.RepeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Enabled = false;
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTimePicker.Location = new System.Drawing.Point(77, 34);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(262, 22);
            this.StartDateTimePicker.TabIndex = 35;
            // 
            // FinishLabel
            // 
            this.FinishLabel.AutoSize = true;
            this.FinishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishLabel.Location = new System.Drawing.Point(28, 69);
            this.FinishLabel.Name = "FinishLabel";
            this.FinishLabel.Size = new System.Drawing.Size(43, 16);
            this.FinishLabel.TabIndex = 33;
            this.FinishLabel.Text = "Finish";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTextBox.Location = new System.Drawing.Point(77, 6);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.ReadOnly = true;
            this.SubjectTextBox.Size = new System.Drawing.Size(262, 22);
            this.SubjectTextBox.TabIndex = 31;
            this.SubjectTextBox.TextChanged += new System.EventHandler(this.SubjectTextBox_TextChanged);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTextBox.Location = new System.Drawing.Point(77, 128);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(262, 22);
            this.LocationTextBox.TabIndex = 30;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(12, 128);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(59, 16);
            this.LocationLabel.TabIndex = 29;
            this.LocationLabel.Text = "Location";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(3, 202);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(466, 242);
            this.DescriptionTextBox.TabIndex = 28;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 183);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.DescriptionLabel.TabIndex = 27;
            this.DescriptionLabel.Text = "Description";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.Location = new System.Drawing.Point(36, 39);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(35, 16);
            this.StartLabel.TabIndex = 26;
            this.StartLabel.Text = "Start";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(12, 9);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(53, 16);
            this.SubjectLabel.TabIndex = 25;
            this.SubjectLabel.Text = "Subject";
            // 
            // FinishDateTimePicker
            // 
            this.FinishDateTimePicker.Enabled = false;
            this.FinishDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishDateTimePicker.Location = new System.Drawing.Point(77, 64);
            this.FinishDateTimePicker.Name = "FinishDateTimePicker";
            this.FinishDateTimePicker.Size = new System.Drawing.Size(262, 22);
            this.FinishDateTimePicker.TabIndex = 24;
            // 
            // RemoveEventButton
            // 
            this.RemoveEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEventButton.Location = new System.Drawing.Point(3, 450);
            this.RemoveEventButton.Name = "RemoveEventButton";
            this.RemoveEventButton.Size = new System.Drawing.Size(466, 27);
            this.RemoveEventButton.TabIndex = 43;
            this.RemoveEventButton.Text = "Remove Event";
            this.RemoveEventButton.UseVisualStyleBackColor = true;
            this.RemoveEventButton.Click += new System.EventHandler(this.RemoveEventButton_Click);
            // 
            // StartTextBox
            // 
            this.StartTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTextBox.Location = new System.Drawing.Point(348, 36);
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.ReadOnly = true;
            this.StartTextBox.Size = new System.Drawing.Size(121, 22);
            this.StartTextBox.TabIndex = 44;
            // 
            // FinishTextBox
            // 
            this.FinishTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishTextBox.Location = new System.Drawing.Point(348, 66);
            this.FinishTextBox.Name = "FinishTextBox";
            this.FinishTextBox.ReadOnly = true;
            this.FinishTextBox.Size = new System.Drawing.Size(121, 22);
            this.FinishTextBox.TabIndex = 45;
            // 
            // RepeatOccurrencesTextBox
            // 
            this.RepeatOccurrencesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatOccurrencesTextBox.Location = new System.Drawing.Point(348, 96);
            this.RepeatOccurrencesTextBox.Name = "RepeatOccurrencesTextBox";
            this.RepeatOccurrencesTextBox.ReadOnly = true;
            this.RepeatOccurrencesTextBox.Size = new System.Drawing.Size(121, 22);
            this.RepeatOccurrencesTextBox.TabIndex = 46;
            // 
            // PriorityTextBox
            // 
            this.PriorityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityTextBox.Location = new System.Drawing.Point(77, 156);
            this.PriorityTextBox.Name = "PriorityTextBox";
            this.PriorityTextBox.ReadOnly = true;
            this.PriorityTextBox.Size = new System.Drawing.Size(121, 22);
            this.PriorityTextBox.TabIndex = 47;
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 481);
            this.Controls.Add(this.PriorityTextBox);
            this.Controls.Add(this.RepeatOccurrencesTextBox);
            this.Controls.Add(this.FinishTextBox);
            this.Controls.Add(this.StartTextBox);
            this.Controls.Add(this.RemoveEventButton);
            this.Controls.Add(this.AllDayCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepeatCheckBox);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.FinishLabel);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.FinishDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewerForm";
            this.Text = "Event Viewer";
            this.Load += new System.EventHandler(this.ViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox AllDayCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RepeatCheckBox;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label FinishLabel;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.DateTimePicker FinishDateTimePicker;
        private System.Windows.Forms.Button RemoveEventButton;
        private System.Windows.Forms.TextBox StartTextBox;
        private System.Windows.Forms.TextBox FinishTextBox;
        private System.Windows.Forms.TextBox RepeatOccurrencesTextBox;
        private System.Windows.Forms.TextBox PriorityTextBox;
    }
}