using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hints : MonoBehaviour
{
    public GameObject hintBox;
    public Text hintText;
    public string hint;
    // Start is called before the first frame update
    void Start()
    {
        hintText.text = "Press space to talk to people when you are close";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (hintBox.activeInHierarchy)
            {
                hintBox.SetActive(false);

            }
            
            }
        }

}

//timestamp 15:00
