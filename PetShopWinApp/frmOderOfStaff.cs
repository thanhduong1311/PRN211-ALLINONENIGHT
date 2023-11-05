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
    public partial class frmOderOfStaff : Form
    {
        private IMemberOderRepo _memberOderRepo;
        public string memberId { get; set; }
        private IPetRepository _petRepository = null;
        private BindingSource _bindingSource;
        public PetShopMember member;
        int petId = 0;
        public frmOderOfStaff()
        {
            _memberOderRepo = new MemberOderRepo();
            _petRepository = new PetRepository();
            InitializeComponent();
        }

        private void frmOderOfStaff_Load(object sender, EventArgs e)
        {
            //1. Load petgroup len combobox
            //lay ra list petgroup
            var petGroups = _petRepository.GetAllPetGroups();

            var items = petGroups.Select(p => p.PetGroupName).ToList();
            items.Insert(0, "All");
            string[] itemsArray = items.ToArray();
            //add vao combobox
            this.cboPetGroup.Items.Clear();
            this.cboPetGroup.Items.AddRange(itemsArray);
            if (this.cboPetGroup.Items.Count > 0)
            {
                this.cboPetGroup.SelectedIndex = 0;
            }
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
                if (listPets.Count() <= 0)
                {
                    MessageBox.Show("The Pet not found!");
                    //txtSearch.Focus();
                    return;
                }


                _bindingSource = new BindingSource();
                _bindingSource.DataSource = listPets;



                //add pets len dgv
                this.dgvPet.DataSource = null;
                this.dgvPet.DataSource = _bindingSource;

                txtPetName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                dtImportDate.DataBindings.Clear();
                cboPetGroup.DataBindings.Clear();


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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //Seach cả 2
            if (txtSearch.Text.Length != 0 && !cboPetGroup.Text.Equals("All"))
            {

                loadPetList(p => p.PetName.ToLower().Contains((string)txtSearch.Text.ToLower())
                && p.PetGroup.PetGroupName.Equals(cboPetGroup.Text));


            }
            //Search bằng Name hoặc giá
            else
            if (cboPetGroup.Text.Equals("All") && txtSearch.Text.Length > 0)
            {

                loadPetList(p => p.PetName.ToLower().Contains((string)txtSearch.Text.ToLower()));

            }
            //Seach bằng PetGroup
            else
            if (!cboPetGroup.Text.Equals("All") && txtSearch.Text.Length == 0)
            {
                loadPetList(p => p.PetGroupId.Equals(_petRepository.GetAllPetGroups()
                        .FirstOrDefault(g => g.PetGroupName.Equals(cboPetGroup.Text))
                        .PetGroupId));
            }
            //SeachAll
            else
            {
                loadPetList(null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng hợp lệ trong DataGridView hay chưa
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị ID của pet từ cột đầu tiên (cột 0)
                petId = Convert.ToInt32(dgvPet.Rows[e.RowIndex].Cells[0].Value);

                // Bây giờ bạn đã có giá trị petId của pet được chọn
                // Bạn có thể sử dụng nó để thực hiện các tác vụ liên quan đến pet này.
            }
        }

        private void dgvPet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, int.MaxValue);
                // Lấy giá trị ID của pet từ cột đầu tiên (cột 0)
                petId = Convert.ToInt32(dgvPet.Rows[e.RowIndex].Cells[0].Value);

                // Bây giờ bạn đã có giá trị petId của pet được chọn
                // Bạn có thể sử dụng nó để thực hiện các tác vụ liên quan đến pet này.
                var pet = _petRepository.GetAllPets()
                      .FirstOrDefault(p => p.PetId.Equals(petId));
                //Chỗ này sau phát triển có thể thêm mua bao nhiêu sản phẩn, nếu số sản
                //phẩm lớn hơn quantity thì ko cho mua.


                //Id này có thể random getall rồi lấy id lớn nhất +1


                MemberOrder memberOrder = new MemberOrder()
                {
                    Id = randomNumber,
                    Quantity = 1,
                    TotalPrice = (int)pet.PetPrice * 1,
                    PetId = petId,
                    MemberId = member.MemberId,
                };
                try
                {
                    if (memberOrder != null)
                    {
                        _memberOderRepo.AddOder(memberOrder);
                        MessageBox.Show("Order" + pet.PetName + "is successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Check lại xem id này đã tồn tại chưa nhé!
            Random random = new Random();
            int randomNumber = random.Next(1, int.MaxValue);
            var pet = _petRepository.GetAllPets()
                      .FirstOrDefault(p => p.PetId.Equals(petId));
            if (pet != null)
            {
                if (int.TryParse(txtQuantityOder.Text, out int quantityOder))
                {
                    if (pet.Quantity > quantityOder)
                    {
                        MemberOrder memberOrder = new MemberOrder()
                        {
                            Id = randomNumber,
                            Quantity = quantityOder,
                            TotalPrice = (int)pet.PetPrice * quantityOder,
                            PetId = petId,
                            MemberId = member.MemberId,
                        };

                        try
                        {
                            if (memberOrder != null)
                            {
                                _memberOderRepo.AddOder(memberOrder);
                                pet.Quantity -= quantityOder;
                                _petRepository.UpdatePet(pet);
                                loadPetList(null);
                                MessageBox.Show("Order " + pet.PetName + "Pet: Success");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Does not have quantity you can by");
                    }
                }
                else
                {
                    MessageBox.Show("You need input number");
                }
            }
            else
            {
                MessageBox.Show("You need choice pet");
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantityOder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
