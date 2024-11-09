using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    Player1 player_one = new Player1(); 
    Player1 player_tow = new Player1(); 
    void Start()
    {
        player_one.InitializePlayer("One",5);
        player_tow.InitializePlayer("two",5);
        player_one.Heal(3);
        player_tow.Heal();
        Player1.ShowPlayerCount();
    }

}
