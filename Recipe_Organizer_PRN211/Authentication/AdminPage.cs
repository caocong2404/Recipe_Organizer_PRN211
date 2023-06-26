using Services.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Organizer_PRN211.Authentication
{
    public partial class AdminPage : Form
    {
        UserRepository _userRepository;
        List<User> listUser = new List<User>();
        public AdminPage()
        {
            _userRepository = new UserRepository();
            InitializeComponent();
            var userList = _userRepository.GetAll();
        }

        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;//đặt thuộc tính cho form con không được hiển thị độc lập
            childForm.FormBorderStyle = FormBorderStyle.None;//tắt đường viền tắt các nút thu nhỏ mở rộng hay đóng form con
            childForm.Dock = DockStyle.Fill;//form con lấp đầy panel body
            Pn_body.Controls.Add(childForm);//thêm form con vào panel body
            Pn_body.Tag = childForm;//gán form con cho thuộc tính tag của panel để lưu trử thông tin form con
            childForm.BringToFront();//ĐƯA form con ra trước trong các điều khiển panel
            childForm.Show();//hiện thị nó 
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            openChildForm(new UserList());
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminProfie());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form login = new Homepage();
            this.Hide();
            login.Show();
        }
    }
}
