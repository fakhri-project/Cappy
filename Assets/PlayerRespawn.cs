using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Respawn(Vector3 position)
    {
        rb.velocity = Vector2.zero;
        transform.position = position;
    }
}