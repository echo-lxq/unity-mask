using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(createCircle.index < 0){
        //     OnMouseDrag();
        // }
        
    }
    void OnMouseDrag()
    {
         //获取需要移动物体的世界转屏幕坐标
        Vector3 screenPos = Camera.main.WorldToScreenPoint(this.transform.position);
        //获取鼠标位置
        Vector3 mousePos = Input.mousePosition;
        //因为鼠标只有X，Y轴，所以要赋予给鼠标Z轴
        mousePos.z = screenPos.z;
        //把鼠标的屏幕坐标转换成世界坐标
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        //控制物体移动
        transform.position = worldPos;
    }
}
