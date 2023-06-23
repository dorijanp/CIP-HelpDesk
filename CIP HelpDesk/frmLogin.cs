using CIP_HelpDesk.Models;
using DBLayer;
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
    public partial class FrmLogin : MaterialForm {
        public FrmLogin() {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e) {

            if (txtEmail.Text == "" || txtPassword.Text == "") {
                MessageBox.Show("Molimo unesite sve podatke za prijavu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {

                var user = UserRepository.GetUser(txtEmail.Text);

                if (user != null && user.CheckPassword(txtPassword.Text)) {
                    FrmUser frmUser = new FrmUser(user);
                    Hide();
                    frmUser.ShowDialog();
                    Close();


                } else {
                    var employee = EmployeeRepository.GetEmployee(txtEmail.Text);

                    if (employee != null && employee.CheckPassword(txtPassword.Text)) {
                        FrmEmployee frmEmployee = new FrmEmployee(employee);
                        Hide();
                        frmEmployee.ShowDialog();
                        Close();
                    } else {
                        MessageBox.Show("Pogrešni podaci za prijavu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                btnLogin_Click(sender, e);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            FrmRegister frmRegister = new FrmRegister();
            Hide();
            frmRegister.ShowDialog();
            Close();
        }
    }
}
