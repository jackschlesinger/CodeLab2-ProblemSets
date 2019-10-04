using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week4 : MonoBehaviour
{
    /*
     * Create a function that returns the number of primes up to and including a given integer.
     *
     * For example:
     *     - HowManyPrimes(10)     ==> returns 4 (2, 3, 5, and 7)
     *     - HowManyPrimes(19)     ==> returns 8 (2, 3, 5, 7, 11, 13, 17 and 19)
     *     - HowManyPrimes(30)     ==> returns 10 (2, 3, 5, 7, 11, 13, 17, 19, 23 and 29)
    */

    private int HowManyPrimes(int max)
    {
        var count = 0;
        
        for (var i = 2; i <= max; i++)
        {
            if (IsPrime(i)) count++;
        }
        
        return count;
    }

    private bool IsPrime(int number)
    {
        for (var i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    /*
     * Override the "Speak" function in Pet for Dog and Cat to make dogs go "Woof" and
     * cats go "Meow".  Also, cats don't need leashes, but dogs do.
     * 
    */

    private abstract class Pet
    {
        public abstract string Speak();
        public abstract bool NeedsLeash();
    }

    private class Dog : Pet
    {
        public override string Speak()
        {
            return "Woof";
        }

        public override bool NeedsLeash()
        {
            return true;
        }

        public virtual void RollOver()
        {
            Debug.Log("Rolled over.");
        }
    }

    private class Beagle : Dog
    {
        public override void RollOver()
        {
            Debug.Log("Too Stubborn");
        }
    }
    

    private class Cat : Pet
    {
        public override string Speak()
        {
            return "Meow";
        }

        public override bool NeedsLeash()
        {
            return false;
        }
    }
    

    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI howManyPrimes, catsAndDogs;
    private void Update()
    {
        howManyPrimes.text = "How Many Primes Assignment\n<align=left>\n";
        howManyPrimes.text += Success(HowManyPrimes(10) == 4) + " correct for first non-inclusive test.\n";
        howManyPrimes.text += Success(HowManyPrimes(19) == 8) + " correct for first inclusive test.\n";
        howManyPrimes.text += Success(HowManyPrimes(100) == 25) + " correct for second non-inclusive test.\n";
        howManyPrimes.text += Success(HowManyPrimes(201) == 46) + " correct for second inclusive test.\n";
        
        catsAndDogs.text = "Cats and Dogs\n<align=left>\n";
        catsAndDogs.text += Success(MakePetsSpeak(new List<Pet> { new Cat(), new Dog() }).ToLower() == "meow woof") + " speak correctly.\n";
        catsAndDogs.text += Success(!new Cat().NeedsLeash()) + " cats don't need leashes.\n";
        catsAndDogs.text += Success(new Dog().NeedsLeash()) + " dogs need leashes.\n";
    }
    
    private string MakePetsSpeak(List<Pet> pets)
    {
        var toReturn = "";
        
        foreach (var pet in pets)
        {
            toReturn += pet.Speak() + " ";
        }
        
        return toReturn.TrimEnd(' ');
    }
    
    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}