using UnityEngine;

public class Rotator : MonoBehaviour
//public class 旋轉器 : MonoBehaviour
{
    void Update()
    //void 更新() 每秒執行約60次
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
        //變形.旋轉(新 3維向量(0, 0, 45 )) * 時間.時間變化)
        //總之可以理解為每秒以Z軸為中心轉45度

        //面對一個人的時候 :
        //對方點頭 就是頭部沿著X軸在旋轉
        //對方搖頭 就是頭部沿著Y軸在旋轉
        //對方擺頭頂著肩膀 就是頭部沿著Z軸在旋轉
    }
}