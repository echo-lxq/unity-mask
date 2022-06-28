using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class buttonMonitor : MonoBehaviour
{
    // // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener (OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnClick(){
       
       // gameObject.GetComponent<Image>().enabled=false;
        switch(this.gameObject.tag){
            
            case "range1":
            SceneManager.LoadScene("Transparentscreen");
            //this.gameObject.GetComponent<Image>().
            //Application.LoadLevelAsync("Transparentscreen");
            break;

            case "range2":
            SceneManager.LoadScene("Transparentscreen1");
            //Application.LoadLevelAsync("Transparentscreen1");
            break;

            case "range3":
            SceneManager.LoadScene("Transparentscreen2");
            //Application.LoadLevelAsync("Transparentscreen2");
            break;
        }
    }
    // void imageShow(){
    //     Graphics g = yourPicturebox.CreateGraphics();
    //     g.DrawImage( yourImage, 0, 0, new Rectangle( 20,20, 100, 100 ),GraphicsUnit.Pixel );
    // }
    
}
