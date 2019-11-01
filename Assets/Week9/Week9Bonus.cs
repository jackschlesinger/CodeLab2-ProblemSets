using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week9Bonus : MonoBehaviour
{
    /*
     * Create a function that takes in a two-dimensional array of characters of any two sizes, and returns the character
     * if there's a "connect-four" style match of the same character, and ' ' if there's no match.
     *
     * For example: if you get in this array:
     * [['X',' ',' ',' '],
     *  ['X',' ',' ',' '],
     *  ['X',' ',' ',' '],
     *  ['O',' ',' ',' ']]
     *
     * Would return 'X'.
     *
     * Rules:
     *     - Ignore spaces.
     *     - Width and height of the array will always be the same.
     *     - The smallest length of a match should be one less than the width and height
     *     - You'll never receive an array smaller than 4x4.
     *     - There will always either be no winner or one winner.
     */

    private char Winner(char[,] grid)
    {
        
        return ' ';
    }
    
    /*
     * Create a function "MinesweeperModel" that takes in a two-dimensional array of characters
     * initialGrid made up of #'s and -'s.
     *
     * # are bombs
     * - are empty spaces
     *
     * Return a two-dimensional array of characters with the '-'s replaced with the number of
     * bombs adjacent to that space.
     *
     * "Adjacent" means any of the up to eight spaces that are one away either diagonally, vertically,
     * or horizontally.
     *
     * For example: if you get in:
     *     - - - - # -
     *     - # - - # #
     *     - - # - - #
     *
     * You should return
     *     1 1 1 2 # 3
     *     1 # 2 3 # #
     *     1 2 # 2 3 #
     * 
    */
    
    private char[,] MinesweeperModel(char[,] initialGrid)
    {
        
        return initialGrid;
    }
    
    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI winnerText, optimalGuessesText;
    
    
    private char[,] InitializeArray(int x, int y, char empty = ' ')
    {
        var toReturn = new char[x, y];
        for (var i = 0; i < x * y; i++) 
            toReturn[i % x, i / x] = empty;

        return toReturn;
    }
    
    private void Update()
    {
        optimalGuessesText.text = "Optimal Guesses Assignment\n<align=left>\n";

        /*
         * - - # -
         * - - # -
         * - # # #
         * - - # -
         */
        
        var grid = InitializeArray(4, 4, '-');
        grid[1, 1] = '#';
        grid[2, 0] = '#';
        grid[2, 1] = '#';
        grid[2, 2] = '#';
        grid[2, 3] = '#';
        grid[3, 1] = '#';
        
        optimalGuessesText.text += Success(MinesweeperModel(grid)[3, 3] == '2' && MinesweeperModel(grid)[3, 2] == '4') +
                                   " - correct for first test grid.\n";
        
        /*
         * - - # -
         * - - # -
         * - # # #
         * - - # -
         */
        
        grid = InitializeArray(4, 4, '-');
        grid[0, 0] = '#';
        grid[2, 2] = '#';

        optimalGuessesText.text += Success(MinesweeperModel(grid)[1, 1] == '2' && MinesweeperModel(grid)[0, 1] == '1') +
                                   " - correct for second test grid.\n";
        
        winnerText.text = "Winner Assignment\n<align=left>\n";
        grid = InitializeArray(4, 4);
        grid[0, 0] = 'a';
        grid[0, 1] = 'a';
        grid[0, 2] = 'a';
        winnerText.text += Success(Winner(grid) == 'a') + " - vertical check works.\n";
        
        
        grid = InitializeArray(4, 4);
        grid[0, 0] = 'x';
        grid[1, 0] = 'x';
        grid[2, 0] = 'x';
        winnerText.text += Success(Winner(grid) == 'x') + " - horizontal check works.\n";
        
        grid = InitializeArray(4, 4);
        grid[0, 0] = 'b';
        grid[1, 1] = 'b';
        grid[2, 2] = 'b';
        winnerText.text += Success(Winner(grid) == 'b') + " - diagonal check works.\n";
        
        
        grid = InitializeArray(100, 100);

        for (var i = 99; i > 0; i--)
        {
            grid[i, i] = '%';
        };
        
        winnerText.text += Success(Winner(grid) == '%') + " - big grid works.\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}
