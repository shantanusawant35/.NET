namespace ConsoleApp1
{

    internal class Employee {
        private string name;
        private String Name
        {
            set
            {
                if(value != null)
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
        private static int id = 0;
        private  int empNo;
        public  int EmpNo
        {
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
                if (value>=10000 && value <= 150000)
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


        public Employee(string name="",decimal basis=0,short deptNo = 0)
        {
            this.Name = name;
            this.Basic = basis;
            this.DeptNo = deptNo;
            this.empNo = ++id;
        }

        public Employee()
        {
            this.empNo = ++id;
        }
        public decimal GetNetSalary()
        {
            return (decimal)10 * basic;
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
            Console.WriteLine("Hello, World!");
            Employee o1 = new Employee("Amol",123456,10);
            Console.WriteLine("Net salary : "+o1.GetNetSalary());
            Console.WriteLine(o1.ToString());
            Employee o2 = new Employee();
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o2.ToString());

        }
    }
}