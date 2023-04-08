using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : Unit
{
    [SerializeField] PlayerAnimator playerAnimator;
    public static PlayerController instance;
    public List<float> List_expLimt;
    public float playerEXP;

    private void Awake()
    {
        instance = this;    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Movement();
        if(Input.GetKeyDown(KeyCode.Z))
        { Attack(); }

    }
    
    public override void Attack()
    {
        playerAnimator.Attack();
    }
    void Movement()
    {
        //����Ű�� ����.
        float hori = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        Vector3 pos = new Vector3(hori, 0, verti);

        //ĳ������ ��ġ
        transform.position
            += pos.normalized * Time.deltaTime * 6f;
        //normalized: ������ ���̰� 1�̵ǵ��� vector���� ����.

        //ĳ���� ȸ��
        transform.LookAt(transform.position + pos);

        //ĳ���� �ִϸ��̼� ����
        playerAnimator.Move(pos.magnitude);
    }

    public override void TakeDamage()
    {
        throw new System.NotImplementedException();
    }

    public void TakeEXP(float monsterEXP)
    {
        playerEXP += monsterEXP;

        if(playerEXP >= List_expLimt[unitLV-1])
        {
            playerEXP -= List_expLimt[unitLV - 1];
            unitLV++;
        }
    }
}
