namespace PetStore_StudentName
{
	partial class frmOderOfStaff
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
			dgvPet = new DataGridView();
			groupBox1 = new GroupBox();
			txtQuantityOder = new TextBox();
			label1 = new Label();
			btnExit = new Button();
			btnDelete = new Button();
			btnSearch = new Button();
			txtSearch = new TextBox();
			label8 = new Label();
			cboPetGroup = new ComboBox();
			label2 = new Label();
			txtQuantity = new TextBox();
			txtDescription = new TextBox();
			label5 = new Label();
			label4 = new Label();
			txtPrice = new TextBox();
			dtImportDate = new DateTimePicker();
			txtPetName = new TextBox();
			label7 = new Label();
			label6 = new Label();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvPet).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// dgvPet
			// 
			dgvPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPet.Location = new Point(81, 224);
			dgvPet.Margin = new Padding(2, 3, 2, 3);
			dgvPet.Name = "dgvPet";
			dgvPet.ReadOnly = true;
			dgvPet.RowHeadersWidth = 72;
			dgvPet.RowTemplate.Height = 39;
			dgvPet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvPet.Size = new Size(942, 322);
			dgvPet.TabIndex = 35;
			dgvPet.CellContentClick += dgvPet_CellContentClick;
			dgvPet.CellDoubleClick += dgvPet_CellDoubleClick;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtQuantityOder);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(btnExit);
			groupBox1.Controls.Add(btnDelete);
			groupBox1.Location = new Point(81, 587);
			groupBox1.Margin = new Padding(2, 3, 2, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(2, 3, 2, 3);
			groupBox1.Size = new Size(942, 103);
			groupBox1.TabIndex = 36;
			groupBox1.TabStop = false;
			// 
			// txtQuantityOder
			// 
			txtQuantityOder.Location = new Point(119, 31);
			txtQuantityOder.Margin = new Padding(2, 3, 2, 3);
			txtQuantityOder.Name = "txtQuantityOder";
			txtQuantityOder.Size = new Size(233, 27);
			txtQuantityOder.TabIndex = 55;
			txtQuantityOder.TextChanged += txtQuantityOder_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(5, 36);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(102, 20);
			label1.TabIndex = 54;
			label1.Text = "Quantity Oder";
			label1.Click += label1_Click;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(689, 27);
			btnExit.Margin = new Padding(2, 3, 2, 3);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(87, 39);
			btnExit.TabIndex = 3;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(383, 23);
			btnDelete.Margin = new Padding(2, 3, 2, 3);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(87, 39);
			btnDelete.TabIndex = 2;
			btnDelete.Text = "Order";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(803, 126);
			btnSearch.Margin = new Padding(2, 3, 2, 3);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(66, 31);
			btnSearch.TabIndex = 41;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(730, 27);
			txtSearch.Margin = new Padding(2, 3, 2, 3);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(203, 27);
			txtSearch.TabIndex = 40;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(574, 31);
			label8.Margin = new Padding(2, 0, 2, 0);
			label8.Name = "label8";
			label8.Size = new Size(87, 20);
			label8.TabIndex = 39;
			label8.Text = "Input Name";
			// 
			// cboPetGroup
			// 
			cboPetGroup.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPetGroup.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			cboPetGroup.FormattingEnabled = true;
			cboPetGroup.Location = new Point(730, 72);
			cboPetGroup.Margin = new Padding(2, 3, 2, 3);
			cboPetGroup.Name = "cboPetGroup";
			cboPetGroup.Size = new Size(203, 29);
			cboPetGroup.TabIndex = 43;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(574, 76);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(74, 20);
			label2.TabIndex = 42;
			label2.Text = "Pet Group";
			// 
			// txtQuantity
			// 
			txtQuantity.Location = new Point(199, 158);
			txtQuantity.Margin = new Padding(2, 3, 2, 3);
			txtQuantity.Name = "txtQuantity";
			txtQuantity.Size = new Size(233, 27);
			txtQuantity.TabIndex = 47;
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(198, 123);
			txtDescription.Margin = new Padding(2, 3, 2, 3);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(233, 27);
			txtDescription.TabIndex = 46;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(52, 126);
			label5.Margin = new Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new Size(85, 20);
			label5.TabIndex = 45;
			label5.Text = "Description";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(52, 161);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(65, 20);
			label4.TabIndex = 44;
			label4.Text = "Quantity";
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(198, 90);
			txtPrice.Margin = new Padding(2, 3, 2, 3);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(233, 27);
			txtPrice.TabIndex = 53;
			// 
			// dtImportDate
			// 
			dtImportDate.Location = new Point(198, 24);
			dtImportDate.Margin = new Padding(2, 3, 2, 3);
			dtImportDate.Name = "dtImportDate";
			dtImportDate.Size = new Size(235, 27);
			dtImportDate.TabIndex = 52;
			// 
			// txtPetName
			// 
			txtPetName.Location = new Point(198, 57);
			txtPetName.Margin = new Padding(2, 3, 2, 3);
			txtPetName.Name = "txtPetName";
			txtPetName.Size = new Size(233, 27);
			txtPetName.TabIndex = 51;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(52, 60);
			label7.Margin = new Padding(2, 0, 2, 0);
			label7.Name = "label7";
			label7.Size = new Size(73, 20);
			label7.TabIndex = 50;
			label7.Text = "Pet Name";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(52, 24);
			label6.Margin = new Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new Size(90, 20);
			label6.TabIndex = 49;
			label6.Text = "Import Date";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(52, 95);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(41, 20);
			label3.TabIndex = 48;
			label3.Text = "Price";
			// 
			// frmOderOfStaff
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1095, 704);
			Controls.Add(txtPrice);
			Controls.Add(dtImportDate);
			Controls.Add(txtPetName);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label3);
			Controls.Add(txtQuantity);
			Controls.Add(txtDescription);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(cboPetGroup);
			Controls.Add(label2);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(label8);
			Controls.Add(groupBox1);
			Controls.Add(dgvPet);
			Name = "frmOderOfStaff";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmOderOfStaff";
			Load += frmOderOfStaff_Load;
			((System.ComponentModel.ISupportInitialize)dgvPet).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvPet;
		private GroupBox groupBox1;
		private Button btnExit;
		private Button btnDelete;
		private Button btnSearch;
		private TextBox txtSearch;
		private Label label8;
		private ComboBox cboPetGroup;
		private Label label2;
		private TextBox txtQuantity;
		private TextBox txtDescription;
		private Label label5;
		private Label label4;
		private TextBox txtPrice;
		private DateTimePicker dtImportDate;
		private TextBox txtPetName;
		private Label label7;
		private Label label6;
		private Label label3;
		private TextBox txtQuantityOder;
		private Label label1;
	}
}