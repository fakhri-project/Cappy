using UnityEngine;

public class NextLevelTrigger : MonoBehaviour
{
    [SerializeField] private GameObject currentLevel;
    [SerializeField] private GameObject nextLevel;
    [SerializeField] private Transform nextSpawn;

    private bool used;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (used) return;

        PlayerRespawn player = other.GetComponentInParent<PlayerRespawn>();
        if (player == null) return;

        used = true;

        Debug.Log("Pindah ke: " + nextSpawn.position + " (" + nextSpawn.name + ")");

        nextLevel.SetActive(true);
        player.Respawn(nextSpawn.position);
        currentLevel.SetActive(false);
    }
}