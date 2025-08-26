using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Congruent_Solution
{

    //we have two entity -
    // teacher - id, firstname, lastname
    // student - studentid, firstname, lastname, teacherid(fk).
    // requiremenrt: fetch the teachid, teacherfirstname, lastname > 30 students
    //linq . 


    public class Teacher
    {
        public int TeacherID { get; set; }
        public string? TeacherFirstName { get; set; }
        public string? TeacherLastName { get; set; }
    }
    public class Students
    {
        public int StudentID { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public int TeacherID { get; set; }
    }
    //w.d.i.e.w : fetch the teacher details who have more than 30 students in there list by using the linq. 
    /*
     1, find the teacher who are handling more than 30 students
     2, get the teacher details
    */
    public class Startup
    {
        public static void NotMain()
        {
            //Congruent Question
            /*
            //mock database =>

            List<Students> studentList = new List<Students>
            {
                new Students{ StudentID = 1, StudentFirstName = "Anith", StudentLastName="Kesava", TeacherID =1 },
                new Students{ StudentID = 2, StudentFirstName = "Saravana", StudentLastName="Saran", TeacherID =1 },
                new Students{ StudentID = 3, StudentFirstName = "Sudalai", StudentLastName="Vignesh", TeacherID =2 },
                new Students{ StudentID = 4, StudentFirstName = "Kamaraj", StudentLastName="Palani", TeacherID =1 },
                new Students{ StudentID = 5, StudentFirstName = "Bala", StudentLastName="Vignesh", TeacherID =1 },
            };

            List<Teacher> teacherList = new List<Teacher>
            {
                new Teacher{ TeacherID = 1, TeacherFirstName = "Suresh", TeacherLastName = "Kumar" },
                new Teacher{ TeacherID = 2, TeacherFirstName = "Vaithee", TeacherLastName = "Lingham" },
            };

            //here we go =>
            var groupTeacherID = studentList.GroupBy(x=>x.TeacherID).Where(x=>x.Count() > 3).Select(x=>x.Key).ToList();
            Console.WriteLine("the teacher who are handling more than 3 students are: ");
            foreach (var teacherId in groupTeacherID)
            {
                var teacherDetails = teacherList.Where(x => x.TeacherID == teacherId).ToList();
                foreach(var teacher in teacherDetails)
                {
                    Console.Write("teacher id: "+teacher.TeacherID);
                    Console.Write(" teacher firstname: "+teacher.TeacherFirstName);
                    Console.Write(" teacher lastname: " + teacher.TeacherLastName);                                       
                }
            }
            */

            string s1 = new string("anith");
            string s2 = new string("anith");

            Console.WriteLine(s1 == s2);

            Console.ReadLine();
        }
    }
}

namespace manual_getter_setter
{
    public class Program
    {
        public static void NotMain()
        {
            Animal dog = new Dog("rottweiler", 3);
            Console.ReadLine();
        }
    }

    public class Employee
    {

        public Employee(string name)
        {
            _name = name;
        }
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be Null");
                }
                _name = value;
            }
        }

        public void getEmployeeName()
        {
            Console.WriteLine("the name of the employee: ", Name);
        }
    }

    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }
        public virtual void GetDetails()
        {
            Console.WriteLine("the animal :" + Name);
        }
    }

    public class Dog : Animal
    {
        public string Name{ get; set; }
        public int Age { get; set; }

        public Dog(string name,int age) : base(name)
        {
            this.Name = name;
            this.Age = age;
        }
        public override void GetDetails()
        {
            Console.WriteLine("the dog name: "+this.Name);
            Console.WriteLine("the dog age: "+this.Age);
        }
    }
}

namespace tryPassEncoding
{
    public class Program
    {
        public static void DontMain()
        {
            /*
            string password = "Anith@123";
            PasswordHash(password);
            */
            Console.WriteLine(ValidatePassword("Anith", "Anith"));
            Console.ReadLine();
        }

        public static void PasswordHash(string userpassword)
        {
            string password = "Anith@123";
            SHA256 hashalogorithm1 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = hashalogorithm1.ComputeHash(bytes);
            
            StringBuilder sb = new StringBuilder();
            foreach(var h in hash)
            {
                sb.Append(h.ToString("x2"));
            }
            Console.WriteLine(sb);

            SHA256 hashalogorithm2 = SHA256.Create();
            byte[] bytes2 = Encoding.UTF8.GetBytes(userpassword);
            byte[] hash2 = hashalogorithm2.ComputeHash(bytes2);
            StringBuilder sb2 = new StringBuilder();
            foreach(byte b in hash2)
            {
                sb2.Append(b.ToString("x2"));
            }
            Console.WriteLine(sb2);
            if(sb.Equals(sb2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static bool ValidatePassword(string oldpassword, string newpassword)
        {
            return oldpassword == newpassword;
        }
      
    }
}
