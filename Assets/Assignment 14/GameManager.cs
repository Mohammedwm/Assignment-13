using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Player player = new Player();
    Enemy enemy = new Enemy();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player name : "+player.Name);
        Debug.Log("Player health : "+player.Health);

        Debug.Log("Enemy name : "+enemy.Name);
        Debug.Log("Enemy health : "+enemy.Health);

        player.Heal(5);
        Debug.Log("Player health after increase : "+player.Health);

        enemy.Attack(5);
        Debug.Log("Enemy health after attack : "+enemy.Health);
    }
   
}
