namespace Gym_Management
{
    partial class Package_Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package_Entry));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPackage_Name = new System.Windows.Forms.Label();
            this.lblPackage_Amount = new System.Windows.Forms.Label();
            this.lblPackage_Duration = new System.Windows.Forms.Label();
            this.lblPackage_Description = new System.Windows.Forms.Label();
            this.lblPackage_Id = new System.Windows.Forms.Label();
            this.txtPackage_Id = new System.Windows.Forms.TextBox();
            this.txtPackage_Name = new System.Windows.Forms.TextBox();
            this.txtPackage_Amount = new System.Windows.Forms.TextBox();
            this.txtPackage_Duration = new System.Windows.Forms.TextBox();
            this.txtPackage_Description = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvPackage_Entry = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage_Entry)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(770, 10);
            this.pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(305, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PACKAGE ENTRY ";
            // 
            // lblPackage_Name
            // 
            this.lblPackage_Name.AutoSize = true;
            this.lblPackage_Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPackage_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage_Name.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblPackage_Name.Location = new System.Drawing.Point(432, 61);
            this.lblPackage_Name.Name = "lblPackage_Name";
            this.lblPackage_Name.Size = new System.Drawing.Size(115, 17);
            this.lblPackage_Name.TabIndex = 1;
            this.lblPackage_Name.Text = "PACKAGE NAME :";
            // 
            // lblPackage_Amount
            // 
            this.lblPackage_Amount.AutoSize = true;
            this.lblPackage_Amount.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage_Amount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPackage_Amount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage_Amount.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblPackage_Amount.Location = new System.Drawing.Point(49, 95);
            this.lblPackage_Amount.Name = "lblPackage_Amount";
            this.lblPackage_Amount.Size = new System.Drawing.Size(135, 17);
            this.lblPackage_Amount.TabIndex = 2;
            this.lblPackage_Amount.Text = "PACKAGE AMOUNT :";
            // 
            // lblPackage_Duration
            // 
            this.lblPackage_Duration.AutoSize = true;
            this.lblPackage_Duration.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage_Duration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPackage_Duration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage_Duration.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblPackage_Duration.Location = new System.Drawing.Point(381, 95);
            this.lblPackage_Duration.Name = "lblPackage_Duration";
            this.lblPackage_Duration.Size = new System.Drawing.Size(165, 17);
            this.lblPackage_Duration.TabIndex = 3;
            this.lblPackage_Duration.Text = "DURATION OF MONTHS :";
            // 
            // lblPackage_Description
            // 
            this.lblPackage_Description.AutoSize = true;
            this.lblPackage_Description.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage_Description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPackage_Description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage_Description.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblPackage_Description.Location = new System.Drawing.Point(26, 126);
            this.lblPackage_Description.Name = "lblPackage_Description";
            this.lblPackage_Description.Size = new System.Drawing.Size(161, 17);
            this.lblPackage_Description.TabIndex = 4;
            this.lblPackage_Description.Text = "PACKAGE DESCRIPTION :";
            // 
            // lblPackage_Id
            // 
            this.lblPackage_Id.AutoSize = true;
            this.lblPackage_Id.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPackage_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage_Id.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblPackage_Id.Location = new System.Drawing.Point(93, 64);
            this.lblPackage_Id.Name = "lblPackage_Id";
            this.lblPackage_Id.Size = new System.Drawing.Size(91, 17);
            this.lblPackage_Id.TabIndex = 5;
            this.lblPackage_Id.Text = "PACKAGE ID :";
            // 
            // txtPackage_Id
            // 
            this.txtPackage_Id.Enabled = false;
            this.txtPackage_Id.Location = new System.Drawing.Point(184, 61);
            this.txtPackage_Id.Name = "txtPackage_Id";
            this.txtPackage_Id.ReadOnly = true;
            this.txtPackage_Id.Size = new System.Drawing.Size(174, 25);
            this.txtPackage_Id.TabIndex = 6;
            // 
            // txtPackage_Name
            // 
            this.txtPackage_Name.Location = new System.Drawing.Point(546, 58);
            this.txtPackage_Name.Name = "txtPackage_Name";
            this.txtPackage_Name.Size = new System.Drawing.Size(174, 25);
            this.txtPackage_Name.TabIndex = 7;
            // 
            // txtPackage_Amount
            // 
            this.txtPackage_Amount.Location = new System.Drawing.Point(184, 92);
            this.txtPackage_Amount.Name = "txtPackage_Amount";
            this.txtPackage_Amount.Size = new System.Drawing.Size(174, 25);
            this.txtPackage_Amount.TabIndex = 8;
            // 
            // txtPackage_Duration
            // 
            this.txtPackage_Duration.Location = new System.Drawing.Point(546, 92);
            this.txtPackage_Duration.Name = "txtPackage_Duration";
            this.txtPackage_Duration.Size = new System.Drawing.Size(174, 25);
            this.txtPackage_Duration.TabIndex = 9;
            // 
            // txtPackage_Description
            // 
            this.txtPackage_Description.Location = new System.Drawing.Point(184, 123);
            this.txtPackage_Description.Multiline = true;
            this.txtPackage_Description.Name = "txtPackage_Description";
            this.txtPackage_Description.Size = new System.Drawing.Size(174, 61);
            this.txtPackage_Description.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(732, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnInsert.Location = new System.Drawing.Point(602, 209);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 36);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnUpdate.Location = new System.Drawing.Point(602, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 36);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnDelete.Location = new System.Drawing.Point(602, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 36);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnReset.Location = new System.Drawing.Point(602, 335);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 36);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvPackage_Entry
            // 
            this.dgvPackage_Entry.BackgroundColor = System.Drawing.Color.White;
            this.dgvPackage_Entry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPackage_Entry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackage_Entry.Location = new System.Drawing.Point(41, 201);
            this.dgvPackage_Entry.Name = "dgvPackage_Entry";
            this.dgvPackage_Entry.Size = new System.Drawing.Size(542, 172);
            this.dgvPackage_Entry.TabIndex = 23;
            this.dgvPackage_Entry.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPackage_Entry_RowHeaderMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(472, 125);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(248, 61);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblSearch.Location = new System.Drawing.Point(404, 128);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 17);
            this.lblSearch.TabIndex = 21;
            this.lblSearch.Text = "SEARCH :";
            // 
            // Package_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 399);
            this.Controls.Add(this.dgvPackage_Entry);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPackage_Description);
            this.Controls.Add(this.txtPackage_Duration);
            this.Controls.Add(this.txtPackage_Amount);
            this.Controls.Add(this.txtPackage_Name);
            this.Controls.Add(this.txtPackage_Id);
            this.Controls.Add(this.lblPackage_Id);
            this.Controls.Add(this.lblPackage_Description);
            this.Controls.Add(this.lblPackage_Duration);
            this.Controls.Add(this.lblPackage_Amount);
            this.Controls.Add(this.lblPackage_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Package_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package_Entry";
            this.Load += new System.EventHandler(this.Package_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage_Entry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPackage_Name;
        private System.Windows.Forms.Label lblPackage_Amount;
        private System.Windows.Forms.Label lblPackage_Duration;
        private System.Windows.Forms.Label lblPackage_Description;
        private System.Windows.Forms.Label lblPackage_Id;
        private System.Windows.Forms.TextBox txtPackage_Id;
        private System.Windows.Forms.TextBox txtPackage_Name;
        private System.Windows.Forms.TextBox txtPackage_Amount;
        private System.Windows.Forms.TextBox txtPackage_Duration;
        private System.Windows.Forms.TextBox txtPackage_Description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvPackage_Entry;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}