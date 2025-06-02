public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries) {
        int size = nums.Length;
        int[] deletionCount = new int[size + 1];
        foreach (var query in queries)
        {
            int l = query[0], r = query[1];
            deletionCount[l]++;
            deletionCount[r + 1]--;
        }
        for (int i = 1; i <= size; i++)
        {
            deletionCount[i] += deletionCount[i - 1];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (deletionCount[i] < nums[i])
            {
                return false;
            }
            
        }
        return true;
    }
}
