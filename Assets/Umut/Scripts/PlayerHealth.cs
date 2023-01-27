using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int Health;
    private PlayerRespawn playerRespawn;
  private void Start()
    {
        playerRespawn = GameObject.Find("Player").GetComponent<PlayerRespawn>();
    }

 public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            playerRespawn.RespawnNow();
        }
    }
}
