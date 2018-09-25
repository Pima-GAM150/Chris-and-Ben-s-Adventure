using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public string loadlevel;
    public void loading()
    {
        SceneManager.LoadScene(loadlevel);
    }
}
