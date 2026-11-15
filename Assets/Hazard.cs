using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerRespawn player = other.GetComponentInParent<PlayerRespawn>();
        if (player != null)
            player.Respawn(respawnPoint.position);
    }
}