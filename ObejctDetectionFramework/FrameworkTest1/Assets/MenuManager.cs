using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public void testBtn(string inp)
    {
        SceneManager.LoadScene(inp);
    }

    public void exit()
    {
        Application.Quit();
    }
}
