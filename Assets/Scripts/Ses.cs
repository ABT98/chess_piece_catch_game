using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ses : MonoBehaviour {
    public AudioSource At;
	
	void Start () {
       
	}
	
	
	void Update () {
		
	}
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        At.Play();
        
    }


}
