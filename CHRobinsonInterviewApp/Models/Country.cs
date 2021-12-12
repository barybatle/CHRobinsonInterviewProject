using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHRobinsonInterviewApp.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<string> Parents { get; set; }
        public List<string> Children { get; set; }
        public List<string> Siblings { get; set; }
    }
}
