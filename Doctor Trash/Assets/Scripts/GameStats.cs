using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStats
{
    private static int clout  = 0;
    private static double btc = 0;


    public static int Clout
    {
        get
        {
            return clout;
        }
        set
        {
            clout = value;
        }

    }

    public static double BTC
    {
        get 
        {
            return btc;
        }
        set 
        {
            btc = value;
        }
    }



}
