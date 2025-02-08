using System.Security.Permissions;
using System.Text;
using System.Xml.XPath;

class Program{
    static void Main(){
        Console.WriteLine(Encode(["Hi","You","Are","Magnanamous","in","Everysingleway!"]));
        Console.WriteLine(string.Join(",",Decode(Encode(["Hi","You","Are","Magnanamous","in","Everysingleway!"]))));
    }
    static string Encode(List<string> strs){
        //store each word in a encoded string beginning with the length of each word and a delimeter
        string result = "";
        foreach(string str in strs){
            result+=str.Length+"#"+str;
        }
        return result;
    }
    static List<string> Decode(string encoded){
        //W algorithm tbh.
        List<string> decodedStrings = new();
        int index = 0;
        while(index < encoded.Length){
            int separatorIndex =encoded.IndexOf('#',index);
            int Length = int.Parse(encoded[index..separatorIndex]);

            index = separatorIndex+1;
            decodedStrings.Add(encoded.Substring(index,Length));
            index+=Length;
        }
        return decodedStrings;
    }
}

