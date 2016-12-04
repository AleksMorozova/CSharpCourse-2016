namespace Task_8_5
{
    public class Car
    {
        public string Name { get; private set; }

        public int IssueYear { get; private set; }

        public Car(string name, int issueYear)
        {
            Name = name;
            IssueYear = issueYear;
        }
    }
}