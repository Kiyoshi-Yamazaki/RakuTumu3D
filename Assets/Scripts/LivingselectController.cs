using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivingselectController : MonoBehaviour
{
    [SerializeField] GameObject TV1CountText;
    [SerializeField] GameObject TV2CountText;
    [SerializeField] GameObject TV3CountText;
    [SerializeField] GameObject TV4CountText;
    [SerializeField] GameObject TVBoard1CountText;
    [SerializeField] GameObject TVBoard2CountText;
    [SerializeField] GameObject Sofa1CountText;
    [SerializeField] GameObject Sofa2CountText;
    [SerializeField] GameObject Sofa3CountText;
    [SerializeField] GameObject LivingBoard1CountText;
    [SerializeField] GameObject LivingBoard2CountText;
    GameObject[] TVObject ;
    GameObject[] TVBoradObject ;
    GameObject[] sofaObject ;
    GameObject[] LivingBoardObject;
    public static int[] countTV ={0,0,0,0}; 
    public static int[] countTVBoard ={0,0};
    public static int[] countSofa ={0,0,0};
    public static int[] countLivingBoard ={0,0}; 
    public static int NumTV(int i)
    {
        return countTV[i];
    }
    public static int NumTVBoard(int i)
    {
        return countTVBoard[i];
    }
    public static int NumSofa(int i)
    {
        return countSofa[i];
    }
    public static int NumLivingBoard(int i)
    {
        return countLivingBoard[i];
    }
    public void CountUpTV(int i)
    {
        countTV[i]++;
        this.TVObject[i].GetComponent<Text>().text = countTV[i].ToString(); 
    }
    public void CountDownTV(int i)
    {
        if(countTV[i] > 0)
        {
            countTV[i]--;
            this.TVObject[i].GetComponent<Text>().text = countTV[i].ToString();
        }    
    }
    public void CountUpTVBoard(int i)
    {
        countTVBoard[i]++;
        this.TVBoradObject[i].GetComponent<Text>().text = countTVBoard[i].ToString();
    }
    public void CountDownTVBoard(int i)
    {
        if(countTVBoard[i] > 0)
        {
            countTVBoard[i]--;
            this.TVBoradObject[i].GetComponent<Text>().text = countTVBoard[i].ToString();
        }    
    }
    public void CountUpSofa(int i)
    {
        countSofa[i]++;
        this.sofaObject[i].GetComponent<Text>().text = countSofa[i].ToString();
    }
    public void CountDownSofa(int i)
    {
        if(countSofa[i] > 0)
        {
            countSofa[i]--;
            this.sofaObject[i].GetComponent<Text>().text = countSofa[i].ToString();
        }    
    }
    public void CountUpLivingBoard(int i)
    {
        countLivingBoard[i]++;
        this.LivingBoardObject[i].GetComponent<Text>().text = countLivingBoard[i].ToString();
    }
    public void CountDownLivingBoard(int i)
    {
        if(countLivingBoard[i] > 0)
        {
            countLivingBoard[i]--;
            this.LivingBoardObject[i].GetComponent<Text>().text = countLivingBoard[i].ToString();
        }    
    }
    // Start is called before the first frame update
    void Start()
    {
         TVObject = new GameObject[]{TV1CountText, TV2CountText, TV3CountText,TV4CountText };
        TVBoradObject = new GameObject[]{TVBoard1CountText, TVBoard2CountText};
        sofaObject = new GameObject[]{Sofa1CountText,Sofa2CountText,Sofa3CountText};
        LivingBoardObject = new GameObject[]{LivingBoard1CountText,                                   LivingBoard2CountText};
        KitchenSelectController.CountTextArray(TVObject,countTV);
        KitchenSelectController.CountTextArray(TVBoradObject,countTVBoard);
        KitchenSelectController.CountTextArray(sofaObject,countSofa);
        KitchenSelectController.CountTextArray(LivingBoardObject,countLivingBoard);
        Debug.Log("変更");
    }
}
