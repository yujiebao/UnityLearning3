using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson40 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 unity中使用的模型
        //Unity支持很多模型格式
        //比如
        //.fbx
        //.dae
        //.3ds
        //.dxf
        //.obj等等

        //99%的模型都不是在unity中制作的，都是美术人员在建模软件中制作
        //如 3DMax、Maya等等
        //当他们制作完模型后，虽然unity支持很多模型格式
        //但是官方建议是将模型在建模软件中导出为.FBX格式后再使用

        //使用FBX模型格式的优势
        //1.减少不必要数据，提升导入效率
        //2.不需要再每台计算机上安装建模软件的授权副本
        //3.对unity版本无要求，使用原始3D模型格式可能会因为版本不同导致错误或意外

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
