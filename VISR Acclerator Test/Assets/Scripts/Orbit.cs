using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

 
    public Transform centerPoint;
 

    void Start()
    {
    
    }


    void Update()
    {

        Rotate();

    }

    void Rotate()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(centerPoint.position, Vector3.up, 1);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(centerPoint.position, Vector3.up, -1);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(centerPoint.position, Vector3.right, 1);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAround(centerPoint.position, Vector3.right, -1);
        }

    }
}