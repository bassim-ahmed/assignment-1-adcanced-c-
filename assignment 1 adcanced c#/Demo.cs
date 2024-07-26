using assignment_1_adcanced_c_.Generics;
using System.Drawing;
using System.Xml;

namespace assignment_1_adcanced_c_
{
  
    internal class Demo
    {
        static void Main(string[] args)
        {
            #region  Generis [swap ex]
            //int A = 20;
            //int B = 30;
            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"b:{B}");
            //Helper.Swap( ref A,ref B );
            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"b:{B}");
            //double A = 2.4;
            // double B = 3.5;
            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"b:{B}");
            // Helper.Swap(ref A, ref B);
            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"b:{B}");
            //Generics.Point point01 = new Generics.Point(1, 2);
            //Generics.Point point03= new Generics.Point(5, 3);
            //Console.WriteLine(point01);
            //Console.WriteLine(point03);
            //Console.WriteLine("=====================");
            //Helper.Swap(ref point01,ref point03);
            //Console.WriteLine(point01);
            //Console.WriteLine(point03);
            #endregion
            #region Generis [search ex]
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            //int index= Helper.SearchArray(numbers,5);
            //Console.WriteLine(index);
            //Employee employee = new Employee()
            //{
            //    Id = 1,
            //    Name = "Test",
            //    Salary = 3444
            //};
            //Employee employee2 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Test",
            //    Salary = 3444
            //};
            //Console.WriteLine($"Hash code of employee{employee.GetHashCode()}");
            //Console.WriteLine($"Hash code of employee2{employee2.GetHashCode()}");
            //if (employee == employee2) //with class (refrence)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("not Equal");
            //}
            //if (employee.Equals(employee2)) {

            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("not Equal");
            //}
            // equal ->[struct] compare object state(data) 
            //equal ->[class] compare between refrence{Identity}

            //Employee employee = new Employee()
            //{
            //    Id = 1,
            //    Name = "Test",
            //    Salary = 3444
            //};
            //Employee employee2 = new Employee()
            //{
            //    Id = 2,
            //    Name = "mohamed",
            //    Salary = 45555
            //};
            //Employee[] employees = new Employee[2]
            // {
            //    employee , employee2
            //};
            //int Index=Helper<Employee>.SearchArray(employees, employee2);
            //Console.WriteLine(Index);

            #endregion
            #region Equality [Class and Struct)
            //int[] numbers = { 1, 5, 3, 7, 5 };
            //foreach (int number in numbers) {
            //    Console.Write($"{number}");

            //}
            //Helper<int>.BubbleSort( numbers );
            //foreach (int number in numbers) {

            //    Console.Write($"{number}");

            //}
            //Employee[] employee = new Employee[]
            //{
            //    new Employee() {Id=10,Name="bassim",Salary=2999 },
            //    new Employee() {Id=30,Name="ahmed",Salary=2999 },
            //    new Employee() {Id=40,Name="kamal",Salary=2000 },
            //    new Employee() {Id=20,Name="ramadan",Salary=1000 }
            //};
            //Helper<Employee>.BubbleSort(employee);
            //Generics.Point[] points =
            //    {
            //  new Generics.Point(7,2),
            //  new Generics.Point(5,4),
            //    new Generics.Point(2,5)
            //};
            //Helper<Generics.Point>.BubbleSort(Generics.Point);
            #endregion





        }
    }
}
