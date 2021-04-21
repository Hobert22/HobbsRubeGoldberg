using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    //not my own creation, got from https://www.youtube.com/watch?v=tNtOcDryKv4

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
