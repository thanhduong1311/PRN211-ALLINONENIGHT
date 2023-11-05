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
    public partial class frmPetDetail : Form
    {
        public IPetRepository PetRepository { get; set; }
        public Pet PetInfo { get; set; }
        public bool UpdateOrInsert { get; set; } //false
        public frmPetDetail()
        {
            InitializeComponent();
        }

        private void frmPetDetail_Load(object sender, EventArgs e)
        {
            //1. Load petgroup len combobox
            //lay ra list petgroup
            var petGroups = PetRepository
                            .GetAllPetGroups();

            var items = petGroups.Select(p => p.PetGroupName).ToArray();
            //add vao combobox
            this.cboPetGroup.Items.Clear();
            this.cboPetGroup.Items.AddRange(items);
            if (this.cboPetGroup.Items.Count > 0)
            {
                this.cboPetGroup.SelectedIndex = 0;
            }
            //2. load default
            if (UpdateOrInsert)
            {
                //dua value len controls
                txtPetId.Text = PetInfo.PetId.ToString();
                txtPetName.Text = PetInfo.PetName;
                txtDescription.Text = PetInfo.PetDescription;
                txtPrice.Text = PetInfo.PetPrice.ToString();
                txtQuantity.Text = PetInfo.Quantity.ToString();
                dtImportDate.Value = PetInfo.ImportDate.Value;
                cboPetGroup.Text = PetInfo.PetGroup.PetGroupName;

                txtPetId.Enabled = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_validation())
            {
                MessageBox.Show("The input not empty or quantity >= 0!");
                txtPetId.Focus();
                return;
            }

            //1. collect data tu frmdetail -> Pet
            Pet pet = new Pet()
            {
                PetId = int.Parse(txtPetId.Text),
                PetName = txtPetName.Text,
                PetDescription = txtDescription.Text,
                PetPrice = double.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ImportDate = DateTime.Parse(dtImportDate.Text),
                //pet group
                PetGroupId = PetRepository.GetAllPetGroups()
                        .FirstOrDefault(g => g.PetGroupName.Equals(cboPetGroup.Text))
                        .PetGroupId,

            };
            //2. add to db
            if (UpdateOrInsert)
            {
                PetRepository.UpdatePet(pet);
                MessageBox.Show("Update success!");
            }
            else
            {
                PetRepository.AddPet(pet);
                MessageBox.Show("Insert success!");
            }

            this.Close();
        }
        private bool _validation()
        {
            //All fields are required.
            if (txtPetId.Text == string.Empty
                || txtPetName.Text == string.Empty
                || txtPrice.Text == string.Empty
                || txtDescription.Text == string.Empty
                || txtQuantity.Text == string.Empty
                )
                return false;
            //-	Value for PetPrice and Quantity is greater than or equal to 0.
            if (double.TryParse(txtQuantity.Text, out _) && double.TryParse(txtPrice.Text, out _))
            {
                if (double.Parse(txtQuantity.Text) < 0 || double.Parse(txtPrice.Text) < 0)
                    return false;

            }
            else
            {
                return false;
            }

            //Value for PetName(the name of the pet) is in the range of 5 – 20 characters
            //if (!((txtPetName.TextLength >= 5) && (txtPetId.TextLength <= 20)))
            //    return false;
            // Each word of the PetName must begin with the capital letter. 
            //string[] words = txtPetName.Text.Split(" ");
            //foreach (string word in words)
            //{
            //    if (!Char.IsUpper(word[0]))
            //    {
            //        return false;
            //    }
            //}
            //Each word of the PetName must begin with the capital letter. PetName is not alowed with special characters.
            //if (hasSpecialChar(txtPetName.Text))
            //    return false;

            return true;
        }
        //public static bool hasSpecialChar(string input)
        //{
        //    string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        //    foreach (var item in specialChar)
        //    {
        //        if (input.Contains(item)) return true;
        //    }

        //    return false;
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
