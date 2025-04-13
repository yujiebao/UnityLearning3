using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson24 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 练习中重点知识
        //重点知识运用
        //1.等距瓦片地图的两项重要设置
        //2.两种等距瓦片地图的区别
        //3.等距瓦片地图的排序问题
        // 3-1:轴心点排序    ---当人物轴心点大于瓦片的轴心点时,人物会被遮挡   瓦片轴心点设置为最高点  但是会有一个瓦片偏移
        // 3-2:排序层排序(推荐)
        //4.等距瓦片地图角色不使用重力
        //5.等距瓦片碰撞器建议使用格子形状(Grid)
        //6.等距瓦片地图上跳跃问题
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
