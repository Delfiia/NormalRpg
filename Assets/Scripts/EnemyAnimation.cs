using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    Animator animator;
    GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        enemy = transform.parent.gameObject;
    }

    public void OnHit()
    {
        animator.SetTrigger("OnHit");
    }
    public void IsDead()
    {
        animator.SetTrigger("isDead");
    }
    public void EnemyActiveFalse()
    {
        enemy.SetActive(false); 
    }
}
