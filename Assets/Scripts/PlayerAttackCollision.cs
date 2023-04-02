using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackCollision : MonoBehaviour
{

    //오브젝트가 활성화 될때마다 실행되는 함수.
    private void OnEnable()
    {
        StartCoroutine(AutoDisable());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AutoDisable()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Debug.Log("몬스터공격");
        }
    }


}
