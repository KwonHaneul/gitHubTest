using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDebug : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log(gameObject.name + " OnTriggerEnter: " + other.gameObject.name);
    }
}
