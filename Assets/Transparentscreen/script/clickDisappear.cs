using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDisappear : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pleaseClick;
    private static bool isShow = true;
    private float times;
    void Start()
    {
        
    }
    void Update()
    {
        if(!isShow)
        times += Time.deltaTime;

        if(times > 5f && !isShow){
            isShow = true;
            setClickActive();
        }
        if(Input.GetMouseButtonDown(0)){
            times = 0;
            isShow = true;
            pleaseClick.SetActive(false);

        }
        if(Input.GetMouseButtonUp(0)){
            isShow = false;
        }
        //print(times);
    }
    public void setClickActive(){
        if(isShow){
            pleaseClick.SetActive(true);
        }else{
            pleaseClick.SetActive(false);
        }
        
    }
}
