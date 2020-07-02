using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace POOF_00014419_00101519
{
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
        }
        private void UserView_Load(object sender, EventArgs e)
        {
            UserTypeInterface test = new Vigilant(tabControlUserView);
            test.load();
            //UserTypeInterface sdlkf = new Employee(tabControlUserView);
            //sdlkf.load();
        }

        private void UserView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}