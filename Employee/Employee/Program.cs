namespace App

{

    internal class Employee
    {

        private string name;
        private String Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name can not be blanck");
                }
            }
            get
            {
                return name;
            }
        }
        private int empNo;
        public int EmpNo
        {
            set
            {
                if (value > 0)
                {
                    empNo = value;
                }
                else
                {
                    Console.WriteLine("Employee no should be grater than 0");
                }
            }
            get
            {
                return empNo;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value >= 10000 && value <= 150000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("basis should be in between 10000 and 150000");

                }
            }
            get
            {
                return basic;
            }
        }

        public short deptNo;
        private short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Department no should be grater than 0");

                }
            }
            get
            {
                return deptNo;
            }
        }


        public Employee(int empNo, string name = "", decimal basis = 0, short deptNo = 0)
        {
            this.EmpNo = empNo;
            this.Name = name;
            this.Basic = basis;
            this.DeptNo = deptNo;
        }


        public decimal GetNetSalary()
        {
            return (decimal)12 * basic;
        }


        public string ToString()
        {
            return "EmpId: " + empNo + " Name: " + name + " basic: " + basic + " deptNo: " + deptNo;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {

            Employee emp = new Employee(12, "", 15000, 4);
            Console.WriteLine(emp.GetNetSalary());
            Console.WriteLine(emp.ToString());
        }
    }
}