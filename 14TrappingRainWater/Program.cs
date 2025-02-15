class Program{
    static void Main(){
        Console.WriteLine(Trap([0,2,0,3,1,0,1,3,2,1]
));
    }
    static int Trap(int[] heights){
        if(heights==null||heights.Length==0){
            return 0;
        }
        int l = 0;
        int r = heights.Length-1;
        int MaxLeft = heights[l];
        int MaxRight = heights[r];
        int res = 0;
        while(l<r){
            if(MaxLeft<MaxRight){
                l++;
                MaxLeft=Math.Max(MaxLeft,heights[l]);
                res+=MaxLeft-heights[l];
            }else{
                r--;
                MaxRight=Math.Max(MaxRight,heights[r]);
                res+=MaxRight-heights[r];
            }

        }
        return res;


    }
}