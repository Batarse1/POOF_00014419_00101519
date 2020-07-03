using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using POOF_00014419_00101519.Controlers;

namespace POOF_00014419_00101519
{
    public class Employee : UserTypeInterface
    {
        private delegate void Pages(TabPage p);
        private static Pages _pages;
        
        private TabControl _tabControl = null;
        public Employee(TabControl t)
        {
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
            dataGridView.DataSource = RecordController.RecordTableId();
            p1.Controls.Add(dataGridView);
        }

        private void Page2(TabPage p2)
        {
            p2.BackColor = Color.Green;
            var title = new Label();
            
            title.Text = $"TOP DE TEMPERATURAS";
            title.Margin = new Padding(0, 0, 0, 0);
            title.TextAlign = ContentAlignment.MiddleLeft;
            title.Font = new Font("Microsoft JhengHei UI Light",24);
            title.Height = 60;
            title.Width = 600;
            title.ForeColor = Color.White;
            title.Location = new Point(130,50);

            p2.Controls.Add(title);

            var listTemperatures = RecordController.TopRecordList();
            var temperatures = new Label[listTemperatures.Count];
            var topPlace = new Label[listTemperatures.Count];
            for (var i = 0; i < listTemperatures.Count ; i++)
            {
                temperatures[i] = new Label();
                topPlace[i] = new Label();
                
                temperatures[i].Text = $"{listTemperatures[i]}°C";
                temperatures[i].Margin = new Padding(0, 0, 0, 0);
                temperatures[i].TextAlign = ContentAlignment.MiddleLeft;
                temperatures[i].Font = new Font("Microsoft JhengHei UI Light",18);
                temperatures[i].Height = 60;
                temperatures[i].Width = 200;
                temperatures[i].ForeColor = Color.White;
                temperatures[i].Location = new Point(480,70*(i+2));

                if (i == 0)
                    topPlace[i].Text = "Primera temperatura más alta";
                if (i == 1)
                    topPlace[i].Text = "Segunda temperatura más alta";
                if (i == 2)
                    topPlace[i].Text = "Tercera temperatura más alta";

                topPlace[i].Margin = new Padding(0, 0, 0, 0);
                topPlace[i].TextAlign = ContentAlignment.MiddleLeft;
                topPlace[i].Font = new Font("Microsoft JhengHei UI Light",18);
                topPlace[i].Height = 60;
                topPlace[i].Width = 600;
                topPlace[i].ForeColor = Color.White;
                topPlace[i].Location = new Point(20,70*(i+2));
                
                p2.Controls.Add(temperatures[i]);
                p2.Controls.Add(topPlace[i]);
            }
        }
    }
}