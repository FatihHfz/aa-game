using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCemberKod : MonoBehaviour

{
    Rigidbody2D fizik;
    public float hiz;
    bool hareketKontrol = false;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
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
        if(col.tag=="donencembertag")
        {
            hareketKontrol = true;
        }
    }
}
