namespace PetStore_StudentName
{
	partial class frmCreateAccount
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
			txtEmail = new TextBox();
			txtFullName = new TextBox();
			label5 = new Label();
			txtPassword = new TextBox();
			txtMemberId = new TextBox();
			label7 = new Label();
			label3 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnExit
			// 
			btnExit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			btnExit.Location = new Point(474, 310);
			btnExit.Margin = new Padding(2);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(113, 43);
			btnExit.TabIndex = 55;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// btnSave
			// 
			btnSave.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			btnSave.Location = new Point(240, 310);
			btnSave.Margin = new Padding(2);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(113, 43);
			btnSave.TabIndex = 54;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// txtEmail
			// 
			txtEmail.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			txtEmail.Location = new Point(321, 149);
			txtEmail.Margin = new Padding(2);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(267, 29);
			txtEmail.TabIndex = 51;
			// 
			// txtFullName
			// 
			txtFullName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			txtFullName.Location = new Point(321, 218);
			txtFullName.Margin = new Padding(2);
			txtFullName.Name = "txtFullName";
			txtFullName.Size = new Size(270, 29);
			txtFullName.TabIndex = 50;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(201, 152);
			label5.Margin = new Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new Size(51, 23);
			label5.TabIndex = 49;
			label5.Text = "Email";
			// 
			// txtPassword
			// 
			txtPassword.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.Location = new Point(321, 93);
			txtPassword.Margin = new Padding(2);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(270, 29);
			txtPassword.TabIndex = 45;
			// 
			// txtMemberId
			// 
			txtMemberId.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			txtMemberId.Location = new Point(321, 37);
			txtMemberId.Margin = new Padding(2);
			txtMemberId.Name = "txtMemberId";
			txtMemberId.Size = new Size(270, 29);
			txtMemberId.TabIndex = 44;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(200, 96);
			label7.Margin = new Padding(2, 0, 2, 0);
			label7.Name = "label7";
			label7.Size = new Size(80, 23);
			label7.TabIndex = 43;
			label7.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(200, 218);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(87, 23);
			label3.TabIndex = 41;
			label3.Text = "Full Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(201, 40);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(94, 23);
			label1.TabIndex = 40;
			label1.Text = "Member Id";
			// 
			// frmCreateAccount
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(754, 378);
			Controls.Add(btnExit);
			Controls.Add(btnSave);
			Controls.Add(txtEmail);
			Controls.Add(txtFullName);
			Controls.Add(label5);
			Controls.Add(txtPassword);
			Controls.Add(txtMemberId);
			Controls.Add(label7);
			Controls.Add(label3);
			Controls.Add(label1);
			Name = "frmCreateAccount";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmCreateAccount";
			Load += frmCreateAccount_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnExit;
		private Button btnSave;
		private TextBox txtEmail;
		private TextBox txtFullName;
		private Label label5;
		private TextBox txtPassword;
		private TextBox txtMemberId;
		private Label label7;
		private Label label3;
		private Label label1;
	}
}