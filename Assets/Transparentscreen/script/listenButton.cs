using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listenButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener (OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnClick(){
        print ("11");
    }
}
