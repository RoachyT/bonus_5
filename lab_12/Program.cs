using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Program
    {
        static List<Person> people = new List<Person>()
        {   //student order string degreeProgram, int year, double fee, string lastname, firstname, string address)
            //staff order string school, double pay, string name, string address
            //Archieved Student Order  double finalScore, string degreeProgram, int year, double fee, string name, string address
            new Student("Dentistry", 2008, 8889.98, "Sherman", "P.", "42 Wallaby Way Sydney"),
            new Staff("Hogwarts", 120000, "Black", "Sirius", "12 Grimmauld Place"),
            new Staff("Project Mayhem", 0, "Durden", "Tyler", "420 Paper St."),
            new Student("Quantum Physics", 2021, 9823.23, "Griffin", "Stewie ", "31 Spooner Street"),
            new Student("Boating License", 2001, 55, "SquarePants", "SpongeBob ","124 Conch Street"),
            new ArchivedStudent(88, "Art and History", 1989, 12569,"Preston, Esq.", "Bill S. ", "123 Cherry Lane")
        };
        Validation val = new Validation();
        static string  studprogInput, studLNameInput, studFNameInput, studAddressInput, currentStud;
        static double  studfeeInput;
        static int studyearinput, studFinalScore;

        static void Main(string[] args)
        {
            Pathway();
            Console.ReadKey();
        }

        static void Pathway()
        {
            Console.WriteLine("What would you like to do? Press:");
            Console.WriteLine("1 to Add a Student\n2 to Show the List\n3 to leave ");
                
            int choosePath = int.Parse(Console.ReadLine());
            if (choosePath == 1)
            {
                //add student
                AddStudent();
            }

            else if (choosePath == 2)
            {
                //print list 
                PrintMe();
            }
            else if (choosePath == 3)
            {
                //leave 
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("That was nonesense.");
                Pathway();
            }
            
            Looper();
        }

        static void AddStudent()
        {
            Console.WriteLine("Would you like to add a student? y/n");
            string addStudinput = Console.ReadLine().ToLower();

            if (addStudinput == "yes" || addStudinput == "y")
            {
                Adding();
            }
            else if (addStudinput == "no" || addStudinput == "n")
            {
                Pathway();
            }
            else
            {
                Console.WriteLine("That was nonsense, again");
                AddStudent();
            }

        }
        static void Adding()
        {
            bool flag = true;
            try
            {
                while (flag)
                {

                    //student order string degreeProgram, int year, double fee, string name, string address)
                    Console.WriteLine("What is the student's first name?");
                    Validation.AreLettersValid(studFNameInput = Console.ReadLine());
                    Console.WriteLine("What is the student's last name?");
                    Validation.AreLettersValid(studLNameInput = Console.ReadLine());
                    Console.WriteLine($"What is {studFNameInput}\'s address?");
                    studAddressInput = Console.ReadLine();
                    Console.WriteLine($"What is {studFNameInput}\'s program or degree?");
                    studprogInput = Console.ReadLine();
                    Console.WriteLine($"what is {studFNameInput}\'s graduating year?");
                    studyearinput = int.Parse(Console.ReadLine());
                    Console.WriteLine($"What is {studFNameInput}\'s tuition cost?");
                    studfeeInput = double.Parse(Console.ReadLine());
                    Console.WriteLine("Is this a current Student? y/n");
                    currentStud = Console.ReadLine().ToLower();
                    if (currentStud == "yes" || currentStud == "y")
                    {
                        people.Add(new Student(studprogInput, studyearinput, studfeeInput, studLNameInput, studFNameInput, studAddressInput));
                        Console.WriteLine($"{studFNameInput} has been added successfully!");
                        Console.WriteLine();
                        Pathway();
                    }
                    else if (currentStud == "no" || currentStud == "n")
                    {
                        Console.WriteLine("What is the students final score?");
                        Validation.BetweenOneHundred(studFinalScore = int.Parse(Console.ReadLine()));
                        people.Add(new ArchivedStudent(studFinalScore, studprogInput, studyearinput, studfeeInput, studLNameInput, studFNameInput, studAddressInput));
                        Console.WriteLine($"{studFNameInput} has been added successfully!");
                        Console.WriteLine();
                        Pathway();

                    }
                    else
                    {
                        Console.WriteLine("What?");
                        flag = false;
                        AddStudent();

                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("What?");
                AddStudent();

            }

        }
        
        

        static void PrintMe()
        {
            people.Sort();
            foreach (Person p in people)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine();
            }
        }

        static void Looper()
        {
            Console.WriteLine("Continue? y/n: ");
            string goAgain = Console.ReadLine().ToLower();
            if (goAgain == "yes" || goAgain == "y")
            {
                Pathway();
            }
            else if (goAgain == "no" || goAgain == "n")
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
               
            }
            else
            {
                Console.WriteLine("That was pure nonsense");
                Looper();
            }
        }
    }
}
