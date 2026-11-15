using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    [Header("Opsional")]
    [SerializeField] private AudioClip pickupSound;
    [SerializeField] private GameObject pickupEffect;

    private bool collected;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (collected) return;

        CaslyTransform player = other.GetComponentInParent<CaslyTransform>();
        if (player == null) return;

        collected = true;
        player.UnlockTransform();

        if (pickupSound != null)
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);

        if (pickupEffect != null)
            Instantiate(pickupEffect, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}