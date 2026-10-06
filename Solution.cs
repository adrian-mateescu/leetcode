public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexByValue = new Dictionary<int, int>();

        for (var index = 0; index < nums.Length; index++)
        {
            var complement = target - nums[index];
            if (indexByValue.TryGetValue(complement, out var complementIndex))
            {
                return [complementIndex, index];
            }

            indexByValue[nums[index]] = index;
        }

        throw new ArgumentException("No two numbers add up to the target.");
    }
}