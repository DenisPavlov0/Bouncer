using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";
    
    private void OnTriggerEnter (Collider playerCollider)
    {
        if (playerCollider.CompareTag(PLAYER_TAG))
        {
            var player = playerCollider.GetComponent<Player>();
            var playerPosition = player.GetComponent<Transform>();
            playerPosition.position = Vector3.zero;
        }
    }
}
