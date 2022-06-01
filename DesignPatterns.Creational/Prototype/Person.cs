using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCooy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}, BirthDate: {this.BirthDate.ToString("ddMMyyyy")} p.Name, p.Age, p.BirthDate) \nID#: {this.IdInfo.IdNumber}";
        }
    }
}
