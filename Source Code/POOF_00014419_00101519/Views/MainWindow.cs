using System;
using System.Windows.Forms;

namespace POOF_00014419_00101519
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserView userView = new UserView();            
            userView.Show();
            Hide();
        }
    }
}