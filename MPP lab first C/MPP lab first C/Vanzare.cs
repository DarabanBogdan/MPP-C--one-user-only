using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPP_lab_first_C.Domain;
using MPP_lab_first_C.Repo;
using MPP_lab_first_C.Service;
namespace MPP_lab_first_C
{
    public partial class Vanzare : Form
    {
        public ServiceClass service ;
        Login login;
        public Vanzare(Login login)
        {
            this.login = login;
            InitializeComponent();
            showTable();
        }
        public void showTable()
        {
            service = new ServiceClass(new RepoAngajat(), new RepoRezervare(), new RepoExcursie());
            var source = new BindingSource();
            var lista= service.findAllExcursie();
            source.DataSource = lista;
           
            Table.AutoGenerateColumns = true;
            Table.DataSource = source;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            login.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           
           var source = new BindingSource();
            var lista = service.findAllMatch(ObiectivField.Text,OraInceput.Text+":"+MinutInceput.Text, OraSfarsit.Text + ":"+MinutSfarsit.Text);
            source.DataSource = lista;

            TableSearch.AutoGenerateColumns = true;
            TableSearch.DataSource = source;
        }

        private void RezervaButton_Click(object sender, EventArgs e)
        {
            
            
            service.addRezervare(new Rezervare { Id = Convert.ToInt32(TableSearch.SelectedRows[0].Cells["Id"].Value.ToString()),NumeClient=NumeField.Text,NumarBilete= Convert.ToInt32(BileteField.Text),NumarTelefon=TelefonField.Text });
            showTable();
        }
        private void ShowRezervare()
        {
            var source = new BindingSource();
            var lista = service.findAllRezervare(service.findOneExcursie(Convert.ToInt32(TableSearch.SelectedRows[0].Cells["Id"].Value.ToString())));
            source.DataSource = lista;

            TableRezervare.AutoGenerateColumns = true;
            TableRezervare.DataSource = source;
        }

        private void TableSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRezervare();
        }
    }
}
