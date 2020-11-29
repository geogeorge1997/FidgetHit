using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFun : MonoBehaviour {

    public int i, SLimit, S, R, L;
    public string PG = "pg";

    public GameObject Fidget;
    public int g = 0;
    public int c = 0;
    public int q = 0;

	public void Starts () {
        q = 0;
        i = 1;
        SLimit = PlayerPrefs.GetInt("PSLimit", 0);
        PG = "pg";
        PG = PG + i;
        PG = PG + "s";
        S = PlayerPrefs.GetInt(PG, 0);
        PG = "pg";
        PG = PG + i;
        PG = PG + "r";
        R = PlayerPrefs.GetInt(PG, 0);
        PG = "pg";
        PG = PG + i;
        PG = PG + "l";
        L = PlayerPrefs.GetInt(PG, 0);
        c = S;
        c = c * 60;
        g = 1;

    }
	
	void Update ()
    {
        if (g==1&&q<=c)
        {
            Fidget.transform.Rotate(0, 0, R);
            Fidget.transform.Rotate(0, 0, -L);
            q = q + 1;
        }
        if (g==1&&q == c)
        {
            Invoke("Help", 0);
        }
    }

    void Help()
    {
        i = i + 1;
        SLimit = PlayerPrefs.GetInt("PSLimit", 0);
        if (i <= SLimit)
        {
            PG = "pg";
            PG = PG + i;
            PG = PG + "s";
            S = PlayerPrefs.GetInt(PG, 0);
            PG = "pg";
            PG = PG + i;
            PG = PG + "r";
            R = PlayerPrefs.GetInt(PG, 0);
            PG = "pg";
            PG = PG + i;
            PG = PG + "l";
            L = PlayerPrefs.GetInt(PG, 0);
            c = S;
            c = c * 60;
            q = 0;
            g = 1;
        }
        else
        {
            g = 0;
            i = 1;
        }
    }

}