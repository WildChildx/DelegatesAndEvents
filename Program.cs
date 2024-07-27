namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);


            del1(5, WorkType.GenerateReports);

            Console.Read();
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("Work performed 1 called");
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("Work performed 2 called");
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports,
    }
}