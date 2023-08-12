internal class Program
{
    private static void Main(string[] args)
    {
        var studentList = StudentDatabase.GetStudentFromDB();

        var query1 = studentList.Where(x => x.IsActive &&
                                            x.Score > 80 &&
                                            x.City == "NYC");

        var query2 = studentList.Where(x => x.Score > 80 ||
                                       x.City == "CA")
                                .Select(x => x.StudentName);

        var query3 = studentList.Where(x => x.StudentName.ToUpper().StartsWith('B'))
                               .Select(x => new MinimalStudent()
                               {
                                   StudentName = x.StudentName
                               });

        var query4 = studentList.Where(x => !x.IsActive)
                                .OrderByDescending(x => x.Score);

        var query5 = studentList.Average(x => x.Score);

        var query6 = studentList.Where(x => x.City == "CA" &&
                                       x.IsActive &&
                                       (x.StudentName.ToUpper().Contains('R') ||
                                       x.StudentName.ToUpper().Contains('D')))
                                .Average(x => x.Score);
    }
}