namespace Assignment5
{

    internal class Employee
    {
        private string name;
        private String Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name should not be null");
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
                    throw new Exception("Employee no should be grater than 0");
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
                   throw new ArgumentException("basis should be in between 10000 and 150000");
                }
            }
            get
            {
                return basic;
            }
        }

        public int deptNo;
        private int DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                   throw new ArgumentException("Department no should be grater than 0");

                }
            }
            get
            {
                return deptNo;
            }
        }


        public Employee(int empNo, string name = "", decimal basic = 0, int deptNo = 0)
        {
            this.EmpNo = empNo;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
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





          

            List<Employee> list = new List<Employee>();
            try
            {
                bool check = true;
                for (int i = 0; check; i++)
                {
                    Console.WriteLine("Accept details of Employee: yes/no");
                    string check1 = Console.ReadLine();
                    if (check1 == "yes")
                    {
                        Console.WriteLine("Enter employee detils: empId,name,basic,deptNo");
                        list.Add(new Employee(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Convert.ToDecimal(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                        
                    }
                    else
                    {
                        check = false;
                    }
                }
                foreach (Employee e in list)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Employee list to Employee array:");
            Employee[] employees= new Employee[list.Count()];
            int a = 0;
            foreach(Employee e in list) 
            {
                employees[a++] = e;
            }
           
            for(int j=0;j<employees.Length;j++)
            {
                Console.WriteLine(employees[j].ToString());
            }

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Employee array to Employee List");
            List<Employee> empList= new List<Employee>();

            for(int k=0;k<employees.Length;k++)
            {
                empList.Add(employees[k]);
            }

            foreach(Employee e in empList)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}