using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP_HelpDesk.Models {
    public class Ticket {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateClosed { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }

        public override string ToString() {
            return $"Zahtjev br.{Id}";
        }

        public bool HasComment() {
            return Comment == null ? true : false;
        }
    }
}
