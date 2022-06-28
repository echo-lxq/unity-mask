using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vedioOver : MonoBehaviour
{
    // Start is called before the first frame update
    private float times = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        times += Time.deltaTime;
        if(times >= 128f){
            times = 0;
            this.gameObject.SetActive(false);
        }
    }

}
