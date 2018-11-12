using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ISravanthRepository<T>
    {
        List<T> GetAll();
    }

    public class Employee : ISravanthRepository<T>
    {
        static void Main(string[] args)
        {
        }
    }
}
