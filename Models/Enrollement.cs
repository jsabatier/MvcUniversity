public class Enrollement
{
    public int Id {get;set;}

    public Grade? Grade { get; set;}
    public int StudentId {get;set;}
    public int CourseId {get;set;}
    //public Student Student {get;set;}
    public Course Course {get;set;} =null!;
    public Student Student {get;set;} = null!;

    public Enrollement( int id,Grade grade,int studentId,int courseId,Course course)
    {
        Id =id;
        Grade =grade;
        StudentId =studentId;
        CourseId = courseId;
        Course =course;
    }
     public Enrollement( int id,int studentId,int courseId,Course course)
    {
        Id =id;
        StudentId =studentId;
        CourseId = courseId;
        Course =course;
    }
    public Enrollement()
    {}
}