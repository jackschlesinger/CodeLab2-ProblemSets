using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

[ExecuteInEditMode]
public class Week9 : MonoBehaviour
{
    /*
     * Create a state machine for a bug.
     *
     * In this game, bugs start standing.
     *
     * If you press 'w' while standing, the you stretch.  While ducking, you stand.
     * If you press 's' while standing, the you duck.  While stretching, you stand.
     * If you press ' ' while standing, you fly.
     * If you press 's' while flying, you start standing.
     *
     * If you press 'a' or 'd' while standing, stretching, or ducking, you start walking either left or right.
     * If you press 'a' or 'd' again in the same direction, you start running that direction.
     * If you press 'a' or 'd' and you're running the opposite direction, you start walking that direction.
     * If you press 'a' or 'd' and your walking the opposite direction, you start standing.
     *
     * The key that is pressed will be in "keyPressed" -> don't use Input.GetKeyDown
    */

    private class Bug
    {
        public enum BugState
        {
            Standing,
            Flying,
            WalkingLeft,
            RunningLeft,
            WalkingRight,
            RunningRight,
            Ducking,
            Stretching,    
        }

        public BugState currentState = BugState.Standing;
        private char keyPressed = '-';

        public Bug Input(char key)
        {
            keyPressed = char.ToLower(key);
            Update();

            return this;
        }

        public void Update()
        {
            // the variable "keyPressed" has the last key that was pressed.
        
            switch (currentState)
            {
                case BugState.Standing:
                    break;
                case BugState.Flying:
                    break;
                case BugState.WalkingLeft:
                    break;
                case BugState.RunningLeft:
                    break;
                case BugState.WalkingRight:
                    break;
                case BugState.RunningRight:
                    break;
                case BugState.Ducking:
                    break;
                case BugState.Stretching:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    /*
     * Create a function that helps identify missing numbers in Sudoku.
     *
     * You'll get in an array of integers, and you need to return an array of all numbers between 1 and 9 that
     * are not in the already found numbers (sorted), and null if there's repeated numbers.
     *
     * For Example:
     *     - SudokuHelper({1, 2, 3, 4, 5, 6, 7, 9}) -> returns {8}
     *     - SudokuHelper({2, 6, 3, 1, 4, 7}) -> returns {5, 8, 9}
     *     - SudokuHelper({1, 5, 8, 5, 2, 7}) -> returns null (two 5's)
     * 
     */

    [CanBeNull]
    private int[] SudokuHelper(int[] foundNumbers)
    {

        return foundNumbers;
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI fsmTest, sudokuHelperTest;

    private void Update()
    {
        fsmTest.text = "Bug State Machine Assignment\n<align=left>\n";
        var testBug = new Bug().Input('w');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.Stretching) + " stretching works.\n";
        testBug = new Bug().Input('w').Input('s');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.Standing) + " standing from stretching works.\n";
        testBug = new Bug().Input('s');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.Ducking) + " ducking works.\n";
        testBug = new Bug().Input('s').Input('w');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.Standing) + " standing from ducking works.\n";
        testBug = new Bug().Input(' ');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.Flying) + " flying works.\n";
        testBug = new Bug().Input(' ').Input('s');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.Standing) + " landing from flying works.\n";
        testBug = new Bug().Input('a');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.WalkingLeft) + " walking left works.\n";
        testBug = new Bug().Input('a').Input('a');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.RunningLeft) + " running left works.\n";
        testBug = new Bug().Input('w').Input('d');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.WalkingRight) + " walking right works.\n";
        testBug = new Bug().Input('s').Input('d').Input('d');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.RunningRight) + " running right works.\n";
        testBug = new Bug().Input('w').Input('a').Input('a').Input('d');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.WalkingLeft) + " walking by pressing back works.\n";
        testBug = new Bug().Input('s').Input('d').Input('d').Input('a').Input('a');
        fsmTest.text += Success(testBug.currentState == Bug.BugState.Standing) + " stopping by pressing back works.\n";

        sudokuHelperTest.text = "Sudoku Helper Assignment\n<align=left>\n";
        
        sudokuHelperTest.text += Success(SudokuHelper(new int[] {1, 2, 3, 4, 5, 6, 9}).SequenceEqual(new[] {7, 8})) + " Finds missing number(s) sorted.\n";
        sudokuHelperTest.text += Success(SudokuHelper(new int[] {2, 6, 3, 1, 4, 7}).SequenceEqual(new[] {5, 8, 9})) + " Finds missing number(s) unsorted.\n";
        sudokuHelperTest.text += Success(SudokuHelper(new int[]{1, 5, 8, 5, 2, 7}) == null) + " Finds repeated numbers.\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}