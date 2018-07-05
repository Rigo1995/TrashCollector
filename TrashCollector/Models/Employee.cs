using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAdress { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime Date { get; set; }   
        public List <Customers> Customers { get; set; }
        

    }
}