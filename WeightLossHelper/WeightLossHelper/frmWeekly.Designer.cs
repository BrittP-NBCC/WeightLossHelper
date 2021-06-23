
namespace WeightLossHelper
{
    partial class frmWeekly
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
            this.lblCurrentWeek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentWeek
            // 
            this.lblCurrentWeek.AutoSize = true;
            this.lblCurrentWeek.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeek.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentWeek.Location = new System.Drawing.Point(279, 42);
            this.lblCurrentWeek.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCurrentWeek.Name = "lblCurrentWeek";
            this.lblCurrentWeek.Size = new System.Drawing.Size(100, 30);
            this.lblCurrentWeek.TabIndex = 2;
            this.lblCurrentWeek.Text = "Week 5";
            this.lblCurrentWeek.Click += new System.EventHandler(this.lblCurrentWeek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(279, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Week 5";
            // 
            // frmWeekly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(676, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentWeek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWeekly";
            this.Text = "frmWeekly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentWeek;
        private System.Windows.Forms.Label label1;
    }
}