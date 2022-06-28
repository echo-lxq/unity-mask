using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickHide : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rightHide;
    public GameObject rightHideC;
    private static bool isShow = false;
    private float times;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isShow)
        times += Time.deltaTime;

        if(times > 5f && isShow){
            isShow = false;
            setClickActive();
            Invoke("rightHideCF",0.5f);
        }
        if(Input.GetMouseButtonDown(0)){
            times = 0;
            isShow = true;
            setClickActive();
        }
    }
    public void setClickActive(){
        if(isShow){
            rightHide.SetActive(true);
        }else{
            rightHideC.SetActive(true);
            rightHide.SetActive(false);
        }
    }
    public void rightHideCF(){
        rightHideC.SetActive(false);
    }
}
