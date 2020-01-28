using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OthersPageController : MonoBehaviour
{
    [SerializeField] GameObject FutonCountText;
    [SerializeField] GameObject AirConditionerCountText;
    [SerializeField] GameObject Kotatu1CountText;
    [SerializeField] GameObject Kotatu2CountText;
    [SerializeField] GameObject SteelRack1CountText;
    [SerializeField] GameObject SteelRack2CountText;
    [SerializeField] GameObject BuddhistAlter1CountText;
    [SerializeField] GameObject BuddhistAlter2CountText;
    GameObject[] KotatuObject ;
    GameObject[] SteelRackObject;
    GameObject[] BuddhistAlterObject;
    public static　int countFuton;
    public static int countAirConditioner;
    public  static int[] countKotatu ={0,0};
    public  static int[] countSteelRack ={0,0};
    public  static int[] countBuddhistAlter ={0,0};
    public  static int NumKotatu(int i)
    {
        return countKotatu[i];
    }
    public  static int NumSteelRack(int i)
    {
        return countSteelRack[i];
    }
    public static int NumBuddhistAlter(int i)
    {
        return countBuddhistAlter[i];
    }
     public void CountUpFuton()
    {
        countFuton++;
        this.FutonCountText.GetComponent<Text>().text = countFuton.ToString();
    }
    public void CountDownFuton()
    {
        if(countFuton > 0)
        {
            countFuton--;
            this.FutonCountText.GetComponent<Text>().text = countFuton.ToString();
        }    
    }
    public void CountUpAirConditioner()
    {
        countAirConditioner++;
        this.AirConditionerCountText.GetComponent<Text>().text = countAirConditioner.ToString();
    }
    public void CountDownAirConditioner()
    {
        if(countAirConditioner > 0)
        {
            countAirConditioner--;
            this.AirConditionerCountText.GetComponent<Text>().text = countAirConditioner.ToString();
        }    
    }
    public void CountUpKotatu(int i)
    {
        countKotatu[i]++;
        this.KotatuObject[i].GetComponent<Text>().text = countKotatu[i].ToString(); 
    }
    public void CountDownKotatu(int i)
    {
        if(countKotatu[i] > 0)
        {
            countKotatu[i]--;
            this.KotatuObject[i].GetComponent<Text>().text = countKotatu[i].ToString();
        }    
    }
    public void CountUpSteelRack(int i)
    {
        countSteelRack[i]++;
        this.SteelRackObject[i].GetComponent<Text>().text = countSteelRack[i].ToString(); 
        this.SteelRackObject[i].GetComponent<Text>().text = countSteelRack[i].ToString(); 
    }
    public void CountDownSteelRack(int i)
    {
        if(countSteelRack[i] > 0)
        {
            countSteelRack[i]--;
            this.SteelRackObject[i].GetComponent<Text>().text = countSteelRack[i].ToString();
        }    
    }
    public void CountUpBuddhistAlter(int i)
    {
        countBuddhistAlter[i]++;
        this.BuddhistAlterObject[i].GetComponent<Text>().text = countBuddhistAlter[i].ToString(); 
    }
    public void CountDownBuddhistAlter(int i)
    {
        if(countBuddhistAlter[i] > 0)
        {
            countBuddhistAlter[i]--;
            this.BuddhistAlterObject[i].GetComponent<Text>().text = countBuddhistAlter[i].ToString();
        }    
    }
    void Start()
    {
        KotatuObject = new GameObject[]{Kotatu1CountText, Kotatu2CountText};
        SteelRackObject = new GameObject[]{SteelRack1CountText,                                     SteelRack2CountText};
        BuddhistAlterObject = new GameObject[]                                                  {BuddhistAlter1CountText, BuddhistAlter2CountText};
        FutonCountText.GetComponent<Text>().text =countFuton.ToString();
        AirConditionerCountText.GetComponent<Text>().text = countAirConditioner.ToString();
        KitchenSelectController.CountTextArray(KotatuObject,countKotatu);
        KitchenSelectController.CountTextArray(SteelRackObject,countSteelRack);
        KitchenSelectController.CountTextArray(BuddhistAlterObject,countBuddhistAlter);
    }
}
