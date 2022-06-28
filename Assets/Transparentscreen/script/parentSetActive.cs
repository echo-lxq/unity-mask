using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentSetActive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parentGameObject;
    public static bool isShow = true;
    public static bool isAudio = false;
    //private float times = 0;
    private float times;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isAudio){
            times += Time.deltaTime;
        }
        if(times>5f){
            showParent(false);
        }
        if(!isShow){
            showParent(false);
            isShow = true;
        }

        if(Input.GetMouseButtonDown(0)){
            times = 0;
            isShow = true;
            showParent(true);
        }
    }
    void showParent(bool isShow){
        if(isShow){
            parentGameObject.SetActive(true);
        }else{
            parentGameObject.SetActive(false);
        }
    }
}
