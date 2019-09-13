using System;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week1 : MonoBehaviour
{
    /*
     * Create a function that returns true if an input string contains only uppercase or 
     * only lowercase letters, and false otherwise.
     * 
     * For example:
     *    - SameCase("TEST") should return true
     *    - SameCase("test") should return true
     *    - SameCase("TesT") should return false
    */

    private bool SameCase(string toCheck)
    {
        return toCheck == toCheck.ToUpper() || toCheck == toCheck.ToLower();
        
        if (toCheck.Length == 0) return false;
        
        for (var i = 1; i < toCheck.Length; i++)
        {
            if (char.IsUpper(toCheck[0]) != char.IsUpper(toCheck[i]))
                return false;
        }

        return true;


        /*int i = 0;

        while (i < toCheck.Length)
        {
            Debug.Log(toCheck[i]);
            i++;
        }*/


        /*
         
         var sameCase = true;
         
        foreach (var character in toCheck)
        {
            if (Char.IsUpper(character) != Char.IsUpper(toCheck[0]))
            {
                sameCase = false;
                break;
            }
        }
        
        return sameCase;

        /*
        string upperCaseString = toCheck.ToUpper();  // take "AbCdE" turn it into "ABCDE"
        string lowerCaseString = toCheck.ToLower();

        return toCheck == toCheck.ToUpper(); || toCheck == toCheck.ToLower();
        
        if (toCheck == toCheck.ToUpper() || toCheck == toCheck.ToLower())
        {
            return true;
        }

        return false;
        */

        /*
        
        
        if (toCheck.All(char.IsUpper) || toCheck.All(char.IsLower))
        {
            Debug.Log("the letters in " + toCheck + " ARE all the same case!");
            return true;
        }
        else
        {
            Debug.Log("the letters in " + toCheck + " are NOT all the same case!");
            return false;
        }
        */
    }

    /*
     * Create a function that returns true if an input string is a palindrome, 
     * ignoring spaces and case.
     * 
     * For example:
     *    - SameCase("Racecar") should return true
     *    - SameCase("Red rum, sir, is murder") should return true
     *    - SameCase("ASDJKWMCJD") should return false
    */
    
    private bool Palindrome(string toCheck)
    {
        var x = "";
        foreach (var character in toCheck) // "Racecars are cool."
        {
            if (char.IsLetter(character))
            {
                x += char.ToUpper(character).ToString(); // "RACECARSARECOOL"
            }
        }

        float floatLength = x.Length;
        
        for (var i = 0; i < Mathf.Floor(f: x.Length / 2f); i++)
        {
            if (x[i] != x[x.Length - 1 - i]) return false;
        }

        return true;
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI sampleCaseTexts, palindromeTests;
    private void Update()
    {
        sampleCaseTexts.text = "SameCase Assignment\n<align=left>\n";
        sampleCaseTexts.text += Success(SameCase("ABCDE")) + " Handles all upper case\n";
        sampleCaseTexts.text += Success(SameCase("abcde")) + " Handles all lower case\n";
        sampleCaseTexts.text += Success(!SameCase("AbCdE")) + " Handles mixed case\n";
        
        palindromeTests.text = "Palindrome Assignment\n<align=left>\n";
        palindromeTests.text += Success(Palindrome("Racecar")) + " Handles one word with odd characters.\n";
        palindromeTests.text += Success(Palindrome("Anna")) + " Handles one word with even characters.\n";
        palindromeTests.text += Success(Palindrome("Red rum, sir, is murder")) + " Handles all lower case\n";
        palindromeTests.text += Success(!Palindrome("ASDJKWMCJD")) + " Handles non-palindrome w/one word\n";
        palindromeTests.text += Success(!Palindrome("asd wef sd j")) + " Handles non-palindrome w/multiple words\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}