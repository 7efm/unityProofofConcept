using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int index;
    public string levelName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            SceneManager.LoadScene(index);
        }
    }
    public void EnterLevel()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame

    void Update()
    {
        
    }
}
