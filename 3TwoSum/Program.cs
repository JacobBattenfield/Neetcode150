using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

class Program{
    static void Main(){
        Console.WriteLine(string.Join(" ",TwoSum([3,4,5,6],7)));
        Console.WriteLine(string.Join(" ",TwoSum([4,5,6],10)));
        Console.WriteLine(string.Join(" ",TwoSum([5,3,4,2,1,5],10)));

    }
    static int[] BruteForce(int[] nums, int target){
        for(int i = 0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]+nums[j]==target){
                    return new int[] {i,j};
                }
            }
        }
        return[0,0];
    }
    static int[] TwoSum(int[] nums,int target){
        //initialize a hashset called visited to store numbers you've checked
        HashSet<int> Visited = [];
        //for each number in the number array we will check if the target minus it exists in the hashset
        for(int i = 0;i<nums.Length;i++){
            int diff = target-nums[i];
            //if the hashset contains the difference then we can return the index of the two numbers
            if(Visited.Contains(diff)){
                return[Array.IndexOf(nums,diff),i];
            }
            //if it doesn't then we can add the number to the hashset
            Visited.Add(nums[i]);
        }
        //failure case: This works in one pass
        return [];
    }
}