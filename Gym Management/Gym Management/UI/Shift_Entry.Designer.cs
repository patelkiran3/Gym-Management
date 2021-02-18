namespace Gym_Management
{
    partial class Shift_Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shift_Entry));
            this.dgvShift_Entry = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtp_Shift_To_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Shift_From_Date = new System.Windows.Forms.DateTimePicker();
            this.cmbType_Of_Shift = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtLast_Name = new System.Windows.Forms.TextBox();
            this.txtFirst_Name = new System.Windows.Forms.TextBox();
            this.txtShift_Id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFirst_Name = new System.Windows.Forms.Label();
            this.lblShift_Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShift_Entry_Form = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift_Entry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShift_Entry
            // 
            this.dgvShift_Entry.BackgroundColor = System.Drawing.Color.White;
            this.dgvShift_Entry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShift_Entry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShift_Entry.Location = new System.Drawing.Point(371, 110);
            this.dgvShift_Entry.Name = "dgvShift_Entry";
            this.dgvShift_Entry.Size = new System.Drawing.Size(513, 258);
            this.dgvShift_Entry.TabIndex = 68;
            this.dgvShift_Entry.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShift_Entry_RowHeaderMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(436, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(448, 25);
            this.txtSearch.TabIndex = 67;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Orange;
            this.lblSearch.Location = new System.Drawing.Point(368, 79);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 17);
            this.lblSearch.TabIndex = 66;
            this.lblSearch.Text = "SEARCH :";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Orange;
            this.btnReset.Location = new System.Drawing.Point(627, 392);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 31);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Orange;
            this.btnDelete.Location = new System.Drawing.Point(503, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Orange;
            this.btnUpdate.Location = new System.Drawing.Point(380, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Orange;
            this.btnInsert.Location = new System.Drawing.Point(256, 392);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 31);
            this.btnInsert.TabIndex = 62;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtp_Shift_To_Date
            // 
            this.dtp_Shift_To_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Shift_To_Date.Location = new System.Drawing.Point(171, 328);
            this.dtp_Shift_To_Date.Name = "dtp_Shift_To_Date";
            this.dtp_Shift_To_Date.Size = new System.Drawing.Size(178, 25);
            this.dtp_Shift_To_Date.TabIndex = 61;
            // 
            // dtp_Shift_From_Date
            // 
            this.dtp_Shift_From_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Shift_From_Date.Location = new System.Drawing.Point(171, 292);
            this.dtp_Shift_From_Date.Name = "dtp_Shift_From_Date";
            this.dtp_Shift_From_Date.Size = new System.Drawing.Size(178, 25);
            this.dtp_Shift_From_Date.TabIndex = 60;
            // 
            // cmbType_Of_Shift
            // 
            this.cmbType_Of_Shift.FormattingEnabled = true;
            this.cmbType_Of_Shift.Items.AddRange(new object[] {
            "MORNING",
            "AFTERNOON",
            "EVENING"});
            this.cmbType_Of_Shift.Location = new System.Drawing.Point(171, 256);
            this.cmbType_Of_Shift.Name = "cmbType_Of_Shift";
            this.cmbType_Of_Shift.Size = new System.Drawing.Size(178, 25);
            this.cmbType_Of_Shift.TabIndex = 59;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "STAFF",
            "USER\t"});
            this.cmbRole.Location = new System.Drawing.Point(171, 219);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(178, 25);
            this.cmbRole.TabIndex = 58;
            // 
            // txtLast_Name
            // 
            this.txtLast_Name.Location = new System.Drawing.Point(171, 185);
            this.txtLast_Name.Name = "txtLast_Name";
            this.txtLast_Name.Size = new System.Drawing.Size(178, 25);
            this.txtLast_Name.TabIndex = 57;
            // 
            // txtFirst_Name
            // 
            this.txtFirst_Name.Location = new System.Drawing.Point(171, 151);
            this.txtFirst_Name.Name = "txtFirst_Name";
            this.txtFirst_Name.Size = new System.Drawing.Size(178, 25);
            this.txtFirst_Name.TabIndex = 56;
            // 
            // txtShift_Id
            // 
            this.txtShift_Id.Enabled = false;
            this.txtShift_Id.Location = new System.Drawing.Point(171, 117);
            this.txtShift_Id.Name = "txtShift_Id";
            this.txtShift_Id.ReadOnly = true;
            this.txtShift_Id.Size = new System.Drawing.Size(178, 25);
            this.txtShift_Id.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(54, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "SHIFT TO DATE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(35, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "SHIFT FROM DATE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(57, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "TYPE OF SHIFT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(117, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "ROLE :";
            // 
            // lblFirst_Name
            // 
            this.lblFirst_Name.AutoSize = true;
            this.lblFirst_Name.BackColor = System.Drawing.Color.Transparent;
            this.lblFirst_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst_Name.ForeColor = System.Drawing.Color.Orange;
            this.lblFirst_Name.Location = new System.Drawing.Point(73, 154);
            this.lblFirst_Name.Name = "lblFirst_Name";
            this.lblFirst_Name.Size = new System.Drawing.Size(92, 17);
            this.lblFirst_Name.TabIndex = 50;
            this.lblFirst_Name.Text = "FIRST NAME :";
            // 
            // lblShift_Id
            // 
            this.lblShift_Id.AutoSize = true;
            this.lblShift_Id.BackColor = System.Drawing.Color.Transparent;
            this.lblShift_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift_Id.ForeColor = System.Drawing.Color.Orange;
            this.lblShift_Id.Location = new System.Drawing.Point(95, 120);
            this.lblShift_Id.Name = "lblShift_Id";
            this.lblShift_Id.Size = new System.Drawing.Size(70, 17);
            this.lblShift_Id.TabIndex = 49;
            this.lblShift_Id.Text = "SHIFT ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(76, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "LAST NAME :";
            // 
            // lblShift_Entry_Form
            // 
            this.lblShift_Entry_Form.AutoSize = true;
            this.lblShift_Entry_Form.BackColor = System.Drawing.Color.Transparent;
            this.lblShift_Entry_Form.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift_Entry_Form.ForeColor = System.Drawing.Color.Orange;
            this.lblShift_Entry_Form.Location = new System.Drawing.Point(384, 29);
            this.lblShift_Entry_Form.Name = "lblShift_Entry_Form";
            this.lblShift_Entry_Form.Size = new System.Drawing.Size(157, 21);
            this.lblShift_Entry_Form.TabIndex = 47;
            this.lblShift_Entry_Form.Text = "SHIFT ENTRY FORM";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Orange;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(926, 13);
            this.pnlTop.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(885, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Shift_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvShift_Entry);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtp_Shift_To_Date);
            this.Controls.Add(this.dtp_Shift_From_Date);
            this.Controls.Add(this.cmbType_Of_Shift);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtLast_Name);
            this.Controls.Add(this.txtFirst_Name);
            this.Controls.Add(this.txtShift_Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFirst_Name);
            this.Controls.Add(this.lblShift_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShift_Entry_Form);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Shift_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift_Entry";
            this.Load += new System.EventHandler(this.Shift_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift_Entry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvShift_Entry;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtp_Shift_To_Date;
        private System.Windows.Forms.DateTimePicker dtp_Shift_From_Date;
        private System.Windows.Forms.ComboBox cmbType_Of_Shift;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtLast_Name;
        private System.Windows.Forms.TextBox txtFirst_Name;
        private System.Windows.Forms.TextBox txtShift_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFirst_Name;
        private System.Windows.Forms.Label lblShift_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShift_Entry_Form;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}