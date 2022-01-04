using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDebug : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log(gameObject.name + " CollisionEnter: "+ other.gameObject.name);
    }
}
