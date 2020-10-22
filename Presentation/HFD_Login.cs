using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class HFD_Login : Form
    {
        public HFD_Login()
        {
            InitializeComponent();
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 135)
            {
                MenuVertical.Width = 40;
            } else
            {
                MenuVertical.Width = 135;
            }
        }
    }
}
