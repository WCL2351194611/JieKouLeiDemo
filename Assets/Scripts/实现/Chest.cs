using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour,IInteractable
{
    public bool isOpened = false;
    public GameObject[] items; // ���豦��������һЩ��Ʒ����Ϸ����������������ʾ

    public void Interact()
    {
        if (!isOpened)
        {
            isOpened = true;
            Debug.Log("�����Ѵ򿪣������Ʒ:");
            foreach (var item in items)
            {
                // ����������ʵ�ʻ�ȡ��Ʒ���߼���������ӵ���ұ����ȣ���ʾ��ֻ��ӡ
                Debug.Log(item.name);
            }
        }
        else
        {
            Debug.Log("�����Ѿ��ǿյ���");
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
                Debug.Log("���䱻�����򿪣����������Ʒ:");
            }
            else
            {
                Debug.Log("���䱻С�Ĵ򿪣���ò�����Ʒ:");
            }
            foreach (var item in items)
            {
                // ����������ʵ�ʻ�ȡ��Ʒ���߼���������ӵ���ұ����ȣ���ʾ��ֻ��ӡ
                Debug.Log(item.name);
            }
        }
        else
        {
            Debug.Log("�����Ѿ��ǿյ���");
            isOpened = false;
        }
    }
}
