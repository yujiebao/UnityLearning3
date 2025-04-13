using System.Collections;
using System.Collections.Generic;
using Spine;
using Spine.Unity;
using UnityEngine;

public class Lesson39 : MonoBehaviour
{
    [SerializeField]
    [SpineAnimation]
    private string jumpName;
    
    [SpineBone]
    public string bone;

    [SpineSlot]
    public string slot;

    [SpineAttachment]
    public string attachment;   
    private SkeletonAnimation skeletonAnimation;

    // Start is called before the first frame update
    void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();  
        #region 知识点一 动画播放
        //方法一 :直接改变SkeletonAnimation中的参数
        skeletonAnimation.loop = true;
        skeletonAnimation.AnimationName = "jump";
        //方法二:使用AnimationState中动画状态改变的函数
        skeletonAnimation.AnimationState.SetAnimation(0, "jump", false);
        //此方法排队播放
        skeletonAnimation.AnimationState.AddAnimation(0, "run", true, 0);
        #endregion
    
        #region 知识点二 转向
        skeletonAnimation.skeleton.ScaleX = -1;
        #endregion
    
        #region 知识点三 动画事件
        skeletonAnimation.AnimationState.Start +=(t) =>{
            print(skeletonAnimation.AnimationName+"开始播放");
        };
        skeletonAnimation.AnimationState.End +=(t) =>{
            print(skeletonAnimation.AnimationName+"播放中断或停止");
        };
        skeletonAnimation.AnimationState.Complete +=(t) =>{
            print(skeletonAnimation.AnimationName+"播放完成");
        };
        skeletonAnimation.AnimationState.Event +=(t,e) =>{
            print(skeletonAnimation.AnimationName+"播放事件");  //如：动画过程中激发子弹
        };
        #endregion
    
        #region 知识点四 便捷特性
        //动画特性
        // [SpineAnimation]

        //骨骼特性
        // [SpineBone]

        //插槽特性    ---换装
        // [SpineSlot]

        //附件特性      ---配合插槽使用  放置在插槽中
        // [SpineAttachment]

        #endregion

        #region 知识点五 获取骨骼，设置插槽附件
        //获取骨骼
        Bone bone1 =  skeletonAnimation.skeleton.FindBone(bone);

        //设置插槽的attachment
        // skeletonAnimation.skeleton.SetAttachment(slot,attachment);   用来换装
        #endregion

        #region 知识点六 在UI中的使用
        //拖入的时候选择UI
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
