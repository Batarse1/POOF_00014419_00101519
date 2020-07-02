using System.Drawing;
using System.Windows.Forms;

namespace POOF_00014419_00101519
{
    public class Employee : UserTypeInterface
    {
        private TabControl _tabControl = null;
        private Label jsdaflk = new Label();
        public Employee(TabControl t)
        {
            _tabControl = t;
        }
        public void load(){
            TabPage tp = new TabPage("Page1");
            _tabControl.TabPages.Add(tp);
            jsdaflk.Text = "asdfasdf";
            jsdaflk.Location= new Point(0,0);
            tp.Controls.Add(jsdaflk);
        }
        
        private void Page1(TabPage t){
        
        }
        
    }
}