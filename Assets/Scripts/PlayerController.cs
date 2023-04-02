using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : Unit
{
    [SerializeField] PlayerAnimator playerAnimator;


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
}
