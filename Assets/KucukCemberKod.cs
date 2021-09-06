using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCemberKod : MonoBehaviour

{
    Rigidbody2D fizik;
    public float hiz;
    bool hareketKontrol = false;
    GameObject oyunYoneticisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi=GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }

    
    void FixedUpdate()
    {
        if(!hareketKontrol)
        {
            fizik.MovePosition(fizik.position+Vector2.up*hiz*Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="donencembertag") //çarpışma olduğunda bu if e giriyor
        {
            transform.SetParent(col.transform);
            hareketKontrol = true;
        }
        if(col.tag=="kucukcembertag") //temas oldugunda
        {
            oyunYoneticisi.GetComponent<OyunYoneticisi>().OyunBitti();
        }
    
    }
}
