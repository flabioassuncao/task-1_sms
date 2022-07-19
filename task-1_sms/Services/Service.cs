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
            for (var j = i + 1; j < numbers.Length; j++)
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

    /// <summary>
    /// This method will find the maximum product between two numbers from the array, that is a multiple of 3. (liner complexity)
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns>int</returns>
    public static int FindTheMaximumProductBetweenTwoNumbersFromArray2(int[] numbers)
    {
        var finalResult = 0;

        Array.Sort(numbers);

        var multiplesOf3 = numbers.Where(c => c.IsDivisibleBy3()).ToArray();
        
        var nonMultiplesOf3 = numbers.Where(c => !c.IsDivisibleBy3()).ToArray();
        
        if (multiplesOf3.Length > 1)
        {
            // the result of multiple of 3 * multiples of 3 is a multiples of 3
            finalResult = multiplesOf3[^1] * multiplesOf3[^2];
        }

        var tempResult = multiplesOf3[^1] * nonMultiplesOf3[^1];

        return tempResult > finalResult ? tempResult : finalResult;
    }
}