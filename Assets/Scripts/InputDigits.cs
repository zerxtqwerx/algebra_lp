using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class InputDigits : MonoBehaviour
{
    public TMP_InputField r1;
    public TMP_InputField i1;

    public TMP_InputField r2;
    public TMP_InputField i2;

    public TMP_InputField r;
    public TMP_InputField i;

    public TMP_InputField trigM;
    public TMP_InputField trigPh;

    public TMP_InputField expM;
    public TMP_InputField expPh;
    public TMP_InputField n;

    public Operation digits;

    public void OnEndEditr1()
    {
        int.TryParse(r1.text, out int result);
        digits.Changealg1(result, digits.alg1.Imaginary);
    }

    public void OnEndEditi1()
    {
        int.TryParse(i1.text, out int result);
        digits.Changealg1(digits.alg1.Real, result);
    }

    public void OnEndEditr2()
    {
        int.TryParse(r2.text, out int result);
        digits.Changealg2(result, digits.alg2.Imaginary);
    }

    public void OnEndEditi2()
    {
        int.TryParse(i2.text, out int result);
        digits.Changealg2(digits.alg2.Real, result);
    }

    public void OnEndEditr()
    {
        int.TryParse(r.text, out int result);
        digits.Changealg(result, digits.alg.Imaginary);
    }

    public void OnEndEditi()
    {
        int.TryParse(i.text, out int result);
        digits.Changealg(digits.alg.Real, result);
    }

    public void OnEndEdittm()
    {
        int.TryParse(trigM.text, out int result);
        digits.Changetrig(result, digits.trig.Phase *180 / Math.PI);
    }

    public void OnEndEdittp()
    {
        int.TryParse(trigPh.text, out int result);
        digits.Changetrig(digits.trig.Magnitude, result);
    }

    public void OnEndEditem()
    {
        int.TryParse(expM.text, out int result);
        digits.Changeexp(result, digits.exp.Phase * 180 / Math.PI);
    }

    public void OnEndEditep()
    {
        int.TryParse(expPh.text, out int result);
        digits.Changeexp(digits.exp.Magnitude, result);
    }

    public void OnEndEditn()
    {
        int.TryParse(n.text, out int result);
        digits.n = result;
    }
}
