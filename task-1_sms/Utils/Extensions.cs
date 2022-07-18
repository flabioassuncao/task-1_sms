namespace task_1_sms.Utils;

public static class Extensions
{
    public static bool IsDivisibleBy3(this int number)
    {
        return number % 3 == 0;
    }
}