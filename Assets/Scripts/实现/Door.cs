using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour,IInteractable
{
    public bool isOpen = false;
    public Animator animator; // �������ж�Ӧ�Ķ�����������ƿ��ض���

    public void Interact()
    {
        isOpen = !isOpen;
        //animator.SetBool("IsOpen", isOpen);
        Debug.Log("�� " + (isOpen ? "�Ѵ�" : "�ѹر�"));
    }

    void IInteractable.Interact(int intSpeed)
    {
        if (intSpeed > 5)
        {
            isOpen = true;
            //animator.SetBool("IsOpen", isOpen);
            Debug.Log("�ű������ƿ����Ѵ�");
        }
        else
        {
            if (!isOpen)
            {
                isOpen = true;
                //animator.SetBool("IsOpen", isOpen);
                Debug.Log("�ű������ƿ����Ѵ�");
            }
            else
            {
                Debug.Log("���Ѿ��Ǵ򿪵���");
                isOpen = false;
            }
        }
    
}
}

