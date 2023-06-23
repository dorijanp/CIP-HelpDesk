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
    public partial class FrmRegister : MaterialForm {
        public FrmRegister() {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if (txtFirstName.Text == "" ||txtLastName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtPasswordAgain.Text == "") {
                MessageBox.Show("Molimo ispunite sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtPasswordAgain.Text) {
                MessageBox.Show("Lozinke se ne podudaraju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = UserRepository.GetUser(txtEmail.Text);

            if (user != null) {
                MessageBox.Show("Već postoji korisnik sa tom email adresom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                UserRepository.InsertUser(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, cboRole.SelectedItem.ToString());
                MessageBox.Show("Uspješno ste registrirani! Može nastaviti sa prijavom.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmLogin frmLogin = new FrmLogin();
                Hide();
                frmLogin.ShowDialog();
                Close();
            }
        }

        private void pbArrowBack_Click(object sender, EventArgs e) {
            FrmLogin frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();
        }
    }
}
