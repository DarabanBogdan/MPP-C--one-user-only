using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPP_lab_first_C.Repo;
using MPP_lab_first_C.Service;
namespace MPP_lab_first_C
{
    public partial class Vanzare : Form
    {
        public ServiceClass service = new ServiceClass(new RepoAngajat(), new RepoRezervare(), new RepoExcursie());

        public Vanzare()
        {
            InitializeComponent();
            showTable();
        }
        public void showTable()
        {
           
            var source = new BindingSource();
            var lista= service.findAllExcursie();
            source.DataSource = lista;
           
            Table.AutoGenerateColumns = true;
            Table.DataSource = source;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
