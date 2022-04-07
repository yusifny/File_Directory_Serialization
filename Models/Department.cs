using System;
using System.Collections.Generic;

namespace File_Directory_Serialization.Models
{
	public class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);  
        }

        public Employee GetEmployeeById(int? id)
        {
            if (id == null){
                throw new Exception("Doğru bir ID daxil edin");
            }
           return Employees.Find(e => e.Id == id);
        }

        public void RemoveEmployee(int? id)
        {
            if (id == null){
                throw new NullReferenceException("ID düzgün daxil edilməyib.");
            }

           Employee ep = Employees.Find(e => e.Id == id);
            Employees.Remove(ep);
        }
    }
}

