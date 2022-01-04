using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0f,0f,vertical*0.01f),Space.World);
    }
}
