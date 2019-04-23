using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    private PlayerController playerControllerObj;
    
    void Start()
    {
        playerControllerObj = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerControllerObj.speed = playerControllerObj.speed * 1.5f;
        }
    }
}
