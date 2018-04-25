using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KrabopajakScript : MonoBehaviour
{
    static bool Used;
    //private static int Counter;
    // Use this for initialization
    void Start () {
        Used = false;
        //Counter = 0;
		
	}

    

    // Update is called once per frame
    void Update()
    {
        if ( tag == "EnemyTable" )
        {
            if ( (Used == false))
            {

                
                //Counter++;
                Debug.Log("enetr if krabopajak");
                GameObject gameObject = GameObject.Find("Game Manager");
                
                gameObject.GetComponent<CardManager>().EnemyPlayCardFromDeck(0);
                gameObject.GetComponent<CardManager>().EnemyPlayCardFromDeck(1);

                Used = true;
            }
        }
    }
}
