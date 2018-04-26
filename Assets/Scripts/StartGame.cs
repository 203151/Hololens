using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class StartGame : MonoBehaviour, IInputClickHandler
{

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject gameManager = GameObject.Find("Game Manager");
        
        for (int i = 0; i < 10; i++)
        {
            gameManager.GetComponent<CardManager>().DrawCard(i);
            gameManager.GetComponent<CardManager>().EnemyDrawCard(i);

        }
        DestroyObject(gameObject);
    }

}
