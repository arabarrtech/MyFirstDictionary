using System;

namespace Collections;

public class Dictionary
{
    static void Main()
    {
        var alphabetDictionary = new Dictionary< char, string >();
        alphabetDictionary.Add('A', "Apple");
        alphabetDictionary.Add('B',"Bat");
        alphabetDictionary.Add('C',"Car");
        alphabetDictionary.Add('D',"Dog");
        alphabetDictionary.Add('E',"Egg");
        alphabetDictionary.Add('F',"Fish");
        alphabetDictionary.Add('G',"Gold");
        alphabetDictionary.Add('H',"House");
        alphabetDictionary.Add('I',"Ink");
        alphabetDictionary.Add('J',"Jug");
        alphabetDictionary.Add('K',"Key");
        alphabetDictionary.Add('L',"Light");
        alphabetDictionary.Add('M',"Man");
        alphabetDictionary.Add('N',"NJh");
        alphabetDictionary.Add('O',"Orange");
        alphabetDictionary.Add('P',"Prince");
        alphabetDictionary.Add('Q',"Queen");
        alphabetDictionary.Add('R',"Rabbit");
        alphabetDictionary.Add('S',"Skd");
        alphabetDictionary.Add('T',"Toy");
        alphabetDictionary.Add('U',"Uranum");
        alphabetDictionary.Add('V',"Vuisd");
        alphabetDictionary.Add('W',"Window");
        alphabetDictionary.Add('X',"Xja");
        alphabetDictionary.Add('Y',"Yale");
        alphabetDictionary.Add('Z',"Zip");
        Console.Write("char, string");

        foreach (var a in alphabetDictionary)
        {
            Console.WriteLine($"{a.Key} => {a.Value}");
        }
    }

    
}
