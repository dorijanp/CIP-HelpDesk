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
    public partial class FrmEmployee : MaterialForm {
        private Employee employee;
        private List<Ticket> activeTickets, newTickets;
        private List<User> users;

        public FrmEmployee(Employee loggedEmployee) {
            InitializeComponent();
            employee = loggedEmployee;
        }

        private void FrmEmployee_Load(object sender, EventArgs e) {
            Text = $"Dobro došli, {employee.ToString()}!";

            users = UserRepository.GetUsers();

            updateTicketsData();
        }

        private void rbtnActiveTickets_CheckedChanged(object sender, EventArgs e) {
            if (rbtnActiveTickets.Checked) {
                cboTickets.DataSource = activeTickets;
                btnCloseTicket.Enabled = true;
                btnAcceptTicket.Enabled = false;
            } else {
                cboTickets.DataSource = newTickets;
                btnCloseTicket.Enabled = false;
                btnAcceptTicket.Enabled = true;
            }
        }

        private void btnCloseTicket_Click(object sender, EventArgs e) {
            var ticket = cboTickets.SelectedItem as Ticket;

            if (ticket.HasComment() == false && txtComment.Text == "") {
                MessageBox.Show("Morate unijeti komentar na zahtjev prije zatvaranja!", "Upozorenje");
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Sigurno zatvoriti {ticket}?", "Upozorenje", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                employee.CloseTicket(ticket);
                updateTicketsData();
                MessageBox.Show("Zahtjev uspješno zatvoren!");
            }
        }

        private void btnClosedTicketsReport_Click(object sender, EventArgs e) {
            FrmClosedTicketsReport frmClosedTicketsReport = new FrmClosedTicketsReport(employee);
            Hide();
            frmClosedTicketsReport.ShowDialog();
            
        }

        private void btnAcceptTicket_Click(object sender, EventArgs e) {
            if (cboPriority.SelectedItem.ToString() == "") {
                MessageBox.Show("Molimo odredite prioritet zahtjeva prije preuzimanja.", "Upozorenje");
                return;
            }

            var ticket = cboTickets.SelectedItem as Ticket;
            DialogResult dialogResult = MessageBox.Show($"Želite li preuzeti {ticket}?", "Upozorenje", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                employee.AcceptTicket(ticket, cboPriority.SelectedItem.ToString());
                updateTicketsData();
                MessageBox.Show("Zahtjev uspješno preuzet!");
            }
        }

        private void cboTickets_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedTicket = cboTickets.SelectedItem as Ticket;
            txtUser.Text = users.FirstOrDefault(user => user.Id == selectedTicket.UserId).ToString();     
            txtDate.Text = selectedTicket.DateCreated.ToString();
            txtDescription.Text = selectedTicket.Description;
            cboPriority.Text = selectedTicket.Priority.ToString();
            txtComment.Text = selectedTicket.Comment.ToString();
        }

        private void pbLogout_Click(object sender, EventArgs e) {
            Environment.Exit(1);
        }

        private void updateTicketsData() {
            activeTickets = employee.GetActiveTickets();
            newTickets = employee.GetNewTickets();

            cboTickets.DataSource = activeTickets;
            rbtnActiveTickets.Checked = true;
        }
    }
}
