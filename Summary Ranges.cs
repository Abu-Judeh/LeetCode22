public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> res = new List<string>();
        if (nums.Length == 0) return res;
        int start = nums[0];
        int end = nums[0];
        foreach (int num in nums.Skip(1))
        {
            if(num== end || num==end+1 )
            {
                end = num;
            }
            else
            {
                if(start==end)
                {
                    res.Add(start.ToString());
                }
                else
                {
                    res.Add(start.ToString() + "->" + end.ToString());
                }
                start = end = num;
            }
        }
        string te;
        if (start == end)
        {
            te=start.ToString();
        }
        else
        {
            te = start.ToString() + "->" + end.ToString();
        }
        if(!res.Contains(te))
        {
            res.Add(te);
        }

        return res;
    }
}
