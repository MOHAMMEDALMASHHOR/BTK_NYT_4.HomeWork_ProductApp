Teacher teacher = new Teacher();
teacher.Name = "Mohammed Almashhor";
teacher.Age = 23;
teacher.Subject = "Math";
Teacher teacher1 = new Teacher("Manger");
System.Console.WriteLine(teacher.ShowInfomation());
System.Console.WriteLine(teacher1.ShowInfomation());
   
Assistant assistant = new Assistant("Ali",19,"Math",40_000);
System.Console.WriteLine(assistant.ShowInfomation());
System.Console.WriteLine( assistant.ShowSub());