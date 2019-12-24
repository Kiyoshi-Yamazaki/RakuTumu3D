using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChengeController : MonoBehaviour
{
    [SerializeField] Text SelectText;
    
    public void ChangeToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
     public void ChangeToSelectScene()
    {
        SceneManager.LoadScene("SelectionScreen");
        // SelectText.text = UIManeger.builderText.ToString();
    }
    // Start is called before the first frame update
   
}
