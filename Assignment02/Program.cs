using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment02

{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //Employees Emp;
            //Emp = new Employees(1, "Omar", "4", 8000, new HiringDate(2023, 10, 19), 'M');
            //Emp.salary = 5000;
            //Console.WriteLine(Emp);
            Employees[] EmpArr = new Employees[3];
            EmpArr[0] = new Employees(1, "Omar", "2", 8000, new HiringDate(10,2,2020), 'M');
            EmpArr[1] = new Employees(2, "Ahmed", "3", 9000, new HiringDate(8,9,2019), 'M');
            EmpArr[2] = new Employees(3, "Aya", "1", 4000, new HiringDate(1,1,2025), 'F');

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i]);
                Console.WriteLine("------------------------------------------------\n");

            }


        }
    }
}
