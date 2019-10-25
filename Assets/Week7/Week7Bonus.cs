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
        if (first.Length != second.Length) return false;

        var pattern = new Dictionary<char, char>();

        for (var i = 0; i < first.Length; i++)
        {
            if (!pattern.ContainsKey(first[i]) && !pattern.ContainsValue(second[i]))
            {
                pattern.Add(first[i], second[i]);
            }
            else if (!pattern.ContainsKey(first[i]) || pattern[first[i]] != second[i])
            {
                return false;
            }
        } 
        
        return true;
    }

    private bool CheckPattern(string a, string b)
    {
        var aHash = GetHash(a);
        var bHash = GetHash(b);

        return aHash.SequenceEqual(bHash);
    }

    private int[] GetHash(string toHash)
    {
        int currentNumber = 0;
        Dictionary<char, int> seenCharacters = new Dictionary<char, int>();
        var toReturn = new int[toHash.Length];

        for (var i = 0; i < toHash.Length; i++)
        {
            if (!seenCharacters.ContainsKey(toHash[i]))
            {
                seenCharacters.Add(toHash[i], currentNumber);
                currentNumber++;
            }
            toReturn[i] = seenCharacters[toHash[i]];
        }

        return toReturn;
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
