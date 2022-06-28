using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public Texture tex;
 
    public GameObject silderButton;
	void OnGUI () {
        //if(Input.GetMouseButtonDown(0)){
        //print ("鼠标放下了");
            //mouseInstanse();   
        
        // Vector3 mP = Input.mousePosition;
        
        // mP.z = 4f;
        // print(mP);
        // Vector3 mousePosition = Camera.main.ScreenToWorldPoint(mP);


        // //指定要显示在的屏幕区域
        // Rect destRect = new Rect(mP.x*0.5f, 0, tex.width/8, tex.height);
        // //指定要显示的图片区域
        // Rect sourceRect = new Rect(mP.x*0.5f, 0, tex.width/8, tex.height);

        Rect destRect = new Rect(silderButton.transform.position.x*0.5f, 0, tex.width/8, tex.height);
        //指定要显示的图片区域
        Rect sourceRect = new Rect(silderButton.transform.position.x*0.5f, 0, tex.width/8, tex.height);
 
        DrawTextureWithTexCoords(destRect, sourceRect, tex);
        //}
        
	}
 
    void DrawTextureWithTexCoords(Rect destRect, Rect sourceRect, Texture tex)
    {
        int tw, th;
        tw = tex.width;
        th = tex.height;
        //------------调整放缩比例------------------
        sourceRect.x = sourceRect.x / tw;
        //屏幕坐标系原点: 左上角
        //图片坐标系原点: 左下角
        //图片的Y轴与屏幕的Y转方向相反，这里需要颠倒一下(都以左上角为坐标原点)
        sourceRect.y = 1.0f - (sourceRect.y + sourceRect.height) / th;
        sourceRect.width = sourceRect.width / tw;
        sourceRect.height = sourceRect.height / th;
        //------------------------------------------
        GUI.DrawTextureWithTexCoords(destRect, tex, sourceRect, true);
    }
}

