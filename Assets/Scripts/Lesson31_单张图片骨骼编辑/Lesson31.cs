using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson31 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 什么是2D骨骼动画
        //首先回顾一下序列帧动画
        //传统的序列帧动画为了达到好的动画效果
        //理论上来说，图片越多，动作越流畅
        //往往需要较多的美术资源，虽然效果好但是资源占用较多
        
        //而2D骨骼动画是利用3D骨骼动画的制作原理进行制作的
        //将一张2D图片分割成n个部位，为每个部位绑上骨骼，控制骨骼旋转移动
        //达到用最少的2D美术资源做出流畅的2D动画效果
        #endregion

        #region 知识点二 unity中如何制作2D骨骼动画
        //主要方式有两种
        //1.使用unity2018新加功能2D Animation工具制作
        //2.使用跨平台骨骼动画制作工具ISpine 制作
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
