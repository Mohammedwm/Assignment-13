using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1
{
    private string playerName = "";
    private int health = 100;
    private static int playerCount = 0;

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
    public void Heal(bool fullRestore )
    {
       if(fullRestore){
            health = 100;
            Debug.Log("Health restored to : " + health);
       }
        
    }

    static public void ShowPlayerCount()
    {
         Debug.Log("Count Of Player : " + playerCount);
    }
}
