using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public void Heal(int amount)
    {
        Health+= amount;
    }
    

}
