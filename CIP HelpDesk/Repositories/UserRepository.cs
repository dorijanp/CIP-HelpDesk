using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP_HelpDesk.Models {
    public class UserRepository {

        /// <summary>
        /// Iz baze podataka se čitaju svi korisnici u upisuju u listu.
        /// </summary>
        /// <returns>Lista objekata korinsik</returns>
        public static List<User> GetUsers() {
            List<User> users = new List<User>();

            string sql = "SELECT * FROM korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                User user = CreateObject(reader);
                users.Add(user);
            }

            reader.Close();
            DB.CloseConnection();

            return users;
        }

        /// <summary>
        /// U bazi podataka se traži korisnik sa unesenom email adresom i zapisuje u varijablu user.
        /// </summary>
        /// <param name="email">String unsene email adrese</param>
        /// <returns>Objekt korisnik</returns>
        public static User GetUser(string email) {

            User user = null;

            string sql = $"SELECT * FROM korisnik where email = '{email}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {

                reader.Read();
                user = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return user;
        }

        /// <summary>
        /// Kreira novog studenta sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="reader">DataReader objekt sa podacima za studenta.</param>
        /// <returns>Vraća novu instancu klase User popunjenu podacima iz DataReadera.</returns>
        private static User CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["id"].ToString());
            string firstName = reader["ime"].ToString();
            string lastName = reader["prezime"].ToString();
            string email = reader["email"].ToString();
            string password = reader["lozinka"].ToString();
            string role = reader["uloga"].ToString();

            User user = new User {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                Role = role
            };

            return user;
        }

        /// <summary>
        /// Unosi u bazu podataka novog korisnika.
        /// </summary>
        /// <param name="firstName">Ime korisnika</param>
        /// <param name="lastName">Prezime koirnsika</param>
        /// <param name="email">Email adresa korisnika</param>
        /// <param name="password">Lozinka korisnika</param>
        /// <param name="role">Uloga korisnika na Fakultetu</param>
        public static void InsertUser(string firstName, string lastName, string email, string password, string role) {
            string sql = $"INSERT INTO korisnik (ime, prezime, email, lozinka, uloga) VALUES ('{firstName}', '{lastName}', '{email}', '{password}', '{role}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
