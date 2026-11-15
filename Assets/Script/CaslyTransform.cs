using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaslyTransform : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private BoxCollider2D col;
    [SerializeField] private Transform groundCheck;

    [Header("Collider Casly")]
    [SerializeField] private Vector2 caslySize = new Vector2(0.5f, 1f);
    [SerializeField] private Vector2 caslyOffset = new Vector2(0f, 0.5f);
    [SerializeField] private Vector2 caslyGroundCheck = new Vector2(0f, 0f);

    [Header("Collider Cappy")]
    [SerializeField] private Vector2 cappySize = new Vector2(1.2f, 0.7f);
    [SerializeField] private Vector2 cappyOffset = new Vector2(0f, 0.35f);
    [SerializeField] private Vector2 cappyGroundCheck = new Vector2(0f, 0f);

    private bool hasPotion;
    private bool isCappy;

    // void Awake()
    // {
    //     if (animator == null) animator = GetComponentInChildren<Animator>();
    //     if (col == null) col = GetComponent<BoxCollider2D>();
    //     ApplyForm();
    // }

    void Awake()
{
    if (animator == null) animator = GetComponentInChildren<Animator>();
    if (col == null) col = GetComponentInChildren<BoxCollider2D>();
    ApplyForm();
}

    void Update()
    {
        if (hasPotion && Input.GetKeyDown(KeyCode.E))
        {
            isCappy = !isCappy;
            animator.SetBool("IsCappy", isCappy);
            ApplyForm();
        }
    }

    void ApplyForm()
    {
        col.size = isCappy ? cappySize : caslySize;
        col.offset = isCappy ? cappyOffset : caslyOffset;
        groundCheck.localPosition = isCappy ? cappyGroundCheck : caslyGroundCheck;
    }

    public void UnlockTransform()
    {
        hasPotion = true;
    }
}