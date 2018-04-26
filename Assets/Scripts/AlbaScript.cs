using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class AlbaScript : MonoBehaviour, IInputClickHandler
{

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
       
        
        if(tag == "Hand")
        {
            GameObject selectedCard;
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
            GameObject gameManager = GameObject.Find("Game Manager");
            Debug.Log("enetr if alba");

            gameManager.GetComponent<CardManager>().PlayCard(this.gameObject);
            gameManager.GetComponent<CardManager>().PlayCardFromDeck(0);
            gameManager.GetComponent<CardManager>().PlayCardFromDeck(1);

        }
       
    }

}
