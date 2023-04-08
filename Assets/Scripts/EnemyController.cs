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
        //HP감소
        hp_current -= PlayerController.instance.damage;

        //몬스터의 hp =< 0
        if(hp_current <= 0)
        {
            PlayerController.instance.TakeEXP(takeEXP);
            hp_current = 0;

            //죽는애니메이션실행
            enemyAnimation.IsDead();
        }

        //UI에 HP반영
        float rate = hp_current / hp_max;
        enemyHPbar.SetHPbar(rate);

        //애니메이션실행
        enemyAnimation.OnHit();

        //색상변경
        StartCoroutine(ColorOnHit());
    }

    IEnumerator ColorOnHit()
    {
        //파란색으로 변경후
        meshRenderer.material.color = Color.blue;
        //잠깐 대기
        yield return new WaitForSeconds(0.25f);
        //원래색으로 변경
        meshRenderer.material.color = oriColor;
    }

}
