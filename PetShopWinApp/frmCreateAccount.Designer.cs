using System.Windows.Forms;

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
            btnSave = new Button();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            txtMemberId = new TextBox();
            label7 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.YellowGreen;
            btnSave.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(445, 361);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 43);
            btnSave.TabIndex = 54;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(445, 211);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 29);
            txtEmail.TabIndex = 51;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(445, 300);
            txtFullName.Margin = new Padding(2, 3, 2, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(270, 29);
            txtFullName.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(445, 183);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 49;
            label5.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(445, 120);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 29);
            txtPassword.TabIndex = 45;
            // 
            // txtMemberId
            // 
            txtMemberId.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemberId.Location = new Point(445, 40);
            txtMemberId.Margin = new Padding(2, 3, 2, 3);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(270, 29);
            txtMemberId.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(441, 92);
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
            label3.Location = new Point(441, 272);
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
            label1.Location = new Point(445, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 40;
            label1.Text = "Member Id";
            // 
            // panel1
            // 
            panel1.BackgroundImage = PetShopWinApp.Properties.Resources.e995287a2bedc655ac41b8a25fd1468a;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(32, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 388);
            panel1.TabIndex = 56;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(602, 361);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(113, 43);
            button1.TabIndex = 57;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmCreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 432);
            Controls.Add(button1);
            Controls.Add(panel1);
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
            Text = "Create Member Account";
            Load += frmCreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Label label5;
        private TextBox txtPassword;
        private TextBox txtMemberId;
        private Label label7;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Button button1;
    }
}