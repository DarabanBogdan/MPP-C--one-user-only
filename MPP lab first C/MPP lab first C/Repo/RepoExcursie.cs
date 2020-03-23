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
    public class RepoExcursie : ICrudRepository<int, Excursie>
    {
        private dbUtils jdbUtils=new dbUtils();
        private static readonly ILog log = LogManager.GetLogger("RepoExcursie");

        public Excursie findOne(int id)
        {
            Excursie a = null;
            using (SQLiteConnection connection = jdbUtils.getConnection())
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("select * from Excursie where id=@excursie", connection);
                    command.Parameters.Add(new SQLiteParameter("excursie", id));
                    SQLiteDataReader dr = command.ExecuteReader();
                    if(dr.Read())

                    a = new Excursie { Id = dr.GetInt32(0),NumeObiectivTuristic=dr.GetString(1),
                        NumeFirma=dr.GetString(2),OraPlecare=dr.GetString(3),Pret= dr.GetInt32(4),
                        NumarLocuriDisponibile= dr.GetInt32(5)};


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

        public IEnumerable<Excursie> findAll()
        {
            List<Excursie> a = new List<Excursie>();
            
            using (SQLiteConnection connection = jdbUtils.getConnection())
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("select * from Excursie", connection);
                    SQLiteDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        // int id = Int32.Parse(dr.GetString(0));
                        //  string test = dr.GetString(1);
                        //  test = dr.GetString(2);
                        // test = dr.GetString(3);
                        // test = dr.GetString(4);
                        // test = dr.GetString(5);


                        Excursie b = new Excursie
                        {
                            Id = dr.GetInt32(0),
                            NumeObiectivTuristic = dr.GetString(1),
                            NumeFirma = dr.GetString(2),
                            OraPlecare = dr.GetString(3),
                            Pret = dr.GetInt32(4),
                            NumarLocuriDisponibile = dr.GetInt32(5)
                        };

                        a.Add(b);
                    }
                    dr.Close();
                    connection.Close();
                }
                catch (Exception e)
                {
                    log.Error(e);
                    Console.WriteLine(e);
                    
                }
               
            }
            return a;
        }

        public IEnumerable<Excursie> findAllMatch(string s)
        {
            List<Excursie> a = new List<Excursie>();
            using (SQLiteConnection connection = jdbUtils.getConnection())
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("select * from Excursie where NumeObiectivTuristic=@s", connection);
                    command.Parameters.Add(new SQLiteParameter("s", s));
                    SQLiteDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {

                        Excursie b = new Excursie
                        {
                            Id = dr.GetInt32(0),
                            NumeObiectivTuristic = dr.GetString(1),
                            NumeFirma = dr.GetString(2),
                            OraPlecare = dr.GetString(3),
                            Pret = dr.GetInt32(4),
                            NumarLocuriDisponibile = dr.GetInt32(5)
                        };

                        a.Add(b);
                    }

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
        public void save(Excursie entity)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

 

        public IEnumerable<Excursie> FindAllMatch(string numeObiectivTuristic)
        {
            return this.findAllMatch(numeObiectivTuristic);
        }

        public IEnumerable<Excursie> findAllMatch(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(int id, int numarBilete)
        {
            using (SQLiteConnection connection = jdbUtils.getConnection())
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("update Excursie set NumarLocuriDisponibile=@n where id=@i", connection);
                    command.Parameters.Add(new SQLiteParameter("n",numarBilete));
                    command.Parameters.Add(new SQLiteParameter("i", id));


                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    log.Error(e);
                    Console.WriteLine(e);
                }

            }
            return true;
        }
    }
}
