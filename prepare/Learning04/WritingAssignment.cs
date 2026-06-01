using System;

class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        string writingInformation = $"{_title} by {studentName}";
        return writingInformation;
    }

}