using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson53 : MonoBehaviour
{
    private CharacterController cc;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        #region 知识点一 角色控制器是什么？
        //角色控制器是让角色可以受制于碰撞，但是不会被刚体所牵制
        //如果我们对角色使用刚体判断碰撞，可能会出现一些奇怪的表现
        //比如:
        //1.在斜坡上往下滑动
        //2.不加约束的情况碰撞可能让自己被撞飞
        //等等
        //而角色控制器会让角色表现的更加稳定
        //unity提供了角色控制器脚本专门用于控制角色

        //注意:
        //添加角色控制器后，不用再添加刚体
        //能检测碰撞函数
        //能检测触发器函数
        //能被射线检测
        #endregion

        #region 知识点二 角色控制器的使用
        cc = GetComponent<CharacterController>();

        if (cc.isGrounded)
        {
            Debug.Log("角色在地面上");
        }

        //关键方法
        //受重力作用的移动
        // cc.SimpleMove(transform.forward * 5);
        //不受重力作用的移动
        // cc.Move(transform.forward * 5);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("Speed",(int)Input.GetAxisRaw("Vertical"));

        //受重力
        cc.SimpleMove(transform.forward * Input.GetAxisRaw("Vertical") * 100 * Time.deltaTime);   //方向为在世界坐标的方向   ---人物的前方
        //不受重力  平地
        //  cc.Move(transform.forward * Input.GetAxisRaw("Vertical") * 100 * Time.deltaTime);   

    }

    //当角色控制器想要判断和别的碰撞器产生碰撞时 使用该函数
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // print(hit.gameObject.name);
    }

    //此函数无用    
    // void OnCollisionEnter(Collision collision)
    // {}

    //可以检查触发器
    void OnTriggerEnter(Collider other)
    {
        print("触发器触发");
        print(other.gameObject.name);
    }
}
