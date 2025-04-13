using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson29 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        #region 知识点一 什么是有限状态机
        //有限状态机(Finite-state machine，FSM)
        //又称有限状态自动机，简称状态机
        //是表示有限个状态以及在这些状态之间的转移和动作等行为的数学模型

        //有限:表示是有限度的不是无限的
        //状态:指所拥有的所有状态
        #endregion

        #region 知识点二 关键组件animator的API
        //我们用代码控制状态机切换主要使用的就是Animator提供给我们的API
        //我们知道一共有四种切换条件 int float bool trigger"
        //所以对应的API也是和这四种类型有关系的

        //1.通过状态机条件切换动画/
        // animator.SetInteger("state条件", 1);
        // animator.SetFloat("state条件", 1);
        // animator.SetBool("state条件", true);
        // animator.SetTrigger("state条件");

        //得到值
        // animator.GetInteger("state");

        //2.直接切换动画  一般不使用
        // animator.Play("state");
        #endregion

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
