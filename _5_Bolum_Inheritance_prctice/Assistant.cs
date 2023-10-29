public class Assistant:Teacher{
    public double Salary { get; set; }
     public string ShowSub(){
        return Subject;
    } 
    public Assistant()
    {
        
    }
    public Assistant(string name):base(name)
    {
        
    }
    public Assistant(string name, int age, string subject):base(name,age,subject)
    {
        
    }
    public Assistant(string name, int age, string subject,double Salary)
    :base(name,age,subject)
    {
        this.Salary = Salary;
    }
    public override string ShowInfomation()
    {
        return base.ShowInfomation()+$"\nSalary: {Salary}";
    }
}