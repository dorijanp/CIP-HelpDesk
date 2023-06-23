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
    public partial class FrmNewTicket : MaterialForm {
        private User user;
        private FrmUser frmUser; 
        public FrmNewTicket(User loggedUser, FrmUser frmUser) {
            InitializeComponent();
            user = loggedUser;
            this.frmUser = frmUser;
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Želite li sigurno poslati novi zahtjev u CIP?", "Pošalji zahtjev?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) {
                user.CreateTicket(txtDescription.Text);
                MessageBox.Show("Uspješno poslan zahtjev!");
                Close();
                frmUser.updateUserTicketsData();
                frmUser.Show();
            }
        }

        private void pbArrowBack_Click(object sender, EventArgs e) {
            Close();
            frmUser.Show();
        }
    }
}
