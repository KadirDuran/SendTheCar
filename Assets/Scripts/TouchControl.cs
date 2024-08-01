using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControl : MonoBehaviour
{
    GameManagerX gameManager;
    private void Start()
    {
        gameManager = GetComponent<GameManagerX>();
    }
    private void OnMouseDown()
    {
        gameManager.CreateCar();
    }
}
