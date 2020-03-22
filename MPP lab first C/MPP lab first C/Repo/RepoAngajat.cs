using log4net;
using MPP_lab_first_C.Domain;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP_lab_first_C.Repo
{
    public class RepoAngajat:ICrudRepository<string,Angajat>
    {
        private dbUtils jdbUtils= new dbUtils();
        private static readonly ILog log = LogManager.GetLogger("RepoAngajat");


        public void delete(string id)
        {
            throw new NotImplementedException();
        }

 

        public Angajat findOne(string id)
        {
            Angajat a = null;
            using (SQLiteConnection connection = jdbUtils.getConnection())
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("select password  from Angajat where Username=@user", connection);
                    command.Parameters.Add(new SQLiteParameter("user", id));
                    SQLiteDataReader dr = command.ExecuteReader();
                    dr.Read();

                    a = new Angajat{Username=id,Password= dr.GetString(0) };



                }
                catch (Exception e)
                {
                    log.Error(e);
                }

            }
            return a;
        }



        public void save(Angajat entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Angajat> ICrudRepository<string, Angajat>.findAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Angajat> FindAllMatch(string numeObiectivTuristic)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Angajat> findAllMatch(int id)
        {
            throw new NotImplementedException();
        }
    }
}
