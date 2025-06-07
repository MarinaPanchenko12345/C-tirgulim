namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a list of Objects
            Console.WriteLine("List Students");
            List<Student> lstStudent  = new List<Student>();
            lstStudent.Add(new Student());
            lstStudent[0].Name = "Donald";
            lstStudent[0].GPA = 3.2;
            lstStudent.Add(new Student());
            lstStudent[1].Name = "Nik";
            lstStudent[1].GPA = 4.0;

            foreach (Student student in lstStudent)
            {
                Console.WriteLine(student.getData());
            }
            Console.ReadLine(); 
        }
    }
}
