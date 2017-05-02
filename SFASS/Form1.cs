using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFASS
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            formFree formFree = new formFree();
            formFree.Hide();
            formFree.Show();
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            formStudy formStudy = new formStudy();
            formStudy.Hide();
            formStudy.Show();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            formProff formProff = new formProff();
            formProff.Hide();
            formProff.Show();
        }
    }
}
