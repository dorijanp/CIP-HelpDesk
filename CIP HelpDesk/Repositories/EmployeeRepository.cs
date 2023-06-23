using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP_HelpDesk.Models {
    public class EmployeeRepository {

        /// <summary>
        /// Dohvaća sve djelatnike iz baze i sprema ih u listu
        /// </summary>
        /// <returns>Lista zaspolenika</returns>
        public static List<Employee> GetEmployees() {

            List<Employee> employees = new List<Employee>();

            string sql = "SELECT * from djelatnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Employee employee = CreateObject(reader);
                employees.Add(employee);
            }

            reader.Close();
            DB.CloseConnection();

            return employees;
        }

        /// <summary>
        /// Dohavaća djelatnika iz baze podataka prema unesenoj email adresi
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Objekt djelatnik</returns>
        public static Employee GetEmployee(string email) {

            Employee employee = null;

            string sql = $"SELECT * FROM djelatnik where email = '{email}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {

                reader.Read();
                employee = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return employee;
        }

        /// <summary>
        /// Kreira novog zaposlenika sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="reader">DataReader objekt sa podacima za zaposlenika.</param>
        /// <returns>Vraća novu instancu klase Employee popunjenu podacima iz DataReadera.</returns>
        private static Employee CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["id"].ToString());
            string firstName = reader["ime"].ToString();
            string lastName = reader["prezime"].ToString();
            string email = reader["email"].ToString();
            string password = reader["lozinka"].ToString();

            Employee employee = new Employee {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            return employee;
        }
    }
}
