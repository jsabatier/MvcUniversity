public class Student
{
public int Id{get;set;}
public string LastName {get; set;}= null!;
public string FirstName{get;set;}=null!;
public DateTime EnrollementDate{get;set;}
public List<Enrollement> Enrollements {get;} = new List<Enrollement>();

public Student(int id,string lastName, string firstName, DateTime enrollementDate,List<Enrollement> enrollements)
{
    Id =id;
    LastName =lastName;
    FirstName = firstName;
    EnrollementDate= enrollementDate;
    Enrollements = enrollements;

}
public Student ()
{
    
}

}
