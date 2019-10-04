using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week3 : MonoBehaviour
{
    /*
     * Create a function that returns "true" if every entry in a string array is unique,
     * "false" if there's a repeated string.
     *
     * For example:
     *     - AllAreUnique(new string[] { "Apple", "Apple", "Chair" })  ==> would return false.
     *     - AllAreUnique(new string[] { "Orange", "Apple", "Chair" }) ==> would return true.
    */

    private bool AllAreUnique(string[] toCheck)
    {
        var list = toCheck.ToList();
        list.Sort();

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] == list[i + 1]) return false;
        }

        return true;
    }

    /*
     * Create a function that takes in two strings, and returns the shorter string repeated
     * until it's the length of the longer one.
     *
     * For example:
     *     - RepeatShorter("la", "songbird")     ==> returns "lalalala"
     *     - RepeatShorter("applause", "clap")   ==> returns "clapclap"
     *     - RepeatShorter("ba", "sheep")        ==> returns "babab"
     * 
    */
    
    private string RepeatShorter(string one, string two)
    {
        var result = "";

        if (two.Length > one.Length)
        {
            (one, two) = (two, one);
        }

        var index = 0;
        
        for (var i = 0; i < one.Length; i++)
        {
            result += two[index];
            index++;
            if (index >= two.Length) index = 0;
        }
        
        return result;
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI uniqueNames, repeatShorterTest;
    private void Update()
    {
        uniqueNames.text = "Unique Assignment\n<align=left>\n";
        uniqueNames.text += Success(!AllAreUnique(new string[] {"Steve", "Steve", "Abba"})) + " handles non-uniqueness.\n";
        uniqueNames.text += Success(AllAreUnique(new string[] {"Jane", "Steve", "Abba"})) + " Handles uniqueness.\n";
        uniqueNames.text += Success(AllAreUnique(new string[0])) + " Handles empty array.\n";
        
        repeatShorterTest.text = "Repeat Shorter Assignment\n<align=left>\n";
        repeatShorterTest.text += Success(RepeatShorter("la", "songbird") == "lalalala") + " handles first shorter.\n";
        repeatShorterTest.text += Success(RepeatShorter("applause", "clap") == "clapclap") + " Handles second shorter.\n";
        repeatShorterTest.text += Success(RepeatShorter("ba", "sheep") == "babab") + " Handles uneven number of letters.\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}