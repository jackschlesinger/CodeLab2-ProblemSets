using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week7 : MonoBehaviour
{
    /*
     * Create a function that returns the next prime number after the input.
     *
     * For example:
     *     - NextPrime(12) ➞ 13
     *     - NextPrime(24) ➞ 29
     *     - NextPrime(11) ➞ 13
    */

    private int NextPrime(int starting)
    {
        
        return 0;
    }
    
    /*
     * Create a function that takes a year, and returns the century as a string.
     *
     * SOME NOTES:
     * All dates will be between 1000 and 2019.
     * The 11th century is between 1001 and 1100.
     * The 18th century is between 1701-1800.
     *
     * For Example:
     *     - CenturyFromYear(1756) ➞ "18th century"
     *     - CenturyFromYear(1000) ➞ "10th century"
     *     - CenturyFromYear(1001) ➞ "11th century"
     * 
    */
    
    private string CenturyFromYear(int year)
    {
        return "";
    }


    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI nextPrimeText, centuryText;

    private void Update()
    {
        nextPrimeText.text = "Next Prime Assignment\n<align=left>\n";
        nextPrimeText.text += Success(NextPrime(12) == 13) + " correct for 12.\n";
        nextPrimeText.text += Success(NextPrime(24) == 29) + " correct for 24.\n";
        nextPrimeText.text += Success(NextPrime(11) == 13) + " correct for 11.\n";
        
        centuryText.text = "Century From Year Assignment\n<align=left>\n";
        
        centuryText.text += Success(CenturyFromYear(1756) == "18th century") + " correct for 1756.\n";
        centuryText.text += Success(CenturyFromYear(1000) == "10th century") + " correct for 1000.\n";
        centuryText.text += Success(CenturyFromYear(1001) == "11th century") + " correct for 1001.\n";
        centuryText.text += Success(CenturyFromYear(2010) == "21st century") + " correct for 2010.\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}