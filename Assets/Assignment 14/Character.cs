using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name = "Subhi";
    private int health = 50;

    public Character(string name, int health)
    {
        this.name = name;
        if(health > 100) this.health = 100;
        else if (health < 0) this.health = 0;
        else this.health = health;
        
    }
    // Start is called before the first frame update
    public string Name
    {
        get { return name;}
        set { name = value; }
    }
     public int Health
    {
        get { return health;}
        set { 
            if(value > 100) health = 100;
            else if (value < 0) health = 0;
            else health = value;
        }
    }

}
