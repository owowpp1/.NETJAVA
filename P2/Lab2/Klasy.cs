using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data.Entity;

namespace Lab2
{
    public class Student
    {
        public int ID { set; get; }
        public string name { set; get; }
        public float avg { set; get; }
    }
    public class University : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
    }
    public class waluty
    {
        public int ID { set; get; }
        public string Base { set; get; }
        public Dictionary<string, decimal> rates { set; get; }
    }
    public class BDwaluty
    {
        public int ID { set; get; }
        public string Base { set; get; }
        public string Symbol { set; get; }
        public decimal Wartosc { set; get; }
    }
    public class BazaWalut2 : DbContext
    {
        public virtual DbSet<BDwaluty> Walutes { set; get; }
    }
}
