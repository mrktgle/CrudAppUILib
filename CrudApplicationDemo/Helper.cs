using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApplicationDemo
{
    public class Helper
    {
        public static string connection(string databaseName)
        {
            return databaseName = $"Server=localhost; Database={databaseName}; Integrated Security=SSPI;";
        }
    }
}
