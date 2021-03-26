using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class student
    {
        public int studentId { set; get; }
        public string studentName { set; get; }
    }
    class waluty
    {
        public string Base { set; get; }
        public Dictionary<string, decimal> rates { set; get; }
    }
}
