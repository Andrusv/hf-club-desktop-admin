using Domain;
using Domain.objects;
using Newtonsoft.Json;
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

namespace Presentation
{
    public partial class HFD_Aproved_Withdrawals : Form
    {
        public HFD_Aproved_Withdrawals()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        private void HFD_Aproved_Withdrawals_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void HFD_Aproved_Withdrawals_LoadAsync(object sender, EventArgs e)
        {
            HFD_Inicio hfd_inicio = new HFD_Inicio();
            Withdrawals withdrawals = new Withdrawals();

            AprovedWithdrawals aprovedWithdrawals = JsonConvert.DeserializeObject<AprovedWithdrawals>(await withdrawals.getAprovedWithdrawals(hfd_inicio.loginInfo.jwt));

            for (var i = 0; i < aprovedWithdrawals.aprovedWithdrawals.Length; i++)
            {
                var withdrawal_id = aprovedWithdrawals.aprovedWithdrawals[i].withdrawal_id;
                var user_id = aprovedWithdrawals.aprovedWithdrawals[i].user_id;
                var balance = aprovedWithdrawals.aprovedWithdrawals[i].balance;
                var character_name = aprovedWithdrawals.aprovedWithdrawals[i].characterName;

                String[] row = { withdrawal_id, user_id, balance.ToString(), character_name };

                dgvAprovedWithdrawals.Rows.Add(row);
            }
        }
    }
}
