namespace CSharp_Hackthon
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string StaffName { get; set; }
    }

    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
    }

    // Custom Exceptions
    public class StaffIdExistsException : Exception
    {
        public StaffIdExistsException(string message) : base(message) { }
    }

    public class StaffNameNullException : Exception
    {
        public StaffNameNullException(string message) : base(message) { }
    }

    public class InvalidStaffNameException : Exception
    {
        public InvalidStaffNameException(string message) : base(message) { }
    }

    // Main Program
    class HackThon
    {
        static List<Staff> staffs = new List<Staff>();
        static List<Student> students = new List<Student>();
        static int studentCounter = 1;

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Staff");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Display Students by Staff");
                Console.WriteLine("4. Display Students by Class");
                Console.WriteLine("5. Display and Write All Students to File");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStaff();
                        break;
                    case 2:
                        AddStudent();
                        break;
                    case 3:
                        DisplayStudentsByStaff();
                        break;
                    case 4:
                        DisplayStudentsByClass();
                        break;
                    case 5:
                        DisplayAndWriteAllStudents();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddStaff()
        {
            try
            {
                Console.Write("Enter Staff ID: ");
                int staffId = int.Parse(Console.ReadLine());

                Console.Write("Enter Staff Name: ");
                string staffName = Console.ReadLine();

                if (string.IsNullOrEmpty(staffName))
                {
                    throw new StaffNameNullException("Staff Name should not be Null");
                }

                if (staffs.Exists(s => s.StaffId == staffId))
                {
                    throw new StaffIdExistsException("Staff ID Exists");
                }

                staffs.Add(new Staff { StaffId = staffId, StaffName = staffName });
                Console.WriteLine("Staff successfully added.");
            }
            catch (StaffIdExistsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (StaffNameNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        static void AddStudent()
        {
            try
            {
                Console.Write("Enter Student Name: ");
                string studentName = Console.ReadLine();

                Console.Write("Enter DOB (yyyy-mm-dd): ");
                DateTime dob = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter Gender: ");
                string gender = Console.ReadLine();

                Console.Write("Enter Class: ");
                string className = Console.ReadLine();

                Console.Write("Enter Section: ");
                string section = Console.ReadLine();

                Console.Write("Enter Staff Name: ");
                string staffName = Console.ReadLine();

                if (!staffs.Exists(s => s.StaffName.Equals(staffName, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new InvalidStaffNameException("Invalid Staff Name");
                }

                students.Add(new Student
                {
                    StudentID = studentCounter++,
                    Name = studentName,
                    DOB = dob,
                    Gender = gender,
                    Class = className,
                    Section = section,
                    StaffName = staffName
                });

                Console.WriteLine("Successfully added");
            }
            catch (InvalidStaffNameException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        static void DisplayStudentsByStaff()
        {
            Console.Write("Enter Staff Name: ");
            string staffName = Console.ReadLine();

            var filteredStudents = students.FindAll(s => s.StaffName.Equals(staffName, StringComparison.OrdinalIgnoreCase));

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine("No students found for the given staff.");
            }
            else
            {
                foreach (var student in filteredStudents)
                {
                    DisplayStudentInfo(student);
                }
            }
        }

        static void DisplayStudentsByClass()
        {
            Console.Write("Enter Class: ");
            string className = Console.ReadLine();

            var filteredStudents = students.FindAll(s => s.Class.Equals(className, StringComparison.OrdinalIgnoreCase));

            if (filteredStudents.Count == 0)
            {
                Console.WriteLine("No students found for the given class.");
            }
            else
            {
                foreach (var student in filteredStudents)
                {
                    DisplayStudentInfo(student);
                }
            }
        }

        static void DisplayAndWriteAllStudents()
        {
            string filePath = "D:/students.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var student in students)
                {
                    DisplayStudentInfo(student);
                    writer.WriteLine($"{student.StudentID}, {student.Name}, {student.DOB:yyyy-MM-dd}, {student.Gender}, {student.Class}, {student.Section}, {student.StaffName}");
                    writer.WriteLine(); // Give a line after writing each student
                }
            }
            Console.WriteLine($"All students have been written to {filePath}");
        }

        static void DisplayStudentInfo(Student student)
        {
            Console.WriteLine($"ID: {student.StudentID}, Name: {student.Name}, DOB: {student.DOB:yyyy-MM-dd}, Gender: {student.Gender}, Class: {student.Class}, Section: {student.Section}, Staff: {student.StaffName}");
        }
    }
}