using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymus
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDay { get; set; }

        public Employee()
        {
        }
        public Employee(int id, string name, DateTime birthDay)
        {
            this.id = id;
            this.name = name;
            this.birthDay = birthDay;
        }
        public override string ToString()
        {
            return "Ma NV: " + id + " - Ten NV: " + name + " - NgaySinh: " + birthDay;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>() {
                new Employee(01,"Nguyen Van A",new DateTime(1995,4,28)),
                new Employee(12,"Chu Van C",new DateTime(1992,04,15)),
                new Employee(20,"Tran Thi B",new DateTime(1998,10,10)),
                new Employee(05,"Hoang Thi D",new DateTime(2000,11,03)),
                new Employee(25,"Ly Van E",new DateTime(1992,09,12))};


            Console.WriteLine("=========================");
            Console.WriteLine("Nhan vien co ID lon hon 10:");
            int id = 10;
            List<Employee> employees1 = getEmployeesWithIdGreaterThan(employees, id);
            printEmployees(employees1);
            Console.WriteLine("=========================");
            Console.WriteLine("Nhan vien co ID lon hon 10 va ten bat dau bang chu C:");
            string prefixName = "C";
            employees1 = getEmployeesWithAgeGreaterThan10AndPrefixNameIn(employees, prefixName);
            printEmployees(employees1);
            Console.WriteLine("=========================");
            Console.WriteLine("Nhan vien co nam sinh 1992:");
            int birthdayYear = 1998;
            employees1 = getEmployeesWithYearBirthday(employees, birthdayYear);
            printEmployees(employees1);
        }
        static List<Employee> getEmployeesWithIdGreaterThan(List<Employee> employees, int id)
        {
            return (from e in employees where e.id > id select e).ToList();

        }
        static List<Employee> getEmployeesWithAgeGreaterThan10AndPrefixNameIn(List<Employee> employees, String prefixName)
        {
            return (from e in employees where e.id > 10 && e.name.StartsWith(prefixName) select e).ToList();
        }
        static List<Employee> getEmployeesWithYearBirthday(List<Employee> employees, int yearBirthday)
        {

            return (from e in employees where e.birthDay.Year.Equals(yearBirthday) select e).ToList();
        }
        static void printEmployees(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
