using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using POOF_00014419_00101519.Controlers;
using POOF_00014419_00101519.Models;


namespace POOF_00014419_00101519
{
    public class Vigilant : UserTypeInterface
    {
        private TabControl _tabControl = null;
        private ComboBox comboBoxUser; 
        private ComboBox comboBoxBoolean;
        private TextBox[] textBoxes = new TextBox[3];
        public Vigilant(TabControl T, User u)
        {
            _tabControl = T;
        }

        public void load()
        {
            //add button in tabControl
            var p1 = new TabPage("Pasar lista");
            _tabControl.TabPages.Add(p1);
            Page1(p1);
            }

        private void Page1(TabPage p1)
        {
            p1.BackColor = Color.DarkGreen;
              
            var Place= new Label[7];    
            for (var i = 0; i < 5; i++)
            {
                Place[i] = new Label();

                if (i == 0)
                {
                   Place[i].Text = "Usuario";
                   comboBoxUser = new ComboBox();
                   comboBoxUser.Font = new Font("Microsoft JhengHei UI Light",12);
                   comboBoxUser.Height = 20;
                   comboBoxUser.Width = 420;
                   comboBoxUser.ForeColor = Color.Black;
                   comboBoxUser.ValueMember = "idUsuario";
                   comboBoxUser.DisplayMember = "nombre";
                   comboBoxUser.DataSource = UserController.UserList();  
                   comboBoxUser.Location = new Point(160,48*(i)+25);
                   comboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
                   p1.Controls.Add(comboBoxUser);
                }

                if (i == 1)
                {
                    List<bool> listBoolean = new List<bool>();
                    listBoolean.Add(true);
                    listBoolean.Add(false);
                    Place[i].Text = "Entrada";
                    comboBoxBoolean = new ComboBox();
                    comboBoxBoolean.Font = new Font("Microsoft JhengHei UI Light",12);
                    comboBoxBoolean.Height = 20;
                    comboBoxBoolean.Width = 420;
                    comboBoxBoolean.DataSource = listBoolean; 
                    comboBoxBoolean.ForeColor = Color.Black;
                    comboBoxBoolean.Location = new Point(160,48*(i)+25);
                    comboBoxBoolean.DropDownStyle = ComboBoxStyle.DropDownList;
                    p1.Controls.Add(comboBoxBoolean);
                }

                if (i == 2)
                {
                   Place[i].Text = "Fecha";
                   textBoxes[i-2] = new TextBox();
                   textBoxes[i-2].Font = new Font("Microsoft JhengHei UI Light",12);
                   textBoxes[i-2].Height = 20;
                   textBoxes[i-2].Width = 420;
                   textBoxes[i-2].ForeColor = Color.Black;
                   textBoxes[i-2].Location = new Point(160,48*(i)+25);
                   p1.Controls.Add(textBoxes[i-2]);
                }

                if (i == 3)
                {
                   Place[i].Text = "Tiempo";
                   textBoxes[i-2] = new TextBox();
                   textBoxes[i-2].Font = new Font("Microsoft JhengHei UI Light",12);
                   textBoxes[i-2].Height = 20;
                   textBoxes[i-2].Width = 420;
                   textBoxes[i-2].ForeColor = Color.Black;
                   textBoxes[i-2].Location = new Point(160,48*(i)+25);
                   p1.Controls.Add(textBoxes[i-2]);
                }

                if (i == 4)
                {
                   Place[i].Text = "Temperatura";
                   textBoxes[i-2] = new TextBox();
                   textBoxes[i-2].Font = new Font("Microsoft JhengHei UI Light",12);
                   textBoxes[i-2].Height = 20;
                   textBoxes[i-2].Width = 420;
                   textBoxes[i-2].ForeColor = Color.Black;
                   textBoxes[i-2].Location = new Point(160,48*(i)+25);
                   p1.Controls.Add(textBoxes[i-2]);
                }
                
                Place[i].Margin = new Padding(0, 0, 0, 0);
                Place[i].TextAlign = ContentAlignment.MiddleLeft;
                Place[i].Font = new Font("Microsoft JhengHei UI Light",12);
                Place[i].Height = 40;
                Place[i].Width = 150;
                Place[i].ForeColor = Color.White;
                Place[i].Location = new Point(20,48*(i)+15);

                p1.Controls.Add(Place[i]);
            }
               
           var Button = new Button();
           Button.Text = "añadir";
           Button.Margin = new Padding(0,0,0,0);
           Button.TextAlign = ContentAlignment.MiddleLeft;
           Button.Font = new Font("Microsoft JhengHei UI Light",12);
           Button.Height = 40;
           Button.Width = 150;
           Button.TextAlign = ContentAlignment.MiddleCenter;
           Button.BackColor = Color.Snow;
           Button.ForeColor = Color.Black;
           Button.Location = new Point(250, 280);
           p1.Controls.Add(Button);
           Button.Click += new System.EventHandler(Button_Click);
        }
        public void Button_Click(object sender, EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            RecordController.AddRecord(Convert.ToInt32(comboBoxUser.SelectedValue),Convert.ToBoolean(comboBoxBoolean.SelectedValue),DateTime.ParseExact(textBoxes[0].Text, "d", provider),DateTime.ParseExact(textBoxes[1].Text, "HH:mm:ss", provider),Convert.ToDouble(textBoxes[2].Text));
        }
    }
}
