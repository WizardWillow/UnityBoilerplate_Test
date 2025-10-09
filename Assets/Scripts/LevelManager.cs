using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    int coinscollected = 0;

    public void CollectCoin()
    {
        coinscollected++;
    }

    public int GetCoinsCollected()
    { 
    return coinscollected;
    }
}