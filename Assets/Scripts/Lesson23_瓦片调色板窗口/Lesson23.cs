using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson23 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 编辑瓦片地图
        //方法-:通过瓦片调色板文件创建
        //方法二:直接在场最中进行创建
        
        //矩形瓦片地图用于做横版游戏地图
        //六边形弯片地图用于做策略游戏地图
        //等距瓦片地图用于做有"z"轴的2D游戏

        //注意:
        //在编辑等距瓦片地图时
        //1.需要修改工程的自定义轴排序 以y轴决定渲染顺序
        //2.如果地图存在前后关系需要修改TileRenderer的渲染模式
        //3.可以通过z轴偏移来控制绘制单个瓦片时的高度
        //4.精灵纹理的中心点会影响最终的显示效果
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
