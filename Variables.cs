using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
 public int health = 10 ;
 private float speed = 1 ;
 public int level = 1 ;


    // Start is called before the first frame update
    void Start()
    {
        health = health + level ;
        print ("lives:" + health) ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position ;
        newPosition.x += speed * Time.deltaTime ;
        transform.position = newPosition ;
    }
}
