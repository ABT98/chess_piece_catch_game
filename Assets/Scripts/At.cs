using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class At : MonoBehaviour {

    public GameObject[] prefabs;
    public float donmeHizi = 300;
    public float dusmeHizi = 5.1f;
    public Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("olustur", 0.1f, 0.4f);
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -dusmeHizi * Time.deltaTime);
       
        transform.Rotate(0, 0, donmeHizi * Time.deltaTime);
       
    
    }

    void olustur()
    {
        float salla = Random.Range(0, prefabs.Length);
        Vector2 position = new Vector2(Random.Range(-2.2f, 2.2f), Random.Range(-50.0f, 50.0f));
        var x = Instantiate(prefabs[(int)salla], position, Quaternion.identity);
        x.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 1, 0);
      
    }

   
    
}
