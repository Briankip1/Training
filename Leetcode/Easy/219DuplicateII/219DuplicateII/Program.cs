// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length && j <= i + k; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }

}

