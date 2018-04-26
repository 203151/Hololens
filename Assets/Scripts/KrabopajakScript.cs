using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KrabopajakScript : MonoBehaviour
{
    private static bool Used;

    void Start ()
    {
        Used = false;
	}

    // Update is called once per frame
    void Update()
    {
        if ( tag == "EnemyTable" )
        {
            if ( (Used == false))
            {

                Debug.Log("enetr if krabopajak");
                GameObject gameObject = GameObject.Find("Game Manager");
                
                gameObject.GetComponent<CardManager>().EnemyPlayCardFromDeck(0);
                gameObject.GetComponent<CardManager>().EnemyPlayCardFromDeck(1);

                Used = true;
            }
        }
    }
}
