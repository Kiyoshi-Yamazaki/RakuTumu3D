using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessorySelectController : MonoBehaviour
{
    [SerializeField] GameObject CardBoardCountText;
    [SerializeField] GameObject PlasticChestCountText;
    [SerializeField] GameObject ThreeStageCase1CountText;
    [SerializeField] GameObject ThreeStageCase2CountText;
    [SerializeField] GameObject CostumCase1CountText;
    [SerializeField] GameObject CostumCase2CountText;
    [SerializeField] GameObject BookCaseCountText;
    [SerializeField] GameObject ColorBoxCountText;
    GameObject[] ThreeStageCaseObject;
    GameObject[] CostumCaseObject;
    public static int[] countThreeStageCase ={0,0};
    public static int[] countCostumCase ={0,0};
    public static int countCardBoard;
    public static int countPlasticChest;
    public static int countBookCase;
    public static int countColorBox;
    public static int NumThreeStageCase(int i){ return countThreeStageCase[i];}
    public static int NumCostumCase(int i){return countCostumCase[i];}
    public void CountUpCardBoard()
    {
        countCardBoard++;
        this.CardBoardCountText.GetComponent<Text>().text = countCardBoard.ToString();
    }
    public void CountDownCardBoard()
    {
        if(countCardBoard > 0)
        {
            countCardBoard--;
            this.CardBoardCountText.GetComponent<Text>().text = countCardBoard.ToString();
        }
    }        
    public void CountUpPlasticChest()
    {
        countPlasticChest++;
        this.PlasticChestCountText.GetComponent<Text>().text = countPlasticChest.ToString();
    }
    public void CountDownPlasticChest()
    {
        if(countPlasticChest > 0)
        {
            countPlasticChest--;
            this.PlasticChestCountText.GetComponent<Text>().text = countPlasticChest.ToString();
        }    
    }
    public void CountUpThreeStageCase(int i)
    {
        countThreeStageCase[i]++;
        this.ThreeStageCaseObject[i].GetComponent<Text>().text = countThreeStageCase[i].ToString(); 
    }
    public void CountDownThreeStageCase(int i)
    {
        if(countThreeStageCase[i] > 0)
        {
            countThreeStageCase[i]--;
            this.ThreeStageCaseObject[i].GetComponent<Text>().text = countThreeStageCase[i].ToString();
        }    
    }
    public void CountUpCostumCase(int i)
    {
        countCostumCase[i]++;
        this.CostumCaseObject[i].GetComponent<Text>().text = countCostumCase[i].ToString(); 
    }
    public void CountDownCostumCase(int i)
    {
        if(countCostumCase[i] > 0)
        {
            countCostumCase[i]--;
            this.CostumCaseObject[i].GetComponent<Text>().text = countCostumCase[i].ToString();
        }    
    }
    public void CountUpBookCase()
    {
        countBookCase++;
        this.BookCaseCountText.GetComponent<Text>().text = countBookCase.ToString();
    }
    public void CountDownBookCase()
    {
        if(countBookCase > 0)
        {
            countBookCase--;
            this.BookCaseCountText.GetComponent<Text>().text = countBookCase.ToString();
        }    
    }
    public void CountUpColorBox()
    {
        countColorBox++;
        this.ColorBoxCountText.GetComponent<Text>().text = countColorBox.ToString();
    }
    public void CountDownColorBox()
    {
        if(countColorBox > 0)
        {
            countColorBox--;
            this.ColorBoxCountText.GetComponent<Text>().text = countColorBox.ToString();
        }
    }          
    // Start is called before the first frame update
    void Start()
    {
        ThreeStageCaseObject = new GameObject[] {ThreeStageCase1CountText, ThreeStageCase2CountText};
        CostumCaseObject = new GameObject[]{CostumCase1CountText,CostumCase2CountText};
        KitchenSelectController.CountTextArray(ThreeStageCaseObject,countThreeStageCase);
        KitchenSelectController.CountTextArray(CostumCaseObject,countCostumCase);
        CardBoardCountText.GetComponent<Text>().text = countCardBoard.ToString();
        PlasticChestCountText.GetComponent<Text>().text = countPlasticChest.ToString();
        BookCaseCountText.GetComponent<Text>().text = countBookCase.ToString();
        ColorBoxCountText.GetComponent<Text>().text = countColorBox.ToString();
    }
}   
