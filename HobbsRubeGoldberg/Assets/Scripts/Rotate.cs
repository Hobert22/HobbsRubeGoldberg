using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //also not my original code, got from https://www.youtube.com/watch?v=OwIE3GI8Rdg
    //However i did remix it to be input related

    public float xAxis;
    public float yAxis;
    public float zAxis;
    

    void Update()
    {
        transform.Rotate(new Vector3(xAxis,yAxis,zAxis));
    }
}
