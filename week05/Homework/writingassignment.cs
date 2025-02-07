public class WritingAssignment : Assignment
{
    private string _title;
    private string _problems;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title, string problems)
        : base(studentName, topic) // Calling the base class constructor
    {
        _title = title;
        _problems = problems;
    }

    // Method to get the writing information
     public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"title {_title} problems {_problems}";
    }
}
