using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveSceneB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene sceneB = SceneManager.GetSceneByName("SceneB");
        SceneManager.SetActiveScene(sceneB);
    }
}
