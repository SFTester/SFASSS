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
    public partial class formStudy : Form
    {
        public formStudy()
        {
            InitializeComponent();
        }

        private void rbMath_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStudyNotReady.Checked == true) tbcLessons.Visible = false;
            if (rbStudyNotReady.Checked == false) tbcLessons.Visible = true;
        }
    }
}
