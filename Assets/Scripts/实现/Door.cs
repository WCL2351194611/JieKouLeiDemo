using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour,IInteractable
{
    public bool isOpen = false;
    public Animator animator; // 假设门有对应的动画组件来控制开关动画

    public void Interact()
    {
        isOpen = !isOpen;
        //animator.SetBool("IsOpen", isOpen);
        Debug.Log("门 " + (isOpen ? "已打开" : "已关闭"));
    }

    void IInteractable.Interact(int intSpeed)
    {
        if (intSpeed > 5)
        {
            isOpen = true;
            //animator.SetBool("IsOpen", isOpen);
            Debug.Log("门被大力推开，已打开");
        }
        else
        {
            if (!isOpen)
            {
                isOpen = true;
                //animator.SetBool("IsOpen", isOpen);
                Debug.Log("门被轻轻推开，已打开");
            }
            else
            {
                Debug.Log("门已经是打开的了");
                isOpen = false;
            }
        }
    
}
}

