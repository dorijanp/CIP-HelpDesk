using CIP_HelpDesk.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP_HelpDesk.Models {
    public class Employee : Person{

        public List<Ticket> GetActiveTickets() {
            return TicketRepository.GetTickets(this);

        }
        public List<Ticket> GetNewTickets() {
            return TicketRepository.GetTickets();
        }

        public List<Ticket> GetClosedTickets() {
            return TicketRepository.GetClosedTickets(this);
        }

        public void CloseTicket(Ticket ticket) {
            TicketRepository.CloseTicket(ticket);
        }

        public void AcceptTicket(Ticket ticket, string priortiy) {
            TicketRepository.AcceptTicket(ticket, this, priortiy);
        }
    }
}
