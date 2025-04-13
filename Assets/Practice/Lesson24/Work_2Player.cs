using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Work_2Player : MonoBehaviour
{
    //跳跃可以加一个父对象  通过移动该物体(此对象)的y值来实现跳跃效果
    SpriteRenderer spriteRenderer;
    private float h;
    private float v;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, v, 0) * speed * Time.deltaTime);

        if(h > 0)
        {
            spriteRenderer.flipX = false;
        }
        if (h < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
