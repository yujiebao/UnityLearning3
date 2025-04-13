using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 为什么要打图集
        //打图集的目的就是  减少Drawca11 提高性能   ----可以在status中查看batch
        //在2D游戏开发，以及UI开发中是会频繁使用的功能
        #endregion

        #region 知识点二 unity自带的打图集功能
        // Editor中有
        #endregion 

        #region 代码加载图集
        GameObject obj = new GameObject();
        SpriteRenderer sr  = obj.AddComponent<SpriteRenderer>();
        SpriteAtlas spriteAtlas = Resources.Load<SpriteAtlas>("MyAtlas");
        sr.sprite = spriteAtlas.GetSprite("dead1");
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
