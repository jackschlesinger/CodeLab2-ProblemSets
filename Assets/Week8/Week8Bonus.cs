using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week8Bonus : MonoBehaviour
{
    /*
     * Create a function that gives the most optimal guesses for solving the "guess the number I'm thinking of between
     * one and some number", if the player has to tell you if your guess is higher than the target, lower than the
     * target, or correct.
     *
     * This function has two inputs:
     *     - The maximum guess (maximum)
     *     - The number I'm thinking of (target)
     *
     * Return the guesses as an array of ints.
     *
     * You can only guess whole integers, and 0.5 rounds up to 1.
     * 
     * Most optimal strategy: https://en.wikipedia.org/wiki/Binary_search_algorithm.
     *
     * For Example:
     *     - OptimalGuesses(100, 40) ➞ [50, 25, 38, 44, 41, 39, 40]
     *     - OptimalGuesses(10, 5) ➞ [5]
     *     - OptimalGuesses(300, 187) ➞ [150, 225, 187]
     * 
    */
    
    private int[] OptimalGuesses(int maximum, int target)
    {
        return new int[0];
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI optimalGuessesText;

    private void Update()
    {
        optimalGuessesText.text = "Optimal Guesses Assignment\n<align=left>\n";
        
        optimalGuessesText.text += Success(Enumerable.SequenceEqual(OptimalGuesses(100, 40), new int[]{50, 25, 38, 44, 41, 39, 40})) + " correct for 100 | 40.\n";
        optimalGuessesText.text += Success(Enumerable.SequenceEqual(OptimalGuesses(10, 5), new int[]{5})) + " correct for 10 | 5.\n";
        optimalGuessesText.text += Success(Enumerable.SequenceEqual(OptimalGuesses(300, 187), new int[]{150, 225, 187})) + " correct for 300 | 187.\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}
