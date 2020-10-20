using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Domain.objects;
using Newtonsoft.Json;

namespace hf_club_desktop_admin
{
    public partial class HFD_Inicio : Form
    {
        public HFD_Inicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private Users users = new Users();
        private User usuario = new User();

        private readonly String apiKeyToken = "7ed9b7682df930a86c38b2e0e70e9ad263508ccdcc7f8c103e154e85dde50667";

        private void HFD_Inicio_Load(object sender, EventArgs e)
        {
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "CORREO ELECTRÓNICO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "CORREO ELECTRÓNICO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "CONTRASEÑA")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "CONTRASEÑA";
                txtpassword.ForeColor = Color.DimGray;
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HFD_Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void btnlogin_ClickAsync(object sender, EventArgs e)
        {
            if (txtuser.Text == "CORREO ELECTRÓNICO" || txtuser.Text == "")
            {
                this.msgError("El campo de correo electrónico no puede estar vacío");
                txtuser.Select();

                return;
            }

            if (txtpassword.Text == "CONTRASEÑA" || txtpassword.Text == "")
            {
                this.msgError("El campo de contraseña no puede estar vacío");
                txtpassword.Select();

                return;
            }

            lblErrorMessage.Visible = false;

            usuario.username = txtuser.Text;
            usuario.password = txtpassword.Text;
            usuario.apiKeyToken = apiKeyToken;

            MessageBox.Show(await users.loginAdminAsync(usuario));
        }

        private void msgError(String msg)
        {
            lblErrorMessage.Text = "      " + msg;
            lblErrorMessage.Visible = true;
        }
    }
}
