﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week6Bonus : MonoBehaviour
{
    /*
     * A number is a palindrome if it's numbers are the same backwards and forwards.
     *
     * A number's child is the sum of each adjacent pair of digits.
     *
     * 123312's child is 363.
     *
     * Create a function that returns true if it or any of it's descendants with two or more digits is a palindrome.
     *
     * Note: Inputs will always have an even number of digits.
    */

    private bool IsPalindromeAncestor(int number)
    {
        while (number.ToString().Length > 1)
        {
            Debug.Log(number);
        
            if (NumberIsPalindrome(number)) return true;

            number = GetChild(number);
        }

        return false;
    }

    private bool NumberIsPalindrome(int number)
    {
        for (var i = 0; i < number.ToString().Length / 2; i++)
        {
            if (number.ToString()[i] != number.ToString()[number.ToString().Length - 1 - i])
                return false;
        }

        return true;
    }

    private int GetChild(int number)
    {
        var toReturn = "";
    
        for (var i = 0; i < number.ToString().Length; i+=2)
        {
            var first = Int32.Parse(number.ToString()[i].ToString());
            var second = Int32.Parse(number.ToString()[i + 1].ToString());

            toReturn += (first + second).ToString();
        }

        return Int32.Parse(toReturn);
    }


    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI isPalindromeAncestor;

    private void Update()
    {
        isPalindromeAncestor.text = "Is Palindrome Ancestor Assignment\n<align=left>\n";
        isPalindromeAncestor.text += Success(IsPalindromeAncestor(11211230)) + " works for 11211230.\n";
        isPalindromeAncestor.text += Success(IsPalindromeAncestor(13001120)) + " works for 13001120.\n";
        isPalindromeAncestor.text += Success(IsPalindromeAncestor(23336014)) + " works for 23336014.\n";
        isPalindromeAncestor.text += Success(IsPalindromeAncestor(11)) + " works for 11.\n";
        isPalindromeAncestor.text += Success(!IsPalindromeAncestor(12)) + " works for 12.\n";
        
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}
