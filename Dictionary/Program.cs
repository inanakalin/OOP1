using Dictionary;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, StudentData> students = new Dictionary<int, StudentData>();
        StudentData student1 = new StudentData();
        student1.Name = "İnan";
        student1.Surname = "Akalın";
        student1.Class = 11;

        StudentData student2 = new StudentData() { Class = 5, Name = "Nazlı", Surname= "Akalın"};
        StudentData student3 = new StudentData() { Name = "Ali", Surname = "Veli", Class = 10 };
        students.Add(1, student3);
        students.Add(2, student2);  
        students.Add(3, student1);

        Console.WriteLine(students[1].Name + " " + students[1].Surname + " " + students[1].Class);



    }
}