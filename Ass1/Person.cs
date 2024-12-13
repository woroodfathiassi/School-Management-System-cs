using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    internal abstract class Person
    {
        private int _Id;
        private string _Name;
        private int _Age;
        private readonly DateTime _AdmissionDate;

        public Person(int id, string name, int age)
        {
            _Id = id;
            _Name = name;
            _Age = age;
            _AdmissionDate = DateTime.Now;
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        public DateTime AdmissionDate
        {
            get { return _AdmissionDate; }
        }

        public abstract void GetPersonDetails();

    }
}
