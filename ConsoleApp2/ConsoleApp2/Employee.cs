using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        private string _FIO;
        private int _otdel;
        private double _salary;
        public static int _count = 0;
        private int _id;

        public Employee(string fIO, int otdel, double salary)
        {
            _FIO = fIO;
            _otdel = otdel;
            _salary = salary;
            _id = _count++;
        }
        public string FIO
        {
            get { return _FIO; }
            set { _FIO = value; }
        }
        public int Otdel
        {
            get { return _otdel; }
            set { _otdel = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        internal static T2 Aggregate<T1, T2>(T2 v, Func<object, object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
