using PetStore_StudentName_Repository.Reprository;

namespace PetStore_StudentName
{
    public partial class frmLogin : Form
    {
        private IShopMemberRepository _memberRepository;
        public frmLogin()
        {
            _memberRepository = new ShopMemberRepository();
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //check xem null
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is not empty!");
                txtEmail.Focus();
                return;
            }


            if (txtPass.Text == "")
            {
                MessageBox.Show("Password is not empty!");
                txtPass.Focus();
                return;
            }

            //goi xuong DB de check xem email va pass co ko?
            //check mat khau va user
            var member = _memberRepository.GetPetShopMembers()
                .FirstOrDefault(m => m.EmailAddress == txtEmail.Text && m.MemberPassword == txtPass.Text);
            if (member == null)
            {
                MessageBox.Show("Email or Password is invalid!");
                txtEmail.Focus();
                return;
            }
            else
            {
                if (member.MemberRole == 1)
                {
                    frmPetManagement frmPet = new();
                    this.Hide();
                    frmPet.ShowDialog();
                    this.Close();
                }
                else if (member.MemberRole == 2)
                {
                    frmOderOfStaff frmPet = new()
                    {
                        memberId = member.MemberId,
                        member = member,

                    };
                    this.Hide();
                    frmPet.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You have no permission to access this function");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}