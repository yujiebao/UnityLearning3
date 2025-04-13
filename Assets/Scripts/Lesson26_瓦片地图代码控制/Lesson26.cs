using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Lesson26 : MonoBehaviour
{
    //瓦片地图信息  可以通过它得到瓦片格子
    public Tilemap tilemap;
    //格子位置相关控制 可以通过它进行坐标转换
    public Grid grid;
    //瓦片资源基类通过它可以获取瓦片资源
    public TileBase tileBase;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 获取Tilemap和TileBase和Grid组件
        //Tilemap组件:用于管理瓦片地图
        //TileBase组件:瓦片资源对象基类
        //Grid组件:用于坐标转换   
        //使用他们需要引入命名空间
        #endregion

        #region 知识点二 重要API
        //1.清空瓦片地图
        // tilemap.ClearAllTiles();

        //2.获取瓦片地图指定格子
        TileBase tmp = tilemap.GetTile(new Vector3Int(-16, -2, 0));
        // print(tmp);

        //3.设置瓦片地图指定格子
        // tilemap.SetTile(new Vector3Int(0, -2, 0), tileBase);

        //4.替换瓦片
        // tilemap.SwapTile(tmp, tileBase);

        //5.世界坐标转换为格子坐标

        //屏幕坐标转世界坐标
        //世界坐标转格子坐标
        //传入的是世界坐标
        // grid.WorldToCell();
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
