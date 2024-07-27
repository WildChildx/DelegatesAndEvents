namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);

            DoWork(del1);

            Console.Read();
        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.Golf);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("Work performed 1 called " + hours);
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("Work performed 2 called " + hours);
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports,
    }
}