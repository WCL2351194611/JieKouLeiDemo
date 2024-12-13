using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour,IInteractable
{
    public bool isOpened = false;
    public GameObject[] items; // 假设宝箱里存放着一些物品的游戏对象，这里简单用数组表示

    public void Interact()
    {
        if (!isOpened)
        {
            isOpened = true;
            Debug.Log("宝箱已打开，获得物品:");
            foreach (var item in items)
            {
                // 这里可以添加实际获取物品的逻辑，比如添加到玩家背包等，简单示例只打印
                Debug.Log(item.name);
            }
        }
        else
        {
            Debug.Log("宝箱已经是空的了");
            isOpened = false;
        }
    }

    void IInteractable.Interact(int intSpeed)
    {
        if (!isOpened)
        {
            isOpened = true;
            if (intSpeed > 3)
            {
                Debug.Log("宝箱被暴力打开，获得所有物品:");
            }
            else
            {
                Debug.Log("宝箱被小心打开，获得部分物品:");
            }
            foreach (var item in items)
            {
                // 这里可以添加实际获取物品的逻辑，比如添加到玩家背包等，简单示例只打印
                Debug.Log(item.name);
            }
        }
        else
        {
            Debug.Log("宝箱已经是空的了");
            isOpened = false;
        }
    }
}
