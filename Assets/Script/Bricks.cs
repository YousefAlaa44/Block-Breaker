using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int MaxHits;
    public static int Breakablecount = 0;


    private int TimeHits;
    private LevelManager levelmanager;
    private bool isBreakable; 
    void Start()
    {
        isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {
            Breakablecount++;
        }
        TimeHits = 0;
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (isBreakable)
        {
            HandleHits();
        }
    }

    void HandleHits()
    {
        TimeHits++;
        if (TimeHits >= MaxHits)
        {
            Breakablecount--;
            levelmanager.BreakableDestroyed();
            Destroy(gameObject);

        }
    }

    public void SimulateWin()
    {
        levelmanager.LoadNextLevel();
    }
}
