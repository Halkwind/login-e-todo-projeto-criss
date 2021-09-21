using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_e_todo_projeto_cris
{
    class DBSQL:DbAcess
    {
        private static string conString;
        private static DBSQL instance;

        public DBSQL(string connectionString)
            : base(connectionString)
        {
        }

        public static DBSQL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBSQL(conString);
                }
                return instance;
            }
        }
        public static string ConnectionString
        {
            get
            {
                return conString;
            }
            set
            {
                conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + value + ";Persist Security Info=False;";
            }

        }
    }
}
