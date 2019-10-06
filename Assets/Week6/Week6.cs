using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class Week6 : MonoBehaviour
{
    /*
     * Create a function that validates whether or not an email address is valid.
     *
     * For example:
     *     - ValidateEmail("@gmail.com") ➞ false
     *     - ValidateEmail("hello.gmail@com") ➞ false
     *     - ValidateEmail("gmail") ➞ false
     *     - ValidateEmail("hello@gmail") ➞ false
     *     - ValidateEmail("hello@gmail.com") ➞ true
     *     - ValidateEmail("hello.@gmail.com") ➞ false
     *     - ValidateEmail("hello@gmail.com.") ➞ false
     *     - ValidateEmail("hello.at@gmail.com") ➞ true
    */

    private bool ValidateEmail(string email)
    {
        
        return false;
    }

    /*
     * Make a function that turns a camelCase string into snake_case.
     *
     * For example:
     *     - ToSnakeCase("helloWorld) => "hello_world"
     *     - ToSnakeCase("anotherExample" => "another_example"
     * 
     * Make a function that turns a snake_case string into camelCase.
     *
     * For example:
     *     - ToCamelCase("hello_world") => "helloWorld"
     *     - ToCamelCase("snake_case") => "snakeCase"
     * 
    */

    private string ToSnakeCase(string input)
    {

        return input;
    }

    private string ToCamelCase(string input)
    {
        
        return input;
    }
    
    


    // =========================== DON'T EDIT BELOW THIS LINE =========================== //

    public TextMeshProUGUI validateEmailText, snakeAndCamelCaseText;

    private void Update()
    {
        validateEmailText.text = "Validate Email Assignment\n<align=left>\n";
        
        validateEmailText.text +=
            Success(!ValidateEmail("@gmail.com")) + " correct for @gmail.com.\n";
        validateEmailText.text +=
            Success(!ValidateEmail("hello.gmail@com")) + " correct for hello.gmail@com.\n";
        validateEmailText.text +=
            Success(!ValidateEmail("gmail")) + " correct for gmail.\n";
        validateEmailText.text +=
            Success(!ValidateEmail("hello@gmail")) + " correct for hello@gmail.\n";
        validateEmailText.text +=
            Success(!ValidateEmail("hello.gmail@com")) + " correct for hello.gmail@com.\n";
        validateEmailText.text +=
            Success(ValidateEmail("hello.at@gmail.com")) + " correct for hello.at@gmail.com.\n";
        validateEmailText.text +=
            Success(ValidateEmail("hello@gmail.com")) + " correct for hello@gmail.com.\n";
        validateEmailText.text +=
            Success(!ValidateEmail("hello.@gmail.com")) + " correct for hello.@gmail.com.\n";
        validateEmailText.text +=
            Success(!ValidateEmail("hello@gmail.com.")) + " correct for hello@gmail.com..\n";
        
        snakeAndCamelCaseText.text = "Snake And Camel Case Assignment\n<align=left>\n";
        
        snakeAndCamelCaseText.text +=
            Success(ToSnakeCase("camelCase") == "camel_case") + " correct for ToSnakeCase(\"camelCase\")\n";
        snakeAndCamelCaseText.text +=
            Success(ToSnakeCase("camel") == "camel") + " correct for ToSnakeCase(\"camel\")\n";
        snakeAndCamelCaseText.text +=
            Success(ToCamelCase("snake_case") == "snakeCase") + " correct for ToCamelCase(\"snake_case\")\n";
        snakeAndCamelCaseText.text +=
            Success(ToCamelCase("snake") == "snake") + " correct for ToCamelCase(\"snake\")\n";
    }

    private string Success(bool test)
    {
        return test ? "<color=\"green\">PASS</color>" : "<color=\"red\">FAIL</color>";
    }
}