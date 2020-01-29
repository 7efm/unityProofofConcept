using UnityEngine;
using System.Collections;

public class npcMove : MonoBehaviour
{
    // Public values
    public float Speed = .3f;
    // Private values
    private Vector2 initialPosition;

    // Use this for initialization
    void Start()
    {
        initialPosition = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
        Debug.Log("Update is running");
        Debug.Log(Speed);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("inrange");
            Speed = 0f;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("notinrange");

        }
    }
}