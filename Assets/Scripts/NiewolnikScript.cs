using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class NiewolnikScript : MonoBehaviour, IInputClickHandler
{

    static bool Used;
    public GameObject gameObject;
    GameObject Created;
    // Use this for initialization
    void Start ()
    {
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
                    Debug.Log("enetr if niewolnik");
                    gameObject1.GetComponent<CardManager>().PlayCard(this.gameObject);
                    Vector3 Pos;
                    Quaternion Qua = Quaternion.Euler(0, 0, 0);


                    Pos = new Vector3(-0.5F, -2.95F, 2.5F);
                    Created = Instantiate(gameObject, Pos, Qua);
                    Created.tag = "SecondRow";
                    Created.layer = 11;

                    Pos = new Vector3(-0.5F, -2.95F, 1.1F);
                    Created = Instantiate(gameObject, Pos, Qua);
                    Created.tag = "ThirdRow";
                    Created.layer = 11;
                    Used = true;
                }
            }
        }

    }

    // Update is called once per frame
    void Update ()
    {
       
    }
}
