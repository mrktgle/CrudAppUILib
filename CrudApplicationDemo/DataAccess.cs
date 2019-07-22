using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace CrudApplicationDemo
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection conn = new SqlConnection(Helper.connection("Sample")))
            {
                var output = conn.Query<Person>("dbo.People_GetByLastName (@LastName", new { lastName = lastName }).ToList();
                return output;
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection conn = new SqlConnection(Helper.connection("Sample")))
            {
                List<Person> people = new List<Person>();

                people.Add(new Person
                {
                    FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber
                });

                conn.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);       
            }
        }
    }
}
