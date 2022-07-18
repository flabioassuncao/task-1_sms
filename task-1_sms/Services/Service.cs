using task_1_sms.Utils;

namespace task_1_sms.Services;

public static class Service
{
    /// <summary>
    /// This method will find the maximum product between two numbers from the array, that is a multiple of 3.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns>int</returns>
    public static int FindTheMaximumProductBetweenTwoNumbersFromArray(int[] numbers)
    {
        var finalResult = 0;
        for (var i = 0; i < numbers.Length - 1; i++)
        {
            for (var j = i + 1 ; j < numbers.Length; j++)
            {
                var result = numbers[i] * numbers[j];
                
                if (finalResult >= result) continue;
                
                if (result.IsDivisibleBy3())
                {
                    finalResult = result;
                }
            }
        }

        return finalResult;
    }
}