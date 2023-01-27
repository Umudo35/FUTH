using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float health;
    public Image filler;
    private PlayerRespawn playerRespawn;
  private void Start()
    {
        playerRespawn = GameObject.Find("Player").GetComponent<PlayerRespawn>();
    }

 public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            playerRespawn.RespawnNow();
        }
    }
  
    private void Update()
    {
        filler.fillAmount = health / maxHealth;
    }

}
