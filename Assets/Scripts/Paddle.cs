using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paddle : MonoBehaviour {

    public float arttir = 0;
    public int saydir = 0;
    public Text skor;
    public GameObject patlama;
    public Text yeniSkor;
   



    // Use this for initialization
    void Start()
    {
      
        yeniSkor.text = PlayerPrefs.GetInt("yeniscore", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
       float yatay = Input.GetAxis("Horizontal") * Time.deltaTime * arttir;
        //float dikey = Input.GetAxis("Vertical") * Time.deltaTime * arttir;
        transform.Translate(yatay, 0, 0);
       


        /*int parmakSayisi = Input.touchCount;
		for (int i = 0; i < parmakSayisi; i++)
		{
			Touch parmak = Input.GetTouch (i);
			if (parmak.phase == TouchPhase.Began) {
				transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (parmak.position.x, parmak.position.y, 0));
			}
			else if (parmak.phase == TouchPhase.Moved) 
			{
				transform.localPosition += (Vector3)parmak.deltaPosition / 100;
			}
		}*/

        if (transform.position.x <= -2.3f)
        {
            transform.position = new Vector2(-2.3f, transform.position.y);
        }
        else if (transform.position.x >= 2.3f)
        {
            transform.position = new Vector2(2.3f, transform.position.y);
        }

       


    }
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "At")
        {
            Instantiate(patlama, coll.gameObject.transform.position, Quaternion.identity);
            print("çalıştı");
            saydir++;
            skor.text = "SKOR : " + saydir.ToString();
            Destroy(coll.gameObject);
            GameObject.Find("Canvas/yeni").GetComponent<Text>().text = ("Yüksek Skor : " + saydir.ToString());
            if (saydir>PlayerPrefs.GetFloat("Rekor"))
            {
                PlayerPrefs.SetFloat("Rekor :", saydir);
            }

            if (saydir > PlayerPrefs.GetInt("yeniscore", 0))
            {
               
                PlayerPrefs.SetInt("yeniscore", saydir);
                GameObject.Find("Canvas/yeni").GetComponent<Text>().text = ("Yüksek Skor : " + saydir.ToString());
                string y = GameObject.Find("Canvas/yeni").GetComponent<Text>().text;
                yeniSkor.text = "Yüksek Skor : " + y;
            }
        }

      

    }

}