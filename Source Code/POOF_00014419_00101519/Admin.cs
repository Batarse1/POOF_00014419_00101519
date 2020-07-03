using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using POOF_00014419_00101519.Controlers;

namespace POOF_00014419_00101519
{
    public class Admin : UserTypeInterface
    {
        private delegate void Pages(TabPage p);
        private static Pages _pages;
        
        private TextBox[] textBoxesP1 = new TextBox[5];
        private TabControl _tabControl = null;
        private TabPage p1;
        private TabPage p2;
        private TabPage p3;
        private TabPage p4;
        private TabPage p5;
        private TabPage p6;
        private TabPage p7;
        private ComboBox comboBoxRemoveUser;
        private ComboBox comboBoxAddUser;
        public Admin(TabControl t)
        {
            _tabControl = t;
        }

        public void load()
        {
            p1 = new TabPage("Agregar Usuario");
            p2 = new TabPage("Remover Usuario");
            p3 = new TabPage("Historial General");
            p4 = new TabPage("Empleados Presentes");
            p5 = new TabPage("Departamento más concurrido");
            p6 = new TabPage("Top Temperatura Empleados");
            p7 = new TabPage("Top Temperatura Empleados");
            _tabControl.TabPages.Add(p1);
            _tabControl.TabPages.Add(p2);
            _tabControl.TabPages.Add(p3);
            _tabControl.TabPages.Add(p4);
            _tabControl.TabPages.Add(p5);
            _tabControl.TabPages.Add(p6);
            _tabControl.TabPages.Add(p7);
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
            _pages = Page6;
            _pages.Invoke(p6);
            _pages = Page7;
            _pages.Invoke(p7);
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
                    comboBoxAddUser = new ComboBox();
                    comboBoxAddUser.Font = new Font("Microsoft JhengHei UI Light",12);
                    comboBoxAddUser.Height = 20;
                    comboBoxAddUser.Width = 400;
                    comboBoxAddUser.ForeColor = Color.Black;
                    comboBoxAddUser.ValueMember = "idDepartamento";
                    comboBoxAddUser.DisplayMember = "nombre";
                    comboBoxAddUser.DataSource = DepartmentsController.DepartmentsList();
                    comboBoxAddUser.Location = new Point(160,40*(i)+25);
                    comboBoxAddUser.DropDownStyle = ComboBoxStyle.DropDownList;
                    p1.Controls.Add(comboBoxAddUser);
                }

                if (i == 1)
                {
                    label[i].Text = "Contraseña";
                    textBoxesP1[i - 1] = new TextBox();
                    textBoxesP1[i - 1].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i - 1].Height = 20;
                    textBoxesP1[i - 1].Width = 400;
                    textBoxesP1[i - 1].ForeColor = Color.Black;
                    textBoxesP1[i - 1].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i - 1]);
                }

                if (i == 2)
                {
                    label[i].Text = "Nombre";
                    textBoxesP1[i - 1] = new TextBox();
                    textBoxesP1[i - 1].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i - 1].Height = 20;
                    textBoxesP1[i - 1].Width = 400;
                    textBoxesP1[i - 1].ForeColor = Color.Black;
                    textBoxesP1[i - 1].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i - 1]);
                }

                if (i == 3)
                {
                    label[i].Text = "Apellido";
                    textBoxesP1[i - 1] = new TextBox();
                    textBoxesP1[i - 1].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i - 1].Height = 20;
                    textBoxesP1[i - 1].Width = 400;
                    textBoxesP1[i - 1].ForeColor = Color.Black;
                    textBoxesP1[i - 1].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i - 1]);
                }

                if (i == 4)
                {
                    label[i].Text = "DUI";
                    textBoxesP1[i - 1] = new TextBox();
                    textBoxesP1[i - 1].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i - 1].Height = 20;
                    textBoxesP1[i - 1].Width = 400;
                    textBoxesP1[i - 1].ForeColor = Color.Black;
                    textBoxesP1[i - 1].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i - 1]);
                }

                if (i == 5)
                {
                    label[i].Text = "Fecha de nacimiento";
                    textBoxesP1[i - 1] = new TextBox();
                    textBoxesP1[i - 1].Font = new Font("Microsoft JhengHei UI Light",12);
                    textBoxesP1[i - 1].Height = 20;
                    textBoxesP1[i - 1].Width = 400;
                    textBoxesP1[i - 1].ForeColor = Color.Black;
                    textBoxesP1[i - 1].Location = new Point(160,40*(i)+25);
                    p1.Controls.Add(textBoxesP1[i - 1]);
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
            label.Text = "Usuario";
            label.Margin = new Padding(0, 0, 0, 0);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Font = new Font("Microsoft JhengHei UI Light",12);
            label.Height = 40;
            label.Width = 150;
            label.ForeColor = Color.White;
            label.Location = new Point(20,100);
            p1.Controls.Add(label);
            
            comboBoxRemoveUser = new ComboBox();
            comboBoxRemoveUser.Font = new Font("Microsoft JhengHei UI Light",12);
            comboBoxRemoveUser.Height = 20;
            comboBoxRemoveUser.Width = 400;
            comboBoxRemoveUser.ForeColor = Color.Black;
            comboBoxRemoveUser.Location = new Point(170,110);
            comboBoxRemoveUser.ValueMember = "idUsuario";
            comboBoxRemoveUser.DisplayMember = "nombre";
            comboBoxRemoveUser.DataSource = UserController.UserList();            
            comboBoxRemoveUser.DropDownStyle = ComboBoxStyle.DropDownList;
            p1.Controls.Add(comboBoxRemoveUser);

            var buttonP2 = new Button();
            buttonP2.Text = "Eliminar";
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
            CultureInfo provider = CultureInfo.InvariantCulture;
            UserController.AddUser(Convert.ToInt32(comboBoxAddUser.SelectedValue),textBoxesP1[0].Text,textBoxesP1[1].Text,textBoxesP1[2].Text,textBoxesP1[3].Text,DateTime.ParseExact(textBoxesP1[4].Text, "d", provider));
        }
        
        public void ButtonP2_Click(object sender, EventArgs e)
        {
            UserController.RemoveUser(Convert.ToInt32(comboBoxRemoveUser.SelectedValue));
        }
        
        private void Page3(TabPage p3){
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.DataSource = RecordController.RecordTable();
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
            label.Text = $"Departamento más concurrido: {DepartmentsController.topDepartment()}";
            label.Margin = new Padding(0, 0, 0, 0);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Font = new Font("Microsoft JhengHei UI Light",18);
            label.Height = 40;
            label.Width = 600;
            label.ForeColor = Color.White;
            label.Location = new Point(40,130);
            p5.Controls.Add(label);
        }
        
        private void Page6(TabPage p6){
            p6.BackColor = Color.Green;
            var title = new Label();
            
            title.Text = $"TOP DE TEMPERATURAS";
            title.Margin = new Padding(0, 0, 0, 0);
            title.TextAlign = ContentAlignment.MiddleLeft;
            title.Font = new Font("Microsoft JhengHei UI Light",24);
            title.Height = 60;
            title.Width = 600;
            title.ForeColor = Color.White;
            title.Location = new Point(130,30);

            p6.Controls.Add(title);

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
                temperatures[i].Font = new Font("Microsoft JhengHei UI Light",12);
                temperatures[i].Height = 60;
                temperatures[i].Width = 200;
                temperatures[i].ForeColor = Color.White;
                temperatures[i].Location = new Point(500,40*(i)+110);

                if (i == 0)
                    topPlace[i].Text = "Primera temperatura más alta";
                if (i == 1)
                    topPlace[i].Text = "Segunda temperatura más alta";
                if (i == 2)
                    topPlace[i].Text = "Tercera temperatura más alta";
                if (i == 3)
                    topPlace[i].Text = "Cuarta temperatura más alta";
                if (i == 4)
                    topPlace[i].Text = "Quinta temperatura más alta";

                topPlace[i].Margin = new Padding(0, 0, 0, 0);
                topPlace[i].TextAlign = ContentAlignment.MiddleLeft;
                topPlace[i].Font = new Font("Microsoft JhengHei UI Light",12);
                topPlace[i].Height = 40;
                topPlace[i].Width = 600;
                topPlace[i].ForeColor = Color.White;
                topPlace[i].Location = new Point(20,40*(i)+120);
                
                p6.Controls.Add(temperatures[i]);
                p6.Controls.Add(topPlace[i]);
            }
        }
        private void Page7(TabPage p7){
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BackgroundColor = Color.Green;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            p7.Controls.Add(dataGridView);
        }
    }
}