using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animator;
    [SerializeField] GameObject attackCollsion;

    void Start()
    {

    }

    public void Move(float DKV)
    {
        animator.SetFloat("DirectKeyValue", DKV);
    }
    public void Attack()
    {
        animator.SetTrigger("onAttack");
    }
    public void ActiveAttackCollision()
    {
        attackCollsion.SetActive(true);
    }    

}
