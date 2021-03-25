using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour {
    public GameObject gj;
    public int can = 3;
    public Text skor;

    

	// Use this for initialization
	void Start () {
       		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "At")
        {
            can--;
            Destroy(coll.gameObject);
        }
        if (can == 0)
        {
            Time.timeScale = 0;
            skor.text = "ÖLDÜN";
            gj.SetActive(true);
            
        }
    }
}
