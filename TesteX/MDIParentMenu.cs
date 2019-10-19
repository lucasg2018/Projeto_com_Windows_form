using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteX
{
    public partial class MDIParentMenu : Form
    {
        public MDIParentMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
        }

        private void MDIParentMenu_Load(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
