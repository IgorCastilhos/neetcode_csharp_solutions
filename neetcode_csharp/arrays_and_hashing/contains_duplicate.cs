namespace neetcode_csharp.arrays_and_hashing;

public class ContainsDuplicate
{
    public bool CheckForDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums)
        {
            if (!seen.Add(num))
            {
                return true;
            }

            seen.Add(num);
        }

        return false;
    }
}

// Time complexity: O(n)
// Space complexity: O(n)
