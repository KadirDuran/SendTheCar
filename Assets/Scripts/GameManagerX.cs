using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.ComponentModel;
using TMPro;

public class GameManagerX : MonoBehaviour
{
    public GameObject cars;
    public Transform startPoint,p0,p1;
    public TextMeshProUGUI txtScore;
    int i = 0;
  
    public void CreateCar()
    {
        GameObject car = Instantiate(cars, startPoint.position, Quaternion.identity);
        car.GetComponent<MoveCar>().pathParentFirst = p0;
        car.GetComponent<MoveCar>().pathParentsSecond = p1;

        i++;
        txtScore.text = i.ToString();
    }
}
