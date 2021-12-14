// See https://aka.ms/new-console-template for more information


using UsersConsoleApp1;

//User user1 = new User("yafit", "samuel", 1998, "@fdvgr");
//User user2 = new User("tikva", "samuel", 1992, "@ndskss");
//User user3 = new User("eden", "samuel", 1994, "@yafit");
//User user4 = new User("amir", "samuel", 1990, "@oonfnf");


//List<User> usersList = new List<User>();
//usersList.Add(user1);
//usersList.Add(user2);
//usersList.Add(user3);
//usersList.Add(user4);
//foreach (User itemUser in usersList)
//{
//    itemUser.ToString();
//}
//usersList.Sort();
//foreach (User itemUser in usersList)
//{
//    itemUser.ToString();
//}

List<Student> stuList = new List<Student>();


Student stu1 = new Student("yaf", "sam", 2000, "from@fr", "A");
Student stu2 = new Student("tikva", "yosef", 1992, "@yafit", "c");
Student stu3 = new Student("eden", "tasama", 1994, "@yafit", "b");
Student stu4 = new Student("amir", "mangisto", 1990, "@oonfnf", "a");

stuList.Add(stu1);
stuList.Add(stu2);
stuList.Add(stu3);
stuList.Add(stu4);

//foreach (Student itemStudent in stuList)
//{
//    itemStudent.Tostring();
//}
//Print(stuList);
//WriteToConsole(Console.ReadLine());



//6
void PrintToFile(List<Student> stuList)
{
    FileStream fs = new FileStream(@"C:\TEST\Students.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(fs))
    {
        for (int i = 0; i < stuList.Count; i++)
        {
            writer.WriteLine($"{stuList[i].firstName} {stuList[i].lastName} {stuList[i].yearOfBirth} {stuList[i].email}");
        }
    }
}
PrintToFile(stuList);

//7
void PrintToConsole()
{
    FileStream file = new FileStream(@"C:\TEST\Students.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(file))
    {
        Console.WriteLine(reader.ReadToEnd());
    }
}



//8
void Print(List<Student> stuList)
{
    for (int i = 0; i < stuList.Count; i++)
    {
        FileStream file = new FileStream($@"C:\TEST\{stuList[i].firstName} {stuList[i].lastName}.txt", FileMode.Append);
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine($"{stuList[i].firstName} {stuList[i].lastName} {stuList[i].yearOfBirth} {stuList[i].email}");
        }
    }
}


//9
void WriteToConsole(string Name)
{
    FileStream file = new FileStream($@"C:\TEST\{Name}.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(file))
    {
        Console.WriteLine(reader.ReadToEnd());
    }
}

//case 1
void AddToFile(List<Student> stuList)
{
    FileStream fs = new FileStream(@"C:\TEST\addStudents.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(fs))
    {
        for (int i = 0; i < stuList.Count; i++)
        {
            writer.WriteLine($"{stuList[i].firstName} {stuList[i].lastName} {stuList[i].yearOfBirth} {stuList[i].email}");
        }
    }
}
void EditToFile()
{
    Console.WriteLine("choos a name ");
    string nameFile = Console.ReadLine();

    FileStream file1 = new FileStream($@"C:\TEST\{nameFile}.txt", FileMode.Create);
    using (StreamWriter writer = new StreamWriter(file1))
    {
        writer.WriteLine(Console.ReadLine());
    }

}



void DeleteFromFile()
{
    Console.WriteLine("enter a name");
    string name = Console.ReadLine();

    File.Delete($@"C:\TEST\{name}.txt");

}



int Menu()
{
    Console.WriteLine("hello!");
    Console.WriteLine("to add atudent pres 1");
    Console.WriteLine("to add edit pres 2");
    Console.WriteLine("to delete atudent pres 3");

    int UserNunber = int.Parse(Console.ReadLine());
    return UserNunber;
}


void start()
{

    switch (Menu())
    {
        case 1:
            AddToFile(stuList);
            break;
        case 2:

            EditToFile();
            break;
        case 3:
            DeleteFromFile();
            break;

    }
}
start();




