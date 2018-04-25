using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class VilgeScript : MonoBehaviour, IInputClickHandler
{

    bool Used;
    // Use this for initialization
    void Start()
    {
        Used = false;
    }

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject selectedCard;
        Debug.Log("kliknale w vilge");
        // On each tap gesture, toggle whether the user is in placing mode.
        if (tag == "Hand")
        {
            selectedCard = GameObject.FindGameObjectWithTag("SelectedCard");
            if(selectedCard != null)
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
                    Debug.Log("enetr if Vilge");
                    gameObject1.GetComponent<CardManager>().PlayCard(this.gameObject);
                    Used = true;
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        //if ( tag == "Table" )
        //{
        //    if ( Used == false )
        //    {
        //        Debug.Log("enetr if vilge");
        //        GameObject gameObject = GameObject.Find("Game Manager");
        //        gameObject.GetComponent<CardManager>().HighlightAllCardOnBoard();
                

        //        if ( Input.GetMouseButtonDown(0) )
        //        {
        //            RaycastHit hit;

        //            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //            if ( Physics.Raycast(ray, out hit) )
        //            {
        //                if ( hit.transform.tag == "EnemyTable" )
        //                {
        //                    hit.transform.position = new Vector3(6, -2.95F, 6);
        //                    hit.transform.rotation = Quaternion.Euler(0, 0, 0);
        //                    hit.transform.gameObject.tag = "EnemyGraveyard";
        //                    Used = true;
        //                    gameObject.GetComponent<CardManager>().UnHighlightEnemyCardOnBoard();
        //                    gameObject.GetComponent<CardManager>().UnHighlightCardOnBoard();
        //                    gameObject.GetComponent<CardManager>().EnemyPlayCardFromDeck(0);

        //                }

        //                else if (hit.transform.tag == "Table")
        //                {
        //                    hit.transform.position = new Vector3(6, -2.95F, 3);
        //                    hit.transform.rotation = Quaternion.Euler(0, 0, 0);
        //                    hit.transform.gameObject.tag = "Graveyard";
        //                    Used = true;
        //                    gameObject.GetComponent<CardManager>().UnHighlightEnemyCardOnBoard();
        //                    gameObject.GetComponent<CardManager>().UnHighlightCardOnBoard();
        //                    gameObject.GetComponent<CardManager>().PlayCardFromDeck(0);
        //                }
        //            }
        //        }

           
        //        Debug.Log("exit if vilge");
        //    }

        //}
    }
}
