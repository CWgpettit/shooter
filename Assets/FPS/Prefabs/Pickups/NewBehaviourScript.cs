using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
public int score=0;
public Text Score;
public AudioSource PickupSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
private void OnTriggerEnter(Collider other){

Destroy(other.transform.gameObject);
score++;
Score.text="Score:"+score.ToString();
}
}
