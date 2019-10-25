using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week8 : MonoBehaviour
{
    /*
     * Create a function that takes in a string that is a hexidecimal representation of a number,
     * and returns a decimal version of that number.
     *
     * You cannot use any built in functions to convert numbers to or from hexadecimal.
     *
     * Definition of hexadecimal: https://en.wikipedia.org/wiki/Hexadecimal
     * Definition of ulong: https://msdn.microsoft.com/en-us/ie/t98873t4(v=vs.94)
     *
     * For example:
     *     - Hexadecimal("0xF") ➞ 15
     *     - Hexadecimal("0xFFFFFF") ➞ 16777215
     *     - Hexadecimal("0x8D2AB") ➞ 578219
    */

    private ulong Hexadecimal(string hexNumber)
    {
        return 0UL;
    }
    
    /*
     * A string's "SumValue" is the sum of each of it's characters translated thusly:
     *
     *     A: 1
     *     B: 2
     *     C: 3
     *     ...and so on.
     *
     *     - SumValue("ABC") ➞ 1 + 2 + 3 = 6
     *     - SumValue("ZZZ") ➞ 26 + 26 + 26 = 78
     *     - SumValue("Abigail") = 41
    */

    private int SumValue(string word)
    {
        return 0;
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI nextPrimeText, sumValueText;

    private void Update()
    {
        nextPrimeText.text = "Hexadecimal Assignment\n<align=left>\n";
        nextPrimeText.text += Success(Hexadecimal("0xF") == 15) + " correct for \"0xF\".\n";
        nextPrimeText.text += Success(Hexadecimal("0xFFFFFF") == 16777215) + " correct for \"0xFFFFFF\".\n";
        nextPrimeText.text += Success(Hexadecimal("0x8D2AB") == 578219) + " correct for \"0x8D2AB\".\n";
        nextPrimeText.text += Success(Hexadecimal("0xAAAAA") == 699050) + " correct for \"0xAAAAA\".\n";
        nextPrimeText.text += Success(Hexadecimal("0xABCDEF") == 11259375) + " correct for \"0xABCDEF\".\n";
        
        sumValueText.text = "SumValue Assignment\n<align=left>\n";
        sumValueText.text += Success(SumValue("ABC") == 6) + " correct for \"AAA\".\n";
        sumValueText.text += Success(SumValue("ZZZ") == 78) + " correct for \"ZZZ\".\n";
        sumValueText.text += Success(SumValue("Abigail") == 41) + " correct for \"Abigail\".\n";
        sumValueText.text += Success(SumValue("Mario") == 56) + " correct for \"Mario\".\n";
        sumValueText.text += Success(SumValue("pneumonoultramicroscopicsilicovolcanoconiosis") == 560) + " correct for \"pneumonoultramicroscopicsilicovolcanoconiosis\".\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}