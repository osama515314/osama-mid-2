using System;
using System.Data.Entity;
using System.Linq;

namespace MuhammadOsama.Models
{
    public class Car
    {
        public int ID {get; set; }
        public string name {get; set; }
        public string EngineNumber {get; set; }
        public string ChasisNumber {get; set; }
        public string RegNumber {get; set; }
        public int Price {get; set; }

        internal static IQueryable<Car> Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }

    public class CarDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}