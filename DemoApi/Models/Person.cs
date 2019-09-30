using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApi.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from SQL
        /// </summary>
        public int IdPerson { get; set; } = 0;

        /// <summary>
        /// User first name
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// User Last Name
        /// </summary>
        public string LastName { get; set; } = "";
    }
}