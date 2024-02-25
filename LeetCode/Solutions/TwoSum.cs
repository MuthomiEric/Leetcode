namespace LeetCode.Solutions
{
    public static class TwoSum
    {
        //Time Complexity O(n log n)
        //Space Complexity O(n)
        public static int[] Sum(int[] nums, int target)
        {
            Dictionary<int, int> picked = new Dictionary<int, int>();

            int l = 0, r = nums.Length - 1;

            while (l <= r)
            {
                var lDiff = target - nums[l];

                var rDiff = target - nums[r];

                if (picked.ContainsKey(lDiff))
                {
                    return [picked[lDiff], l];
                }

                if (picked.ContainsKey(rDiff))
                {
                    return [picked[rDiff], r];
                }

                if ((lDiff + rDiff) == target)
                {
                    return [l, r];
                }

                if (!picked.ContainsKey(nums[l]))
                {
                    picked.Add(nums[l], l);

                }

                if (!picked.ContainsKey(nums[r]))
                {
                    picked.Add(nums[r], r);

                }

                l++;

                r--;
            }

            return [];
        }

        //Time Complexity O(n)
        //Space Complexity O(n)
        public static int[] Sum2(int[] nums, int target)
        {
            Dictionary<int, int> picked = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (picked.ContainsKey(diff))
                {
                    return [picked[diff], i];
                }

                picked.Add(nums[i], i);
            }

            return [];
        }

    }
}
