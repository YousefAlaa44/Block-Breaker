using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour
{
    private LevelManager levelmanager;
    void OnTriggerEnter2D(Collider2D trigger)
    {
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
        levelmanager.LoadLevel("Loose");

    }    
}
