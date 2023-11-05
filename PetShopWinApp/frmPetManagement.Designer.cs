namespace PetStore_StudentName
{
    partial class frmPetManagement
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
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            btnExit = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dgvPet = new DataGridView();
            cboPetGroup = new ComboBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            dtImportDate = new DateTimePicker();
            txtPetName = new TextBox();
            txtDescription = new TextBox();
            txtPetId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnCreateAccout = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPet).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(80, 442);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(728, 77);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(398, 31);
            btnLoad.Margin = new Padding(2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(76, 29);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(563, 31);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(240, 31);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(76, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(90, 31);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(76, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvPet
            // 
            dgvPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPet.Location = new Point(80, 221);
            dgvPet.Margin = new Padding(2);
            dgvPet.Name = "dgvPet";
            dgvPet.ReadOnly = true;
            dgvPet.RowHeadersWidth = 72;
            dgvPet.RowTemplate.Height = 39;
            dgvPet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPet.Size = new Size(728, 218);
            dgvPet.TabIndex = 34;
            dgvPet.CellContentClick += dgvPet_CellContentClick;
            dgvPet.CellDoubleClick += dgvPet_CellDoubleClick;
            // 
            // cboPetGroup
            // 
            cboPetGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPetGroup.FormattingEnabled = true;
            cboPetGroup.Location = new Point(589, 139);
            cboPetGroup.Margin = new Padding(2);
            cboPetGroup.Name = "cboPetGroup";
            cboPetGroup.Size = new Size(204, 23);
            cboPetGroup.TabIndex = 33;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(589, 97);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(204, 23);
            txtQuantity.TabIndex = 32;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(192, 184);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(204, 23);
            txtPrice.TabIndex = 31;
            // 
            // dtImportDate
            // 
            dtImportDate.Location = new Point(192, 142);
            dtImportDate.Margin = new Padding(2);
            dtImportDate.Name = "dtImportDate";
            dtImportDate.Size = new Size(206, 23);
            dtImportDate.TabIndex = 30;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(190, 97);
            txtPetName.Margin = new Padding(2);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(204, 23);
            txtPetName.TabIndex = 29;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(589, 55);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(204, 23);
            txtDescription.TabIndex = 28;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(190, 59);
            txtPetId.Margin = new Padding(2);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(204, 23);
            txtPetId.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 100);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 26;
            label7.Text = "Pet Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 25;
            label6.Text = "Import Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(478, 58);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 24;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 98);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 23;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 188);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 22;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 140);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 21;
            label2.Text = "Pet Group";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 20;
            label1.Text = "Pet Id";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnCreateAccout
            // 
            btnCreateAccout.Location = new Point(295, 20);
            btnCreateAccout.Margin = new Padding(3, 2, 3, 2);
            btnCreateAccout.Name = "btnCreateAccout";
            btnCreateAccout.Size = new Size(294, 22);
            btnCreateAccout.TabIndex = 39;
            btnCreateAccout.Text = "CreateAccount";
            btnCreateAccout.UseVisualStyleBackColor = true;
            btnCreateAccout.Click += btnCreateAccout_Click;
            // 
            // frmPetManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 528);
            Controls.Add(btnCreateAccout);
            Controls.Add(groupBox1);
            Controls.Add(dgvPet);
            Controls.Add(cboPetGroup);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(dtImportDate);
            Controls.Add(txtPetName);
            Controls.Add(txtDescription);
            Controls.Add(txtPetId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPetManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetStore Management ";
            Load += frmPetManagement_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnExit;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dgvPet;
        private ComboBox cboPetGroup;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private DateTimePicker dtImportDate;
        private TextBox txtPetName;
        private TextBox txtDescription;
        private TextBox txtPetId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnCreateAccout;
        private Button btnLoad;
    }
}