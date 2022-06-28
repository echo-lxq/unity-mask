using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadScence : MonoBehaviour
{
    private static bool isShow = false;
    private float times;
    // Start is called before the first frame update
    void Start()
    {
      // ReadConfig.LoadConfig("");
    }

    // Update is called once per frame
    void Update()
    {
        if(!isShow && xiaojiB.IsPlay)
        times += Time.deltaTime;

        if(times > 60f && !isShow){
            isShow = true;
            //加载场景
            SceneManager.LoadSceneAsync("Transparentscreen3");
        }
        if(Input.GetMouseButtonDown(0)){
            times = 0;
            isShow = true;
        }
        if(Input.GetMouseButtonUp(0)){
            isShow = false;
        }
    }
}
