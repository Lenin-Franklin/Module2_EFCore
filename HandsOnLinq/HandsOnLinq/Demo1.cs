using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HandsOnLinq
{
    class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Designation { get; set; }
    }

    class Demo1
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(){Eid=1,Ename="Rohan",Designation="Programmer"},
                 new Employee(){Eid=2,Ename="Karam",Designation="Programmer"},
                  new Employee(){Eid=3,Ename="Chran",Designation="TeamLead"},
                   new Employee(){Eid=4,Ename="Suren",Designation="Programmer"},
                    new Employee(){Eid=5,Ename="Ram",Designation="Programmer"},
                     new Employee(){Eid=6,Ename="Bheem",Designation="TeamLead"},
                      new Employee(){Eid=7,Ename="Krishna",Designation="Programmer"},
                       new Employee(){Eid=8,Ename="Sachin",Designation="Programmer"},
            };
            //Fetching Employee Sorted By Ename
            var result = from e in list orderby e.Ename ascending select e;
            result = list.OrderBy(i => i.Ename);
            //Fetching all employees working as Programmer
            var result1 = list.Where(i => i.Designation == "Programmer").OrderBy(i => i.Ename);
            result1 = from e in list where e.Designation == "Programmer" orderby e.Ename select e;
            //Fetch Employee record with Id=2
            var result2 = list.Where(i => i.Eid == 2);
            Employee e1 = list.SingleOrDefault(i => i.Eid == 2); //return single object or null
            List<Employee> list1 = list.Where(i => i.Designation == "TeamLead").ToList();
            foreach (var item in result)
                Console.WriteLine($"{item.Eid} {item.Ename} {item.Designation}");
            //fetch Eid,Ename who are working as TeamLead
            var result3 = from i in list where i.Designation == "TeamLead" 
                          select new { Eid = i.Eid, Ename = i.Ename };
            foreach (var item in result3)
                Console.WriteLine($"{item.Ename} {item.Ename}");
            Console.WriteLine();
            //using group by
            var result4 = from i in list group i by i.Designation;
           result4= list.GroupBy(i => i.Designation);
            foreach(var item in result4)
            {
                Console.WriteLine($"Employees working as {item.Key}");
                foreach(var emp in item)
                {
                    Console.WriteLine($"{emp.Ename}");
                }
            }
            Employee e2 = list.First(i => i.Designation=="TeamLeader"); //retusn exception when conditon false
            e2 = list.FirstOrDefault(i => i.Designation == "TeamLeader");//returns null when condition false
            e2= list.LastOrDefault(i => i.Designation == "TeamLeader"); //in sequence return last record
            e2= list.Last(i => i.Designation == "TeamLeader"); //in sequence return last record when there is not data throw excepetion


        }
    }
}
