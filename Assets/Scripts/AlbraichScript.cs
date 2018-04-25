using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class AlbraichScript : MonoBehaviour, IInputClickHandler
{
    bool Used;
    //public CardManager cardManager;
	// Use this for initialization
	void Start () {
        Used = false;
		
	}

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject selectedCard;
        // On each tap gesture, toggle whether the user is in placing mode.
        if (tag == "Hand")
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
                    Debug.Log("enetr if Albraich");
                    gameObject1.GetComponent<CardManager>().PlayCard(this.gameObject);
                    gameObject.GetComponent<CardManager>().AlbraichDrawCard();
                    gameObject.GetComponent<CardManager>().AlbraichEnemyDrawCard();

                    Used = true;
                }
            }
        }

    }

    // Update is called once per frame
    void Update () {
       
		
	}
}
