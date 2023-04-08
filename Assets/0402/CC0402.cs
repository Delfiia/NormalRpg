using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC0402 : MonoBehaviour
{
    public GameObject cube;
    public Vector3 offset;

    private void LateUpdate()
    {
        gameObject.transform.position = cube.transform.position + offset;
    }
}
