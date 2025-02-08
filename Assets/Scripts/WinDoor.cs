using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDoor : MonoBehaviour
{
    void Update()
    {
        // Restart level when pressing R
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
