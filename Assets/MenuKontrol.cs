using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
    void Start() 
    {
        //PlayerPrefs.DeleteAll();   //Bu kod çalıştırırsak tüm kayıtlar siliniyor.     
    }
    public void oyunaGit()
    {
        int kayitliLevel = PlayerPrefs.GetInt("kayit");
            if(kayitliLevel == 0)
            {
                SceneManager.LoadScene(kayitliLevel + 1);
            }
            else
            {
                SceneManager.LoadScene(kayitliLevel);
            }
        
    }

    public void cik()
    {
        Application.Quit();
    }
}
