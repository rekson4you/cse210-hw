public class Job
{
    // Member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Method to display the job details
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

