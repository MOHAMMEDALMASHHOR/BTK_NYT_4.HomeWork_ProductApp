public class Student:Person{
    public int Id { get; set; }
    public override string ShowInfomation()
    {
        return base.ShowInfomation()+$"\nThe Id: {Id}";
    }
}