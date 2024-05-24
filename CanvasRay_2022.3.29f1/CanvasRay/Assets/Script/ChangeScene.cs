using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("SceneB");
    }

    public void ChangeAdditive()
    {
        SceneManager.LoadScene("SceneB", LoadSceneMode.Additive);
    }
}
