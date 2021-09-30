using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimDetectionScript : MonoBehaviour
{
   void OnTriggerEnter(Collider other){
       print ("water");
   }
}
