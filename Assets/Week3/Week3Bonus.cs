using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week3Bonus : MonoBehaviour
{
    /*
     * Create a function that determines the frequency of each object in an array.
     *
     * For example:
     *     - Frequency<int>({0, 0, 0, 1, 1})
     *         ==> dictionary with key/value pairs {[0, 3], [1, 2]}
     * 
     *     - Frequency<string>({"A", "A", "B", "C", "C")
     *         ==> dictionary with key/value pairs {["A", 2], ["B", 1], ["C", 2]}
     * 
    */
    
    private Dictionary<T, int> Frequency<T>(T[] objects)
    {
        
        
        return new Dictionary<T, int>();
    }

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI frequencyTests;

    private void Update()
    {
        frequencyTests.text = "Frequency Assignment\n<align=left>\n";

        var test1 = Frequency(new string[] {"A", "A", "B"});
        
        frequencyTests.text += Success(test1.ContainsKey("A") && test1["A"] == 2) + " Handles strings.\n";

        var test2 = Frequency(new int[] {1, 1, 2, 3, 3, 3});

        frequencyTests.text += Success(test2.ContainsKey(3) && test2[3] == 3) + " Handles integers.\n";
        
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}
