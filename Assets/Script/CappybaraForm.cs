using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CappybaraForm : MonoBehaviour
{
    public Animator animator;

    public RuntimeAnimatorController caslyController;
    public RuntimeAnimatorController cappybaraController;

    public static bool hasPotion = false;
    public static bool isCappybara = false;

    void Awake()
    {
        if (animator == null)
            animator = GetComponentInChildren<Animator>();

        animator.runtimeAnimatorController =
            isCappybara ? cappybaraController : caslyController;
    }

    void Update()
    {
        if (hasPotion && Input.GetKeyDown(KeyCode.E))
        {
            isCappybara = !isCappybara;

            animator.runtimeAnimatorController =
                isCappybara ? cappybaraController : caslyController;
        }
    }

    public void CollectPotion()
    {
        hasPotion = true;
    }
}
