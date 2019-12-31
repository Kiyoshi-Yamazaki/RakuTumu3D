using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TruckScaleText : MonoBehaviour
{
[SerializeField] Camera simulator2tCamera,simulator3tCamera,simulator4tCamera;
[SerializeField] Text truckScaleText;
    void Update()
    {
        if(simulator2tCamera.enabled == true)
        {
            truckScaleText.text = "２トンショートコンテナ\n（高さ２.０M、幅１.７M、長さ３.１M）";
        }
        else if(simulator3tCamera.enabled == true)
        {
            truckScaleText.text = "３トンコンテナ\n（高さ２.２M、幅２.２M、長さ４.５M）";
        }
        else if(simulator4tCamera == true)
        {
            truckScaleText.text = "４トンコンテナ\n（高さ２.４M、幅２.３M、長さ７.２M）";
        }
        else
        {
            truckScaleText.text = "";
        }
    }
}
