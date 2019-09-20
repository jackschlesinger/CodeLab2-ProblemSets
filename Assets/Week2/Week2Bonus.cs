using System;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week2Bonus : MonoBehaviour
{
    /*
     * Create function that takes in a sentence in Enlish, and returns that sentence in pig-latin.
     * 
     * If a word starts with a consonant move the first letter(s) of the word, till you reach a vowel,
     * to the end of the word and add "ay" to the end.
     *     have ➞ avehay
     *     cram ➞ amcray
     *     trebuchet ➞ ebuchettray
     *
     * If a word starts with a vowel add "yay" to the end of the word.
     *     apple ➞ appleyay
     *     oaken ➞ oakenyay
     *     eagle ➞ eagleyay
    */

    private string PigLatinTranslator(string sentence)
    {
        
        
        return "";
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI pigLatinTests;

    private void Update()
    {
        pigLatinTests.text = "Pig Latin Assignment\n<align=left>\n";
        pigLatinTests.text += Success(PigLatinTranslator("have") == "avehay") + " Handles consonants\n";
        pigLatinTests.text += Success(PigLatinTranslator("apple") == "appleyay") + " Handles vowels\n";
        pigLatinTests.text += Success(PigLatinTranslator("I have an apple") == "Iyay avehay anyay appleyay") + " Handles multiple words\n";
        pigLatinTests.text += Success(PigLatinTranslator("Me?  I am someone, who has an apple.") == 
                                                                                "Emay? Iyay amyay omeonesay, owhay ashay anyay appleyay.") + " Handles punctuation.\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}
