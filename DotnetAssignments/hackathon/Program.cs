namespace hackathon
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

    public class StaffIdExistsException : Exception
    {
        public StaffIdExistsException() : base("Staff ID Exists") { }
    }

    public class StaffNameNullException : Exception
    {
        public StaffNameNullException() : base("Staff Name should not be Null") { }
    }

    public class InvalidStaffNameException : Exception
    {
        public InvalidStaffNameException() : base("Invalid Staff Name") { }
    }

    internal class Program
    {

        static List<Staff> staffList = new List<Staff>();
        static List<Student> studentList = new List<Student>();
        static int studentIdCounter = 1;

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Staff");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Display Students by Staff");
                Console.WriteLine("4. Display Students by Class");
                Console.WriteLine("5. Display and Write All Students to File");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

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
                        DisplayAndWriteAllStudentsToFile();
                        break;
                    case 6:
                        return;
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
                int staffId = Convert.ToInt32(Console.ReadLine());

                if (staffList.Exists(s => s.StaffId == staffId))
                    throw new StaffIdExistsException();

                Console.Write("Enter Staff Name: ");
                string staffName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(staffName))
                    throw new StaffNameNullException();

                staffList.Add(new Staff { StaffId = staffId, StaffName = staffName });
                Console.WriteLine("Staff successfully added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

                if (!staffList.Exists(s => s.StaffName == staffName))
                    throw new InvalidStaffNameException();

                studentList.Add(new Student
                {
                    StudentID = studentIdCounter++,
                    Name = studentName,
                    DOB = dob,
                    Gender = gender,
                    Class = className,
                    Section = section,
                    StaffName = staffName
                });
                Console.WriteLine("Successfully added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DisplayStudentsByStaff()
        {
            Console.Write("Enter Staff Name: ");
            string staffName = Console.ReadLine();

            var students = studentList.FindAll(s => s.StaffName == staffName);

            if (students.Count > 0)
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"StudentID: {student.StudentID}, Name: {student.Name}, Class: {student.Class}, Section: {student.Section}");
                }
            }
            else
            {
                Console.WriteLine("No students found for the given staff.");
            }
        }

        static void DisplayStudentsByClass()
        {
            Console.Write("Enter Class: ");
            string className = Console.ReadLine();

            var students = studentList.FindAll(s => s.Class == className);

            if (students.Count > 0)
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"StudentID: {student.StudentID}, Name: {student.Name}, Section: {student.Section}, Staff: {student.StaffName}");
                }
            }
            else
            {
                Console.WriteLine("No students found for the given class.");
            }
        }

        static void DisplayAndWriteAllStudentsToFile()
        {
            using (StreamWriter writer = new StreamWriter("D:\\Dotnet\\Dotnetc#\\students.txt"))
            {
                foreach (var student in studentList)
                {
                    string studentInfo = $"StudentID: {student.StudentID}, Name: {student.Name}, Class: {student.Class}, Section: {student.Section}, Staff: {student.StaffName}";
                    Console.WriteLine(studentInfo);
                    writer.WriteLine(studentInfo);
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Student details have been written to students.txt");
        }
    }
}
