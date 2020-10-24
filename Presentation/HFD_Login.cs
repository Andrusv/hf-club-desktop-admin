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
using DataAccess.objects;
using Newtonsoft.Json;

namespace Presentation
{
    public partial class HFD_Login : Form
    {
        public HFD_Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public readonly string sessionToken = new HFD_Inicio().loginInfo.jwt;

        private Users users = new Users();
        private Stats stats = new Stats();

        private void disableButtons()
        {
            lblErrorMessage.Visible = false;
            btnRefresh.Enabled = false;
            btnPendingWithdrawals.Enabled = false;
            btnAprovedWithdrawals.Enabled = false;
            btnBanUser.Enabled = false;
            btnGenerateCoupons.Enabled = false;
        }

        private void enableButtons()
        {
            btnRefresh.Enabled = true;
            btnPendingWithdrawals.Enabled = true;
            btnAprovedWithdrawals.Enabled = true;
            btnBanUser.Enabled = true;
            btnGenerateCoupons.Enabled = true;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HFD_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRefresh_MouseDown(object sender, MouseEventArgs e)
        {
            btnRefresh.Visible = false;
            pctRefreshOrange.Visible = true;
        }

        private async void btnRefresh_MouseUpAsync(object sender, MouseEventArgs e)
        {
            disableButtons();
            UseWaitCursor = true;

            btnRefresh.Visible = true;
            pctRefreshOrange.Visible = false;

            try
            {
                Stats stats = await users.refreshStats(sessionToken);
                
                txtTotalCoupons.Text = stats.totalCoupons.ToString();
                txtTotalCredits.Text = stats.totalCredits.ToString();
                txtTotalWithdrawals.Text = stats.totalWithdrawals.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
                msgError("Error de comunicacion con el servidor");
            }

            enableButtons();
            UseWaitCursor = false;
        }

        private void msgError(String msg)
        {
            lblErrorMessage.Text = "      " + msg;
            lblErrorMessage.Visible = true;
        }

        private void btnGenerateCoupons_Click(object sender, EventArgs e)
        {
            HFD_Generate_Coupons hfd_generate_coupons = new HFD_Generate_Coupons();
            this.Hide();
            hfd_generate_coupons.Show();
        }

        private void btnBanUser_MouseClick(object sender, MouseEventArgs e)
        {
            HFD_Ban_User hfd_generate_coupons = new HFD_Ban_User();
            this.Hide();
            hfd_generate_coupons.Show();
        }

        private void btnPendingWithdrawals_Click(object sender, EventArgs e)
        {
            HFD_Pending_Withdrawals hfd_pending_withdrawals = new HFD_Pending_Withdrawals();
            this.Hide();
            hfd_pending_withdrawals.Show();
        }
    }
}
