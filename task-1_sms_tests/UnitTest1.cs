using Xunit;
using task_1_sms.Services;

namespace task_1_sms_tests;

public class UnitTest1
{
    [Theory]
    [InlineData(new[] {6, 8, 8, 7, 2, 5}, 48)]
    [InlineData(new[] {1, 9, 2, 4}, 36)]
    public void Should_FindTheMaximumProductBetweenTwoNumbers_FromTheArray_ThatIsMultipleOf3(int[] numbers, int expectedResult)
    {
        var result = Service.FindTheMaximumProductBetweenTwoNumbersFromArray(numbers);
        Assert.Equal(expectedResult, result);
    }
}