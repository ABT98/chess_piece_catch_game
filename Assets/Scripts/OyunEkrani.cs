using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunEkrani : MonoBehaviour {
    public GameObject Butonlar;
    bool isMute;
    public GameObject mute;
    public GameObject notMute;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Cikis()
    {
        Application.LoadLevel("GirisEkrani");
    }
    
    public void Durdur()
    {
        
        Time.timeScale = 0;
        Butonlar.SetActive(true);
    }

    public void Devam()
    {
        Time.timeScale = 1;
        Butonlar.SetActive(false);
    }

    public void Restart()
    {
       Time.timeScale = 1;
       SceneManager.LoadScene(1);

    }


    public void Mute()
    {
        mute.SetActive(true);
        notMute.SetActive(false);
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;

    }
    public void NotMute()
    {
        mute.SetActive(false);
        notMute.SetActive(true);
        isMute =! isMute;
        AudioListener.volume = isMute ? 1 : 1;
    }
  
}
