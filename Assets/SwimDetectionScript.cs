using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimDetectionScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        other.gameObject.GetComponent<PlayerCharacterController>().swimming = true;
    }
    void OnTriggerExit(Collider other){
        other.gameObject.GetComponent<PlayerCharacterController>().swimming = false;
    }
}
