
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(){
        Console.WriteLine(string.Join(", ",TopKFrequent([7,7],1)));
    }
    static int[] TopKFrequent(int[] nums, int k){
        //initialize a key value pair where the key is the number and the value is the count
        var HashMap = new Dictionary<int,int>();
        foreach(int num in nums){
            //if our hashmap doesn't already contain the number then we will initialize it with the count of 0
            if(!HashMap.ContainsKey(num)){
                HashMap[num]=0;
            } 
            //if our hashmap does contain the number then we will increment by one
            HashMap[num]++;
        }
        //initialize a priority queue to get the biggest value
        var heap = new PriorityQueue<int,int>();
        foreach(var entry in HashMap){
            //Enter Every Single Value Into THe Queue
            heap.Enqueue(entry.Key,entry.Value);
            //If Our Heap Count Is Bigger Than K, Remove First In Line.
            if(heap.Count>k){
                heap.Dequeue();
            }
        }
        //for return value
        int[] result = new int[k];
        //for every value up to k number
        for(int i = 0;i<k;i++){
            //the next k biggest ones are added on to the result
            result[i]=heap.Dequeue();
        }
        //return result
        return result;
    }

}