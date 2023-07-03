namespace ConsoleApp2
{

    internal interface DBFunctions {

    }


    internal abstract class Employee:DBFunctions
    {
        private string name;
        private string Name
        {
            set
            {
                if(value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name should not be blank");
                }
            }
            get
            {
                return name;
            }
        }
        private int empNo;
        private int EmpNo
        {
            get
            {
                return empNo;
            }
        }

        private short deptNo;
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
                    Console.WriteLine("Department numbert should be grater than zero");
                }
            }
            get
            {
                return deptNo;
            }
        }

       
       public abstract decimal Basis
        {
            get;
            set;
        }

        public abstract decimal ClaNetSalary();

        private static int id = 1000;
        public Employee(string name,short deptNo)
        {
            Console.WriteLine("Inside Employee class");
            this.Name = name;
            this.deptNo = deptNo;
            this.empNo = ++id;
        }

        public string ToString()
        {
            return "EmpNo: "+empNo+" Name: " + Name + " Depatment: " + DeptNo;
        }
        
    }


    class Manager : Employee, DBFunctions
    {


        private string designation;
        public string Designation
        {
            set
            {
                if(value != null && value != "")
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("Disignation can't blank");
                }
            }
            get
            {
                return designation;
            }
        }

        private decimal basis;

        public Manager(string name, short deptNo,decimal basis,string designamtion) : base(name, deptNo)
        {
            this.designation = designamtion;
            this.basis = basis;
        }

        public override decimal Basis {
            set
            {
                if (value > 200)
                {
                    basis = value;
                }
                
            }
            get
            {
                return basis;
            }
        }

        

        public override decimal ClaNetSalary()
        {
            return 12*basis;
        }

        public string ToString()
        {
            return base.ToString() + " Designation: " + designation + "  basis " + basis;
        }

    }

    internal class GeneralManager : Manager, DBFunctions
    {
        private string perks;

        public GeneralManager(string name, short deptNo, decimal basis, string designamtion,string perks) : base(name, deptNo, basis, designamtion)
        {
            this.perks = perks;
        }

        private string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }
        public string ToString()
        {
            return base.ToString() + "  Perks: " + perks;
        }

    }


    internal class CEO : Employee, DBFunctions
    {
        public CEO(string name, short deptNo,decimal basis) : base(name, deptNo)
        {
            this.basis = basis;
        }

        decimal CalNetSalary()
        {
            return Basis * 12;
        }

        public override decimal ClaNetSalary()
        {
            return basis* 12;
        }
        private decimal basis;
        public override decimal Basis
        {
            get
            {
                return basis;
            }
            set
            {
                basis = value;
            }

        }

        public string ToString()
        {
            return base.ToString() + "  basis " + basis;
        }

        
    }

    internal class Program
    {
        static void Main()
        {
            CEO ceo = new CEO("shant",12,45664);
            Console.WriteLine(ceo.ClaNetSalary());
            Console.WriteLine(ceo.ToString());
        }
    }





}