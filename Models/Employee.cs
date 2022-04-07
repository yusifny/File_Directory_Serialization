using System;
namespace File_Directory_Serialization.Models
{
	public class Employee
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public string ShowInfo(){
            return $"ID: {Id}\n Name: {Name}\n Salary: {Salary}";
        }
    }
}

