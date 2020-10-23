using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class HFD_Generate_Coupons : Form
    {
        public HFD_Generate_Coupons()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Coupons coupons = new Coupons();

        private readonly String sessionToken = new HFD_Inicio().loginInfo.jwt;

        private void HFD_Generate_Coupons_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnArrowBack_MouseDown(object sender, MouseEventArgs e)
        {
            btnArrowBack.Visible = false;
            pctArrowBack.Visible = true;
        }

        private void btnArrowBack_MouseUp(object sender, MouseEventArgs e)
        {
            btnArrowBack.Visible = true;
            pctArrowBack.Visible = false;

            HFD_Login hfd_login = new HFD_Login();

            this.Hide();
            hfd_login.Show();
        }

        private void disableButtons()
        {
            btnArrowBack.Enabled = false;
            btnCreateCoupons.Enabled = false;
        }

        private void enableButtons()
        {
            btnArrowBack.Enabled = true;
            btnCreateCoupons.Enabled = true;
        }

        private void txtCoupons_Enter(object sender, EventArgs e)
        {
            if (txtCoupons.Text == "NUMERO DE CUPONES A CREAR")
            {
                txtCoupons.Text = "";
                txtCoupons.ForeColor = Color.LightGray;
            }
        }

        private void txtCoupons_Leave(object sender, EventArgs e)
        {
            if (txtCoupons.Text == "")
            {
                txtCoupons.Text = "NUMERO DE CUPONES A CREAR";
                txtCoupons.ForeColor = Color.DimGray;
            }
        }

        private async void btnCreateCoupons_ClickAsync(object sender, EventArgs e)
        {
            if (txtCoupons.Text != "" && txtCoupons.Text != "NUMERO DE CUPONES A CREAR" && txtCoupons.Text != "0")
            {
                disableButtons();
                UseWaitCursor = true;

                txtResponse.Text = await coupons.createCoupons(Int32.Parse(txtCoupons.Text), sessionToken);

                txtCoupons.Text = "";

                UseWaitCursor = false;
                enableButtons();
            }
        }

        private void txtCoupons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
