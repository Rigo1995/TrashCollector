using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Admin
    {
        [key]
        public string Id { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Customers> Customers { get; set; }
        
    }
}