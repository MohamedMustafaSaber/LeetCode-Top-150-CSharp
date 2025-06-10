public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> ItemsCounter = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if (ItemsCounter.ContainsKey(i))
                ItemsCounter[i]++;
            else
                ItemsCounter[i] = 1;
        }

        List<int[]> array = ItemsCounter.Select(i=> new int[] {i.Value, i.Key}).ToList();
        array.Sort((a,b) => b[0].CompareTo(a[0]));

        int[] res = new int[k];
        for (int i = 0; i < k; i++)
        {
            res[i] = array[i][1];
        }
        return res;
    }
}