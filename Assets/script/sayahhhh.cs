using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sayahhhh : MonoBehaviour
{
    public int[] enemies = new int[10];

    public int a = 10;
   //[SerializeField]
   // 
//    private string Password = "ahmad";
    private void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("Sayahh", 50);
        player2.InitializePlayer("Ramee", 75);


        player1.Heal(10);
        player2.Heal(true);
        // Debug.Log(Password);
        //   Debug.Log(a);
       //  Debug.Log(enemies.Length);
        Player.ShowPlayerCount();
        Debug.Log($"{player1.playerName}      " + "   fully restored to full health. Current health:" + $"{player1.health}  ");
        Debug.Log($"{player2.playerName}    " + "    fully restored to full health. Current health:" + $"{player2.health}  ");
        // Debug.log($"{player2.playerName}")

    }

}
