using CIP_HelpDesk.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP_HelpDesk.Repositories {
    public class TicketRepository {

        /// <summary>
        /// Prema unesenom sql upita, otvara vezu na bazu podataka i u listu zahtjeva dodaje dohvačene zahtjeve.
        /// </summary>
        /// <param name="sql">String sql upita</param>
        /// <returns>Lista objekata zahtjeva</returns>
        private static List<Ticket> FetchTickets(string sql) {
            List<Ticket> tickets = new List<Ticket>();

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Ticket ticket = CreateObject(reader);
                tickets.Add(ticket);
            }

            reader.Close();
            DB.CloseConnection();

            return tickets;
        }

        /// <summary>
        /// Funkcija deifinira sql upit za dohvat zahtjeva gdje je djelatnikId = NULL tj. 
        /// zahtjev koji nije još preuzet
        /// </summary>
        /// <returns>Lista zahtjeva koje niti jedan djelatnik nije preuzeo</returns>
        public static List<Ticket> GetTickets() {
            string sql = $"SELECT * FROM zahtjev where djelatnikId IS NULL";
            return FetchTickets(sql);
        }

        /// <summary>
        /// Definira sql upit za dohvat zahtjeva koje je poslao korisnik.
        /// Zatim poziva funkciju za dohvat zahtjeva prema definiranom sql upitu.
        /// </summary>
        /// <param name="user">Objekt korisnik</param>
        /// <returns>Lista objekata zahtjeva</returns>
        public static List<Ticket> GetTickets(User user) {
            string sql = $"SELECT * FROM zahtjev where korisnikId = {user.Id}";
            return FetchTickets(sql);
        }

        /// <summary>
        /// Definira sql upit za dohvat zahtjeva koje je preuzeo djelatnik i koji nisu zatvoreni.
        /// Zatim poziva funkciju za dohvat zahtjeva prema definiranom sql upitu.
        /// </summary>
        /// <param name="employee">Objekt zapsolenik</param>
        /// <returns>Lista objekata zahtjeva</returns>
        public static List<Ticket> GetTickets(Employee employee) {
            string sql = $"SELECT * FROM zahtjev where djelatnikId = {employee.Id} and status != 'Zatvoren'";
            return FetchTickets(sql);
        }

        /// <summary>
        /// Definira sql upit za dohvat zahtjeva koje je preuzeo djelatnik i koji su zatvoreni.
        /// Zatim poziva funkciju za dohvat zahtjeva prema definiranom sql upitu.
        /// </summary>
        /// <param name="employee">objekt zaposlenika</param>
        /// <returns>Lista objekata zahtjeva</returns>
        public static List<Ticket> GetClosedTickets(Employee employee) {
            string sql = $"SELECT * FROM zahtjev where djelatnikId = {employee.Id} and status = 'Zatvoren'";
            return FetchTickets(sql);
        }

        /// <summary>
        /// Kreira novoi zahtjev sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="reader">DataReader objekt sa podacima za zahtjev.</param>
        /// <returns>Vraća novu instancu klase Ticket popunjenu podacima iz DataReadera.</returns>
        private static Ticket CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["id"].ToString());
            int userId = int.Parse(reader["korisnikId"].ToString());
            int.TryParse(reader["djelatnikId"].ToString(), out int employeeId);
            DateTime dateCreated = DateTime.Parse(reader["datumStvoren"].ToString());
            DateTime.TryParse(reader["datumZatvoren"].ToString(), out DateTime dateClosed);
            string description = reader["opis"].ToString();
            string comment = reader["komentar"].ToString();
            string priority = reader["prioritet"].ToString();
            string status = reader["status"].ToString();

            Ticket ticket = new Ticket {
                Id = id,
                UserId = userId,
                EmployeeId = employeeId,
                DateCreated = dateCreated,
                DateClosed = dateClosed,
                Description = description,
                Comment = comment,
                Priority = priority,
                Status = status
            };

            return ticket;
        }

        /// <summary>
        /// Prema proslijeđenim paramterima se izrađuje sql upit za dodavanje sloga u bazu podataka, te se izvršava upis.
        /// </summary>
        /// <param name="user">Objekt korisnik</param>
        /// <param name="desctiprion">Tekstualni opis problema zahtjeva</param>
        public static void InsertTicket(User user, string desctiprion) {
            string sql = $"INSERT INTO zahtjev VALUES ({user.Id}, NULL, GETDATE(), NULL, '{desctiprion}', NULL, NULL, 'Zaprimljen')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        /// <summary>
        /// Zatvara se zahtjev tako se da status postavi na vrijednost "Zatvoren" i zabilježi se trenutno vrijeme.
        /// </summary>
        /// <param name="ticket">Objekt zahtjeva</param>
        public static void CloseTicket(Ticket ticket) {
            string sql = $"UPDATE zahtjev SET status = 'Zatvoren', datumZatvoren = GETDATE() WHERE id = {ticket.Id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        /// <summary>
        /// Ažurira se zapis zahtjeva tako da se posatavi ID djelatnika koji ga preuzima, prioritet zahteva te status koji se postavlja u "U postupku"
        /// </summary>
        /// <param name="ticket">Objekt zahtjeva kojem se ažuriraju podaci</param>
        /// <param name="employee">Objekt zaposlenika koji preuzima zahtjev</param>
        /// <param name="priority">Prioritet zahtjeva</param>
        public static void AcceptTicket(Ticket ticket, Employee employee, string priority) {
            string sql = $"UPDATE zahtjev SET djelatnikID = {employee.Id}, prioritet = '{priority}', status = 'U postupku' WHERE id = {ticket.Id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        /// <summary>
        /// Iz baze podataka se briže slog zahtjeva.
        /// </summary>
        /// <param name="ticket">Objekt zahtjeva</param>
        public static void DeleteTicket(Ticket ticket) {
            string sql = $"DELETE FROM zahtjev WHERE id = {ticket.Id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
