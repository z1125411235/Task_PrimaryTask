using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class LevelScrol : MonoBehaviour, IBeginDragHandler, IEndDragHandler {

    private ScrollRect scrollRect;
    public float smoothing = 5;
    public Toggle[] toggleArray;
    private float[] pageArray = new float[] { 0, 0.25f, 0.50f, 0.75f, 1 };
    private float targetHorizontalPosition = 0;
    private bool isDraging = false;
    // Use this for initialization
    void Start () {
        scrollRect = GetComponent<ScrollRect>();
	}

    // Update is called once per frame
    void Update()
    {
        if (isDraging == false)
        {
            scrollRect.horizontalNormalizedPosition = Mathf.Lerp(scrollRect.horizontalNormalizedPosition, targetHorizontalPosition, Time.deltaTime * smoothing);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDraging = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDraging = false;
        float posX = scrollRect.horizontalNormalizedPosition;//EngDrag的點
        int index = 0;//預設的頁碼
        float offset = Math.Abs(pageArray[index] - posX);//差值運算
        for (int i = 1; i < pageArray.Length;i++)
        {
            float offsetTemp = Math.Abs(pageArray[i] - posX);
            if (offsetTemp < offset)
            {
                index = i;
                offset = offsetTemp;//實現跳頁(離array點最近的位置)
            }
        }
        targetHorizontalPosition = pageArray[index];
        toggleArray[index].isOn = true;
        //scrollRect.horizontalNormalizedPosition = pageArray[index];//
    }

    public void TurnToPage1(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[0];//跳轉到第一頁
        }
    }
    public void TurnToPage2(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[1];//跳轉到第二頁
        }
    }
    public void TurnToPage3(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[2];//跳轉到第三頁
        }
    }
    public void TurnToPage4(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[3];//跳轉到第四頁
        }
    }
    public void TurnToPage5(bool isOn)
    {
        if (isOn)
        {
            targetHorizontalPosition = pageArray[4];//跳轉到第五頁
        }
    }
}
