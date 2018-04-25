using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class LowcaScript : MonoBehaviour, IInputClickHandler
{

	// Use this for initialization
	void Start () {
		
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
            gameObject1.GetComponent<CardManager>().PlayCard(this.gameObject);
            //if (tag == "Table")
            {
                //if ((Used == false))
                //{
                //    Debug.Log("enetr if lowca");


                //    //gameObject.GetComponent<CardManager>().EnemyPlayCardFromDeck(0);
                //    //gameObject.GetComponent<CardManager>().EnemyPlayCardFromDeck(1);
                //    Used = true;
                //}
            }
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
