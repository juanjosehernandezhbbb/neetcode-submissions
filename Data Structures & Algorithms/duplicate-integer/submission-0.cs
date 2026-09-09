

public class Solution {
    public bool hasDuplicate(int[] nums) {

bool duplicate=false;

for (int i = 0; i < nums.Length; i++)
{
    for (int j = i+1; j < nums.Length; j++)
    {
        if (nums[i] == nums[j])
        {
            duplicate = true; break;
        }       
     }
}
return duplicate;
    }
}