using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1
{
    private string playerName = "";
    private int health = 0;
    private static int playerCount = 0;
    public bool fullRestore = true;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }
    public void Heal(int amount)
    {
        health += amount;
        Debug.Log("Health has been increased to : " + health);
    }
    public void Heal()
    {
       if(fullRestore){
            health = 5;
            Debug.Log("Health restored to : " + health);
       }
        
    }

    static public void ShowPlayerCount()
    {
         Debug.Log("Count Of Player : " + playerCount);
    }
}
