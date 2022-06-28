using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daijiContro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject daijiL;
    public GameObject daijiC;
    public GameObject daijiHC;
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
        daijiHC.SetActive(true);
        Invoke("IsShowHC",0.5f);
        daijiL.SetActive(true);
        Invoke("IsShow",8f);
    }
    void IsShow(){
        daijiC.SetActive(true);
        daijiL.SetActive(false);
        Invoke("IsShowC",0.5f);
    }
    void IsShowC(){
        daijiC.SetActive(false);
    }
    void IsShowHC(){
        daijiHC.SetActive(false);
    }
}
