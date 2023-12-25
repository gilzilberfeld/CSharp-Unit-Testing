namespace UnitTestingCourse.Solution.ex4.Refactoring.ex6.Notify
{
    internal class MockNotifier : INotificationService
    {
        public string notification_log="";
        public void NotifyTownCrier(string message)
        {
            notification_log += message;
            notification_log += "\n";
        }
    }
}
