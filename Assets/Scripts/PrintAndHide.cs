using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    //private Prefab redPrefab;
    int i;
    int j;
    //Start is called before the first frame update
    void Start()
    {
        i = 3;
        j = UnityEngine.Random.Range(200, 251);
      //  redPrefab = GetComponent<RedPrefab>();
        //j = rnd.Next(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        if (rend.CompareTag("Red") && i == 101)
        {
            rend.gameObject.SetActive(false);
            Debug.Log(gameObject.name + ":" + ++i);

        }
        if (rend.CompareTag("Blue") && i == j)
        {
            rend.enabled = !rend.enabled;
            Debug.Log(gameObject.name + ":" + ++i);

        }

        else if (rend.gameObject.active)
        {
            Debug.Log(gameObject.name + ":" + ++i);
        }
        
    }
}
