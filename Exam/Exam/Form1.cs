using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();     
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            FormManager manager = new FormManager();
            manager.Show();
        }

        private void buttonFizLica_Click(object sender, EventArgs e)
        {
            FormFizLica fzlc = new FormFizLica();
            fzlc.Show();
        }

        private void buttonYurLica_Click(object sender, EventArgs e)
        {
            FormYurLica yl = new FormYurLica();
            yl.Show();
        }
    }
}
