using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class xiaojiB : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Vedio;
    public static bool IsPlay = true;
    //public GameObject background;
    public AudioSource backGroundMusic;
    void Start()
    {
        // Button btn = this.GetComponent<Button>();
        // btn.onClick.AddListener (OnClick);
        //backGroundMusic =  background.transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         if (!IsPlay){
    //             backGroundMusic.Play();
    //             IsPlay = true;
    //             Vedio.SetActive(false);
    //         }
    //     }
    // }

    void OnMouseEnter(){
            backGroundMusic.Pause();
            Vedio.SetActive(true);
            IsPlay = false;
    }
    void OnMouseExit(){
        backGroundMusic.Play();
        IsPlay = true;
        Vedio.SetActive(false);
    }

    // void OnClick(){
    //     if(IsPlay){
    //         backGroundMusic.Pause();
    //         Vedio.SetActive(true);
    //         IsPlay = false;
    //     }else{
    //         backGroundMusic.Play();
    //         IsPlay = true;
    //         Vedio.SetActive(false);
    //     }
    // }

}
