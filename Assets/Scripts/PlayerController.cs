using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        Vector3 pos = new Vector3(hori, 0, verti);

        //ĳ������ ��ġ += �̵����� * ��ŸŸ�� * ���ǵ�
        transform.position 
            += pos.normalized * Time.deltaTime * 6f;
        //normalized: ������ ���̰� 1�̵ǵ��� vector���� ����.

        transform.LookAt(transform.position + pos);
    }
}
