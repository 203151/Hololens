using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class KusznikScript : MonoBehaviour, IInputClickHandler
{
    bool Used;
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
                    Debug.Log("enetr if kusznik");
                    gameObject1.GetComponent<CardManager>().PlayCard(this.gameObject);

                    // gameObject.GetComponent<CardManager>().EnemyPlayCardFromDeck(0);
                    //gameObject.GetComponent<CardManager>().EnemyPlayCardFromDeck(1);
                    Used = true;
                }
            }
        }

    }

    // Update is called once per frame
    void Update ()
    {
        //if ( tag == "Table" )
        //{
        //    if ( Used == false )
        //    {
        //        Debug.Log("enetr if kusznik");
        //        GameObject gameObject = GameObject.Find("Game Manager");
        //        gameObject.GetComponent<CardManager>().HighlightEnemyCardOnBoard();

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
        //                }
        //            }
        //        }

                
        //        Debug.Log("exit if kusznik");
        //    }

        //}
    }
}
