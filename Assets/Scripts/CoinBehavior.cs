using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        // todo: test if the other object is the player

        //find an object which have levelmanager script attached and collect coin funct to it
        FindObjectOfType<LevelManager>().CollectCoin();

        // destroy the coin
        Destroy(this.gameObject);


    }

    // Update is called once per frame
   
}
