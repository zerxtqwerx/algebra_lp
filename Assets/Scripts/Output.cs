using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Output : MonoBehaviour
{
    public Operation digits;
    public Text output;

    /*public Button add;
    public Button mult;
    public Button diff;
    public Button div;
    public Button ate;
    public Button tae;
    public Button eat;
    public Button exp;
    public Button roots;*/

    public void Add()
    {
        Ans ans = digits.Add();
        //Debug.Log(ans.first);
        //Debug.Log(ans.second);
        output.text = "= " + ans.first + " + (" + ans.second + ")i";
    }

    public void Multiply()
    {
        Ans ans = digits.Multiply();
        output.text = "= " + ans.first + " + (" + ans.second + ")i";
    }

    public void Difference()
    {
        Ans ans = digits.Difference();
        output.text = "= " + ans.first + " + (" + ans.second + ")i";
    }

    public void Divide()
    {
        Ans ans = digits.Divide();
        output.text = "= " + ans.first + " + (" + ans.second + ")i";
    }

    public void ATE()
    {
        Ans ans = digits.ATE();
        output.text = "= " + ans.first + "(cos(" + ans.second + ") + isin(" + ans.second + "))" +
            "\n= " + ans.first + "e** " + ans.second + "i";
    }

    public void TAE()
    {
        Ans ans = digits.TAE();
        output.text = "= " + ans.first + " + (" + ans.second + ")i" +
            "\n= " + ans.first + "e** " + ans.second + "i";
    }

    public void EAT()
    {
        Ans ans = digits.EAT();
        output.text = "= " + ans.first + " + (" + ans.second + ")i" +
            "\n= " + ans.first + "(cos(" + ans.second + ") + isin(" + ans.second + "))";
    }

    public void Exponentaion()
    {
        Ans ans = digits.Exponentation();
        output.text = "= " + ans.first + " + (" + ans.second + ")i";
    }

    public void Roots()
    {
        Ans ans = digits.Roots();
        output.text = "k = 1: \n= " + ans.first + " + (" + ans.second + ")i";
    }
}
