public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool inc=true;
        bool dec=true;
        for(int i=0;i<nums.Length-1;i++){
           if(nums[i]>nums[i+1]){
               dec=false;
           }
        }
        for(int i=0;i<nums.Length-1;i++){
           if(nums[i]<nums[i+1]){
               inc=false;
           }
        }
        return inc||dec;
    }
}
