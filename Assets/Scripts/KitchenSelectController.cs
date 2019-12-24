using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

public class KitchenSelectController : MonoBehaviour
{
    [SerializeField] GameObject RGR1CountText;
    [SerializeField] GameObject RGR2CountText;
    [SerializeField] GameObject RGR3CountText;
    [SerializeField] GameObject WM1CountText;
    [SerializeField] GameObject WM2CountText;
    [SerializeField] GameObject CupBoard1CountText;
    [SerializeField] GameObject CupBoard2CountText;
    [SerializeField] GameObject CupBoard3CountText;
    [SerializeField] GameObject CupBoard4CountText;
    [SerializeField] GameObject DiningTable1CountText;
    [SerializeField] GameObject DiningTable2CountText;
    [SerializeField] GameObject DiningTable3CountText;
    [SerializeField] GameObject DiningChairCountText;
    GameObject[] RGRObject;
    GameObject[] WMObject;
    GameObject[] CupBoardObject;
    GameObject[] DiningTableObject;
    public static int[] RGRCount = {0, 0, 0};
    public static int[] WMCount = {0, 0};
    public static int[] CupBoardCount = {0, 0, 0, 0};
    public static int[] DiningTableCount = {0, 0, 0};
    public static int DiningChairCount = 0;
    public static int NumRGR(int i)
    {
        return RGRCount[i];
    }
    public static int NumWM(int i)
    {
        return WMCount[i];
    }
    public static int NumCupBoard(int i)
    {
        return CupBoardCount[i];
    }
    public static int NumDiningTable(int i)
    {
        return DiningTableCount[i];
    }
     public  void CountUpRGR(int i)
    {
        RGRCount[i]++;
        RGRObject[i].GetComponent<Text>().text = RGRCount[i].ToString(); 
    }
    public  void CountDownRGR(int i)
    {
        if(RGRCount[i] > 0)
        {
            RGRCount[i]--;
            RGRObject[i].GetComponent<Text>().text = RGRCount[i].ToString();
        }    
    }
     public  void CountUpWM(int i)
    {
        WMCount[i]++;
        WMObject[i].GetComponent<Text>().text = WMCount[i].ToString(); 
    }
    public  void CountDownWM(int i)
    {
        if(WMCount[i] > 0)
        {
            WMCount[i]--;
            WMObject[i].GetComponent<Text>().text =  WMCount[i].ToString();
        }    
    }
     public  void CountUpCupBoard(int i)
    {
        CupBoardCount[i]++;
        CupBoardObject[i].GetComponent<Text>().text = CupBoardCount[i].ToString(); 
    }
    public  void CountDownCupBoard(int i)
    {
        if(CupBoardCount[i] > 0)
        {
            CupBoardCount[i]--;
            CupBoardObject[i].GetComponent<Text>().text = CupBoardCount[i].ToString();
        }    
    }
     public  void CountUpDiningTable(int i)
    {
        DiningTableCount[i]++;
        DiningTableObject[i].GetComponent<Text>().text = DiningTableCount[i].ToString(); 
    }
    public  void CountDownDiningTable(int i)
    {
        if(DiningTableCount[i] > 0)
        {
            DiningTableCount[i]--;
            DiningTableObject[i].GetComponent<Text>().text = DiningTableCount[i].ToString();
        }    
    }
     public  void CountUpDiningChair()
    {
        DiningChairCount++;
        DiningChairCountText.GetComponent<Text>().text = DiningChairCount.ToString(); 
    }
    public  void CountDownDiningChair()
    {
        if(DiningChairCount > 0)
        {
            DiningChairCount--;
           DiningChairCountText.GetComponent<Text>().text = DiningChairCount.ToString();
        }    
    }
    public static void CountTextArray(GameObject[]　ob, int[] count)
    {
        for(int i = 0; i <ob.Length; i++)
        {
            ob[i].GetComponent<Text>().text = count[i].ToString(); 
        }
    }
    void Start()
    {
      RGRObject = new GameObject[]{RGR1CountText, RGR2CountText,RGR3CountText};
      WMObject = new GameObject[]{WM1CountText,WM2CountText};
      CupBoardObject = new GameObject[]{CupBoard1CountText,CupBoard2CountText,
                                              CupBoard3CountText,CupBoard4CountText};
      DiningTableObject = new GameObject[]{DiningTable1CountText,DiningTable2CountText,                         DiningTable3CountText};
      CountTextArray(RGRObject,RGRCount);
      CountTextArray(WMObject,WMCount);
      CountTextArray(CupBoardObject,CupBoardCount);
      CountTextArray(DiningTableObject,DiningTableCount);
      DiningChairCountText.GetComponent<Text>().text = DiningChairCount.ToString(); 
    }
}
