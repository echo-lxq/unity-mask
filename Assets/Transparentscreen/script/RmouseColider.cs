using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RmouseColider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown(){
        if(this.tag == "RANGE"){
            createCircle.RANGE = true;
        }
       print(createCircle.RANGE);
    }void OnMouseUp(){
        createCircle.RANGE = false;
    }
}
