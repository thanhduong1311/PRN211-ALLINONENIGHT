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
    public partial class frmPetManagement : Form
    {
        private IPetRepository _petRepository = null;
        private IEnumerable<PetGroup> _petGroups = null;
        private BindingSource _bindingSource;
        public frmPetManagement()
        {
            _petRepository = new PetRepository();
            InitializeComponent();
        }



        private void dgvPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPetManagement_Load(object sender, EventArgs e)
        {
            //1. Load PetGroup len combobox
            loadPetGroupToCombo();
            //2. Load Pets len dgv
            loadPetList(null);
        }
        private void loadPetList(Func<Pet, bool> predicate)
        {
            //1. get all pets

            var petLists = _petRepository.GetAllPets();
            if (predicate is not null)
            {
                petLists = petLists.Where(predicate);
            }
            /*2. convert petLists => list moi*/

            var listPets = petLists.Select(p =>
            new
            {
                Id = p.PetId,
                Name = p.PetName,
                Description = p.PetDescription,
                CreateDate = p.ImportDate,
                Quantity = p.Quantity,
                Price = p.PetPrice,
                PetGroupId = p.PetGroupId,
                PetGroupName = p.PetGroup.PetGroupName

            });

            try
            {
                //if (listPets.Count() <= 0)
                //{
                //	MessageBox.Show("Em khong tim thay phan Pet nao..., xin moi nhap lai");
                //	txtSearch.Focus();
                //	return;
                //}


                _bindingSource = new BindingSource();
                _bindingSource.DataSource = listPets;



                //add pets len dgv
                this.dgvPet.DataSource = null;
                this.dgvPet.DataSource = _bindingSource;

                txtPetId.DataBindings.Clear();
                txtPetName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                dtImportDate.DataBindings.Clear();
                cboPetGroup.DataBindings.Clear();


                txtPetId.DataBindings.Add("Text", _bindingSource, "Id");
                txtPetName.DataBindings.Add("Text", _bindingSource, "Name");
                txtPrice.DataBindings.Add("Text", _bindingSource, "Price");
                dtImportDate.DataBindings.Add("Text", _bindingSource, "CreateDate");
                txtDescription.DataBindings.Add("Text", _bindingSource, "Description");
                txtQuantity.DataBindings.Add("Text", _bindingSource, "Quantity");
                cboPetGroup.DataBindings.Add("Text", _bindingSource, "PetGroupName");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Trapped error");
            }


        }
        private void loadPetGroupToCombo()
        {
            //lay ra list petgroup
            this._petGroups = _petRepository
            .GetAllPetGroups();

            var items = _petGroups.Select(p => p.PetGroupName).ToArray();
            //add vao combobox
            this.cboPetGroup.Items.Clear();
            this.cboPetGroup.Items.AddRange(items);
            if (this.cboPetGroup.Items.Count > 0)
            {
                this.cboPetGroup.SelectedIndex = 0;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var petId = int.Parse(this.txtPetId.Text); //"1" => 1

            //check xem petID co ton tai khong?
            var pet = _petRepository.GetPetById(petId);
            if (pet != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    _petRepository.DeletePet(petId);
                    MessageBox.Show("Delete completed!", "Exit", MessageBoxButtons.OK);
                    //load lai form
                    loadPetList(null);
                }

            }
            else
            {
                MessageBox.Show($"Pet co id {petId} khong ton tai");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var petGroupId = _petRepository.GetAllPetGroups()
                        .FirstOrDefault(g => g.PetGroupName.Equals(cboPetGroup.Text))
                        .PetGroupId;
            Pet pet = new Pet()
            {
                PetId = int.Parse(txtPetId.Text),
                PetName = txtPetName.Text,
                PetDescription = txtDescription.Text,
                PetPrice = double.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ImportDate = DateTime.Parse(dtImportDate.Text),
                //pet group
                PetGroupId = petGroupId,
                PetGroup = _petGroups.FirstOrDefault(g => g.PetGroupId.Equals(petGroupId))

            };

            frmPetDetail frm = new frmPetDetail()
            {
                PetRepository = _petRepository,
                UpdateOrInsert = true,
                PetInfo = pet
            };
            frm.ShowDialog();

            loadPetList(null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmPetDetail frm = new frmPetDetail()
            {
                PetRepository = _petRepository,
                UpdateOrInsert = false,
            };
            frm.ShowDialog();

            loadPetList(null);
        }

        private void dgvPet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var petGroupId = _petRepository.GetAllPetGroups()
                       .FirstOrDefault(g => g.PetGroupName.Equals(cboPetGroup.Text))
                       .PetGroupId;
            Pet pet = new Pet()
            {
                PetId = int.Parse(txtPetId.Text),
                PetName = txtPetName.Text,
                PetDescription = txtDescription.Text,
                PetPrice = double.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ImportDate = DateTime.Parse(dtImportDate.Text),
                //pet group
                PetGroupId = petGroupId,
                PetGroup = _petGroups.FirstOrDefault(g => g.PetGroupId.Equals(petGroupId))

            };

            frmPetDetail frm = new frmPetDetail()
            {
                PetRepository = _petRepository,
                UpdateOrInsert = true,
                PetInfo = pet
            };
            frm.ShowDialog();
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{

        //    if (txtSearch.Text.Length > 0)
        //    {
        //        if (double.TryParse(txtSearch.Text, out double value))
        //        {

        //            loadPetList(p => p.PetPrice.Equals(value) || p.Quantity.Equals((int)value));
        //        }
        //        else
        //        {
        //            MessageBox.Show("You need input number!");
        //        }

        //    }
        //    else
        //    {
        //        loadPetList(null);
        //    }
        //}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccout_Click(object sender, EventArgs e)
        {
            frmCreateAccount frm = new();
            frm.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadPetList(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var petId = int.Parse(this.txtPetId.Text); //"1" => 1

            //check xem petID co ton tai khong?
            var pet = _petRepository.GetPetById(petId);
            if (pet != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    _petRepository.DeletePet(petId);
                    MessageBox.Show("Delete completed!", "Exit", MessageBoxButtons.OK);
                    //load lai form
                    loadPetList(null);
                }
            }
            else
            {
                MessageBox.Show($"Pet co id {petId} khong ton tai");
            }
        }
    }
}
