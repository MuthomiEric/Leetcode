namespace LeetCode.Solutions
{
    internal class ContainsDuplicate
    {
        public bool ContainsDuplicates(int[] nums)
        {
            var map = new HashSet<int>();

            foreach (int num in nums)
            {
                if (map.Contains(num))
                {
                    return true;
                }

                map.Add(num);
            }

            return false;
        }
    }
}
