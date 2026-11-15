using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    [SerializeField] private Transform nextLevelSpawn;

    private bool hasTransitioned = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (hasTransitioned) return;

        if (other.CompareTag("Player"))
        {
            hasTransitioned = true;
            other.transform.position = nextLevelSpawn.position;
        }
    }
}
