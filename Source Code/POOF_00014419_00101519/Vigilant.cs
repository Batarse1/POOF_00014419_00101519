using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace POOF_00014419_00101519
{
    public class Vigilant : UserTypeInterface
    {
        private TabControl _tabControl = null;
        private Label af = new Label();

        public Vigilant(TabControl T)
        {
            _tabControl = T;
        }

        public void load()
        {
            //add button in tabControl
            var p1 = new TabPage("Pasar lista-entrada");
            var p2 = new TabPage("Pasar lista-Salida");
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
                       var comboBox = new ComboBox();
                       comboBox.Font = new Font("Microsoft JhengHei UI Light",12);
                       comboBox.Height = 20;
                       comboBox.Width = 420;
                       comboBox.ForeColor = Color.Black;
                       comboBox.Location = new Point(160,48*(i)+25);
                       comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                       p1.Controls.Add(comboBox);
                   }

                   if (i == 1)
                   {
                       Place[i].Text = "Entrada";
                       var ComboBox2 = new ComboBox();
                       ComboBox2.Font = new Font("Microsoft JhengHei UI Light",12);
                       ComboBox2.Height = 20;
                       ComboBox2.Width = 420;
                       ComboBox2.ForeColor = Color.Black;
                       ComboBox2.Location = new Point(160,48*(i)+25);
                       ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                       p1.Controls.Add(ComboBox2);
                   }

                   if (i == 2)
                   {
                       Place[i].Text = "Fecha";
                       var textBox = new TextBox();
                       textBox.Font = new Font("Microsoft JhengHei UI Light",12);
                       textBox.Height = 20;
                       textBox.Width = 420;
                       textBox.ForeColor = Color.Black;
                       textBox.Location = new Point(160,48*(i)+25);
                       p1.Controls.Add(textBox);
                   }

                   if (i == 3)
                   {
                       Place[i].Text = "Tiempo";
                       var textBox = new TextBox();
                       textBox.Font = new Font("Microsoft JhengHei UI Light",12);
                       textBox.Height = 20;
                       textBox.Width = 420;
                       textBox.ForeColor = Color.Black;
                       textBox.Location = new Point(160,48*(i)+25);
                       p1.Controls.Add(textBox);
                   }

                   if (i == 4)
                   {
                       Place[i].Text = "Temperatura";
                       var textBox = new TextBox();
                       textBox.Font = new Font("Microsoft JhengHei UI Light",12);
                       textBox.Height = 20;
                       textBox.Width = 420;
                       textBox.ForeColor = Color.Black;
                       textBox.Location = new Point(160,48*(i)+25);
                       p1.Controls.Add(textBox);
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
            }

        }
    }
