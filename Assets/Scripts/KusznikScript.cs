using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class KusznikScript : MonoBehaviour, IInputClickHandler
{

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        
        if (tag == "Hand")
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
            GameObject gameObject1 = GameObject.Find("Game Manager");
            Debug.Log("enetr if kusznik");
            gameObject1.GetComponent<CardManager>().PlayCard(this.gameObject);

        }

    }

}
