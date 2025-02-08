using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;

class Solution{

    static void Main(){
         Console.WriteLine(string.Join(" | ", GroupAnagrams(new string[] { "pots", "spot", "tops", "post", "stop", "opts",  
    "snap", "pans", "span", "naps", "maps", "amps",  
    "evil", "live", "vile", "veil", "levi", "lave",  
    "care", "race", "acre", "earc", "acer", "bear",  
    "stab", "bats", "tabs", "bas", "abts", "star",  
    "read", "dear", "dare", "ared", "rade", "red",  
    "tea", "eat", "ate", "eta", "tae", "sea",  
    "rat", "tar", "art", "tra", "atr", "bat",  
    "god", "dog", "odg", "gdo", "dgo", "tad"} ).Select(group => string.Join(", ", group))));
    }
    /*static List<List<string>> GroupAnagrams(string[] strs){
        Dictionary<string,List<string>> AnagramGorups = [];

        for(int i = 0;i<strs.Length;i++){

            char[] characters = strs[i].ToCharArray();
            Array.Sort(characters);
            string word = new(characters);

            if(!AnagramGorups.ContainsKey(word)){
                AnagramGorups[word]=new List<string>();
            }
            AnagramGorups[word].Add(strs[i]);
        }
        return AnagramGorups.Values.ToList();
    }*/
    static List<List<string>> GroupAnagrams(string[] strs){
        //Create A HashMap With The Key Being A String Of Numbers And The Value Being A List Of Anagrams
        var HashMap = new Dictionary<string, List<string>>();
        //forevery word in strings, initialize a count(key) with 26 letters
        foreach(string s in strs){
            int[] count = new int[26];
            //for every character in word we are going to subtract it by 'a' to get the index, increment at that index
            foreach(char c in s){
                count[c-'a']++;
            }
            //form the key out of our integer array
            string key = string.Join(",",count);
            //if the hashmap doens't contain the key then we will initialize a new key under the number string
            if(!HashMap.ContainsKey(key)){
                HashMap[key] = [];
            }
            //if the hashmap does contain the key then we will add the word to the corresponding key
            HashMap[key].Add(s);
        }
        //return the nested list of anagrams in proper order.
        return HashMap.Values.ToList<List<string>>();
    }
}




