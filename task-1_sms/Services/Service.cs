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
    /// This method will find the maximum product between two numbers from the array, that is a multiple of 3.
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

    /// <summary>
    /// This method will find the maximum product between two numbers from the array, that is a multiple of 3.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns>int</returns>
    public static int FindTheMaximumProductBetweenTwoNumbersFromArray3(int[] numbers)
    {
        var maxMultipleOf3_1 = int.MinValue;
        var maxMultipleOf3_2 = int.MinValue;

        var maxNonMultipleOf3_1 = int.MinValue;

        for (var i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].IsDivisibleBy3())
            {
                if (numbers[i] > maxMultipleOf3_1)
                {
                    maxMultipleOf3_2 = maxMultipleOf3_1;
                    maxMultipleOf3_1 = numbers[i];
                }
                else if (numbers[i] > maxMultipleOf3_2)
                {
                    maxMultipleOf3_2 = numbers[i];
                }
            }
            else
            {
                if (numbers[i] > maxNonMultipleOf3_1)
                {
                    maxNonMultipleOf3_1 = numbers[i];
                }
            }
        }

        return maxMultipleOf3_1 * (maxMultipleOf3_2 > maxNonMultipleOf3_1 ? maxMultipleOf3_2 : maxNonMultipleOf3_1);
    }
}