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

        //캐릭터의 위치 += 이동방향 * 델타타임 * 스피드
        transform.position 
            += pos.normalized * Time.deltaTime * 6f;
        //normalized: 벡터의 길이가 1이되도록 vector값을 변경.

        transform.LookAt(transform.position + pos);
    }
}
