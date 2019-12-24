using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedRoomSlectController : MonoBehaviour
{
    [SerializeField] GameObject Bed1CountText;
    [SerializeField] GameObject Bed2CountText;
    [SerializeField] GameObject Bed3CountText;
    [SerializeField] GameObject Bed4CountText;
    [SerializeField] GameObject Bed5CountText;
    [SerializeField] GameObject WardRobe1CountText;
    [SerializeField] GameObject WardRobe2CountText;
    [SerializeField] GameObject WardRobe3CountText;
    [SerializeField] GameObject LowChest1CountText;
    [SerializeField] GameObject LowChest2CountText;
    [SerializeField] GameObject LowChest3CountText;
    [SerializeField] GameObject DeskCountText;
    [SerializeField] GameObject DeskChairCountText;
    GameObject[] BedObject ;
    GameObject[] WardRobeObject ;
    GameObject[] LowChestObject ;
    public static int[] countBed ={0,0,0,0,0}; 
    public static int[] countWardRobe ={0,0,0};
    public static int[] countLowChest ={0,0,0};
    public static int countDesk = 0;
    public static int countDeskChair =0; 
    public static int NumBed(int i)
    {
        return countBed[i];
    }
    public static int NumWardRobe(int i)
    {
        return countWardRobe[i];
    }
    public static int NumLowChest(int i)
    {
        return countLowChest[i];
    }
    public void CountUpBed(int i)
    {
        countBed[i]++;
        this.BedObject[i].GetComponent<Text>().text = countBed[i].ToString(); 
    }
    public void CountDownBed(int i)
    {
        if(countBed[i] > 0)
        {
            countBed[i]--;
            this.BedObject[i].GetComponent<Text>().text = countBed[i].ToString();
        }    
    }
    public void CountUpWardRobe(int i)
    {
        countWardRobe[i]++;
        this.WardRobeObject[i].GetComponent<Text>().text = countWardRobe[i].ToString();
    }
    public void CountDownWardRobe(int i)
    {
        if(countWardRobe[i] > 0)
        {
            countWardRobe[i]--;
            this.WardRobeObject[i].GetComponent<Text>().text = countWardRobe[i].ToString();
        }    
    }
    public void CountUpLowChest(int i)
    {
        countLowChest[i]++;
        this.LowChestObject[i].GetComponent<Text>().text = countLowChest[i].ToString(); 
    }
    public void CountDownLowChest(int i)
    {
        if(countLowChest[i] > 0)
        {
            countLowChest[i]--;
            this.LowChestObject[i].GetComponent<Text>().text = countLowChest[i].ToString();
        }    
    }
    public void CountUpDesk()
    {
        countDesk++;
        this.DeskCountText.GetComponent<Text>().text = countDesk.ToString();
    }
    public void CountDownDesk()
    {
        if(countDesk > 0)
        {
            countDesk--;
            this.DeskCountText.GetComponent<Text>().text = countDesk.ToString();
        }    
    }
    public void CountUpDeskChair()
    {
        countDeskChair++;
        this.DeskChairCountText.GetComponent<Text>().text = countDeskChair.ToString();
    }
    public void CountDownDeskChair()
    {
        if(countDeskChair > 0)
        {
            countDeskChair--;
            this.DeskChairCountText.GetComponent<Text>().text = countDeskChair.ToString();
        }    
    }
    void Start()
    {
        BedObject = new GameObject[]{Bed1CountText, Bed2CountText,  Bed3CountText,Bed4CountText,                                          Bed5CountText };
        WardRobeObject = new GameObject[]{WardRobe1CountText, WardRobe2CountText, WardRobe3CountText};
        LowChestObject = new GameObject[]{LowChest1CountText, LowChest2CountText, LowChest3CountText};
        KitchenSelectController.CountTextArray(BedObject,countBed);
        KitchenSelectController.CountTextArray(WardRobeObject,countWardRobe);
        KitchenSelectController.CountTextArray(LowChestObject,countLowChest);
        DeskCountText.GetComponent<Text>().text = countDesk.ToString();
        DeskChairCountText.GetComponent<Text>().text = countDeskChair.ToString();
    }
}
