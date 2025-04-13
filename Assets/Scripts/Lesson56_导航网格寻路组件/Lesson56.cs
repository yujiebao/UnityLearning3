using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Lesson56 : MonoBehaviour
{

    [SerializeField] NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        //使用Lesson55的场景

        #region 知识点一 动画网格寻路组件是用来干什么的？
        //通过上节课导航网格生成知识点的学习
        //我们已经准备好了地形相关的数据
        //知道地形上哪些地方可以到达，哪些不能
        //那么寻路组件的作用就是帮助我们让角色可以在地形上准确的移动起来
        
        //寻路组件的本质就是根据烘焙出的寻路网格信息
        //通过基于A星寻路的算法计算出行进路径让我们在该路径上移动起来
        #endregion

        #region 知识点二 寻路组件代码相关
        //设置寻路目标点
        // navMeshAgent.SetDestination(new Vector3(0, 0, 0));
        
        //停止寻路
        // navMeshAgent.isStopped = true;
        #endregion

        #region 不常用内容
        #region 变量
        //1.面板参数相关 速度 加速度 旋转速度等等
        print(navMeshAgent.speed);
        print(navMeshAgent.acceleration);
        print(navMeshAgent.angularSpeed);
        //2.其他重要属性
        //2.1当前是否有路径
        // if(navMeshAgent.hasPath)
        // {}
        //2.2设置目标点
        // navMeshAgent.destination

        //是否停止
        // print(navMeshAgent.isStopped);

        //2.4当前路径
        // navMeshAgent.path

        //2.5路径是否在计算中
        // navMeshAgent.pathPending

        //2.6路径状态
        // navMeshAgent.pathStatus

        //2.7是否更新位置
        // navMeshAgent.updatePosition = true;

        //2.8是否更新角度
        // navMeshAgent.updateRotation = true;

        //2.9代理速度
        // navMeshAgent.velocity
        #endregion
        
        #region 方法
        //手动寻路
        //计算生成路径
        // NavMeshPath navMeshPath = null;
        // if(navMeshAgent.CalculatePath(new Vector3(0, 0, 0), navMeshPath))
        // if(navMeshAgent.CalculatePath(new Vector3(0, 0, 0), null))  //可达
        // {

        // }

        //设置新路径
        // navMeshAgent.SetPath(navMeshPath);

        //清除路径
        // navMeshAgent.ResetPath();

        //调整到指定位置
        // navMeshAgent.Warp(new Vector3(0, 0, 0));
        #endregion
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                print(hit.collider.name);
                //让对象朝目标点移动
                navMeshAgent.SetDestination(hit.point);
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //停止寻路
            navMeshAgent.isStopped = true;
        }
    }
}
