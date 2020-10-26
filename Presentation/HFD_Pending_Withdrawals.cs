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
using Newtonsoft.Json;
using Domain.objects;

namespace Presentation
{
    public partial class HFD_Pending_Withdrawals : Form
    {
        public HFD_Pending_Withdrawals()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void HFD_Pending_Withdrawals_MouseDown(object sender, MouseEventArgs e)
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

        private async void HFD_Pending_Withdrawals_LoadAsync(object sender, EventArgs e)
        {
            HFD_Inicio hfd_inicio = new HFD_Inicio();
            Withdrawals withdrawals = new Withdrawals();
            PendingWithdrawalsObject pendingWithdrawalsObject = new PendingWithdrawalsObject();

            PendingWithdrawals pendingWithdrawals = JsonConvert.DeserializeObject<PendingWithdrawals>(await withdrawals.getPendingWithdrawals(hfd_inicio.loginInfo.jwt));
                        
            for (var i=0; i < pendingWithdrawals.pendingWithdrawals.Length; i++)
            {
                var user_id = pendingWithdrawals.pendingWithdrawals[i].user_id;
                var balance = pendingWithdrawals.pendingWithdrawals[i].balance;

                String[] row = { user_id, balance.ToString() };

                dgvPendingWithdrawals.Rows.Add(row);
            }
        }
    }
}
