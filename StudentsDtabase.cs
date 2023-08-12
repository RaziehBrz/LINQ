using System.Linq;

class StudentDatabase
{
    public static IQueryable<Student> GetStudentFromDB()
    {
        return new[]
        {
            new Student() {StudentId = 1 , StudentName = "John Nigel" , Score = 38 , City = "CA" , IsActive = true} ,
            new Student() {StudentId = 2 , StudentName = "Alex Roma" , Score = 88 , City = "NYC" , IsActive = false} ,
            new Student() {StudentId = 3 , StudentName = "Noha Shamil" , Score = 90 , City = "CA" , IsActive = false} ,
            new Student() {StudentId = 4 , StudentName = "James Palatte" , Score = 40 , City = "NYC" , IsActive = true} ,
            new Student() {StudentId = 5 , StudentName = "Ron Jenova" , Score = 67 , City = "CA" , IsActive = true}
        }.AsQueryable();
    }
}