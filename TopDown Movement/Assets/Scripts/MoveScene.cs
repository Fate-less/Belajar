using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    //inspector
    public int scene;

    public void moveScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<GameObject>();
        if(collision.name == "Player")
        {
            SceneManager.LoadScene(scene);
        }
    }
}
