using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpItem : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.Scale();
            
            player.AddScore(player);
            Destroy(gameObject);
        }
    }
}
