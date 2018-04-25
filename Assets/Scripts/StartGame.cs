using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class StartGame : MonoBehaviour, IInputClickHandler
{

	// Use this for initialization
	void Start () {
		
	}

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {

        
        GameObject gameManager1 = GameObject.Find("Game Manager");
        Debug.Log("kliknalem w kostke");
        for (int i = 0; i < 10; i++)
        {
            gameManager1.GetComponent<CardManager>().DrawCard(i);
            gameManager1.GetComponent<CardManager>().EnemyDrawCard(i);

        }
        DestroyObject(gameObject);
    }

        // Update is called once per frame
        void Update () {
		
	}
}
