using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson30 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;    //序列帧动画的图片
    private float time = 0 ;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[index];
        #region 知识点一 什么是序列帧动画
        //我们最常见的序列帧动画就是我们看的日本动画片
        //以固定时间间隔 按序列切换图片 就是 序列帧动画的本质
        //当固定时间间隔足够短时 我们肉眼就会认为图片是连续动态的 进而形成动画(会动的画面)
        
        //它的本质和游戏的帧率概念有点类似
        //原理就是在一个循环中按一定时间间隔不停的切换显示的图片
        #endregion
   
        #region 知识点二 Animation制作序列帧动画
        //方法一:
        //1.创建一个空物体
        //2.创建一个动画
        //3.直接将某一个动作的序列帧拖入窗口中
        //方法二:
        //直接将图片拖入Hierarchy层级窗口中
        //注意:需要修改动画帧率 来控制动画的播放速度
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 0.03f)
        {
            time = 0;
            index++;
            if(index >= sprites.Length)
            {
                index = 0;
            }
            spriteRenderer.sprite = sprites[index];
        }
    }
}
