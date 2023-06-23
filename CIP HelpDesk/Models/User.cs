using CIP_HelpDesk.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP_HelpDesk.Models {
    public class User : Person{
        public string Role { get; set; }

        public List<Ticket> GetTickets() {
            return TicketRepository.GetTickets(this);
        }

        public void CreateTicket(string description) {
            TicketRepository.InsertTicket(this, description);
        }
    }
}
