
namespace WeightLossHelper
{
    partial class frmHome
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblThisWeekRange = new System.Windows.Forms.Label();
            this.lblCurrentWeek = new System.Windows.Forms.Label();
            this.lblGoalWeight = new System.Windows.Forms.Label();
            this.lblStartingWeight = new System.Windows.Forms.Label();
            this.lblCurrentWeight = new System.Windows.Forms.Label();
            this.lblPoundsToLose = new System.Windows.Forms.Label();
            this.lblDaysRemaining = new System.Windows.Forms.Label();
            this.lblWeightDown = new System.Windows.Forms.Label();
            this.lblWeightUp = new System.Windows.Forms.Label();
            this.lblTotalWeightLost = new System.Windows.Forms.Label();
            this.btnRecordWeight = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(634, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 47);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Firebrick;
            this.panelTop.Controls.Add(this.lblPage);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(676, 55);
            this.panelTop.TabIndex = 1;
            // 
            // lblThisWeekRange
            // 
            this.lblThisWeekRange.AutoSize = true;
            this.lblThisWeekRange.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisWeekRange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblThisWeekRange.Location = new System.Drawing.Point(26, 58);
            this.lblThisWeekRange.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblThisWeekRange.Name = "lblThisWeekRange";
            this.lblThisWeekRange.Size = new System.Drawing.Size(164, 22);
            this.lblThisWeekRange.TabIndex = 2;
            this.lblThisWeekRange.Text = "June 22nd - 27th";
            // 
            // lblCurrentWeek
            // 
            this.lblCurrentWeek.AutoSize = true;
            this.lblCurrentWeek.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeek.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentWeek.Location = new System.Drawing.Point(25, 15);
            this.lblCurrentWeek.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCurrentWeek.Name = "lblCurrentWeek";
            this.lblCurrentWeek.Size = new System.Drawing.Size(100, 30);
            this.lblCurrentWeek.TabIndex = 1;
            this.lblCurrentWeek.Text = "Week 5";
            // 
            // lblGoalWeight
            // 
            this.lblGoalWeight.AutoSize = true;
            this.lblGoalWeight.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalWeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGoalWeight.Location = new System.Drawing.Point(26, 278);
            this.lblGoalWeight.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGoalWeight.Name = "lblGoalWeight";
            this.lblGoalWeight.Size = new System.Drawing.Size(79, 60);
            this.lblGoalWeight.TabIndex = 4;
            this.lblGoalWeight.Text = "Goal \r\n297.5\r\n";
            // 
            // lblStartingWeight
            // 
            this.lblStartingWeight.AutoSize = true;
            this.lblStartingWeight.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingWeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartingWeight.Location = new System.Drawing.Point(25, 186);
            this.lblStartingWeight.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblStartingWeight.Name = "lblStartingWeight";
            this.lblStartingWeight.Size = new System.Drawing.Size(108, 60);
            this.lblStartingWeight.TabIndex = 3;
            this.lblStartingWeight.Text = "Starting \r\n298.8\r\n";
            // 
            // lblCurrentWeight
            // 
            this.lblCurrentWeight.AutoSize = true;
            this.lblCurrentWeight.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentWeight.Location = new System.Drawing.Point(410, 97);
            this.lblCurrentWeight.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCurrentWeight.Name = "lblCurrentWeight";
            this.lblCurrentWeight.Size = new System.Drawing.Size(142, 57);
            this.lblCurrentWeight.TabIndex = 5;
            this.lblCurrentWeight.Text = "297.8";
            // 
            // lblPoundsToLose
            // 
            this.lblPoundsToLose.AutoSize = true;
            this.lblPoundsToLose.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoundsToLose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPoundsToLose.Location = new System.Drawing.Point(27, 127);
            this.lblPoundsToLose.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPoundsToLose.Name = "lblPoundsToLose";
            this.lblPoundsToLose.Size = new System.Drawing.Size(98, 22);
            this.lblPoundsToLose.TabIndex = 6;
            this.lblPoundsToLose.Text = "1.2 lbs left";
            // 
            // lblDaysRemaining
            // 
            this.lblDaysRemaining.AutoSize = true;
            this.lblDaysRemaining.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRemaining.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDaysRemaining.Location = new System.Drawing.Point(25, 90);
            this.lblDaysRemaining.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDaysRemaining.Name = "lblDaysRemaining";
            this.lblDaysRemaining.Size = new System.Drawing.Size(195, 25);
            this.lblDaysRemaining.TabIndex = 7;
            this.lblDaysRemaining.Text = "3 days remaining";
            // 
            // lblWeightDown
            // 
            this.lblWeightDown.AutoSize = true;
            this.lblWeightDown.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightDown.ForeColor = System.Drawing.Color.Green;
            this.lblWeightDown.Location = new System.Drawing.Point(554, 124);
            this.lblWeightDown.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblWeightDown.Name = "lblWeightDown";
            this.lblWeightDown.Size = new System.Drawing.Size(54, 30);
            this.lblWeightDown.TabIndex = 8;
            this.lblWeightDown.Text = "-0.2";
            // 
            // lblWeightUp
            // 
            this.lblWeightUp.AutoSize = true;
            this.lblWeightUp.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightUp.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWeightUp.Location = new System.Drawing.Point(335, 120);
            this.lblWeightUp.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblWeightUp.Name = "lblWeightUp";
            this.lblWeightUp.Size = new System.Drawing.Size(61, 30);
            this.lblWeightUp.TabIndex = 9;
            this.lblWeightUp.Text = "+0.2";
            // 
            // lblTotalWeightLost
            // 
            this.lblTotalWeightLost.AutoSize = true;
            this.lblTotalWeightLost.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeightLost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalWeightLost.Location = new System.Drawing.Point(399, 248);
            this.lblTotalWeightLost.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTotalWeightLost.Name = "lblTotalWeightLost";
            this.lblTotalWeightLost.Size = new System.Drawing.Size(153, 37);
            this.lblTotalWeightLost.TabIndex = 10;
            this.lblTotalWeightLost.Text = "30 lbs lost";
            // 
            // btnRecordWeight
            // 
            this.btnRecordWeight.BackColor = System.Drawing.Color.Firebrick;
            this.btnRecordWeight.FlatAppearance.BorderSize = 0;
            this.btnRecordWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordWeight.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordWeight.Location = new System.Drawing.Point(296, 0);
            this.btnRecordWeight.Name = "btnRecordWeight";
            this.btnRecordWeight.Size = new System.Drawing.Size(70, 55);
            this.btnRecordWeight.TabIndex = 11;
            this.btnRecordWeight.Text = "+";
            this.btnRecordWeight.UseVisualStyleBackColor = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Firebrick;
            this.panelBottom.Controls.Add(this.btnWeekly);
            this.panelBottom.Controls.Add(this.btnRecordWeight);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 420);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(676, 55);
            this.panelBottom.TabIndex = 12;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.lblThisWeekRange);
            this.panelCenter.Controls.Add(this.lblDaysRemaining);
            this.panelCenter.Controls.Add(this.lblCurrentWeek);
            this.panelCenter.Controls.Add(this.lblTotalWeightLost);
            this.panelCenter.Controls.Add(this.lblStartingWeight);
            this.panelCenter.Controls.Add(this.lblGoalWeight);
            this.panelCenter.Controls.Add(this.lblPoundsToLose);
            this.panelCenter.Controls.Add(this.lblWeightUp);
            this.panelCenter.Controls.Add(this.lblCurrentWeight);
            this.panelCenter.Controls.Add(this.lblWeightDown);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 55);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(676, 365);
            this.panelCenter.TabIndex = 13;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(267, 18);
            this.lblPage.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(129, 30);
            this.lblPage.TabIndex = 11;
            this.lblPage.Text = "This Week";
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.Color.Firebrick;
            this.btnWeekly.FlatAppearance.BorderSize = 0;
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.Location = new System.Drawing.Point(63, 0);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(70, 55);
            this.btnWeekly.TabIndex = 12;
            this.btnWeekly.Text = "Weekly";
            this.btnWeekly.UseVisualStyleBackColor = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(676, 475);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCurrentWeek;
        private System.Windows.Forms.Label lblGoalWeight;
        private System.Windows.Forms.Label lblStartingWeight;
        private System.Windows.Forms.Label lblThisWeekRange;
        private System.Windows.Forms.Label lblCurrentWeight;
        private System.Windows.Forms.Label lblPoundsToLose;
        private System.Windows.Forms.Label lblDaysRemaining;
        private System.Windows.Forms.Label lblWeightDown;
        private System.Windows.Forms.Label lblWeightUp;
        private System.Windows.Forms.Label lblTotalWeightLost;
        private System.Windows.Forms.Button btnRecordWeight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnWeekly;
    }
}

