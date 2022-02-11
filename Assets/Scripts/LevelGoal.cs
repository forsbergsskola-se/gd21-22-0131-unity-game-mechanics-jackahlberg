using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGoal : MonoBehaviour
{
    public int nextSceneLoad;

    private void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player") && nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
        {
            SceneManager.LoadScene("MainMenu");
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                        
        }

    }
}