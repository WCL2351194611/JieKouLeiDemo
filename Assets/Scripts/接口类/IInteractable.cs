using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ɽ����ӿڣ��涨��Interact����������ʵ�ָýӿڵ��඼Ҫʵ�ִ˷�����������彻����Ϊ
public interface IInteractable 
{
    //���������Ľӿ�
    void Interact();
    //�������Ľӿ�
    void Interact(int intSpeed);
}
