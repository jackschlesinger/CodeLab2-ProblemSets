using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week7Bonus : MonoBehaviour
{
    /*
     * Identify where two strings have the same pattern of letters.
     *
     *     - HasSamePattern("ABAB", "CDCD") ➞ true
     *     - HasSamePattern("ABCBA", "BCDCB") ➞ true
     *     - HasSamePattern("FFGG", "CDCD") ➞ false
     *     - HasSamePattern("FFFF", "ABCD") ➞ false
    */

    private bool HasSamePattern(string first, string second)
    {
        
        return true;
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI bonusDisplayText;

    private void Update()
    {
        bonusDisplayText.text = "Has Same Pattern Assignment\n<align=left>\n";
        bonusDisplayText.text += Success(HasSamePattern("ABAB", "CDCD")) + " works for \"ABAB\", \"CDCD\".\n";
        bonusDisplayText.text += Success(HasSamePattern("ABCBA", "BCDCB")) + " works for \"ABCBA\", \"BCDCB\".\n";
        bonusDisplayText.text += Success(!HasSamePattern("FFGG", "CDCD")) + " works for \"FFGG\", \"CDCD\"\n";
        bonusDisplayText.text += Success(!HasSamePattern("FFFF", "ABCD")) + " works for \"FFFF\", \"ABCD\".\n";
        
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}
