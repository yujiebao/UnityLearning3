using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson49 : MonoBehaviour
{
    Animator animator;
    [SerializeField] Transform transform;
    [SerializeField] Transform transform1;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        #region 知识点一 什么是IK
        //在骨骼动画中，构建骨骼的方法被称为正向动力学
        //它的表现形式是，子骨骼(关节)的位置根据父骨骼(关节)的旋转而改变
        //用我们人体举例子
        //当我们抬起手臂时，是肩部关节带动的整个手臂的运动，用父子骨骼理解的话就是父带动了子

        //而IK全称是Inverse kinematics，翻译过来的意思就是反向动力学的意思
        //它和正向动力学恰恰相反
        //它的表现形式是，子骨骼(关节)末端的位置改变会带动自己以及自己的父骨骼(关节)旋转
        //用我们人体举例子
        //当我们拿起一个杯子的时候是用手掌去拿，以杯子为参照物，我们移动杯子的位置，手臂会随着杯子一起移动
        //用父子骨骼理解的话就是子带动了父
        #endregion

        #region 知识点二 如何进行IK控制
        //1.在状态机的层级设置中 开启 IK 通道
        //2.继承MonoBehavior的类中
        //Unity定义了一个IK回调函数:OnAnimatorIK
        //我们可以在该函数中调用unity提供的IK相关API来控制IK
        //3.Animator中的IK相关API
        // SetLookAtWeight   设置头部IK权重
        //SetLookAtPosition    设置头部IK看向位置
        
        //SetIKPositionWeight   设置IK位置权重
        //SetIKRotationWeight   设置IK旋转权重
        //SetIKPosition         设置IK对应的位置  
        //SetIKRotation         设置IK对应的角度
        
        //AvatarIKGoal     四肢末端IK枚举
        #endregion

        #region 知识点三 Ik反向动力学控制对我们的意义
        //IK在游戏开发中的应用
        //1.拾取某一件物品
        //2.持枪或持弓箭瞄准某一个对象
        //等等
        #endregion

        #region 知识点四 关于OnAnimatorIK和OnAnimatorMove两个函数的理解
        //我们可以简单理解这两个函数是两个和动画相关的特殊生命周期函数
        //他们在update之后LateUpdate之前调用
        //他们会在每帧的状态机和动画处理完后调用
        //OnAnimatorIk在OnAnimatorMove之前调用
        //OnAnimatorIk中主要处理 IK运动相关逻辑
        //OnAnimatorMove主要处理 动画移动以修改根运动的回调逻辑    为动画添加移动

        //他们存在的目的只是多了一个调用时机，当每帧的动画和状态机逻辑处理完后再调用
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnAnimatorIK(int layerIndex)
    {
        //头部IK相关
        //weight:LookAt全局权重 0-1
        //bodyWeight:身体权重  0-1
        //headWeight:头部权重  0-1
        //eyesWeight:眼睛权重  0-1
        //clampWeight:是否限制权重  0-1  1表示角色完成固定无法执行LookAt 0.5表示只能移动范围的一半
        animator.SetLookAtWeight(1, 0.5f, 0.5f, 0.5f, 0.5f);
        animator.SetLookAtPosition(transform.position);

        //
        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);  //设置IK位置权重
        animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
        animator.SetIKPosition(AvatarIKGoal.LeftHand, transform1.position);   //设置IK末端的位置
        animator.SetIKRotation(AvatarIKGoal.LeftHand, transform1.rotation);  //设置IK末端的角度
    }
}
