using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    Player player_one = new Player(); 
    Player player_tow = new Player(); 
    void Start()
    {
        player_one.InitializePlayer("One",5);
        player_tow.InitializePlayer("two",5);
        player_one.Heal(3);
        player_tow.Heal();
        Player.ShowPlayerCount();
    }

}
