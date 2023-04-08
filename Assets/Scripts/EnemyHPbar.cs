using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHPbar : MonoBehaviour
{
    [SerializeField] Image red;
    [SerializeField] Image white;


    private void Update()
    {
        transform.rotation = Quaternion.Euler(0,0,0);  
    }


    public void SetHPbar(float rate)
    {
        //HP 즉시감소
        //red.rectTransform.localScale = new Vector2(rate, 1);

        //HP 천천히 감소
        //StartCoroutine(SlowReduce(red, rate, 2f));

        //HP 이팩트 감소
        StartCoroutine(EffectReduce(rate));
    }
    IEnumerator SlowReduce(Image imageName, float rate, float speed)
    {
        //최종목표치에 다를때까지 현재 Scale을 조금씩 감소
        //최종목표치 : rate
        //현재Scale값 : x

        float x = imageName.rectTransform.localScale.x;

        while( x >= rate )
        {
            x -= 0.01f * speed;
            imageName.rectTransform.localScale = new Vector2(x, 1);
            yield return null;  
        }
        imageName.rectTransform.localScale = new Vector2(rate, 1);
    }

    IEnumerator EffectReduce(float rate)
    {
        StartCoroutine(SlowReduce(red, rate, 1.5f));
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(SlowReduce(white, rate, 1f));
    }



}
