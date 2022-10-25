public class Course
{
    public int Id {get; set;}
    public string Title {get;set;}= null !;
    public int Credit {get;set;}
    public List<Enrollement> Enrollements {get;set;} = new List<Enrollement>();

    public Course(int id, string title, int credit,List<Enrollement> enrollements)
    {
        Id =id;
        Title =title;
        Credit =Credit;
        Enrollements = enrollements;
    }
    public Course()
    {}


}