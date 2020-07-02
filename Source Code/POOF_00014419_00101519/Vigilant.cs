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
            _tabControl.TabPages.Add(p2);
            Page1(p1);
            Page2(p2);
            }

        private void Page1(TabPage p1)
            {
               p1.BackColor = Color.DarkGreen;
               var listIn = new List <int>();
               listIn.Add(5);
               var ing = new Label[10];
               for (var i = 0; i < 10; i++)
               {
                   ing [i] = new Label();
                   ing[i].Text = listIn[i].ToString();
                   ing[i].Margin = new Padding(0, 0, 0, 0);
                   ing[i].TextAlign = ContentAlignment.MiddleLeft;
                   ing[i].ForeColor = Color.White;
                   ing[i].Location = new Point(100,20*(i+1));
               }
            }

        private void Page2(TabPage p2)
        {
           // af.Text = "Previo a salir miraremos su temperatura";
           // af.Location = new Point(0, 0);
           
        }
        
        }
    }
