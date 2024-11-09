using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    // Start is called before the first frame update
    public void Attack(int amount)
    {
        Health -= amount;
    }

}
