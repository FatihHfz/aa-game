using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
    public void oyunaGit()
    {
        SceneManager.LoadScene("level 1");
    }

    public void cik()
    {
        Application.Quit();
    }
}
