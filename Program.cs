namespace ConsoleApp11
{
    internal class Program
    {
        enum DayOfWeekEnum { Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье };

        delegate string GetNextDayOfWeekDelegate();
        static void Main(string[] args)
        {
            int currentDayIndex = -1;

            GetNextDayOfWeekDelegate getNextDay = () =>
            {
                currentDayIndex = (currentDayIndex + 1) % Enum.GetValues(typeof(DayOfWeekEnum)).Length;
                return ((DayOfWeekEnum)currentDayIndex).ToString();
            };

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"День недели - {getNextDay()}");
            }
        }
    }
}