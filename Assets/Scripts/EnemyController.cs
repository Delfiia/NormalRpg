using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Unit
{
    [SerializeField] EnemyHPbar enemyHPbar;
    [SerializeField] EnemyAnimation enemyAnimation;
    [SerializeField] SkinnedMeshRenderer meshRenderer;
    Color oriColor;

    void Start()
    {
        oriColor = meshRenderer.material.color;
    }

    public override void Attack()
    {
        throw new System.NotImplementedException();
    }

    public override void TakeDamage()
    {
        //HP����
        hp_current -= PlayerController.instance.damage;

        //������ hp =< 0
        if(hp_current <= 0)
        {
            PlayerController.instance.TakeEXP(takeEXP);
            hp_current = 0;

            //�״¾ִϸ��̼ǽ���
            enemyAnimation.IsDead();
        }

        //UI�� HP�ݿ�
        float rate = hp_current / hp_max;
        enemyHPbar.SetHPbar(rate);

        //�ִϸ��̼ǽ���
        enemyAnimation.OnHit();

        //���󺯰�
        StartCoroutine(ColorOnHit());
    }

    IEnumerator ColorOnHit()
    {
        //�Ķ������� ������
        meshRenderer.material.color = Color.blue;
        //��� ���
        yield return new WaitForSeconds(0.25f);
        //���������� ����
        meshRenderer.material.color = oriColor;
    }

}
