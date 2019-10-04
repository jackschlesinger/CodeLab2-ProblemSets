using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week4Bonus : MonoBehaviour
{
    /*
     * Create a function that takes in an array of numbers and returns
     * the sum of that fibonacci number.
     * https://www.mathsisfun.com/numbers/fibonacci-sequence.html
     *
     * For Example:
     *     - FibonacciSum(2, 5, 9) =>
     *         0, 1 => 1
     *         0, 1, 1, 2, 3 =>  3
     *         0, 1, 1, 2, 3, 5, 8, 13, 21 => 21
     *         return 1 + 3 + 21 = 25
     *     - FibonacciSum(11, 4) =>
     *         0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 => 55
     *         0, 1, 1, 2 => 2
     *         return 2 + 55 => 57
     *    0 FibonacciSum(5)
     *         0, 1, 1, 2, 3 =>  3
     *         return 3
     * 
    */

    private int FibonacciSum(params int[] numbers)
    {

        return 0;
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI isRectangleTest;

    private void Update()
    {
        isRectangleTest.text = "Fibonacci Sum Assignment\n<align=left>\n";
        isRectangleTest.text += Success(FibonacciSum(2, 5, 9) == 25) + " works for numbers in order.\n";
        isRectangleTest.text += Success(FibonacciSum(11, 4) == 57) + " works for number out of order.\n";
        isRectangleTest.text += Success(FibonacciSum(5) == 3) + " works for one number.\n";
        
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}
