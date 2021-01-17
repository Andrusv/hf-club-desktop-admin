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
using Domain.objects;
using Newtonsoft.Json;

namespace Presentation
{
    public partial class HFD_Aprove_Coupons : Form
    {
        public HFD_Aprove_Coupons()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private readonly string sessionToken = new HFD_Inicio().loginInfo.jwt;

        private void btnArrowBack_MouseDown(object sender, MouseEventArgs e)
        {
            btnArrowBack.Visible = false;
            pctArrowBack.Visible = true;
        }

        private void HFD_Aprove_Coupons_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void HFD_Aprove_Coupons_LoadAsync(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            lblUserId.Text = HFD_Pending_Withdrawals.userIdCouponsToAprove;

            Users user = new Users();
            CouponsToCheckMonthly couponsToCheckMonthly = await user.checkCouponsMonthly(sessionToken, HFD_Pending_Withdrawals.userIdCouponsToAprove);

            txb_Link.Text = couponsToCheckMonthly.userLink;
            txb_Response.Text = couponsToCheckMonthly.userViews.ToString();

            UseWaitCursor = false;
        }

        private void btnArrowBack_MouseUp(object sender, MouseEventArgs e)
        {
            btnArrowBack.Visible = true;
            pctArrowBack.Visible = false;

            HFD_Pending_Withdrawals HFD_Pending_Withdrawals = new HFD_Pending_Withdrawals();

            this.Hide();
            HFD_Pending_Withdrawals.Show();
        }
    }
}
