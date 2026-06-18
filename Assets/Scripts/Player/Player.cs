using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // UŒ‚’†ƒtƒ‰ƒO
    private bool isAttacking;

    public void Attack()
    {
        if(isAttacking)
        {
            return;
        }

        isAttacking = true;

        animator.SetTrigger("Attack");

        StartCoroutine(EndAttack());
    }

    private IEnumerator EndAttack()
    {
        yield return new WaitForSeconds(1.0f);

        isAttacking = false;
    }
}
