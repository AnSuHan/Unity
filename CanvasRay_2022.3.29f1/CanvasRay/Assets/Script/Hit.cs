using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hit : MonoBehaviour
{
    Vector2 pos;
    RaycastHit2D hit;

    // Update is called once per frame
    void Update()
    {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(pos, Vector2.zero);

        if(hit.collider != null)
        {
            Debug.Log($"in {SceneManager.GetActiveScene().name} : hit {hit.transform.parent.name}");
        }
    }
}