using System.Collections;
using System.Collections.Generic;
using System;
using System.Numerics;
using UnityEngine;

public struct Ans
{
    public double first;
    public double second;

    public Ans(double f, double s)
    {
        first = Math.Round(f, 2);
        second = Math.Round(s, 2);
    }
};

public class Operation : MonoBehaviour
{
    public Complex alg1;
    public Complex alg2;
    public Complex alg;
    public Complex trig;
    public Complex exp;
    public int n;

    public Operation()
    {
        alg1 = new Complex(0, 0);
        alg2 = new Complex(0, 0);
        alg  = new Complex(0, 0);
        trig = new Complex(0, 0);
        exp  = new Complex(0, 0);
        n = 0;
    }

    public void Changealg1(double r, double i)
    {
        alg1 = new Complex(r, i);
    }

    public void Changealg2(double r, double i)
    {
        alg2 = new Complex(r, i);
    }

    public void Changealg(double r, double i)
    {
        alg = new Complex(r, i);
    }

    public void Changetrig(double m, double p)
    {
        double rad = (Math.PI / 180) * p;
        trig = new Complex(m*Math.Cos(rad), m*Math.Sin(rad));
    }

    public void Changeexp(double m, double p)
    {
        double rad = (Math.PI / 180) * p;
        exp = new Complex(m * Math.Cos(rad), m * Math.Sin(rad));
    }


    public Ans Add()
    {
        Complex dig = Complex.Add(alg1, alg2);
        Debug.Log(alg1);
        Ans ans = new Ans(dig.Real, dig.Imaginary);
        return ans;
    }

    public Ans Multiply()
    {
        Complex dig = Complex.Multiply(alg1, alg2);

        Ans ans = new Ans(dig.Real, dig.Imaginary);
        return ans;
    }

    public Ans Difference()
    {
        Complex t = Complex.Multiply(alg2, -1.0);
        Complex dig = Complex.Add(alg1, t);

        Ans ans = new Ans(dig.Real, dig.Imaginary);
        return ans;
    }

    public Ans Divide()
    {
        Complex dig = Complex.Divide(alg1, alg2);

        Ans ans = new Ans(dig.Real, dig.Imaginary);
        return ans;
    }
    public Ans Exponentation()
    {
        Complex dig = new Complex();
        dig = Complex.Pow(alg, n);

        Ans ans = new Ans(dig.Real, dig.Imaginary);
        return ans;
    }

    public Ans ATE()
    {
        Ans ans = new Ans(alg.Magnitude, alg.Phase * 180 / Math.PI);
        return ans;
    }

    public Ans TAE()
    {
        Ans ans = new Ans(trig.Real, trig.Imaginary);
        return ans;
    }

    public Ans EAT()
    {
        Ans ans = new Ans(exp.Real, exp.Imaginary);
        return ans;
    }
    //??
    public Ans Roots()
    {
        int k = 1;
        double m = Math.Sqrt(alg.Magnitude);
        double p = ((alg.Phase * 180 / Math.PI) + 2 * Math.PI * k) / n;
        double rad = (Math.PI / 180) * p;
        Complex dig = new Complex(m * Math.Cos(rad), m * Math.Sin(rad));

        Ans ans = new Ans(dig.Real, dig.Imaginary);
        return ans;
    }
}
