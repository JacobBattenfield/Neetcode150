class Program{
    static void Main(){
        Console.WriteLine(LongestConsecutive([2,20,4,10,3,4,5]));
        Console.WriteLine(LongestConsecutive([0,3,2,5,4,6,1,1]));
    }
    //The longest consecutive sequence will be the length of the sequence in which one number is one away from another number
    static int LongestConsecutive(int[] nums){
        HashSet<int> numSet = [.. nums];
        int longest = 0;

        foreach(int num in numSet){
            if(!numSet.Contains(num-1)){
                int length=1;
                while(numSet.Contains(num+length)){
                    length++;
                }
                longest=Math.Max(longest,length);
            }

        }
        return longest;
        
    }
}