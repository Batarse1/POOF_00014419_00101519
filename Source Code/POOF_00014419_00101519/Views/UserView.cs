﻿using System;
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
            
            UserTypeInterface sdlkf = new Employee(tabControlUserView);
            sdlkf.load();
        }
    }
}