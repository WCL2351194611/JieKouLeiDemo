using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 定义可交互接口，规定了Interact方法，所有实现该接口的类都要实现此方法来定义具体交互行为
public interface IInteractable 
{
    //不带参数的接口
    void Interact();
    //带参数的接口
    void Interact(int intSpeed);
}
