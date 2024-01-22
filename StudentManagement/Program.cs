// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using StudentManagement;

void PrintStudentInfo(List<Student> studentList)
{
    Console.WriteLine("====================\nStudent Information:\n====================\n------------------------------------------");
    foreach (Student stu in studentList)
    {
        Console.WriteLine("Name : {0} \nID : {1}\nDOB : {2}\nEmail : {3}\nPersonal phone : {4}\n------------------------------------------", stu.name, stu.generateId(), stu.GetDOB(), stu.GetEmail(), stu.phoneNumber);
    }
}
Student stu1 = new Student();
stu1.SetName("Le Van Nam");
stu1.SetDOB(new DateTime(1999, 12, 30));
stu1.SetEmail(stu1.name);
stu1.phoneNumber = "012-345-678";
Student stu2 = new Student();
stu2.SetName("Le Nguyen Minh");
stu2.SetDOB(new DateTime(1999, 2, 5));
stu2.SetEmail(stu2.name);
stu2.phoneNumber = "012-345-679";

List<Student> students = new List<Student>();
students.Add(stu1);
students.Add(stu2);
PrintStudentInfo(students);
