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
    public partial class HFD_Ban_User : Form
    {
        public HFD_Ban_User()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void HFD_Ban_User_MouseDown(object sender, MouseEventArgs e)
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
            btnBanUser.Enabled = false;
        }

        private void enableButtons()
        {
            btnArrowBack.Enabled = true;
            btnBanUser.Enabled = true;
        }

        private void txtUserId_Enter(object sender, EventArgs e)
        {
            if (txtUserId.Text == "USER ID")
            {
                txtUserId.Text = "";
                txtUserId.ForeColor = Color.LightGray;
            }
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                txtUserId.Text = "USER ID";
                txtUserId.ForeColor = Color.DimGray;
            }
        }

        private async void btnBanUser_ClickAsync(object sender, EventArgs e)
        {
            if (txtUserId.Text != "" && txtUserId.Text != "USER ID" && txtUserId.TextLength == 24) {
                disableButtons();
                UseWaitCursor = true;

                txtResponse.Text = "";

                Users users = new Users();
                String sessionToken = new HFD_Inicio().loginInfo.jwt;

                txtResponse.Text = await users.banUser(sessionToken, txtUserId.Text);

                UseWaitCursor = false;
                enableButtons();
            } else
            {
                txtResponse.Text = "Campo USER ID incompleto o inexistente";
            }
        }
    }
}
