using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<GameObject>();
        if(collision.name == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}
