using DemoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoApi.Controllers
{
    /// <summary>
    /// People Class Controller
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { IdPerson = 1, FirstName = "Betty", LastName = "Pinzon" });
            people.Add(new Person { IdPerson = 2, FirstName = "Armando", LastName = "Mendoza" });
            people.Add(new Person { IdPerson = 3, FirstName = "Patricia", LastName = "Ramirez" });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(p => p.IdPerson == id).FirstOrDefault();
        }

        /// <summary>
        /// Gets a list of the first name of all users
        /// </summary>
        /// <param name="userId">user identifier</param>
        /// <param name="age">age of the user</param>
        /// <returns>List of all the first names</returns>
        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> firstNames = new List<string>();

            foreach (Person person in people)
            {
                firstNames.Add(person.FirstName);
            }

            return firstNames;
        }

        // POST: api/People
        /// <summary>
        /// 
        /// </summary>
        /// <param name="per"></param>
        public void Post(Person per)
        {
            people.Add(per);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            
        }
    }
}
