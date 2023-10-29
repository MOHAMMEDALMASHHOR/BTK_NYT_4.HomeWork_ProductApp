public class Teacher : Person{
    public string? Subject { get; set; }
    public Teacher():base()
    {
        
    }
    public Teacher(string name):base(name)
    {
        
    }
    public Teacher(string name, int age):base(name, age)
    {
        
    }
    public override string ShowInfomation()
    {
        return base.ShowInfomation()+$"\nThe Subject: {Subject}";
    }
    public Teacher(string name, int age, string Subject):base(name,age)
    {
        this.Subject = Subject;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}