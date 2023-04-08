using UnityEngine;

public class Cube : MonoBehaviour
{
    float speed;
    private void Start()
    {
        speed = 5;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.1f,0.0f,0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.1f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f, 0.0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.0f, 0.0f, 0.1f);
        }
    }
}
