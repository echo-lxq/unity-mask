using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseColider : MonoBehaviour
{
    // Start is called before the first frame update
    //private GameObject backGround;
    void Start()
    {
        //backGround = GameObject.FindGameObjectWithTag("backGround");
    }
    void showIntroNum(int index,bool isShow){
        createCircle.showIntro = index-1;
        createCircle.showCirle = isShow;
    }
    // Update is called once per frame
    void OnMouseEnter(){
        switch(this.tag){
        case "1": showIntroNum(1,true);
        break;
        case "2": showIntroNum(2,true);
        break;
        case "3": showIntroNum(3,true);
        break;
        case "4": showIntroNum(4,true);
        break;
        case "5": showIntroNum(5,true);
        break;
        case "6": showIntroNum(6,true);
        break;
        case "7": showIntroNum(7,true);
        break;
        case "8": showIntroNum(8,true);
        break;
        case "9": showIntroNum(9,true);
        break;
        case "RANGE": showIntroNum(-1,false);
        break;
        }
        //print(createCircle.showIntro);
    }
    void OnMouseExit(){
        createCircle.showIntro = -1;    
        //print(createCircle.showIntro);
    }
    
}
