using CIP_HelpDesk.Repositories;
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

namespace CIP_HelpDesk.Models {
    public partial class FrmClosedTicketsReport : MaterialForm {
        private Employee employee;
        private List<Ticket> closedTickets;

        public FrmClosedTicketsReport(Employee loggedEmployee) {
            InitializeComponent();
            employee = loggedEmployee;
        }

        private void updateClosedTicketsData() {
            closedTickets = employee.GetClosedTickets();
            dgvClosedTickets.DataSource = closedTickets;
        }

        private void FrmClosedTicketsReport_Load(object sender, EventArgs e) {
            Text = $"Izviješće zatvorenih zahtjeva za djelatnika {employee}";

            updateClosedTicketsData(); 
        }

        private void txtFilter_TextChanged(object sender, EventArgs e) {
            dgvClosedTickets.DataSource = closedTickets.FindAll(ticket => ticket.Description.Contains(txtFilter.Text));
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Trajno obrisati zapis o zahtjevu?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                Ticket selectedTicket = dgvClosedTickets.CurrentRow.DataBoundItem as Ticket;
                if (selectedTicket != null) {
                    TicketRepository.DeleteTicket(selectedTicket);

                    updateClosedTicketsData();
                }
            }
        }

        private void pbArrowBack_Click(object sender, EventArgs e) {
            Close();
            foreach (Form form in Application.OpenForms) {
                if (form is FrmEmployee) {
                    form.Show();
                }
            }
        }
    }
}
