
using BusinessObject.Models;
using PetStore_StudentName_Repository.Reprository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore_StudentName
{
	public partial class frmCreateAccount : Form
	{
		private IShopMemberRepository _shopMemberRepository;
		public frmCreateAccount()
		{
			_shopMemberRepository = new ShopMemberRepository();
			InitializeComponent();
		}

		private void frmCreateAccount_Load(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!_validation())
			{
				MessageBox.Show("The input is invalid!");
				txtMemberId.Focus();
				return;
			}
			PetShopMember petShopMemberCheck = _shopMemberRepository.GetPetShopMemberById(txtMemberId.Text);
			if (petShopMemberCheck != null)
			{
				MessageBox.Show("Id already exist!");
				txtMemberId.Focus();
				return;
			}
			else
			{
				PetShopMember petShopMember = new PetShopMember()
				{
					MemberId = txtMemberId.Text,
					MemberPassword = txtPassword.Text,
					FullName = txtFullName.Text,
					EmailAddress = txtEmail.Text,
					MemberRole = 2,
				};

				try
				{
					if (petShopMember != null)
					{
						_shopMemberRepository.AddPetShopMember(petShopMember);
						MessageBox.Show("Create Account success!");
					}
					this.Close();
					frmPetManagement frm = new frmPetManagement();
					frm.Show();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}


		}
		private bool _validation()
		{
			//All fields are required.
			if (txtEmail.Text == string.Empty
				|| txtFullName.Text == string.Empty
				|| txtMemberId.Text == string.Empty
				|| txtPassword.Text == string.Empty
				)
				return false;
			//-	Value for PetPrice and Quantity is greater than or equal to 0.


			//Value for PetName(the name of the pet) is in the range of 5 – 20 characters
			//if (!((txtFullName.TextLength >= 5) && (txtFullName.TextLength <= 20)))
			//	return false;

			//if (!((txtPassword.TextLength >= 5) && (txtPassword.TextLength <= 20)))
			//	return false;
			// Each word of the PetName must begin with the capital letter. 
			//string[] words = txtFullName.Text.Split(" ");
			//foreach (string word in words)
			//{
			//	if (!Char.IsUpper(word[0]))
			//	{
			//		return false;
			//	}
			//}
			////Each word of the PetName must begin with the capital letter. PetName is not alowed with special characters.
			//if (hasSpecialChar(txtFullName.Text))
			//	return false;

			return true;
		}
		//public static bool hasSpecialChar(string input)
		//{
		//	string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
		//	foreach (var item in specialChar)
		//	{
		//		if (input.Contains(item)) return true;
		//	}

		//	return false;
		//}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
			frmPetManagement frm = new frmPetManagement();
			frm.Show();
		}
	}
}
