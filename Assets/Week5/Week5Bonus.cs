using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week5Bonus : MonoBehaviour
{
    /*
     * Create a function that returns "true" if the input array of four corners makes a
     * rectangle.
     *
     * Remember - rectangles have 90 degree angles on each corner!
     *
     * You can assume you're always getting four inputs.
    */

    private bool IsRectangle(Vector3[] corners)
    {
        

        return true;
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI isRectangleTest;

    private void Update()
    {
        isRectangleTest.text = "Is Rectangle Assignment\n<align=left>\n";
        isRectangleTest.text += Success(IsRectangle(new Vector3[] {Vector3.zero, Vector3.right, Vector3.one, Vector3.up})) + " identifies a rectangle.\n";
        isRectangleTest.text += Success(!IsRectangle(new Vector3[] {Vector3.zero, Vector3.right, Vector3.one, Vector3.left})) + " identifies not a rectangle.\n";
        
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}
