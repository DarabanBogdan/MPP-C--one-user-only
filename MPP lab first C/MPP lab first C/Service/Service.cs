using MPP_lab_first_C.Domain;
using MPP_lab_first_C.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP_lab_first_C.Service
{
     public class ServiceClass
    {
        private ICrudRepository<String, Angajat> repoAngajat;
        private ICrudRepository<int, Excursie> repoExcursie;
        private ICrudRepository<int, Rezervare> repoRezervare;
        public ServiceClass(ICrudRepository<String, Angajat> repoAngajat, ICrudRepository<int, Rezervare> repoRezervare, ICrudRepository<int, Excursie> repoExcursie)
        {
            this.repoAngajat = repoAngajat;
            this.repoExcursie = repoExcursie;
            this.repoRezervare = repoRezervare;
        }
        public class Ora
        {
           public int ora, minut;
            public Ora(int o, int m)
            {
                ora = o;
                minut = m;
            }

        }

        public bool login(Angajat angajat)
        {

            Angajat temp = repoAngajat.findOne(angajat.Username);
            if (temp != null)
            {
                if (temp.Password==angajat.Password)
                {
                    return true;
                }
            }
            return false;

        }

        public Ora StringToOra(string s)
        {
            string[] spliting = s.Split(':');
            return new Ora(Int32.Parse(spliting[0]), Int32.Parse(spliting[1]));

        }


        public IEnumerable<Excursie> findAllMatch(String numeObiectivTuristic, String oraInceput, String oraSfarsit)
        {

            List<Excursie> tasks = new List<Excursie>();
            List<Excursie> all = (List<Excursie>)repoExcursie.FindAllMatch(numeObiectivTuristic);
            Ora inceput = StringToOra(oraInceput);
            Ora sfarsit = StringToOra(oraSfarsit);
            foreach(Excursie curent in all)
            {
                
                Ora curentOra = StringToOra(curent.OraPlecare);
                if (curentOra.ora > inceput.ora && curentOra.ora < sfarsit.ora)
                    tasks.Add(curent);
                else if (curentOra.ora == inceput.ora && curentOra.minut >= inceput.minut && curentOra.ora < sfarsit.ora)
                    tasks.Add(curent);
                else if (curentOra.ora == inceput.ora && curentOra.minut >= inceput.minut && curentOra.ora == sfarsit.ora && curentOra.minut <= sfarsit.minut)
                    tasks.Add(curent);
                else if (curentOra.ora > inceput.ora && curentOra.ora == sfarsit.ora && curentOra.minut <= sfarsit.minut)
                    tasks.Add(curent);
            }

            return tasks;

        }

        internal void addRezervare(Rezervare rezervare)
        {
            int n = repoExcursie.findOne(rezervare.Id).NumarLocuriDisponibile - rezervare.NumarBilete;
            if ( n>= 0)
            {
                repoExcursie.update(rezervare.Id, n);
                repoRezervare.save(rezervare);
            }
            
        }

        internal Excursie findOneExcursie(int v)
        {
            return repoExcursie.findOne(v);
        }

        public IEnumerable<Rezervare> findAllRezervare(Excursie excursie)
        {

            return repoRezervare.findAllMatch(excursie.Id);

        }
        public IEnumerable<Excursie> findAllExcursie()
        {

            return repoExcursie.findAll();

        }
    }
}
