using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System;

public class ComplexDig
{
    public Complex dig1 = new Complex(0,0);
    public Complex dig2 = new Complex(0,0);
    public int n = 0;

    struct Trig
    {
        public double magnitude;
        public double phase;

        public Trig(double m, double p)
        {
            magnitude = m;
            phase = p;
        }
    }

    struct Exp
    {
        public double magnitude;
        public double phase;

        public Exp(double m, double p)
        {
            magnitude = m;
            phase = p;
        }
    }

    void ChangeDig1R(double dig1r)
    {
        dig1 = new Complex(dig1r, dig1.Imaginary); 
    }

    void ChangeDig1I(double dig1i)
    {
        dig1 = new Complex(dig1.Real, dig1i);
    }

    void ChangeDig2R(double dig2r)
    {
        dig2 = new Complex(dig2r, dig2.Imaginary);
    }

    void ChangeDig2I(double dig2i)
    {
        dig2 = new Complex(dig2.Real, dig2i);
    }

    Trig TrigForm(Complex dig)
    {
        return new Trig(dig.Magnitude, dig.Phase * 180 / Math.PI);
    }

    Exp ExpForm(Complex dig)
    {
        return new Exp(dig.Magnitude, dig.Phase * 180 / Math.PI);
    }

    Complex Sum()
    {
        return Complex.Add(dig1, dig2);
    }

    Complex Difference()
    {
        Complex t = Complex.Multiply(dig2, -1.0);
        return Complex.Add(dig1, t);
    }
    Complex Multiply()
    {
        return Complex.Multiply(dig1, dig2);
    }
    Complex Divide()
    {
        return Complex.Divide(dig1, dig2);
    }
    Complex Exponentation()
    {
        return Complex.Pow(dig1, n); ;
    }

    //?????
    Complex RootOfIntDegree()
    {
        return Complex.Add(dig1, dig2);
    }
}