using UnityEngine;

public class TriggerAndCollider : MonoBehaviour
//public class 觸發器與碰撞器 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    //void 碰撞器進入2D (碰撞器2D 碰撞) 觸碰到東西的時候才執行
    {
        Debug.Log("OnCollisionEnter2D " + name + "碰到了" + collision.gameObject.name);
        //除錯.紀錄("碰撞器進入2D "+ 名稱 +"碰到了"+ 碰撞器.所屬遊戲物件.名稱 );
    }

    void OnTriggerEnter2D(Collider2D collision)
    //void 觸發器進入2D (碰撞器2D 碰撞) 觸碰到東西的時候才執行
    {
        Debug.Log("OnTriggerEnter2D " + name + "觸發了" + collision.gameObject.name);
        ////除錯.紀錄("觸發器進入2D "+ 名稱 +"觸發了" + 碰撞器.所屬遊戲物件.名稱 );
    }
}