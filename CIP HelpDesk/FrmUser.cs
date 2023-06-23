using CIP_HelpDesk.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIP_HelpDesk {
    public partial class FrmUser : MaterialForm {
        private User user;

        public FrmUser(User loggedUser) {
            InitializeComponent();
            user = loggedUser;
        }

        public void updateUserTicketsData() {
            dgvUserTickets.DataSource = user.GetTickets();
        }

        private void FrmUser_Load(object sender, EventArgs e) {
            Text = $"Dobro došli, {user.ToString()}!";

            updateUserTicketsData();
        }

        private void btnNewTicket_Click(object sender, EventArgs e) {
            FrmNewTicket frmNewTicket = new FrmNewTicket(user, this);
            Hide();
            frmNewTicket.ShowDialog();
        }

        private void pbLogout_Click(object sender, EventArgs e) {
            Environment.Exit(1);
        }
    }
}
