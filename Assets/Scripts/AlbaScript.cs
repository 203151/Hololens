using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class AlbaScript : MonoBehaviour, IInputClickHandler
{

    static bool Used;
    //private static int Counter;
    // Use this for initialization
    void Start()
    {
        Used = false;
        //Counter = 0;

    }

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject selectedCard;
        // On each tap gesture, toggle whether the user is in placing mode.
        if(tag == "Hand")
        {
            selectedCard = GameObject.FindGameObjectWithTag("SelectedCard");
            if (selectedCard != null)
            {
                selectedCard.transform.position += new Vector3(0, 0, -0.05F);
                selectedCard.tag = "Hand";
            }
            tag = "SelectedCard";
            this.transform.position += new Vector3(0, 0, 0.05F);
        }
        else if (tag == "SelectedCard")
        {
            GameObject gameObject1 = GameObject.Find("Game Manager");

            //if (tag == "Table")
            {
                if ((Used == false))
                {
                    //Counter++;
                    Debug.Log("enetr if alba");
                    gameObject1.GetComponent<CardManager>().PlayCard(this.gameObject);

                    gameObject1.GetComponent<CardManager>().PlayCardFromDeck(0);
                    gameObject1.GetComponent<CardManager>().PlayCardFromDeck(1);

                    Used = true;
                }
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
