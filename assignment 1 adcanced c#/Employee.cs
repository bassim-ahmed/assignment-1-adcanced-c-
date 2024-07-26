using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1_adcanced_c_
{
    internal class Employee:IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary{ get; set; }
        public override string ToString()
        {
            return $"{Id}:::{Name}:::{Salary}";
        }
        #region operatoers overloading

        ////==
        //public static bool operator ==(Employee left, Employee right)
        //{
        //    //Left.Id==Right.ID
        //    //Left.Name==Right.Name
        //    //Left.Salary==Right.Salary
        //    //return(left.Id ==  right.Id) &&(left.Name == right.Name)&&(left.Salary == right.Salary);
        //    return left.Equals(right)   ;
        //}
        //public static bool operator !=(Employee left, Employee right)
        //{
        //    //Left.Id!=Right.ID
        //    //Left.Name!=Right.Name
        //    //Left.Salary!=Right.Salary
        //    //return (left.Id != right.Id) || (left.Name != right.Name) || (left.Salary != right.Salary);
        //    return !left.Equals(right) ;
        //}



        #endregion
        public override bool Equals(object? obj)
        {
            Employee employee = obj as Employee;
            return (this.Id == employee.Id) && (this.Name == employee.Name) && (this.Salary == employee.Salary);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id.GetHashCode(),Name?.GetHashCode(),Salary.GetHashCode());    
        }
        //SORTING BASED ON Salary
        public int CompareTo(object? obj)
        {
            //Employee? PassedEmployee =(Employee?)obj;//unsafe 
            //  //explicit casting 
            //  //may throw Exception
            #region Is Conditional Operators [True|false]
            //this operators will return ture in 2 cases
            //1.obj is a Employee
            //2.obj is an object from class inherted from employee
            //if(obj is Employee PassedEmployee)
            //{
            //    return this.Salary.CompareTo(PassedEmployee.Salary);
            //}
            #endregion
            #region AS Casting Operators
            Employee? PassedEmployee= obj as Employee;
            //casting succeed in 2 casses
            //1.obj is Employee
            //2.obj is an object from classes inherited from employee
            //if failed will return Null
            //zero execption will be throw
            return this.Salary.CompareTo(PassedEmployee?.Salary);
            #endregion

            //return this.Salary.CompareTo(PassedEmployee?.Salary);
        }
    }
}
