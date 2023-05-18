 
public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
       Array.Sort(people);
        int l=0,r=people.Length-1;
        int ans=0;
        while(l<r){
            if(people[l]+people[r]<=limit){
                ans++;
                r--;
                l++;
            }
            else{
                ans++;
                r--;
            }
        }
        if(l==r){
            ans++;
        }

        return ans;
    }
}
