using System;
using System.Windows.Forms;
using POOF_00014419_00101519.Controlers;
using POOF_00014419_00101519.Models;

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
            if(comboBoxUser.SelectedValue.Equals(textBoxPassword.Text)){
                UserView userView = new UserView((User)comboBoxUser.SelectedItem);            
                userView.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }
        
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            comboBoxUser.DisplayMember = "nombre";
            comboBoxUser.ValueMember = "contrasenia";
            comboBoxUser.DataSource = UserController.UserList();
        }
    }
}