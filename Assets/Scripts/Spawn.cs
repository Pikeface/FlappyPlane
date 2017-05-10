using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    public GameObject rock4;
    public GameObject[] selectorArr;
    public GameObject selector;
    public int num = 4;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 2f);
    }

    void CreateObstacle()
    {
        for (int i = 0; i < num; i++)
        {
            Instantiate(rock1);
        }

    }
}