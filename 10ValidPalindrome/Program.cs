class Program{
    static void Main(){
        Console.WriteLine(IsPalindrome("0P"));
    }
    static bool IsPalindrome(string s){
        int i = 0;
        int j = s.Length-1;
        while(i<j){
            
            while(i<j&&!char.IsLetterOrDigit(s[i])) i++;
            while(i<j&&!char.IsLetterOrDigit(s[j])) j--;
            Console.WriteLine($"{s[i]}{s[j]}");
            if(char.ToLower(s[i])!=char.ToLower(s[j]))return false;
            i++;
            j--;
        }
        return true;
    }
}