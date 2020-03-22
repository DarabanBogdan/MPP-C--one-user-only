using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP_lab_first_C.Repo
{
	public class dbUtils
    {

		private static SQLiteConnection connection;
		private string properies= ConfigurationManager.ConnectionStrings["excursiiDB"].ConnectionString;
		private static readonly ILog logger = LogManager.GetLogger("DbUtils");



		public dbUtils()
		{

		}

		private SQLiteConnection createConnection()
		{
			logger.Info("realizare conexiune...");
			
			return new SQLiteConnection(properies);
		}
		public SQLiteConnection getConnection()
		{

			try
			{
				if (connection == null)
				{
					connection = createConnection();


				}

			}
			catch (SQLiteException e)
			{
				logger.Error(e);
			}
			return connection;
		}
	}
}

