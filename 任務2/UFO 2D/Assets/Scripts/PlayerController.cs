using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    [Header("水平方向")]
    public float moveX;

    [Header("垂直方向")]
    public float moveY;

    [Header("推力")]
    public float push;

    Rigidbody2D rb2D;
    //剛體 以便可以被施力;

    [Header("分數文字UI")]
    public Text countText;//這不是string字串

    [Header("過關文字UI")]
    public Text winText;//這不是string字串

    int score;//分數

// Use this for initialization
void Start () {
        rb2D = GetComponent<Rigidbody2D> ( );
        //rd2D = 取得組件<剛體> ();

        winText.text = "";//清空過關文字的內容
        setScoreText();//顯示 目前分數:0
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        moveX = Input.GetAxis("Horizontal");
        //水平移動 = 輸入.取得軸向("水平");

        moveY = Input.GetAxis("Vertical");
        //垂直移動 = 輸入.取得軸向("垂直");

        Vector2 movement = new Vector2 ( moveX , moveY );
        //2維向量 移動方向 = 新 2維向量(水平移動, 垂直移動);

        rb2D.AddForce ( push * movement);
        //rb2D.施加力量 ( 推力 * 移動方向 );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log (name + "觸發了" + other.name);
        
        if ( other.CompareTag("PickUp") )
        //其他.比較標籤("PickUp")
            {
            other.gameObject.SetActive ( false ) ;
        //其他.遊戲物件.設定活耀狀態(否);

        score = score + 1;
        setScoreText();
            }
    }

    void setScoreText()
{
        countText.text = "所得金塊數:" + score.ToString() + "塊";
        //計分文字UI.文字 = "目前分數:" + 分數.轉字串 ( )+ "塊";

        if (score >= 14) //如果分數大於14
            {
            winText.text = "採礦完成";
            //過關文字UI.文字　= "你贏了";
            }
    }
}
