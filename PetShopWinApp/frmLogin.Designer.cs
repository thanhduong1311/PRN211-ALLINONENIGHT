namespace PetStore_StudentName
{
	partial class frmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnCancel = new Button();
			btnLogin = new Button();
			txtPass = new TextBox();
			txtEmail = new TextBox();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(349, 230);
			btnCancel.Margin = new Padding(2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(87, 36);
			btnCancel.TabIndex = 11;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(165, 230);
			btnLogin.Margin = new Padding(2);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(87, 36);
			btnLogin.TabIndex = 10;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click_1;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(275, 135);
			txtPass.Margin = new Padding(2);
			txtPass.Name = "txtPass";
			txtPass.PasswordChar = '*';
			txtPass.Size = new Size(195, 27);
			txtPass.TabIndex = 9;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(275, 83);
			txtEmail.Margin = new Padding(2);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(195, 27);
			txtEmail.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(115, 135);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 7;
			label2.Text = "Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(115, 83);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(46, 20);
			label1.TabIndex = 6;
			label1.Text = "Email";
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(642, 345);
			Controls.Add(btnCancel);
			Controls.Add(btnLogin);
			Controls.Add(txtPass);
			Controls.Add(txtEmail);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			Load += frmLogin_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCancel;
		private Button btnLogin;
		private TextBox txtPass;
		private TextBox txtEmail;
		private Label label2;
		private Label label1;
	}
}