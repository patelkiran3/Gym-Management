namespace Gym_Management.UI
{
    partial class TrainerDetailsReport
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
            this.lblAttendence_Id = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnInsert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAttendence_Id
            // 
            this.lblAttendence_Id.AutoSize = true;
            this.lblAttendence_Id.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendence_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendence_Id.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAttendence_Id.Location = new System.Drawing.Point(312, 25);
            this.lblAttendence_Id.Name = "lblAttendence_Id";
            this.lblAttendence_Id.Size = new System.Drawing.Size(88, 17);
            this.lblAttendence_Id.TabIndex = 26;
            this.lblAttendence_Id.Text = "TRAINER ID :";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(5, 52);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1025, 434);
            this.crystalReportViewer1.TabIndex = 28;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInsert.Location = new System.Drawing.Point(605, 21);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 24);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "VIEW";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 30;
            // 
            // TrainerDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 487);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lblAttendence_Id);
            this.Name = "TrainerDetailsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainerReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrainerDetailsReport_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAttendence_Id;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox textBox1;
    }
}