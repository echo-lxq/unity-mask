using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemC : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rightdajiC;
    void Start()
    {
        Invoke("Disright",1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Disright(){
        rightdajiC.SetActive(true);
        this.gameObject.SetActive(false);
        Invoke("IsShowC",0.5f);
    }
    void IsShowC(){
        rightdajiC.SetActive(false);
    }
}
