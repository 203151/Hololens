using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour {

    // Use this for initialization
    private GameObject[] Deck, Hand, Table, Graveyard, EnemyDeck, EnemyHand, EnemyTable;
    private int DeckSize, HandSize, TableSize, GraveyardSize, EnemyDeckSize, EnemyHandSize, EnemyTableSize;
    private bool StartHand;
    private GameObject SelectedCard;
    private int NumberOfPlayedCards = 0;

    public Vector3 BoardCoordinates;
    public int ScaleFactor;

    public Vector3 DeckCoordinates;
    public Vector3 EnemyDeckCoordinates;
    public Vector3 GraveyardCoordinates;
    public Vector3 EnemyGraveyardCoordinates;
    public Vector3 HandCoordinates;
    public Vector3 EnemyHandCoordinates;


    void Start ()
    {
        StartHand = false;
        Deck = new GameObject[35];
        Hand = new GameObject[35];
        Table = new GameObject[35];
        Graveyard = new GameObject[35];
        EnemyDeck = new GameObject[35];
        EnemyHand = new GameObject[35];
        EnemyTable = new GameObject[35];

        DeckCoordinates = BoardCoordinates + new Vector3(0.3F, 0, -0.2F);
        EnemyDeckCoordinates = BoardCoordinates + new Vector3(0.3F, 0, 0.2F);
        GraveyardCoordinates = BoardCoordinates + new Vector3(0.3F, 0, -0.1F);
        EnemyGraveyardCoordinates = BoardCoordinates + new Vector3(0.3F, 0, 0.1F);
        HandCoordinates = BoardCoordinates + new Vector3(-0.25F, 0.15F, -0.3F);
        EnemyHandCoordinates = BoardCoordinates + new Vector3(-0.25F, 0.15F, 0.3F);
        //NumberOfPlayedCards = 0;
        GameObject gameManager = GameObject.Find("Game Manager");
        gameManager.GetComponent<GameManager>().CreateMyDeck();
        gameManager.GetComponent<GameManager>().CreateOppDeck();

    }
	
	// Update is called once per frame
	void Update ()
    {

        Deck = GameObject.FindGameObjectsWithTag("Deck");
        DeckSize = Deck.Length;
        Hand = GameObject.FindGameObjectsWithTag("Hand");
        HandSize = Hand.Length;
        Table = GameObject.FindGameObjectsWithTag("Table");
        TableSize = Table.Length;
        Graveyard = GameObject.FindGameObjectsWithTag("Graveyard");
        GraveyardSize = Graveyard.Length;
        EnemyDeck = GameObject.FindGameObjectsWithTag("EnemyDeck");
        EnemyDeckSize = EnemyDeck.Length;
        EnemyHand = GameObject.FindGameObjectsWithTag("EnemyHand");
        EnemyHandSize = EnemyHand.Length;
        EnemyTable = GameObject.FindGameObjectsWithTag("EnemyTable");
        EnemyTableSize = EnemyTable.Length;

        //if ( Input.GetMouseButtonDown(0) )
        //{
        //    RaycastHit hit;
            
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    if ( Physics.Raycast(ray, out hit) )
        //    {
        //        if ( hit.transform.tag == "Deck" )
        //        {
        //            if( StartHand == false)
        //            {
        //                StartHand = true;

        //                for ( int i = 0; i < 10; i++ )
        //                {
        //                    DrawCard(i);
        //                    EnemyDrawCard(i);

        //                    //DrawCard(Deck[DeckSize - 1 - i], i);
        //                    //EnemyDrawCard(EnemyDeck[EnemyDeckSize - 1 - i], i);
        //                    //Debug.Log(DeckSize);
        //                }
                        
        //            }
                   
        //        }

        //        else if ( hit.transform.tag == "Hand" )
        //        {
                    

        //            if( hit.transform.gameObject != SelectedCard)
        //            {
        //                if(SelectedCard)
        //                {
        //                    UnSelectCard(SelectedCard);
        //                }

        //                SelectedCard = hit.transform.gameObject;
        //                SelectCard(SelectedCard);
        //            }
        //            else
        //            {
        //                PlayCard(SelectedCard);
        //                EnemyPlayCard();
        //                SelectedCard = null;
        //            }
                    
        //            //PlayCard(hit);
        //        }
        //    }
        //}


    }



    void SelectCard(GameObject gameObject)
    {
        gameObject.transform.position += new Vector3(0, 0, 0.05F);

    }

    void UnSelectCard(GameObject gameObject)
    {
        gameObject.transform.position += new Vector3(0, 0, -0.05F);

    }

    void ShowCard(GameObject gameObject)
    {

        //gameObject.transform.position = new Vector3(-1, 0, 2);
        //gameObject.transform.rotation = Quaternion.Euler(-30, 0, 0);
    }

    void SetLayerRecursively(GameObject obj, int newLayer)
    {
        if ( null == obj )
        {
            return;
        }

        obj.layer = newLayer;

        foreach ( Transform child in obj.transform )
        {
            if ( null == child )
            {
                continue;
            }
            SetLayerRecursively(child.gameObject, newLayer);
        }
    }


    public void PlayCard(GameObject gameObject)
    {
        MoveHand();
        gameObject.transform.tag = "Table";
        SetLayerRecursively(gameObject, 11);
        gameObject.transform.position = new Vector3(BoardCoordinates.x - 0.1F + ( Table.Length * 0.075F ), BoardCoordinates.y, BoardCoordinates.z - 0.02F);
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        
        NumberOfPlayedCards++;
       
    }

    public void VilgeEnemyPlayCardFromDeck(int i)
    {
        Debug.Log(EnemyTableSize);
        EnemyDeck[EnemyDeckSize - 1 - i].transform.tag = "EnemyTable";
        SetLayerRecursively(EnemyDeck[EnemyDeckSize - 1 - i], 10);
        EnemyDeck[EnemyDeckSize - 1 - i].transform.position = new Vector3(BoardCoordinates.x - 0.1F + ( ( EnemyTable.Length + i ) * 0.075F ), BoardCoordinates.y, BoardCoordinates.z + 0.14F);
        EnemyDeck[EnemyDeckSize - 1 - i].transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void VilgePlayCardFromDeck(int i)
    {
        Debug.Log(TableSize);
        Deck[DeckSize - 1 - i].transform.tag = "Table";
        SetLayerRecursively(Deck[DeckSize - 1 - i], 11);
        Deck[DeckSize - 1 - i].transform.position = new Vector3(-2 + ( ( Table.Length + i ) * 0.75F ), -2.95F, 4);
        Deck[DeckSize - 1 - i].transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void EnemyPlayCardFromDeck(int i)
    {
        Debug.Log(EnemyTableSize);
        EnemyDeck[EnemyDeckSize - 1 - i].transform.tag = "EnemyTable";
        SetLayerRecursively(EnemyDeck[EnemyDeckSize - 1 - i], 10);
        EnemyDeck[EnemyDeckSize - 1 - i].transform.position = new Vector3(-2 + ( (EnemyTable.Length + i + 1) * 0.75F ), -2.95F, 6);
        EnemyDeck[EnemyDeckSize - 1 - i].transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void PlayCardFromDeck(int i)
    {
        Debug.Log(TableSize);
        Deck[DeckSize - 1 - i].transform.tag = "Table";
        SetLayerRecursively(Deck[DeckSize - 1 - i], 11);
        Deck[DeckSize - 1 - i].transform.position = new Vector3(BoardCoordinates.x - 0.1F + ( ( Table.Length + i + 1 ) * 0.75F ), BoardCoordinates.y, BoardCoordinates.z - 0.02F);
        Deck[DeckSize - 1 - i].transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void EnemyPlayCard()
    {
        if(NumberOfPlayedCards == 1)
        {
            EnemyHand[2].transform.tag = "EnemyTable";
            SetLayerRecursively(EnemyHand[2], 10);
            EnemyMoveHand(2);
            EnemyHand[2].transform.position = new Vector3(-2 + ( EnemyTable.Length * 0.75F ), -2.95F, 6); 
            EnemyHand[2].transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if(NumberOfPlayedCards == 2)
        {
            EnemyHand[1].transform.tag = "EnemyTable";
            SetLayerRecursively(EnemyHand[1], 10);
            EnemyMoveHand(1);
            EnemyHand[1].transform.position = new Vector3(-2 + ( EnemyTable.Length * 0.75F ), -2.95F, 6);
            EnemyHand[1].transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (NumberOfPlayedCards == 3)
        {
            EnemyHand[5].transform.tag = "EnemyTable";
            SetLayerRecursively(EnemyHand[5], 10);
            EnemyMoveHand(5);
            EnemyHand[5].transform.position = new Vector3(-2 + ( EnemyTable.Length * 0.75F ), -2.95F, 6);
            EnemyHand[5].transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (NumberOfPlayedCards == 4)
        {
            EnemyHand[4].transform.tag = "EnemyTable";
            SetLayerRecursively(EnemyHand[4], 10);
            EnemyMoveHand(4);
            EnemyHand[4].transform.position = new Vector3(-2 + ( EnemyTable.Length * 0.75F ), -2.95F, 6);
            EnemyHand[4].transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void AlbraichDrawCard()
    {
        Deck[DeckSize - 1].transform.tag = "Hand";
        Deck[DeckSize - 1].transform.position = new Vector3(-3 + ( Hand.Length * 0.075F ) - ( 0.075F * 1 ), 0, -0.75F);
        Deck[DeckSize - 1].transform.rotation = Quaternion.Euler(-10, 0, 0);
    }

    public void AlbraichEnemyDrawCard()
    {
        EnemyDeck[EnemyDeckSize - 1].transform.tag = "EnemyHand";
        EnemyDeck[EnemyDeckSize - 1].transform.position = new Vector3(EnemyHandCoordinates.x + (EnemyHand.Length * 0.75F) - (0.75F * 1), EnemyHandCoordinates.y, EnemyHandCoordinates.z);
        EnemyDeck[EnemyDeckSize - 1].transform.rotation = Quaternion.Euler(-90, 0, 0);
    }

    public void DrawCard (int i)
    {
        
        Deck[DeckSize - 1 - i].transform.tag = "Hand";
        Deck[DeckSize - 1 - i].transform.position = new Vector3(HandCoordinates.x + (Hand.Length * 0.075F) + (0.075F * i), HandCoordinates.y, HandCoordinates.z );
        Deck[DeckSize - 1 - i].transform.rotation = Quaternion.Euler(-130, 180, 180);
    }

    public void EnemyDrawCard(int i)
    {
        EnemyDeck[EnemyDeckSize - 1 - i].transform.tag = "EnemyHand";
        EnemyDeck[EnemyDeckSize - 1 - i].transform.position = new Vector3(EnemyHandCoordinates.x + (EnemyHand.Length * 0.075F) + (0.075F * i), EnemyHandCoordinates.y, EnemyHandCoordinates.z );
        EnemyDeck[EnemyDeckSize - 1 - i].transform.rotation = Quaternion.Euler(-90, 0, 180);
    }

    public void EnemyDrawCardRevealed(int i)
    {
        EnemyDeck[EnemyDeckSize - 1 - i].transform.tag = "EnemyHand";
        EnemyDeck[EnemyDeckSize - 1 - i].transform.position = new Vector3(EnemyHandCoordinates.x + (EnemyHand.Length * 0.75F) + (0.75F * i), EnemyHandCoordinates.y, EnemyHandCoordinates.z);
        EnemyDeck[EnemyDeckSize - 1 - i].transform.rotation = Quaternion.Euler(-90, 0, 0);
    }

    public void HighlightAllCardOnBoard()
    {
        GameObject gameObject = GameObject.Find("Directional Light");
        gameObject.GetComponent<Light>().cullingMask = 0;
        gameObject.GetComponent<Light>().cullingMask |= 1 << LayerMask.NameToLayer("MyBoard");
        gameObject.GetComponent<Light>().cullingMask |= 1 << LayerMask.NameToLayer("EnemyBoard");
    }

    public void HighlightCardOnBoard()
    {
        GameObject gameObject = GameObject.Find("Directional Light");
        gameObject.GetComponent<Light>().cullingMask = 0;
        gameObject.GetComponent<Light>().cullingMask |= 1 << LayerMask.NameToLayer("MyBoard");
    }

    public void HighlightEnemyCardOnBoard()
    {
        GameObject gameObject = GameObject.Find("Directional Light");
        gameObject.GetComponent<Light>().cullingMask = 0;
        gameObject.GetComponent<Light>().cullingMask |= 1 << LayerMask.NameToLayer("EnemyBoard");
    }

    public void UnHighlightCardOnBoard()
    {
        GameObject gameObject = GameObject.Find("Directional Light");
        gameObject.GetComponent<Light>().cullingMask = -1;
    }

    public void UnHighlightEnemyCardOnBoard()
    {
        GameObject gameObject = GameObject.Find("Directional Light");
        gameObject.GetComponent<Light>().cullingMask = -1;
    }

    void MoveHand()
    {
        GameObject selectedCard;
        selectedCard = GameObject.FindGameObjectWithTag("SelectedCard");
        //Debug.Log(HandSize);
        for ( int i = 0; i < HandSize; i++ )
        {
            if(selectedCard.transform.position.x - Hand[i].transform.position.x < 0)
            {
                Hand[i].transform.position = new Vector3(Hand[i].transform.position.x - 0.075F, Hand[i].transform.position.y, Hand[i].transform.position.z); 
            }

        }
    }

    void EnemyMoveHand(int j)
    {
        for ( int i = 0; i < EnemyHandSize; i++ )
        {
            if ( EnemyHand[j].transform.position.x - EnemyHand[i].transform.position.x < 0 )
            {
                EnemyHand[i].transform.position = new Vector3(EnemyHand[i].transform.position.x - 0.075F, EnemyHand[i].transform.position.y, EnemyHand[i].transform.position.z);
            }

        }
    }

}
