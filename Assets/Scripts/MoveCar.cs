using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCar : MonoBehaviour
{
    public Transform pathParentFirst;
    public Transform pathParentsSecond;
    public Sprite cars;

    private void Start()
    {
        CreatePath(pathParentFirst, 1, Vector2.up);
    }
    

    void CreatePath(Transform pathParent, int loop,Vector2 c)
    {
        Vector3[] vectors = new Vector3[pathParent.childCount];

        for (int i = 0; i < vectors.Length; i++)
        {
            vectors[i] = pathParent.GetChild(i).position;
        }
        if(loop==-1)GetComponent<SpriteRenderer>().sprite = cars;
        transform.DOPath(vectors, vectors.Length, PathType.CatmullRom)
           .SetLookAt(0.0001f,c)
           .SetLoops(loop)
           .SetEase(Ease.Linear).OnKill(() =>
           {
               CreatePath(pathParentsSecond, -1, Vector2.left);
           }
         ); 
           
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Car")
        {
            Debug.Log("Çarpýþma");
            SceneManager.LoadScene(0);
        }
    }
}
