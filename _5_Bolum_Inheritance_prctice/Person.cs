public class Person{
    public string? Name { get; set; }
    public int Age { get; set; }
    public Person()
    {
        
    }
    public Person(string name):this()
    {
        Name = name;
    }
    public Person(string name, int age):this(name)
    {
        Age = age;
    }
    public virtual string ShowInfomation(){
        return ToString()+"\n\n"+$"The person's name: {Name}\nAge:{Age}";
    }
    public override string ToString()
    {
        return "Samsun University is welcoming you";
    }
}