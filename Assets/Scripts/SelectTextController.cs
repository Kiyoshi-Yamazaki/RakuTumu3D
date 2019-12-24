using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTextController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text = UIManeger.builderText.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
