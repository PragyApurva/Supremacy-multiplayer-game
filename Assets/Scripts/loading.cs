using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    public Text loadingtext;

    private float tm = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string dots = new string('.',(int)tm%3);
        tm += Time.deltaTime*2;
        loadingtext.text = "Loading"+dots; 


    }
}
