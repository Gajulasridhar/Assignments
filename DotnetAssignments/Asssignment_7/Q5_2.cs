using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Tasks
{
    interface IRepository
    {
        void AddStudent(StudentDetails student);
        List<StudentDetails> GetAllStudents();
        StudentDetails GetStudent(int id);
        void RemoveStudent(int id);
        void UpdateStudent(StudentDetails student);
    }

    class StudentRepository : IRepository
    {
        List<StudentDetails> sd = new List<StudentDetails>();

        public void AddStudent(StudentDetails student)
        {
            sd.Add(student);
        }

        public List<StudentDetails> GetAllStudents()
        {
            return sd;
        }

        public StudentDetails GetStudent(int id)
        {
            foreach (StudentDetails student in sd)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public void RemoveStudent(int id)
        {
            StudentDetails studentToRemove = null;
            foreach (StudentDetails student in sd)
            {
                if (student.Id == id)
                {
                    studentToRemove = student;
                    break;
                }
            }
            if (studentToRemove != null)
            {
                sd.Remove(studentToRemove);
            }
        }

        public void UpdateStudent(StudentDetails student)
        {
            for (int i = 0; i < sd.Count; i++)
            {
                if (sd[i].Id == student.Id)
                {
                    sd[i].Name = student.Name;
                    sd[i].Branch = student.Branch;
                }
            }
        }
    }



    internal class Five_2
    {
        static void Main()
        {
            StudentRepository studentRepository = new StudentRepository();
            try
            {
                do
                {
                    Console.WriteLine("1. Add\n2. GetById\n3. GetAll\n4. Update\n5. Delete\n6. Exit");
                    Console.WriteLine("Select Option");
                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            {
                                StudentDetails student_details = new StudentDetails();
                                student_details.Id = new Random().Next();
                                Console.WriteLine("Enter Your name");
                                student_details.Name = Console.ReadLine();
                                Console.WriteLine("Enter your branch");
                                student_details.Branch = Console.ReadLine();
                                studentRepository.AddStudent(student_details);
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Enter Student Id");
                                int id = int.Parse(Console.ReadLine());
                                StudentDetails student_details = studentRepository.GetStudent(id);
                                if (student_details != null)
                                {
                                    Console.WriteLine(student_details.ToString());
                                }
                                else
                                {
                                    Console.WriteLine("Invalid id");
                                }
                                break;
                            }

                        case 3:
                            {
                                List<StudentDetails> student_details = studentRepository.GetAllStudents();
                                if (student_details.Count > 0)
                                {
                                    foreach (var item in student_details)
                                    {
                                        Console.WriteLine(item.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("List is empty");
                                }
                            }
                            break;

                        case 4:
                            {
                                StudentDetails student_details = new StudentDetails();
                                Console.WriteLine("Enter id of the user");
                                student_details.Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Name");
                                student_details.Name = Console.ReadLine();
                                Console.WriteLine("Enter Branch");
                                student_details.Branch = Console.ReadLine();
                                studentRepository.UpdateStudent(student_details);
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("Enter student id");
                                int id = int.Parse(Console.ReadLine());
                                studentRepository.RemoveStudent(id);
                            }
                            break;
                        case 6:
                            {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}