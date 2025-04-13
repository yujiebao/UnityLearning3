using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region  知识点一 高级设置是设置什么？
        //高级设置主要是纹理的一些尺寸规则、读写规则、以及MipMap相关设置
        #endregion

        #region 知识点二 MipMap是什么
        //在三维计算机图形的贴图渲染中有一个常用的技术被称为Mipmapping。
        //为了加快渲染速度和减少图像锯齿,贴图被处理成由一系列被预先计算和优化过的图片组成的文件
        //这样的贴图被称为mipmap
        // Mipmap 需要占用一定的内存空间    存储多个小图(层级)

        //Mipmap中每一个层级的小图都是主图的一个特定比例的缩小细节的复制品
        //虽然在某些必要的视角，主图仍然会被使用，来渲染完整的细节。
        //但是当贴图被缩小或者只需要从远距离观看时，mipmap就会转换到适当的层级

        //因为mipmap贴图需要被读取的像素远少于普通贴图，所以渲染的速度得到了提升。
        //而且操作的时间减少了，因为mipmap的图片已经是做过抗锯齿处理的，从而减少了实时渲染的负担。
        //放大和缩小也因为mipmap而变得更有效率。

        //如果贴图的基本尺寸是256x256像素的话,它mipmap就会有8个层级。   
        //每个层级是上一层级的四分之一的大小
        //依次层级大小就是:128x128;64x64;32x32;16x16;8x8;4x4;2x2;1x1(一个像素)

        //说人话，开启MipMap功能后，unity会帮助我们根据图片信息生成n张不同分辨率的图片
        //在场景中会根据我们离该模型的距离选择合适尺寸的图片用于渲染，提升渲染效率
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
