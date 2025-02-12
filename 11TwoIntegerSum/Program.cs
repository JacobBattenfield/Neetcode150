class Program{
    static void Main(){
        Console.WriteLine(string.Join(",", TwoSum([1,2,3,4],3)));
    }
    static int[] TwoSum(int[] nums, int target){
        int StartPoint = 0;
        int EndPoint = nums.Length-1;
        
        while(StartPoint<EndPoint){
            if(nums[StartPoint]+nums[EndPoint]<target){
                StartPoint++;
            }
            if(nums[StartPoint]+nums[EndPoint]>target){
                EndPoint--;
            }
            if(nums[StartPoint]+nums[EndPoint]==target){
                return new int[] {StartPoint+1,EndPoint+1};
            }
        }
        return[0,0];
    }
}