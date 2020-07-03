using System;
using System.Drawing;
using System.Windows.Forms;

namespace POOF_00014419_00101519
{
    public class Admin : UserTypeInterface
    {
        private delegate void Pages(TabPage p);
        private static Pages _pages;
        
        private TextBox[] textBoxesP1 = new TextBox[6];
        private TabControl _tabControl = null;

        public Admin(TabControl t)
        {
            _tabControl = t;
        }

        public void load()
        {
            var p1 = new TabPage("Agregar Usuario");
            var p2 = new TabPage("Remover Usuario");
            var p3 = new TabPage("Historial General");
            var p4 = new TabPage("Empleados Presentes");
            var p5 = new TabPage("Empleados Presentes");
            _tabControl.TabPages.Add(p1);
            _tabControl.TabPages.Add(p2);
            _tabControl.TabPages.Add(p3);
            _tabControl.TabPages.Add(p4);
            _tabControl.TabPages.Add(p5);
            _pages = Page1;
            _pages.Invoke(p1);
            _pages = Page2;
            _pages.Invoke(p2);
            _pages = Page3;
            _pages.Invoke(p3);
            _pages = Page4;
            _pages.Invoke(p4);
            _pages = Page5;
            _pages.Invoke(p5);
        }
        
        private void Page1(TabPage p1){
            p1.BackColor = Color.Green;
            
            var label = new Label[6];
            for (var i = 0; i < 6 ; i++)
            {
                label[i] = new Label();

                if (i == 0)
                {
                    label[i].Text = "Departamento";
                    var comboBox = new ComboBox();
                    comboBox.Font = new Font("Microsoft JhengHei UI Light",12);
                    comboBox.Height = 20;
                    comboBox.Width = 400;
                    comboBox.ForeColor = Color.Black;
                    comboBox.Location = new Point(160,40*(i)+25);
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    p1.Controls.Add(comboBox);
                }

                if (i == 1)
                {
                    label[i].Text = "Contraseña";
                    textBoxesP1[i] = new TextBox();
                    textBoxesP1[i].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i].Height = 20;
                    textBoxesP1[i].Width = 400;
                    textBoxesP1[i].ForeColor = Color.Black;
                    textBoxesP1[i].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i]);
                }

                if (i == 2)
                {
                    label[i].Text = "Nombre";
                    textBoxesP1[i] = new TextBox();
                    textBoxesP1[i].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i].Height = 20;
                    textBoxesP1[i].Width = 400;
                    textBoxesP1[i].ForeColor = Color.Black;
                    textBoxesP1[i].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i]);
                }

                if (i == 3)
                {
                    label[i].Text = "Apellido";
                    textBoxesP1[i] = new TextBox();
                    textBoxesP1[i].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i].Height = 20;
                    textBoxesP1[i].Width = 400;
                    textBoxesP1[i].ForeColor = Color.Black;
                    textBoxesP1[i].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i]);
                }

                if (i == 4)
                {
                    label[i].Text = "DUI";
                    textBoxesP1[i] = new TextBox();
                    textBoxesP1[i].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i].Height = 20;
                    textBoxesP1[i].Width = 400;
                    textBoxesP1[i].ForeColor = Color.Black;
                    textBoxesP1[i].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i]);
                }

                if (i == 5)
                {
                    label[i].Text = "Fecha de nacimiento";
                    textBoxesP1[i] = new TextBox();
                    textBoxesP1[i].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i].Height = 20;
                    textBoxesP1[i].Width = 400;
                    textBoxesP1[i].ForeColor = Color.Black;
                    textBoxesP1[i].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i]);
                }
                    
                label[i].Margin = new Padding(0, 0, 0, 0);
                label[i].TextAlign = ContentAlignment.MiddleLeft;
                label[i].Font = new Font("Microsoft JhengHei UI Light",12);
                label[i].Height = 40;
                label[i].Width = 150;
                label[i].ForeColor = Color.White;
                label[i].Location = new Point(20,40*(i)+15);

                p1.Controls.Add(label[i]);
            }

            var buttonP1 = new Button();
            buttonP1.Text = "Añadir";
            buttonP1.Margin = new Padding(0, 0, 0, 0);
            buttonP1.TextAlign = ContentAlignment.MiddleLeft;
            buttonP1.Font = new Font("Microsoft JhengHei UI Light",12);
            buttonP1.Height = 40;
            buttonP1.Width = 150;
            buttonP1.TextAlign = ContentAlignment.MiddleCenter;
            buttonP1.BackColor = Color.Snow;
            buttonP1.ForeColor = Color.Black;
            buttonP1.Location = new Point(230,280);
            p1.Controls.Add(buttonP1);
            buttonP1.Click += new System.EventHandler(ButtonP1_Click);
        }
        
        private void Page2(TabPage p1){
            p1.BackColor = Color.Green;
            
            var label = new Label();
            label.Text = "Departamento";
            label.Margin = new Padding(0, 0, 0, 0);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Font = new Font("Microsoft JhengHei UI Light",12);
            label.Height = 40;
            label.Width = 150;
            label.ForeColor = Color.White;
            label.Location = new Point(20,100);
            p1.Controls.Add(label);
            
            var comboBox = new ComboBox();
            comboBox.Font = new Font("Microsoft JhengHei UI Light",12);
            comboBox.Height = 20;
            comboBox.Width = 400;
            comboBox.ForeColor = Color.Black;
            comboBox.Location = new Point(170,110);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            p1.Controls.Add(comboBox);

            var buttonP2 = new Button();
            buttonP2.Text = "Añadir";
            buttonP2.Margin = new Padding(0, 0, 0, 0);
            buttonP2.TextAlign = ContentAlignment.MiddleLeft;
            buttonP2.Font = new Font("Microsoft JhengHei UI Light",12);
            buttonP2.Height = 40;
            buttonP2.Width = 150;
            buttonP2.TextAlign = ContentAlignment.MiddleCenter;
            buttonP2.BackColor = Color.Snow;
            buttonP2.ForeColor = Color.Black;
            buttonP2.Location = new Point(230,200);
            p1.Controls.Add(buttonP2);
            buttonP2.Click += new System.EventHandler(ButtonP2_Click);
        }

        public void ButtonP1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("simn");
        }
        
        public void ButtonP2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("simn");
        }
        
        private void Page3(TabPage p3){
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.Green;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            p3.Controls.Add(dataGridView);
        }
        
        private void Page4(TabPage p4){
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.Green;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            p4.Controls.Add(dataGridView);
        }
        
        private void Page5(TabPage p5){
            p5.BackColor = Color.Green;
            
            var label = new Label();
            string s = "administrativo";
            label.Text = $"Departamento más concurrido: {s}";
            label.Margin = new Padding(0, 0, 0, 0);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Font = new Font("Microsoft JhengHei UI Light",18);
            label.Height = 40;
            label.Width = 600;
            label.ForeColor = Color.White;
            label.Location = new Point(40,130);
            p5.Controls.Add(label);
        }
    }
}