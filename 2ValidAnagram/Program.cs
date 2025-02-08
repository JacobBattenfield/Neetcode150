class Program(){
    static void Main(){
        Console.WriteLine(ValidAnagram("hydroxydeoxycorticosterones","hydroxydesoxycorticosterone"));
        Console.WriteLine(ValidAnagram("cat","tac"));
        Console.WriteLine(ValidAnagram("ham","hat"));
    }

    static bool ValidAnagram(string One, string Two){
        //build a key for word one
        int[] lol = new int[26];
        foreach (char c in One){
            lol[c-'a']++;
        }
        //build a key for word two
        int[] far = new int[26];
        foreach (char c in Two){
            far[c-'a']++;
        }
        Console.WriteLine(string.Join("",lol));
        Console.WriteLine(string.Join("",far));
        //compare the keys
        if(string.Join("",far)==string.Join("",lol)){
            return true;
        }
        return false;
        
    }
}