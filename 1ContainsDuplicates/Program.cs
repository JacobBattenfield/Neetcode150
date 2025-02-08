using System.Runtime.InteropServices;

class Program{
    static void Main(){
        Console.WriteLine(LogarithmicDuplicate([1,6,4,7,8,9,19]));
        Console.WriteLine(BruteForceDuplicate([1,6,4,7,8,9,19]));
        Console.WriteLine(ContainsDuplicate([1,6,4,7,8,9,19]));


        Console.WriteLine(LogarithmicDuplicate([1,6,4,7,8,9,1]));
        Console.WriteLine(BruteForceDuplicate([1,6,4,7,8,9,1]));
        Console.WriteLine(ContainsDuplicate([1,6,4,7,8,9,1]));

    }
    //O(n^2)
    static bool BruteForceDuplicate(int[] array){
        for(int i = 0;i<array.Length;i++){
            for(int j = i+1;j<array.Length;j++){
                if(array[i]==array[j]){
                    return true;
                }
            }
        }
        return false;
    }
    //O(n log n)
    static bool LogarithmicDuplicate(int[] array){
        Array.Sort(array);
        for(int i = 0;i<array.Length-1;i++){
            if(array[i]==array[i+1]){
                return true;
            }
        }
        return false;
    }
    //O(n)
    static bool ContainsDuplicate(int[] array){
        HashSet<int> SeenNums = [];
        for(int i = 0;i<array.Length;i++){
            if(SeenNums.Contains(array[i])){
                return true;
            }
            SeenNums.Add(array[i]);
        }
        return false;
    }
}