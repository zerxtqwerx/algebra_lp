using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISwitch : MonoBehaviour
{
    public GameObject alg1;
    public GameObject alg2;
    public GameObject alg;
    public GameObject trig;
    public GameObject exp;
    public GameObject n;

    public GameObject add;
    public GameObject mult;
    public GameObject diff;
    public GameObject divide;
    public GameObject ate;
    public GameObject tae;
    public GameObject eat;
    public GameObject expon;
    public GameObject roots;

    void Start()
    {
        alg1.SetActive(false);
        alg2.SetActive(false);

        alg.SetActive(false);
        trig.SetActive(false);
        exp.SetActive(false);

        n.SetActive(false);

        add.SetActive(false);
        mult.SetActive(false);
        diff.SetActive(false);
        divide.SetActive(false);
        ate.SetActive(false);
        tae.SetActive(false);
        eat.SetActive(false);
        expon.SetActive(false);
        roots.SetActive(false);
    }

    public void OnButtonClick_Add()
    {
        alg1.SetActive(true);
        alg2.SetActive(true);

        alg.SetActive(false);
        trig.SetActive(false);
        exp.SetActive(false);

        n.SetActive(false);

        add.SetActive(true);
        mult.SetActive(false);
        diff.SetActive(false);
        divide.SetActive(false);
        ate.SetActive(false);
        tae.SetActive(false);
        eat.SetActive(false);
        expon.SetActive(false);
        roots.SetActive(false);
    }
    public void OnButtonClick_Mult()
    {
        alg1.SetActive(true);
        alg2.SetActive(true);

        alg.SetActive(false);
        trig.SetActive(false);
        exp.SetActive(false);

        n.SetActive(false);

        add.SetActive(false);
        mult.SetActive(true);
        diff.SetActive(false);
        divide.SetActive(false);
        ate.SetActive(false);
        tae.SetActive(false);
        eat.SetActive(false);
        expon.SetActive(false);
        roots.SetActive(false);
    }
    public void OnButtonClick_Diff()
    {
        alg1.SetActive(true);
        alg2.SetActive(true);

        alg.SetActive(false);
        trig.SetActive(false);
        exp.SetActive(false);

        n.SetActive(false);

        add.SetActive(false);
        mult.SetActive(false);
        diff.SetActive(true);
        divide.SetActive(false);
        ate.SetActive(false);
        tae.SetActive(false);
        eat.SetActive(false);
        expon.SetActive(false);
        roots.SetActive(false);
    }
    public void OnButtonClick_Div()
    {
        alg1.SetActive(true);
        alg2.SetActive(true);

        alg.SetActive(false);
        trig.SetActive(false);
        exp.SetActive(false);

        n.SetActive(false);

        add.SetActive(false);
        mult.SetActive(false);
        diff.SetActive(false);
        divide.SetActive(true);
        ate.SetActive(false);
        tae.SetActive(false);
        eat.SetActive(false);
        expon.SetActive(false);
        roots.SetActive(false);
    }
    public void OnButtonClick_ate()
    {
        alg1.SetActive(false);
        alg2.SetActive(false);

        alg.SetActive(true);
        trig.SetActive(false);
        exp.SetActive(false);

        n.SetActive(false);

        add.SetActive(false);
        mult.SetActive(false);
        diff.SetActive(false);
        divide.SetActive(false);
        ate.SetActive(true);
        tae.SetActive(false);
        eat.SetActive(false);
        expon.SetActive(false);
        roots.SetActive(false);
    }
    public void OnButtonClick_tae()
    {
        alg1.SetActive(false);
        alg2.SetActive(false);

        alg.SetActive(false);
        trig.SetActive(true);
        exp.SetActive(false);

        n.SetActive(false);

        add.SetActive(true);
        mult.SetActive(false);
        diff.SetActive(false);
        divide.SetActive(false);
        ate.SetActive(false);
        tae.SetActive(true);
        eat.SetActive(false);
        expon.SetActive(false);
        roots.SetActive(false);
    }
    public void OnButtonClick_eat()
    {
        alg1.SetActive(false);
        alg2.SetActive(false);

        alg.SetActive(false);
        trig.SetActive(false);
        exp.SetActive(true);

        n.SetActive(false);

        add.SetActive(false);
        mult.SetActive(false);
        diff.SetActive(false);
        divide.SetActive(false);
        ate.SetActive(false);
        tae.SetActive(false);
        eat.SetActive(true);
        expon.SetActive(false);
        roots.SetActive(false);
    }
    public void OnButtonClick_exp()
    {
        alg1.SetActive(false);
        alg2.SetActive(false);

        alg.SetActive(true);
        trig.SetActive(false);
        exp.SetActive(false);

        n.SetActive(true);

        add.SetActive(true);
        mult.SetActive(false);
        diff.SetActive(false);
        divide.SetActive(false);
        ate.SetActive(false);
        tae.SetActive(false);
        eat.SetActive(false);
        expon.SetActive(true);
        roots.SetActive(false);
    }
    public void OnButtonClick_roots()
    {
        alg1.SetActive(false);
        alg2.SetActive(false);

        alg.SetActive(true);
        trig.SetActive(false);
        exp.SetActive(false);

        n.SetActive(true);

        add.SetActive(true);
        mult.SetActive(false);
        diff.SetActive(false);
        divide.SetActive(false);
        ate.SetActive(false);
        tae.SetActive(false);
        eat.SetActive(false);
        expon.SetActive(false);
        roots.SetActive(true);
    }
}
