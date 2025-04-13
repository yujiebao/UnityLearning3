using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson48 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region  知识点一 什么是子状态机
        //子状态机顾名思义就是在状态机里还有一个状态机
        //它的主要作用就是某一个状态是由多个动作状态组合而成的复杂状态
        //比如某一个技能它是由3段动作组合而成的，跳起，攻击，落下
        //当我们释放这个技能时会连续播放这3个动作
        //那么我们完全可以把他们放到一个子状态机中
        #endregion

        #region 知识点二 创建子状态机
        //在Animator controller窗囗中右键->Create sub-state Machine
        #endregion

        #region 知识点三 编辑子状态机
        //注意:子状态机和外部状态的相互连接方式
        //回到状态和回到状态机 
        // 回到状态机   --->回到默认状态
        // 回到状态    --->回到指定状态(可以选择)
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
