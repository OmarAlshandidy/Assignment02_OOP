using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public enum SecurityPrivileges
    {
        Guest=1,
        Developer=2,
        Secretary=3,
        DBA=4
    }
    internal class Employees
    {
        #region Attribute 

        private string Name;
        private char Gender;
        private decimal Salary;
        private HiringDate HireDate;
        private int ID;
        private SecurityPrivileges SecurityLevel;
        #endregion
        // Constructor 
        public Employees(int ID ,string Name  , string securityLevel , decimal Salary , HiringDate HireDate , char Gender)
        {
            this.ID = ID;
            this.Name = Name;
            this.SecurityLevel = (SecurityPrivileges)Enum.Parse(typeof(SecurityPrivileges), securityLevel.ToString(), true);
            this.Salary = Salary;
            this.HireDate = HireDate;
            this.Gender = Gender;

        }
        #region property

        public int Id
        {

            get { return ID; }
            set { ID = value; }
        }
        public string name 
        {

            get { return Name; }
            set { Name = value; }
        }
        public SecurityPrivileges securityLevel
        {

            get { return SecurityLevel; }
            set { SecurityLevel = value; }
        }
        public  decimal salary
        {

            get { return Salary; }
            set {Salary = value; }
        }
        public HiringDate hireDate
        {

            get { return HireDate; }
            set { HireDate = value; }
        }
        public char gender
        {

            get { return Gender; }
            set { Gender = value; }
        }
        #endregion

        #region Methodes 
        public override string ToString()
        {
            return $"Employee ID: {ID}\n  Name: {Name}\n Security Level: {SecurityLevel}\n Salary: {Salary:0$}\n Hire Date: {HireDate.ToString()}\n Gender: {(Gender == 'M' ? "Male" : "Female")}";
        }
        #endregion



    }
}

