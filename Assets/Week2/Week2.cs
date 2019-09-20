using System;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week2 : MonoBehaviour
{
    /*
     * Create a function that returns the median of an array of integers.
     * 
    */

    private float Median(int[] numbers)
    {
    
        return 0;
    }

    /*
     * Create a function that returns the sum of all odd numbers between 1 and the number provided - including
     * the number provided.
     *
     * For example:
     *     - SumOfOdd(1) ==> 1
     *     - SumOfOdd(5) ==> 1 + 3 + 5 ==> 9
     * 
    */

    private int SumOfOdd(int upperBound)
    {
        
        return 0;
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI medianTests, sumOfOddTests;
    private void Update()
    {
        medianTests.text = "Median Assignment\n<align=left>\n";
        medianTests.text += Success(Math.Abs(Median(new int[] {9}) - 9) < 0.001f) + " Handles single number.\n";
        medianTests.text += Success(Math.Abs(Median(new int[] {0, 1, 2}) - 1) < 0.001f) + " Handles all odd number of numbers.\n";
        medianTests.text += Success(Math.Abs(Median(new int[] {0, 1, 2, 3}) - 1.5f) < 0.001f) + " Handles even number of numbers.\n";
        
        sumOfOddTests.text = "Sum Of Odd Assignment\n<align=left>\n";
        sumOfOddTests.text += Success(SumOfOdd(1) == 1) + " Handles 1.\n";
        sumOfOddTests.text += Success(SumOfOdd(2) == 1) + " Handles 2.\n";
        sumOfOddTests.text += Success(SumOfOdd(5) == 9) + " Handles 5\n";
        sumOfOddTests.text += Success(SumOfOdd(13) == 49) + " Handles 13\n";
        sumOfOddTests.text += Success(SumOfOdd(14) == 49) + " Handles 14\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}