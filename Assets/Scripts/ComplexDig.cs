/*using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System;

public class ComplexDig
{
    public Complex dig;
    ComplexDig()
    {
        this.dig = new Complex(0, 0); 
    }

    *//*ComplexDig(string name)
    {
        this.dig = new Complex(0, 0);
        switch (name)
        {
            case == "alg":
                this.Alg(this.dig.)
        }
    }

    public struct Alg
    {
        public double real;
        public double imaginary;

        public Alg(double r, double i)
        {
            real = r;
            imaginary = i;
        }
    }

    public struct Trig
    {
        public double magnitude;
        public double phase;

        public Trig(double m, double p)
        {
            magnitude = m;
            phase = p;
        }
    }

    public 
        struct Exp
    {
        public double magnitude;
        public double phase;

        public Exp(double m, double p)
        {
            magnitude = m;
            phase = p;
        }
    }*//*

    //changing
    public void ChangeDigR(double digr)
    {
        dig = new Complex(digr, dig.Imaginary); 
    }

    public void ChangeDigI(double digi)
    {
        dig = new Complex(dig.Real, digi);
    }


    //form
    public Trig TrigForm(Complex dig)
    {
        return new Trig(dig.Magnitude, dig.Phase * 180 / Math.PI);
    }

    public Exp ExpForm(Complex dig)
    {
        return new Exp(dig.Magnitude, dig.Phase * 180 / Math.PI);
    }
    

    //operation
    public Complex Sum(ComplexDig dig2)
    {
        return Complex.Add(this.dig, dig2.dig);
    }

    public Complex Difference(ComplexDig dig2)
    {
        Complex t = Complex.Multiply(dig2.dig, -1.0);
        return Complex.Add(this.dig, t);
    }
    public Complex Multiply(ComplexDig dig2)
    {
        return Complex.Multiply(dig, dig2.dig);
    }
    public Complex Divide(ComplexDig dig2)
    {
        return Complex.Divide(dig, dig2.dig);
    }
    public Complex Exponentation(int n)
    {
        return Complex.Pow(dig, n); ;
    }

    *//*//?????
    public Complex RootOfIntDegree()
    {
        return ; 
    }*//*
}*/