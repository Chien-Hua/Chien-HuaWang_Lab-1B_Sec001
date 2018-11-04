using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chien_HuaWang_Lab_1B_Ex04
{
    class Test
    {
               static void Main(string[] args)
        {

            int initialEmploteeId = 100;
            int dictionaryIds = 0;
            SortedDictionary<int, Employee> employeeDict = new SortedDictionary<int, Employee>();
            AddDictionaryItem((dictionaryIds + 1), employeeDict, new Employee((initialEmploteeId + 1), "Hua", "Wang", 3111.37));
            AddDictionaryItem((dictionaryIds + 2), employeeDict, new Employee((initialEmploteeId + 2), "Hank", "Lin", 3404.04));
            AddDictionaryItem((dictionaryIds + 3), employeeDict, new Employee((initialEmploteeId + 3), "Edward", "Chen", 2727.39));
            AddDictionaryItem((dictionaryIds + 4), employeeDict, new Employee((initialEmploteeId + 4), "Denny", "Hao", 1110.11));
            AddDictionaryItem((dictionaryIds + 5), employeeDict, new Employee((initialEmploteeId + 5), "Mary", "Sham", 2220.22));

            Console.WriteLine($"There are currently {employeeDict.Count} employees:\n");
            DisplayDictionary(employeeDict);
            RemoveDictionaryItem(1, employeeDict);
            Console.WriteLine($"Remaining {employeeDict.Count} Employees after deleting the first employee\n");
            DisplayDictionary(employeeDict);
            Console.WriteLine("Searching the third Employee:\n");
            SearchDictionaryItem(3, employeeDict);
            Console.WriteLine("\nDisplaying the maximum salary employee is:\n");
            MaxDictionaryItem(employeeDict);
            Console.WriteLine("\n");
        }

        private static void AddDictionaryItem(int dictId, SortedDictionary<int, Employee> empDict, Employee emp)
        {
            empDict.Add(dictId, emp);
        }
        private static void RemoveDictionaryItem(int empId, SortedDictionary<int, Employee> empDict)
        {
            empDict.Remove(empId);
        }
        private static void DisplayDictionary<K, V>(SortedDictionary<K, V> empDict)
        {
            foreach (var key in empDict.Keys)
            {
                Console.WriteLine($"{empDict[key]}\n");
            }
        }
        private static void SearchDictionaryItem(int empId, SortedDictionary<int, Employee> empDict)
        {
            Employee employee;

            if (empDict.TryGetValue(empId, out employee))
            {
                Console.WriteLine($"Key {empId}:");
                Console.WriteLine($"{employee}");

            }
            else
            {
                Console.WriteLine($"\nThe key {empId} does not exist!!!");
            }
        }

        private static void MaxDictionaryItem(SortedDictionary<int, Employee> empDict)
        {
            double maxSalary = 0.00;
            int employeeId = 0;

            foreach (var key in empDict.Keys)
            {
                if (empDict[key].Salary > maxSalary)
                {
                    employeeId = key;
                    maxSalary = empDict[key].Salary;
                }
            }

            Console.WriteLine($"\nThe highest salary employee is:\n");
            Console.WriteLine($"Employee Key {employeeId}:");
            Console.WriteLine($"{empDict[employeeId]}");

        }

    }
}
