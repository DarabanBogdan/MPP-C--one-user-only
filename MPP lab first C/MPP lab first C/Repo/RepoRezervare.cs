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
    public class RepoRezervare : ICrudRepository<int, Rezervare>
    {
        private dbUtils jdbUtils=new dbUtils();
        private static readonly ILog log = LogManager.GetLogger("RepoRezervare");
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rezervare> findAll()
        {
            throw new NotImplementedException();
        }

        public Rezervare findOne(int id)
        {
            Rezervare a = null;
            using (SQLiteConnection connection = jdbUtils.getConnection())
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("select * from Rezervare where idExcursie=@excursie", connection);
                    command.Parameters.Add(new SQLiteParameter("excursie", id));
                    SQLiteDataReader dr = command.ExecuteReader();
                    dr.Read();

                    a = new Rezervare
                    {
                        NumeClient = dr.GetString(1),
                        NumarTelefon = dr.GetString(2),
                        NumarBilete = dr.GetInt32(3),
                        Id = dr.GetInt32(4)
                    };

                    dr.Close();
                    connection.Close();
                }
                catch (Exception e)
                {
                    log.Error(e);
                    
                }

               
            }
            return a;
        }

        public void save(Rezervare entity)
        {
            using (SQLiteConnection connection = jdbUtils.getConnection())
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("insert into Rezervare(NumeClient, NumarTelefon, NumarBilete, idExcursie)  values(@numeC,@numarT,@numarB,@excursie)", connection);
                    command.Parameters.Add(new SQLiteParameter("numeC", entity.NumeClient));
                    command.Parameters.Add(new SQLiteParameter("numarT", entity.NumarTelefon));
                    command.Parameters.Add(new SQLiteParameter("numarB", entity.NumarBilete));
                    command.Parameters.Add(new SQLiteParameter("excursie", entity.Id));

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    log.Error(e);
                   
                }
                
            }
        }
            public IEnumerable<Rezervare> findAllMatch(int s)
            {
                List<Rezervare> a = new List<Rezervare>();
                using (SQLiteConnection connection = jdbUtils.getConnection())
                {
                    try
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand("select * from Rezervare where idExcursie=@s", connection);
                        command.Parameters.Add(new SQLiteParameter("s", s));
                        SQLiteDataReader dr = command.ExecuteReader();
                       while(dr.Read())

                        a.Add(new Rezervare
                    {
                        NumeClient = dr.GetString(1),
                        NumarTelefon = dr.GetString(2),
                        NumarBilete = dr.GetInt32(3),
                        Id = dr.GetInt32(4)
                    });

                    dr.Close();
                    connection.Close();
                }
                    catch (Exception e)
                    {
                        log.Error(e);
                    
                    }
                

            }
                return a;
            
        }

        public List<Excursie> FindAllMatch(string numeObiectivTuristic)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Rezervare> ICrudRepository<int, Rezervare>.FindAllMatch(string numeObiectivTuristic)
        {
            throw new NotImplementedException();
        }

        public bool update(int id, int numarBilete)
        {
            throw new NotImplementedException();
        }
    }
}
