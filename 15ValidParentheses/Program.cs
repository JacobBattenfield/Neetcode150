class Program{
    static void Main(){
        Console.WriteLine(IsValid("[]"));
        Console.WriteLine(IsValid("([{}])"));
        Console.WriteLine(IsValid("[)])"));
    }
    static bool IsValid(string s){
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> CloseToOpen = new Dictionary<char, char>{
            {')','('},
            {']','['},
            {'}','{'},
        };
        foreach(char c in s){
            if(CloseToOpen.ContainsKey(c)){
                if(stack.Count>0&&stack.Peek()==CloseToOpen[c]){
                    stack.Pop();
                }else{
                    return false;
                }
            }else{
                stack.Push(c);
            }
        }
        return true;
    }
}