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
        
        return true;
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