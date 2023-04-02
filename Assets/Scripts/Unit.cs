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

    public float takeEXP; //ȹ���� ����ġ

    //�߻�ȭ: ������ ����, �����⸸ ����� ��.
    //�߻�ȭ�� �Լ� �տ��� abstract�� �ٰ�
    //��ũ��Ʈ�� �߻�ȭ�Լ��� ������ ��쿡��, abstract�� ���δ�.
    abstract public void Attack();
    abstract public void TakeDamage();
}
