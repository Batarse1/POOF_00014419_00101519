using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using POOF_00014419_00101519.Controlers;
using POOF_00014419_00101519.Models;

namespace POOF_00014419_00101519
{
    public class Employee : UserTypeInterface
    {
        private delegate void Pages(TabPage p);
        private static Pages _pages;
        private User userSelected;
        private TabControl _tabControl = null;
        public Employee(TabControl t, User u)
        {
            userSelected = u;
            _tabControl = t;
        }
        public void load(){
            var p1 = new TabPage("Historial");
            var p2 = new TabPage("Temperaturas más altas");
            _tabControl.TabPages.Add(p1);
            _tabControl.TabPages.Add(p2);
            _pages = Page1;
            _pages.Invoke(p1);
            _pages = Page2;
            _pages.Invoke(p2);
        }

        private void Page1(TabPage p1){
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.Green;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = RecordController.RecordTableId(Convert.ToInt32(userSelected.IdUsuario));
            p1.Controls.Add(dataGridView);
        }

        private void Page2(TabPage p2)
        {
            p2.BackColor = Color.Green;
            
            var label = new Label();
            label.Text = $"Temperatura más alta: {RecordController.TopTemperatureID(Convert.ToInt32(userSelected.IdUsuario))} °C";
            label.Margin = new Padding(0, 0, 0, 0);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Font = new Font("Microsoft JhengHei UI Light",18);
            label.Height = 40;
            label.Width = 600;
            label.ForeColor = Color.White;
            label.Location = new Point(120,130);
            p2.Controls.Add(label);
        }
    }
}