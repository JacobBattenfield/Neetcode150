using System.Net.NetworkInformation;

class Program{
    static void Main(){
        Console.WriteLine(string.Join(",",ProductsOfArrayExceptSelfBrute([1,2,4,6])));
        Console.WriteLine(string.Join(",",ProductsOfArrayExceptSelfEfficient([4,2,3,5]))); //expected 2048 1024 64 64
    }


    //brute force approach
    static int[] ProductsOfArrayExceptSelfBrute(int[] nums){
        int[] res = new int[nums.Length];
        for(int i = 0;i<nums.Length;i++){
            int product = 1;
            for(int j = 0;j<nums.Length;j++){
                if(j!=i){
                    product *= nums[j];
                }
            }
            res[i] = product;
        }
        return res;
    }
    static int[] ProductsOfArrayExceptSelfEfficient(int[] nums){
        int[] res = new int[nums.Length];
        int[] pre = new int[nums.Length];
        int[] suf = new int[nums.Length];

        pre[0] = 1;
        suf[nums.Length-1]=1;
        for(int i = 1;i<nums.Length;i++){
            pre[i] = nums[i-1]*pre[i-1];
        }
        for(int i =nums.Length-2;i>=0;i--){
            suf[i] = nums[i-1]*suf[i+1];
        }
        for(int i = 0;i<nums.Length;i++){
            res[i] = pre[i]*suf[i];
        }
        return res;
    }
}