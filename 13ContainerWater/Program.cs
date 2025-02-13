class Program{
    static void Main(){
        Console.WriteLine(MaxArea([1,3,6,2,5,10,4,8,3,7]));
    }
    static int MaxArea(int[] heights){
        int ans = 0;
        int l = 0;
        int r = heights.Length-1;
        while(l<r){
            int area = Math.Min(heights[l],heights[r])*(r-l);
            ans = Math.Max(area,ans);
            if(heights[l]<=heights[r]){
                l++;
            }else{
                r--;
            }
        }
        return ans;
    }
}