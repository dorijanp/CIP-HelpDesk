using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP_HelpDesk.Models {
    public abstract class Person {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString() {
            return FirstName + ' ' + LastName;
        }

        public bool CheckPassword(string password) {
            if (Password == password)
                return true;
            else return false;
        }
    }
}
