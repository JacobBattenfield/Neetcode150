class Program{
    static void Main(){
        Console.WriteLine(LongestConsecutive([2,20,4,10,3,4,5]));
        Console.WriteLine(LongestConsecutive([0,3,2,5,4,6,1,1]));
        Console.WriteLine(LongestConsecutive([1,2,3,4,5,6,7,20,8,423,424,425]));
    }
    //The longest consecutive sequence will be the length of the sequence in which one number is one away from another number
    static int LongestConsecutive(int[] nums){
        // keep a hashset that is a direct copy of num array
        HashSet<int> numSet = new HashSet<int>(nums);
        //our longest value starts at 0
        int longest = 0;
        //forever num in our hashset we will check if it doesn't contain one less than itself, if it doesn't its length is 0
        foreach(int num in numSet){
            if(!numSet.Contains(num-1)){
                int length=1;
                //while we have a consecutive sequence we are going to count up the length of the sequence
                while(numSet.Contains(num+length)){
                    length++;
                }
                // the longest is going to equal the max between the longest value with length
                longest=Math.Max(longest,length);
            }

        }
        return longest;
        
    }
}