using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dondurme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float hiz;
    void Update()
    {
        transform.Rotate(0,0,hiz*Time.deltaTime);
    }
}
