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
    public Transform cardDimentios;
    public int NumberOfCards;
    

    public void CreateOppDeck()
    {
        GameObject gameManager = GameObject.Find("Game Manager");
        CardManager cardmanager = gameManager.GetComponent<CardManager>();
        
        Vector3 Pos;
        Quaternion Qua = Quaternion.Euler(0, 0, 180);
        for ( int i = 0; i < NumberOfCards; i++ )
        {
            Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( i * cardDimentios.localScale.y ), cardmanager.EnemyDeckCoordinates.z);
            Instantiate(OppBronzePrefab10, Pos, Qua);
        }

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ), cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab11, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 2, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab11, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 3, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 4, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 5, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 6, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 7, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 8, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 9, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab10, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 10, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppBronzePrefab11, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 11, cardmanager.EnemyDeckCoordinates.z);
        Instantiate(OppSilverPrefab12, Pos, Qua);

        Pos = new Vector3(cardmanager.EnemyDeckCoordinates.x, cardmanager.EnemyDeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 12, cardmanager.EnemyDeckCoordinates.z);
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
            Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( i * cardDimentios.localScale.y ), cardmanager.DeckCoordinates.z);
            Instantiate(DefaultPrefab, Pos, Qua);
        }

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ), cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab3, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab1, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 2, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab1, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 3, cardmanager.DeckCoordinates.z);
        Instantiate(GoldPrefab9, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 4, cardmanager.DeckCoordinates.z);
        Instantiate(GoldPrefab8, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 5, cardmanager.DeckCoordinates.z);
        Instantiate(SilverPrefab7, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 6, cardmanager.DeckCoordinates.z);
        Instantiate(SilverPrefab6, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 7, cardmanager.DeckCoordinates.z);
        Instantiate(SilverPrefab5, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 8, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab4, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 9, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab3, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 10, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab2, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 11, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab2, Pos, Qua);

        Pos = new Vector3(cardmanager.DeckCoordinates.x, cardmanager.DeckCoordinates.y + ( NumberOfCards * cardDimentios.localScale.y ) + cardDimentios.localScale.y * 12, cardmanager.DeckCoordinates.z);
        Instantiate(BronzePrefab1, Pos, Qua);
    }
    
}
