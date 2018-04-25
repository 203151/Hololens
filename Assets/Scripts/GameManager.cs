using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject DefaultPrefab;
    public GameObject BronzePrefab1;
    public GameObject BronzePrefab2;
    public GameObject BronzePrefab3;
    public GameObject BronzePrefab4;
    public GameObject SilverPrefab5;
    public GameObject SilverPrefab6;
    public GameObject SilverPrefab7;
    public GameObject GoldPrefab8;
    public GameObject GoldPrefab9;
    public GameObject OppBronzePrefab10;
    public GameObject OppBronzePrefab11;
    public GameObject OppSilverPrefab12;
    public int NumberOfCards;
    
    // Use this for initialization
    void Start()
    {
      
    }

    public void CreateOppDeck()
    {
        GameObject gameManager = GameObject.Find("Game Manager");
        CardManager cardmanager = gameManager.GetComponent<CardManager>();
        
        Vector3 Pos;
        Quaternion Qua = Quaternion.Euler(0, 0, 180);
        for ( int i = 0; i < NumberOfCards; i++ )
        {
            Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( i * 0.002F ), cardmanager.EnemyDeckCoordinates.z);
            Instantiate(OppBronzePrefab10, Pos, Qua);
        }

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ), cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.002F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab11, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.004F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab11, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.006F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.008F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.01F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.012F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.014F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.016F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.018F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.02F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab11, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.022F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppSilverPrefab12, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.024F, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);
    }

    public void CreateMyDeck()
    {
        GameObject gameManager = GameObject.Find("Game Manager");
        CardManager cardmanager = gameManager.GetComponent<CardManager>();
        Vector3 Pos;
        Quaternion Qua = Quaternion.Euler(0, 0, 180);
        for ( int i = 0; i < NumberOfCards; i++ )
        {
            Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( i * 0.002F ), cardmanager.DeckCoordinates.z);
            Instantiate(DefaultPrefab, Pos, Qua);
        }

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ), cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab3, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.002F, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab1, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.004F, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab1, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.006F, cardmanager.DeckCoordinates.z);
        Instantiate(GoldPrefab9, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.008F, cardmanager.DeckCoordinates.z);
        Instantiate(GoldPrefab8, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.01F, cardmanager.DeckCoordinates.z);
        Instantiate(SilverPrefab7, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.012F, cardmanager.DeckCoordinates.z);
        Instantiate(SilverPrefab6, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.014F, cardmanager.DeckCoordinates.z);
        Instantiate(SilverPrefab5, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.016F, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab4, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.018F, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab3, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.02F, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab2, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.022F, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab2, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * 0.002F ) + 0.024F, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab1, Pos, Qua);
    }
    
}
