using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwards : MonoBehaviour
{
    //same as the MoveTransform, but I tweaked it a bit to move backwards

    public void Update()
    {
        transform.position -= transform.forward * Time.deltaTime;     
    }
}
