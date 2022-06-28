using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createCircle : MonoBehaviour
{
    public GameObject CanvasGame;
    public static bool RANGE = false;
    public GameObject[] wenBen;
    public GameObject[] textAudio;
    private GameObject wenBenI;
    private GameObject textAudioI;
    private Vector3 mP;
    public static int showIntro = -1;
    public static bool showCirle = true;
    public static int gameIndex = -5;
    
    // Start is called before the first frame update
    Vector3 oinVector;
    Vector2 subVector;
    Vector2 subOinVector;
    int width;
    int height;
    float oinbit;
    float subheight;
    float subwidth;
    void Start()
    {
        width=Screen.width;
        //height=Screen.height+284;
        height=Screen.height;
        oinVector=maskGameObjectRect.anchoredPosition;
        oinVector.x+=Screen.width;
        subVector=subGameObjectRect.anchoredPosition;
        oinbit=subGameObjectRect.localScale.x;
        subOinVector=new Vector2(oinVector.x-Screen.width,oinVector.y);
        subheight=height*oinbit;
        //subwidth=height*oinbit/2;
    }
    public RectTransform maskGameObjectRect;
    public RectTransform subGameObjectRect;

    // Update is called once per frame
    void Update()
    {
        if(showIntro != -2){
            showCirle = true;
        }
        //AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("音效/撞到猪草的音效"),Camera.main.transform.position);
        //textAudio[0].Play();
        //textAudio[0].Stop();
        //
        if(showCirle){
            Vector2 pos=Input.mousePosition-oinVector;
            maskGameObjectRect.anchoredPosition=pos;
            float bitx=Input.mousePosition.x*1.0f/width;
            float bity=Input.mousePosition.y*1.0f/height;

            //print(subVector.x-bitx*width*oinbit);
            subGameObjectRect.anchoredPosition=new Vector2(subVector.x-bitx*width*oinbit,subVector.y-bity*height*oinbit+subheight);
        try{
            if((textAudioI.GetComponent<AudioSource>().isPlaying)==false){
                parentSetActive.isShow = false;
                parentSetActive.isAudio = false;
                Destroy(wenBenI);
                Destroy(textAudioI);
            }
        }catch{

        }
        
        
            mP = Input.mousePosition;
            if(showIntro >= 0 && gameIndex == -5){
                //&& (obj.Contains(wenBenI)==false)
                gameIndex = showIntro;
                wenBenI = Instantiate(wenBen[showIntro], mP, Quaternion.identity, CanvasGame.transform);
                textAudioI = Instantiate(textAudio[showIntro], Camera.main.transform.position, Quaternion.identity, CanvasGame.transform);
                parentSetActive.isAudio = true;
                //textAudio[showIntro].Play();
                //obj.Add(wenBenI);
            }else if(showIntro >= 0 && gameIndex != showIntro){
                //textAudio[gameIndex].Stop();
                gameIndex = showIntro;
                Destroy(wenBenI);
                Destroy(textAudioI);
                wenBenI = Instantiate(wenBen[showIntro], mP, Quaternion.identity, CanvasGame.transform);
                textAudioI = Instantiate(textAudio[showIntro], Camera.main.transform.position, Quaternion.identity, CanvasGame.transform);
                parentSetActive.isAudio = true;
                //textAudio[showIntro].Play();
            }else if(showIntro < 0){
                try{
                    //textAudio[gameIndex].Stop();
                    gameIndex = -5;
                    parentSetActive.isAudio = false;
                    Destroy(wenBenI);
                    Destroy(textAudioI);
                }catch{}
            }
        }
    }
    void playTextAudio(int index){
        switch(index){
            case 0: AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("音效/撞到猪草的音效"),Camera.main.transform.position);
            break;
        }
    }
}
