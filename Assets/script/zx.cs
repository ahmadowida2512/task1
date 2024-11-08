using UnityEngine;

public class Player
{
    public string playerName;
    public int health;

    public static int playerCount = 0;


    // public Player(string ahmed, int initialHealth)
    // {
    //     playerName = ahmed;
    //     health = initialHealth;
    //     playerCount++;
    // }
    
    // public Player(){
    //       playerName = "";
    //     health = 100;
    //     playerCount++;
    // }
    public void InitializePlayer(string ahmed, int initialHealth)
    {
        playerName = ahmed;
        health = initialHealth;
        playerCount++;
    }


    // Method to heal by a specified amount
    public void Heal(int amount)
    {
        health += amount;
         Debug.Log($"{playerName} healed by {amount}. Current health: {health}");
    }

    // Overloaded Heal method to fully restore health
    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100; // Assuming 100 is the full health
        }
    }

    public static void ShowPlayerCount()
    {
    }
}
