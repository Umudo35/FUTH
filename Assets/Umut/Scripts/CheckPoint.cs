using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private PlayerRespawn playerRespawn;
    public GameObject greenFlag;
    public GameObject redFlag;

    // Start is called before the first frame update
    void Start()
    {
        playerRespawn = GameObject.Find("Player").GetComponent<PlayerRespawn>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerRespawn.respawnPoint = transform.position;
            redFlag.SetActive(false);
            greenFlag.SetActive(true);
        }
    }
  
}
