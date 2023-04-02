using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLV;

    public float damage;

    public float hp_max;
    public float hp_current;

    public float takeEXP; //획득한 경험치

    //추상화: 내용은 없고, 껍데기만 남기는 것.
    //추상화한 함수 앞에는 abstract이 붙고
    //스크립트가 추상화함수를 포함한 경우에도, abstract을 붙인다.
    abstract public void Attack();
    abstract public void TakeDamage();
}
