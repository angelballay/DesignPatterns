using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton
{
    internal class DataBase
    {
        private static DataBase? _instance;


        private DataBase()
        {
            //Conexion a la DB
        }

        public static DataBase Instance()
        {
            if(_instance == null)
            {
                return new DataBase();
            }
            return _instance;
        }

        public string Query(string query)
        {
            return "JSON";
        }
    }
}
