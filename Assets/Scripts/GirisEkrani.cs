using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GirisEkrani : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Baslat()
    {
        
        Application.LoadLevel("OyunEkrani");
        
    }
    public void Kapat()
    {
        Application.Quit();
    }

    public void Hazirlayanlar()
    {
        Application.LoadLevel("Hazirlayan");
    }
    
}
