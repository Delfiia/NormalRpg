using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TestA<T> : MonoBehaviour
{
    public string unitName;
    public int unitLV;

    public float damage;

    public float hp_max;
    public float hp_current;

    public float takeEXP; //ȹ���� ����ġ
    public Action<T> action;

    public abstract TestA<T> InputHandle(T t);
    //�߻�ȭ : �����⸸ ����� �۾�
    public abstract void Attack();
    public abstract void TakeDamage();
    private TestA()
    {
        action = Enter;
    }
    public virtual void Enter(T t)
    {
        action = Update;
    }

    public virtual void Update(T t)
    {

    }

    public virtual void Exit(T t)
    {

    }
}

