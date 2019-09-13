using System;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week1Bonus : MonoBehaviour
{
    /*
     * Create a function that returns true if an input string contains only uppercase or 
     * only lowercase letters, and false otherwise.
     * 
     * For example:
     *    - SimplifyFraction("5/25") should return "1/5"
     *    - SimplifyFraction("5/63") should return "5/63"
     *    - SimplifyFraction("12/3") should return "4"
     *    - SimplifyFraction("11/4") should return "2 3/4"
    */

    private string SimplifyFraction(string toReduce)
    {
        if (toReduce.Split('/').Length < 2) return toReduce;

        var numerator = int.Parse(toReduce.Split('/')[0]);
        var denominator = int.Parse(toReduce.Split('/')[1]);
        var integer = 0;

        /*if (numerator > denominator)
        {
            integer = numerator / denominator;
        }*/
        
        while (numerator >= denominator)
        {
            numerator -= denominator;
            integer++;
        }
    
        if (numerator == 0) return integer.ToString();

        for (var i = 2; i < denominator; i++)
        {
            var newNumerator = numerator * i / denominator ;

            if (Mathf.Abs((float) newNumerator / i - (float) numerator / denominator) > 0.00001) continue;
        
            numerator = (int) newNumerator;
            denominator = i;
            break;
        }
    
        return (integer > 0 ? integer + " " : "") + numerator + "/" + denominator;
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI simplifyFractionTests;

    private void Update()
    {
        simplifyFractionTests.text = "Simplify Fractions Assignment\n<align=left>\n";
        simplifyFractionTests.text += Success(SimplifyFraction("5/25") == "1/5") + " Handles reduction\n";
        simplifyFractionTests.text += Success(SimplifyFraction("5/63") == "5/63") + " Handles can't reducee\n";
        simplifyFractionTests.text += Success(SimplifyFraction("12/3") == "4") + " Reducing to integer\n";
        simplifyFractionTests.text += Success(SimplifyFraction("11/4") == "2 3/4") + " Handles removing int.\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}
