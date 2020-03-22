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
                    dr.Read();

                    a = new Excursie { Id = Int32.Parse( dr.GetString(0)),NumeObiectivTuristic=dr.GetString(1),
                        NumeFirma=dr.GetString(2),OraPlecare=dr.GetString(3),Pret= Int32.Parse(dr.GetString(4)),
                        NumarLocuriDisponibile= Int32.Parse(dr.GetString(5))};



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
            List<Excursie> a = null;
            using (SQLiteConnection connection = jdbUtils.getConnection())
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("select * from Excursie", connection);
                    SQLiteDataReader dr = command.ExecuteReader();
                    dr.Read();



                    int id = Int32.Parse(dr.GetString(0));
                    string test = dr.GetString(1);
                    test= dr.GetString(2);
                    test = dr.GetString(3);
                    test = dr.GetString(4);
                    test = dr.GetString(5);



                    a.Add(new Excursie
                    {
                        Id = Int32.Parse(dr.GetString(0)),
                        NumeObiectivTuristic = dr.GetString(1),
                        NumeFirma = dr.GetString(2),
                        OraPlecare = dr.GetString(3),
                        Pret = Int32.Parse(dr.GetString(4)),
                        NumarLocuriDisponibile = Int32.Parse(dr.GetString(5))
                    });



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
            List<Excursie> a = null;
            using (SQLiteConnection connection = jdbUtils.getConnection())
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("select * from Excursie NumeObiectivTuristic=@s", connection);
                    command.Parameters.Add(new SQLiteParameter("s", s));
                    SQLiteDataReader dr = command.ExecuteReader();
                    dr.Read();

                    a.Add(new Excursie
                    {
                        Id = Int32.Parse(dr.GetString(0)),
                        NumeObiectivTuristic = dr.GetString(1),
                        NumeFirma = dr.GetString(2),
                        OraPlecare = dr.GetString(3),
                        Pret = Int32.Parse(dr.GetString(4)),
                        NumarLocuriDisponibile = Int32.Parse(dr.GetString(5))
                    });



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
            throw new NotImplementedException();
        }

        public IEnumerable<Excursie> findAllMatch(int id)
        {
            throw new NotImplementedException();
        }
    }
}
