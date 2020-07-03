using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using POOF_00014419_00101519.Models;

namespace POOF_00014419_00101519
{
    public partial class UserView : Form
    {
        private User userSelected;
        public UserView(User u)
        {
            userSelected = u;
            InitializeComponent();
        }
        private void UserView_Load(object sender, EventArgs e)
        {
            byte opt = Convert.ToByte(userSelected.IdDepartamento);
            switch (opt)
            {
                case 1:
                    Text = "General";
                    UserTypeInterface employee = new Employee(tabControlUserView, userSelected);
                    employee.load();
                    break;
                case 2:
                    Text = "Vigilancia";
                    UserTypeInterface vigilant = new Vigilant(tabControlUserView, userSelected);
                    vigilant.load();
                    break;
                case 3:    
                    Text = "Administrativo";
                    UserTypeInterface admin = new Admin(tabControlUserView, userSelected);
                    admin.load();
                    break;
            }
        }

        private void UserView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}