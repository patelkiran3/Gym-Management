namespace Gym_Management.UI
{
    partial class Payment_Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Entry));
            this.dgvPayment_Entry = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpPayment_Due_Date = new System.Windows.Forms.DateTimePicker();
            this.lblPayment_Due_Date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpPayment_Date = new System.Windows.Forms.DateTimePicker();
            this.txtPaid_Amount = new System.Windows.Forms.TextBox();
            this.cmbPayment_Type = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPayment_Id = new System.Windows.Forms.TextBox();
            this.lblPayment_Date = new System.Windows.Forms.Label();
            this.lblPayment_Amount = new System.Windows.Forms.Label();
            this.lblPayment_Type = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPayment_Id = new System.Windows.Forms.Label();
            this.lblPayment_Entry = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment_Entry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayment_Entry
            // 
            this.dgvPayment_Entry.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayment_Entry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment_Entry.Location = new System.Drawing.Point(35, 293);
            this.dgvPayment_Entry.Name = "dgvPayment_Entry";
            this.dgvPayment_Entry.Size = new System.Drawing.Size(613, 150);
            this.dgvPayment_Entry.TabIndex = 84;
            this.dgvPayment_Entry.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPayment_Entry_RowHeaderMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(35, 262);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(613, 25);
            this.txtSearch.TabIndex = 83;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Peru;
            this.lblSearch.Location = new System.Drawing.Point(32, 242);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 17);
            this.lblSearch.TabIndex = 82;
            this.lblSearch.Text = "SEARCH :";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Peru;
            this.btnReset.Location = new System.Drawing.Point(542, 218);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 33);
            this.btnReset.TabIndex = 81;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Peru;
            this.btnDelete.Location = new System.Drawing.Point(450, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 33);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Peru;
            this.btnUpdate.Location = new System.Drawing.Point(542, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 33);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Peru;
            this.btnInsert.Location = new System.Drawing.Point(450, 179);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 33);
            this.btnInsert.TabIndex = 78;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpPayment_Due_Date
            // 
            this.dtpPayment_Due_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPayment_Due_Date.Location = new System.Drawing.Point(254, 198);
            this.dtpPayment_Due_Date.Name = "dtpPayment_Due_Date";
            this.dtpPayment_Due_Date.Size = new System.Drawing.Size(172, 25);
            this.dtpPayment_Due_Date.TabIndex = 77;
            // 
            // lblPayment_Due_Date
            // 
            this.lblPayment_Due_Date.AutoSize = true;
            this.lblPayment_Due_Date.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment_Due_Date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment_Due_Date.ForeColor = System.Drawing.Color.Peru;
            this.lblPayment_Due_Date.Location = new System.Drawing.Point(251, 178);
            this.lblPayment_Due_Date.Name = "lblPayment_Due_Date";
            this.lblPayment_Due_Date.Size = new System.Drawing.Size(143, 17);
            this.lblPayment_Due_Date.TabIndex = 76;
            this.lblPayment_Due_Date.Text = "PAYMENT DUE DATE :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtpPayment_Date
            // 
            this.dtpPayment_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPayment_Date.Location = new System.Drawing.Point(35, 198);
            this.dtpPayment_Date.Name = "dtpPayment_Date";
            this.dtpPayment_Date.Size = new System.Drawing.Size(172, 25);
            this.dtpPayment_Date.TabIndex = 74;
            // 
            // txtPaid_Amount
            // 
            this.txtPaid_Amount.Location = new System.Drawing.Point(456, 145);
            this.txtPaid_Amount.Name = "txtPaid_Amount";
            this.txtPaid_Amount.Size = new System.Drawing.Size(172, 25);
            this.txtPaid_Amount.TabIndex = 73;
            // 
            // cmbPayment_Type
            // 
            this.cmbPayment_Type.FormattingEnabled = true;
            this.cmbPayment_Type.Items.AddRange(new object[] {
            "CASH",
            "CHEQUE",
            "ONLINE PAYMENT"});
            this.cmbPayment_Type.Location = new System.Drawing.Point(254, 145);
            this.cmbPayment_Type.Name = "cmbPayment_Type";
            this.cmbPayment_Type.Size = new System.Drawing.Size(172, 25);
            this.cmbPayment_Type.TabIndex = 72;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "STAFF\t",
            "USER"});
            this.cmbRole.Location = new System.Drawing.Point(35, 145);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(172, 25);
            this.cmbRole.TabIndex = 71;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(456, 93);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(172, 25);
            this.txtLastName.TabIndex = 70;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(254, 93);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(172, 25);
            this.txtFirstName.TabIndex = 69;
            // 
            // txtPayment_Id
            // 
            this.txtPayment_Id.Enabled = false;
            this.txtPayment_Id.Location = new System.Drawing.Point(35, 93);
            this.txtPayment_Id.Name = "txtPayment_Id";
            this.txtPayment_Id.ReadOnly = true;
            this.txtPayment_Id.Size = new System.Drawing.Size(172, 25);
            this.txtPayment_Id.TabIndex = 68;
            // 
            // lblPayment_Date
            // 
            this.lblPayment_Date.AutoSize = true;
            this.lblPayment_Date.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment_Date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment_Date.ForeColor = System.Drawing.Color.Peru;
            this.lblPayment_Date.Location = new System.Drawing.Point(32, 178);
            this.lblPayment_Date.Name = "lblPayment_Date";
            this.lblPayment_Date.Size = new System.Drawing.Size(113, 17);
            this.lblPayment_Date.TabIndex = 67;
            this.lblPayment_Date.Text = "PAYMENT DATE :";
            // 
            // lblPayment_Amount
            // 
            this.lblPayment_Amount.AutoSize = true;
            this.lblPayment_Amount.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment_Amount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment_Amount.ForeColor = System.Drawing.Color.Peru;
            this.lblPayment_Amount.Location = new System.Drawing.Point(453, 125);
            this.lblPayment_Amount.Name = "lblPayment_Amount";
            this.lblPayment_Amount.Size = new System.Drawing.Size(108, 17);
            this.lblPayment_Amount.TabIndex = 66;
            this.lblPayment_Amount.Text = "PAID AMOUNT :";
            // 
            // lblPayment_Type
            // 
            this.lblPayment_Type.AutoSize = true;
            this.lblPayment_Type.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment_Type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment_Type.ForeColor = System.Drawing.Color.Peru;
            this.lblPayment_Type.Location = new System.Drawing.Point(251, 125);
            this.lblPayment_Type.Name = "lblPayment_Type";
            this.lblPayment_Type.Size = new System.Drawing.Size(111, 17);
            this.lblPayment_Type.TabIndex = 65;
            this.lblPayment_Type.Text = "PAYMENT TYPE :";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Peru;
            this.lblRole.Location = new System.Drawing.Point(32, 125);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 17);
            this.lblRole.TabIndex = 64;
            this.lblRole.Text = "ROLE :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Peru;
            this.lblLastName.Location = new System.Drawing.Point(453, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(89, 17);
            this.lblLastName.TabIndex = 63;
            this.lblLastName.Text = "LAST NAME :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Peru;
            this.lblFirstName.Location = new System.Drawing.Point(251, 73);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 17);
            this.lblFirstName.TabIndex = 62;
            this.lblFirstName.Text = "FIRST NAME :";
            // 
            // lblPayment_Id
            // 
            this.lblPayment_Id.AutoSize = true;
            this.lblPayment_Id.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment_Id.ForeColor = System.Drawing.Color.Peru;
            this.lblPayment_Id.Location = new System.Drawing.Point(32, 73);
            this.lblPayment_Id.Name = "lblPayment_Id";
            this.lblPayment_Id.Size = new System.Drawing.Size(94, 17);
            this.lblPayment_Id.TabIndex = 61;
            this.lblPayment_Id.Text = "PAYEMNT ID :";
            // 
            // lblPayment_Entry
            // 
            this.lblPayment_Entry.AutoSize = true;
            this.lblPayment_Entry.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment_Entry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment_Entry.ForeColor = System.Drawing.Color.Peru;
            this.lblPayment_Entry.Location = new System.Drawing.Point(274, 16);
            this.lblPayment_Entry.Name = "lblPayment_Entry";
            this.lblPayment_Entry.Size = new System.Drawing.Size(140, 21);
            this.lblPayment_Entry.TabIndex = 60;
            this.lblPayment_Entry.Text = "PAYEMNT ENTRY";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Peru;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(692, 10);
            this.pnlTop.TabIndex = 59;
            // 
            // Payment_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 480);
            this.Controls.Add(this.dgvPayment_Entry);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtpPayment_Due_Date);
            this.Controls.Add(this.lblPayment_Due_Date);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpPayment_Date);
            this.Controls.Add(this.txtPaid_Amount);
            this.Controls.Add(this.cmbPayment_Type);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPayment_Id);
            this.Controls.Add(this.lblPayment_Date);
            this.Controls.Add(this.lblPayment_Amount);
            this.Controls.Add(this.lblPayment_Type);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPayment_Id);
            this.Controls.Add(this.lblPayment_Entry);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Payment_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment_Entry";
            this.Load += new System.EventHandler(this.Payment_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment_Entry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayment_Entry;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtpPayment_Due_Date;
        private System.Windows.Forms.Label lblPayment_Due_Date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpPayment_Date;
        private System.Windows.Forms.TextBox txtPaid_Amount;
        private System.Windows.Forms.ComboBox cmbPayment_Type;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPayment_Id;
        private System.Windows.Forms.Label lblPayment_Date;
        private System.Windows.Forms.Label lblPayment_Amount;
        private System.Windows.Forms.Label lblPayment_Type;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPayment_Id;
        private System.Windows.Forms.Label lblPayment_Entry;
        private System.Windows.Forms.Panel pnlTop;
    }
}