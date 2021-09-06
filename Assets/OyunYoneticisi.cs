using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunYoneticisi : MonoBehaviour
{
    GameObject donenCember;
    GameObject AnaCember;
    void Start()
    {
        donenCember=GameObject.FindGameObjectWithTag("donencembertag");
        AnaCember=GameObject.FindGameObjectWithTag("anacembertag");
    }

    
    public void OyunBitti()
    {
        donenCember.GetComponent<Dondurme>().enabled = false;
        AnaCember.GetComponent<AnaCember>().enabled = false;
    }
}
