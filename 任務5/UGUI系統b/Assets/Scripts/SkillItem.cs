using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillItem : MonoBehaviour {
    public float coldTime = 2;//技能冷卻時間
    private float timer = 0;//計時器初始值
    private Image FilledImage;
    private bool isStartTimer;//是否開始計算時間
    public KeyCode KeyCode;

	// Use this for initialization
	void Start () {
        FilledImage = transform.Find("FillSkill").GetComponent<Image>();//取得Filledskill內的Image組件
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode))//當按下設定的按鈕後
        {
            isStartTimer = true;//計時器開始執行
        }

        if (isStartTimer)//如果計時器開始執行
        {
            timer += Time.deltaTime;//計時器的時間.開始往上疊加
            FilledImage.fillAmount = (coldTime - timer) / coldTime;//武器的黑色圈,透過比例增加
        }
        if (timer >= coldTime)//當計時器的時間超過了 技能冷卻的時間
        {
            FilledImage.fillAmount = 0;//武器的黑色圖隱藏
            timer = 0;//將計時器歸零
            isStartTimer = false;//是否開始計算時間
        }
	}

    public void OnClick()
    {
        isStartTimer = true;
    }
}
