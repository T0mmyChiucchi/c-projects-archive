namespace Student.BlaisePascal.Domain
{
    public class Grade
    {
        public  int Value { get; private set; }
        public string Subject { get; private set; }

        public DateTime Date;

        public Grade(int value, string subject)
        {
            Value = value;
            Subject = subject;
            Date = DateTime.Now;
        }
    }
}
