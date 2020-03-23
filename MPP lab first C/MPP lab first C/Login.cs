using MPP_lab_first_C.Repo;
using MPP_lab_first_C.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPP_lab_first_C
{
    public partial class Login : Form
    {
        public ServiceClass service = new ServiceClass(new RepoAngajat(), new RepoRezervare(), new RepoExcursie());
        public Vanzare vanzare;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool t=service.login(new Domain.Angajat { Username = UsernameField.Text, Password = PasswordField.Text });

            if (t)
            {
                vanzare=new Vanzare(this);
                vanzare.Show();
                UsernameField.Clear();
                PasswordField.Clear();
                this.Hide();
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show("Username or password incorrect!", "Error", buttons);

            }
        }
    }
}
