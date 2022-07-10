using ex18_composicao.Entities.Enums;
using System.Collections.Generic;

namespace ex18_composicao.Entities
{
    internal class Worker
    {
        
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
                
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double income = BaseSalary;
            foreach (HourContract contr in Contracts)
            {
                if (contr.Date.Year == year && contr.Date.Month == month)
                {
                    income += contr.TotalValue();
                }
            }
            
            return income;
        }
    }
}
