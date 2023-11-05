namespace PetStore_StudentName
{
    partial class frmPetDetail
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
            btnExit = new Button();
            btnSave = new Button();
            cboPetGroup = new ComboBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            dtImportDate = new DateTimePicker();
            txtPetName = new TextBox();
            txtPetId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(282, 501);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 43);
            btnExit.TabIndex = 39;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(71, 501);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 43);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cboPetGroup
            // 
            cboPetGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPetGroup.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            cboPetGroup.FormattingEnabled = true;
            cboPetGroup.Location = new Point(166, 379);
            cboPetGroup.Margin = new Padding(2);
            cboPetGroup.Name = "cboPetGroup";
            cboPetGroup.Size = new Size(267, 29);
            cboPetGroup.TabIndex = 37;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(166, 323);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(267, 29);
            txtQuantity.TabIndex = 36;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(166, 267);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(267, 29);
            txtDescription.TabIndex = 35;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(167, 213);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(270, 29);
            txtPrice.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 270);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 33;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 323);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 32;
            label4.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 379);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 31;
            label2.Text = "Pet Group";
            // 
            // dtImportDate
            // 
            dtImportDate.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            dtImportDate.Location = new Point(166, 154);
            dtImportDate.Margin = new Padding(2);
            dtImportDate.Name = "dtImportDate";
            dtImportDate.Size = new Size(271, 29);
            dtImportDate.TabIndex = 30;
            // 
            // txtPetName
            // 
            txtPetName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtPetName.Location = new Point(162, 93);
            txtPetName.Margin = new Padding(2);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(270, 29);
            txtPetName.TabIndex = 29;
            // 
            // txtPetId
            // 
            txtPetId.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtPetId.Location = new Point(162, 43);
            txtPetId.Margin = new Padding(2);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(270, 29);
            txtPetId.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(46, 96);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 27;
            label7.Text = "Pet Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 152);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 23);
            label6.TabIndex = 26;
            label6.Text = "Import Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 213);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 25;
            label3.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 24;
            label1.Text = "Pet Id";
            // 
            // frmPetDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 604);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(cboPetGroup);
            Controls.Add(txtQuantity);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dtImportDate);
            Controls.Add(txtPetName);
            Controls.Add(txtPetId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmPetDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPetDetail";
            Load += frmPetDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnSave;
        private ComboBox cboPetGroup;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Label label5;
        private Label label4;
        private Label label2;
        private DateTimePicker dtImportDate;
        private TextBox txtPetName;
        private TextBox txtPetId;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label1;
    }
}