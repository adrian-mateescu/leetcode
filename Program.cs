var solution = new Solution();
var nums = new[] { 2, 7, 11, 15 };
var target = 9;
var expected = new[] { 0, 1 };
var actual = solution.TwoSum(nums, target);

if (!expected.SequenceEqual(actual))
{
    Console.Error.WriteLine($"Two Sum failed. Expected [{string.Join(", ", expected)}], got [{string.Join(", ", actual)}].");
    return 1;
}

Console.WriteLine("Two Sum: passed");
return 0;