namespace Gym_Management
{
    partial class Attendence_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence_Form));
            this.cmbAttendence = new System.Windows.Forms.ComboBox();
            this.dtpAttendence_Date = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAttendence_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAttendence_Date = new System.Windows.Forms.Label();
            this.lblAttend = new System.Windows.Forms.Label();
            this.lblLast_Name = new System.Windows.Forms.Label();
            this.lblFirst_Name = new System.Windows.Forms.Label();
            this.lblAttendence_Id = new System.Windows.Forms.Label();
            this.lblAttendence = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAttendence_Form = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence_Form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAttendence
            // 
            this.cmbAttendence.FormattingEnabled = true;
            this.cmbAttendence.Items.AddRange(new object[] {
            "PRESENT",
            "ABSENT"});
            this.cmbAttendence.Location = new System.Drawing.Point(174, 232);
            this.cmbAttendence.Name = "cmbAttendence";
            this.cmbAttendence.Size = new System.Drawing.Size(150, 25);
            this.cmbAttendence.TabIndex = 32;
            this.cmbAttendence.SelectedIndexChanged += new System.EventHandler(this.cmbAttendence_SelectedIndexChanged);
            // 
            // dtpAttendence_Date
            // 
            this.dtpAttendence_Date.Location = new System.Drawing.Point(174, 263);
            this.dtpAttendence_Date.Name = "dtpAttendence_Date";
            this.dtpAttendence_Date.Size = new System.Drawing.Size(150, 25);
            this.dtpAttendence_Date.TabIndex = 31;
            this.dtpAttendence_Date.ValueChanged += new System.EventHandler(this.dtpAttendence_Date_ValueChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(174, 201);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 25);
            this.txtLastName.TabIndex = 28;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(174, 170);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 25);
            this.txtFirstName.TabIndex = 26;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtAttendence_Id
            // 
            this.txtAttendence_Id.Enabled = false;
            this.txtAttendence_Id.Location = new System.Drawing.Point(174, 139);
            this.txtAttendence_Id.Name = "txtAttendence_Id";
            this.txtAttendence_Id.ReadOnly = true;
            this.txtAttendence_Id.Size = new System.Drawing.Size(150, 25);
            this.txtAttendence_Id.TabIndex = 25;
            this.txtAttendence_Id.TextChanged += new System.EventHandler(this.txtAttendence_Id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(120, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "ROLE :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAttendence_Date
            // 
            this.lblAttendence_Date.AutoSize = true;
            this.lblAttendence_Date.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendence_Date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendence_Date.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAttendence_Date.Location = new System.Drawing.Point(32, 265);
            this.lblAttendence_Date.Name = "lblAttendence_Date";
            this.lblAttendence_Date.Size = new System.Drawing.Size(136, 17);
            this.lblAttendence_Date.TabIndex = 23;
            this.lblAttendence_Date.Text = "ATTENDENCE DATE :";
            this.lblAttendence_Date.Click += new System.EventHandler(this.lblAttendence_Date_Click);
            // 
            // lblAttend
            // 
            this.lblAttend.AutoSize = true;
            this.lblAttend.BackColor = System.Drawing.Color.Transparent;
            this.lblAttend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttend.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAttend.Location = new System.Drawing.Point(69, 235);
            this.lblAttend.Name = "lblAttend";
            this.lblAttend.Size = new System.Drawing.Size(99, 17);
            this.lblAttend.TabIndex = 22;
            this.lblAttend.Text = "ATTENDENCE :";
            this.lblAttend.Click += new System.EventHandler(this.lblAttend_Click);
            // 
            // lblLast_Name
            // 
            this.lblLast_Name.AutoSize = true;
            this.lblLast_Name.BackColor = System.Drawing.Color.Transparent;
            this.lblLast_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast_Name.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLast_Name.Location = new System.Drawing.Point(79, 204);
            this.lblLast_Name.Name = "lblLast_Name";
            this.lblLast_Name.Size = new System.Drawing.Size(89, 17);
            this.lblLast_Name.TabIndex = 21;
            this.lblLast_Name.Text = "LAST NAME :";
            this.lblLast_Name.Click += new System.EventHandler(this.lblLast_Name_Click);
            // 
            // lblFirst_Name
            // 
            this.lblFirst_Name.AutoSize = true;
            this.lblFirst_Name.BackColor = System.Drawing.Color.Transparent;
            this.lblFirst_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst_Name.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFirst_Name.Location = new System.Drawing.Point(76, 173);
            this.lblFirst_Name.Name = "lblFirst_Name";
            this.lblFirst_Name.Size = new System.Drawing.Size(92, 17);
            this.lblFirst_Name.TabIndex = 19;
            this.lblFirst_Name.Text = "FIRST NAME :";
            this.lblFirst_Name.Click += new System.EventHandler(this.lblFirst_Name_Click);
            // 
            // lblAttendence_Id
            // 
            this.lblAttendence_Id.AutoSize = true;
            this.lblAttendence_Id.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendence_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendence_Id.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAttendence_Id.Location = new System.Drawing.Point(51, 142);
            this.lblAttendence_Id.Name = "lblAttendence_Id";
            this.lblAttendence_Id.Size = new System.Drawing.Size(117, 17);
            this.lblAttendence_Id.TabIndex = 18;
            this.lblAttendence_Id.Text = "ATTENDENCE ID :";
            this.lblAttendence_Id.Click += new System.EventHandler(this.lblAttendence_Id_Click);
            // 
            // lblAttendence
            // 
            this.lblAttendence.AutoSize = true;
            this.lblAttendence.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendence.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAttendence.Location = new System.Drawing.Point(440, 29);
            this.lblAttendence.Name = "lblAttendence";
            this.lblAttendence.Size = new System.Drawing.Size(162, 21);
            this.lblAttendence.TabIndex = 17;
            this.lblAttendence.Text = "ATTENDENCE FORM";
            this.lblAttendence.Click += new System.EventHandler(this.lblAttendence_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 11);
            this.panel1.TabIndex = 33;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInsert.Location = new System.Drawing.Point(301, 373);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 34);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReset.Location = new System.Drawing.Point(688, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 34);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSearch.Location = new System.Drawing.Point(344, 89);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 17);
            this.lblSearch.TabIndex = 35;
            this.lblSearch.Text = "SEARCH :";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(415, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(571, 25);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvAttendence_Form
            // 
            this.dgvAttendence_Form.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendence_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAttendence_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendence_Form.Location = new System.Drawing.Point(347, 120);
            this.dgvAttendence_Form.Name = "dgvAttendence_Form";
            this.dgvAttendence_Form.Size = new System.Drawing.Size(639, 220);
            this.dgvAttendence_Form.TabIndex = 37;
            this.dgvAttendence_Form.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendence_Form_CellContentClick);
            this.dgvAttendence_Form.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttendence_Form_RowHeaderMouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Location = new System.Drawing.Point(425, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 34);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.Location = new System.Drawing.Point(555, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 34);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(990, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "STAFF",
            "USER"});
            this.cmbRole.Location = new System.Drawing.Point(174, 294);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(150, 25);
            this.cmbRole.TabIndex = 41;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // Attendence_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 442);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvAttendence_Form);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbAttendence);
            this.Controls.Add(this.dtpAttendence_Date);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAttendence_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAttendence_Date);
            this.Controls.Add(this.lblAttend);
            this.Controls.Add(this.lblLast_Name);
            this.Controls.Add(this.lblFirst_Name);
            this.Controls.Add(this.lblAttendence_Id);
            this.Controls.Add(this.lblAttendence);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Attendence_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendence_Form";
            this.Load += new System.EventHandler(this.Attendence_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence_Form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAttendence;
        private System.Windows.Forms.DateTimePicker dtpAttendence_Date;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAttendence_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAttendence_Date;
        private System.Windows.Forms.Label lblAttend;
        private System.Windows.Forms.Label lblLast_Name;
        private System.Windows.Forms.Label lblFirst_Name;
        private System.Windows.Forms.Label lblAttendence_Id;
        private System.Windows.Forms.Label lblAttendence;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAttendence_Form;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}