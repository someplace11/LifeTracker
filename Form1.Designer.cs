namespace LifeTracker
{
    partial class formLifeTracker
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
            this.inputActivity = new System.Windows.Forms.TextBox();
            this.inputHours = new System.Windows.Forms.TextBox();
            this.inputActivityNote = new System.Windows.Forms.TextBox();
            this.btnSubmitActivity = new System.Windows.Forms.Button();
            this.inputCalories = new System.Windows.Forms.TextBox();
            this.btnSubmitHealth = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblActivityNote = new System.Windows.Forms.Label();
            this.gbActivity = new System.Windows.Forms.GroupBox();
            this.gbHealth = new System.Windows.Forms.GroupBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.inputWeight = new System.Windows.Forms.TextBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.gbMoney = new System.Windows.Forms.GroupBox();
            this.btnSubmitMoney = new System.Windows.Forms.Button();
            this.lblMoneyNote = new System.Windows.Forms.Label();
            this.inputMoneyNote = new System.Windows.Forms.TextBox();
            this.lblMoneySpent = new System.Windows.Forms.Label();
            this.inputMoneySpent = new System.Windows.Forms.TextBox();
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.gbActivity.SuspendLayout();
            this.gbHealth.SuspendLayout();
            this.gbMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputActivity
            // 
            this.inputActivity.Location = new System.Drawing.Point(110, 21);
            this.inputActivity.Name = "inputActivity";
            this.inputActivity.Size = new System.Drawing.Size(200, 22);
            this.inputActivity.TabIndex = 1;
            // 
            // inputHours
            // 
            this.inputHours.Location = new System.Drawing.Point(110, 49);
            this.inputHours.Name = "inputHours";
            this.inputHours.Size = new System.Drawing.Size(200, 22);
            this.inputHours.TabIndex = 2;
            // 
            // inputActivityNote
            // 
            this.inputActivityNote.Location = new System.Drawing.Point(110, 77);
            this.inputActivityNote.Name = "inputActivityNote";
            this.inputActivityNote.Size = new System.Drawing.Size(200, 22);
            this.inputActivityNote.TabIndex = 3;
            // 
            // btnSubmitActivity
            // 
            this.btnSubmitActivity.Location = new System.Drawing.Point(65, 117);
            this.btnSubmitActivity.Name = "btnSubmitActivity";
            this.btnSubmitActivity.Size = new System.Drawing.Size(225, 29);
            this.btnSubmitActivity.TabIndex = 4;
            this.btnSubmitActivity.Text = "Submit Activity...";
            this.btnSubmitActivity.UseVisualStyleBackColor = true;
            this.btnSubmitActivity.Click += new System.EventHandler(this.BtnSubmitActivity_Click);
            // 
            // inputCalories
            // 
            this.inputCalories.Location = new System.Drawing.Point(110, 25);
            this.inputCalories.Name = "inputCalories";
            this.inputCalories.Size = new System.Drawing.Size(200, 22);
            this.inputCalories.TabIndex = 5;
            // 
            // btnSubmitHealth
            // 
            this.btnSubmitHealth.Location = new System.Drawing.Point(65, 93);
            this.btnSubmitHealth.Name = "btnSubmitHealth";
            this.btnSubmitHealth.Size = new System.Drawing.Size(225, 29);
            this.btnSubmitHealth.TabIndex = 7;
            this.btnSubmitHealth.Text = "Submit Health...";
            this.btnSubmitHealth.UseVisualStyleBackColor = true;
            this.btnSubmitHealth.Click += new System.EventHandler(this.BtnSubmitHealth_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(74, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(48, 24);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(56, 17);
            this.lblActivity.TabIndex = 8;
            this.lblActivity.Text = "Activity:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(54, 52);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(50, 17);
            this.lblHours.TabIndex = 9;
            this.lblHours.Text = "Hours:";
            // 
            // lblActivityNote
            // 
            this.lblActivityNote.AutoSize = true;
            this.lblActivityNote.Location = new System.Drawing.Point(62, 80);
            this.lblActivityNote.Name = "lblActivityNote";
            this.lblActivityNote.Size = new System.Drawing.Size(42, 17);
            this.lblActivityNote.TabIndex = 10;
            this.lblActivityNote.Text = "Note:";
            // 
            // gbActivity
            // 
            this.gbActivity.Controls.Add(this.lblActivity);
            this.gbActivity.Controls.Add(this.lblActivityNote);
            this.gbActivity.Controls.Add(this.btnSubmitActivity);
            this.gbActivity.Controls.Add(this.lblHours);
            this.gbActivity.Controls.Add(this.inputActivity);
            this.gbActivity.Controls.Add(this.inputActivityNote);
            this.gbActivity.Controls.Add(this.inputHours);
            this.gbActivity.Location = new System.Drawing.Point(12, 40);
            this.gbActivity.Name = "gbActivity";
            this.gbActivity.Size = new System.Drawing.Size(366, 163);
            this.gbActivity.TabIndex = 11;
            this.gbActivity.TabStop = false;
            this.gbActivity.Text = "Activities";
            // 
            // gbHealth
            // 
            this.gbHealth.Controls.Add(this.lblWeight);
            this.gbHealth.Controls.Add(this.inputWeight);
            this.gbHealth.Controls.Add(this.lblCalories);
            this.gbHealth.Controls.Add(this.inputCalories);
            this.gbHealth.Controls.Add(this.btnSubmitHealth);
            this.gbHealth.Location = new System.Drawing.Point(12, 209);
            this.gbHealth.Name = "gbHealth";
            this.gbHealth.Size = new System.Drawing.Size(366, 139);
            this.gbHealth.TabIndex = 12;
            this.gbHealth.TabStop = false;
            this.gbHealth.Text = "Health";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(48, 57);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 17);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Weight:";
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(110, 54);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(200, 22);
            this.inputWeight.TabIndex = 6;
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(41, 28);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(63, 17);
            this.lblCalories.TabIndex = 0;
            this.lblCalories.Text = "Calories:";
            // 
            // gbMoney
            // 
            this.gbMoney.Controls.Add(this.btnSubmitMoney);
            this.gbMoney.Controls.Add(this.lblMoneyNote);
            this.gbMoney.Controls.Add(this.inputMoneyNote);
            this.gbMoney.Controls.Add(this.lblMoneySpent);
            this.gbMoney.Controls.Add(this.inputMoneySpent);
            this.gbMoney.Location = new System.Drawing.Point(12, 354);
            this.gbMoney.Name = "gbMoney";
            this.gbMoney.Size = new System.Drawing.Size(364, 134);
            this.gbMoney.TabIndex = 13;
            this.gbMoney.TabStop = false;
            this.gbMoney.Text = "Money";
            // 
            // btnSubmitMoney
            // 
            this.btnSubmitMoney.Location = new System.Drawing.Point(65, 90);
            this.btnSubmitMoney.Name = "btnSubmitMoney";
            this.btnSubmitMoney.Size = new System.Drawing.Size(225, 29);
            this.btnSubmitMoney.TabIndex = 10;
            this.btnSubmitMoney.Text = "Submit Money...";
            this.btnSubmitMoney.UseVisualStyleBackColor = true;
            this.btnSubmitMoney.Click += new System.EventHandler(this.BtnSubmitMoney_Click);
            // 
            // lblMoneyNote
            // 
            this.lblMoneyNote.AutoSize = true;
            this.lblMoneyNote.Location = new System.Drawing.Point(62, 54);
            this.lblMoneyNote.Name = "lblMoneyNote";
            this.lblMoneyNote.Size = new System.Drawing.Size(42, 17);
            this.lblMoneyNote.TabIndex = 11;
            this.lblMoneyNote.Text = "Note:";
            // 
            // inputMoneyNote
            // 
            this.inputMoneyNote.Location = new System.Drawing.Point(110, 51);
            this.inputMoneyNote.Name = "inputMoneyNote";
            this.inputMoneyNote.Size = new System.Drawing.Size(200, 22);
            this.inputMoneyNote.TabIndex = 9;
            // 
            // lblMoneySpent
            // 
            this.lblMoneySpent.AutoSize = true;
            this.lblMoneySpent.Location = new System.Drawing.Point(9, 25);
            this.lblMoneySpent.Name = "lblMoneySpent";
            this.lblMoneySpent.Size = new System.Drawing.Size(95, 17);
            this.lblMoneySpent.TabIndex = 9;
            this.lblMoneySpent.Text = "Money Spent:";
            // 
            // inputMoneySpent
            // 
            this.inputMoneySpent.Location = new System.Drawing.Point(110, 22);
            this.inputMoneySpent.Name = "inputMoneySpent";
            this.inputMoneySpent.Size = new System.Drawing.Size(200, 22);
            this.inputMoneySpent.TabIndex = 8;
            // 
            // inputDate
            // 
            this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputDate.Location = new System.Drawing.Point(122, 12);
            this.inputDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(200, 22);
            this.inputDate.TabIndex = 0;
            this.inputDate.Value = new System.DateTime(2020, 1, 14, 22, 5, 58, 0);
            // 
            // formLifeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 500);
            this.Controls.Add(this.gbMoney);
            this.Controls.Add(this.gbHealth);
            this.Controls.Add(this.gbActivity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.inputDate);
            this.Name = "formLifeTracker";
            this.Text = "Life Tracker";
            this.gbActivity.ResumeLayout(false);
            this.gbActivity.PerformLayout();
            this.gbHealth.ResumeLayout(false);
            this.gbHealth.PerformLayout();
            this.gbMoney.ResumeLayout(false);
            this.gbMoney.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputActivity;
        private System.Windows.Forms.TextBox inputHours;
        private System.Windows.Forms.TextBox inputActivityNote;
        private System.Windows.Forms.Button btnSubmitActivity;
        private System.Windows.Forms.TextBox inputCalories;
        private System.Windows.Forms.Button btnSubmitHealth;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblActivityNote;
        private System.Windows.Forms.GroupBox gbActivity;
        private System.Windows.Forms.GroupBox gbHealth;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.GroupBox gbMoney;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox inputWeight;
        private System.Windows.Forms.TextBox inputMoneyNote;
        private System.Windows.Forms.Label lblMoneySpent;
        private System.Windows.Forms.TextBox inputMoneySpent;
        private System.Windows.Forms.Label lblMoneyNote;
        private System.Windows.Forms.Button btnSubmitMoney;
        private System.Windows.Forms.DateTimePicker inputDate;
    }
}

