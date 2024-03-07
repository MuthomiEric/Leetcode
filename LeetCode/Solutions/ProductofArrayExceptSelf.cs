namespace LeetCode.Solutions
{
    internal static class ProductofArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            // 1,2,3,4
            int len = nums.Length;

            int[] output_arr = new int [len];

            output_arr[0] = 1;

            for (var i = 1; i < len; i++)
            {
                output_arr[i] = nums[i - 1] * output_arr[i - 1];
            }

            int prod = 1;

            for (var i = len - 1; i >= 0; i--)
            {
                output_arr[i] = output_arr[i] * prod;

                prod *= nums[i];
            }

            return output_arr;
        }
    }
}
