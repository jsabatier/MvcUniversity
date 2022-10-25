public class SeedData
{
    public static void Init()
    {
        var context = new UniversityContext();
        Student carson = new Student
{
    FirstName = "Alexander",
    LastName = "Carson",
    EnrollementDate = DateTime.Parse("2016-09-01"),
};
Student alonso = new Student
{
    FirstName = "Meredith",
    LastName = "Alonso",
    EnrollementDate = DateTime.Parse("2018-09-01"),
};
Student anand = new Student
{
    FirstName = "Arturo",
    LastName = "Anand",
    EnrollementDate = DateTime.Parse("2019-09-01"),
};
Student barzdukas = new Student
{
    FirstName = "Gytis",
    LastName = "Barzdukas",
    EnrollementDate = DateTime.Parse("2018-09-01"),
};
context.Students.AddRange(
    carson,
    alonso,
    anand,
    barzdukas
);
context.SaveChanges();
// Add courses
Course chemistry = new Course
{
    Id = 1050,
    Title = "Chemistry",
    Credit = 3
};
Course microeconomics = new Course
{
    Id = 4022,
    Title = "Microeconomics",
    Credit = 3
};
Course macroeconmics = new Course
{
    Id = 4041,
    Title = "Macroeconomics",
    Credit = 3
};
Course calculus = new Course
{
    Id = 1045,
    Title = "Calculus",
    Credit = 4
};
context.Courses.AddRange(
    chemistry,
    microeconomics,
    macroeconmics,
    calculus
);
context.SaveChanges();
// Add enrollments
context.Enrollements.AddRange(
    new Enrollement
    {
        Student = carson,
        Course = chemistry,
        Grade = Grade.A
    },
    new Enrollement
    {
        Student = carson,
        Course = microeconomics,
        Grade = Grade.C
    },
    new Enrollement
    {
        Student = alonso,
        Course = calculus,
        Grade = Grade.B
    },
    new Enrollement
    {
        Student = anand,
        Course = chemistry,
    },
    new Enrollement
    {
        Student = anand,
        Course = microeconomics,
        Grade = Grade.B
    },
    new Enrollement
    {
        Student = barzdukas,
        Course = chemistry,
        Grade = Grade.C
    }  
);
context.SaveChanges();
    }
}