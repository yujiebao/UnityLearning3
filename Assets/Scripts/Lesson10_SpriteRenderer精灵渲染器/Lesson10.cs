using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region  知识点一 SpriteRenderer是什么
        //顾名思义，Sprite Renderer是精灵渲染器
        //所有2D游戏中游戏资源(除UI外)都是通过sprite Renderer让我们看到的
        //它是2D游戏开发中的一个极为面要的组件
        #endregion

        #region 知识点二 2D对象创建
        //1.直接拖入Sprite图片
        //2.右键创建
        //3.空物体添加脚本
        #endregion

        #region 知识点三 代码设置
        GameObject obj = new GameObject();
        SpriteRenderer sr  = obj.AddComponent<SpriteRenderer>();
        //动态更改图片
        // sr.sprite = Resources.Load<Sprite>("Sprite/sprited1");
        Sprite[] sprs = Resources.LoadAll<Sprite>("Sprite/sprited2");
        sr.sprite = sprs[10];
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
