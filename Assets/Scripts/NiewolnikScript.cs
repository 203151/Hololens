using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class NiewolnikScript : MonoBehaviour, IInputClickHandler
{

    public GameObject referenceGameObject;
    GameObject Created;


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
            GameObject gameManager = GameObject.Find("Game Manager");

            Debug.Log("enetr if niewolnik");
            gameManager.GetComponent<CardManager>().PlayCard(this.gameObject);
            Vector3 Pos;
            Quaternion Qua = Quaternion.Euler(0, 0, 0);

            Pos = new Vector3(-0.5F, -2.95F, 2.5F);
            Created = Instantiate(referenceGameObject, Pos, Qua);
            Created.tag = "SecondRow";
            Created.layer = 11;

            Pos = new Vector3(-0.5F, -2.95F, 1.1F);
            Created = Instantiate(referenceGameObject, Pos, Qua);
            Created.tag = "ThirdRow";
            Created.layer = 11;
                    
  
        }

    }

}
