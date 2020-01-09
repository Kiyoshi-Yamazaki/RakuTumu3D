using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutSidePageController : MonoBehaviour
{
    [SerializeField] GameObject Tire1CountText;
     [SerializeField] GameObject Tire2CountText;
     [SerializeField] GameObject Bicycle1CountText;
     [SerializeField] GameObject Bicycle2CountText;
     [SerializeField] GameObject Bicycle3CountText;
     [SerializeField] GameObject Planting1CountText;
     [SerializeField] GameObject Planting2CountText;
     [SerializeField] GameObject ScooterCountText;
     GameObject[] TireObject;
     GameObject[] BicycleObject;
     GameObject[] PlantingObject;
     public static int[] countTire ={0,0};
     public static int[] countBicycle ={0,0,0};
     public static int[] countPlanting ={0,0};
     public static int countScooter = 0;
     public static int NumTire(int i)
    {
        return countTire[i];
    }
    public static int NumBicycle(int i)
    {
        return countBicycle[i];
    }
    public static int NumPlanting(int i)
    {
        return countPlanting[i];
    }
     public void CountUpTire(int i)
    {
        countTire[i]++;
        this.TireObject[i].GetComponent<Text>().text = countTire[i].ToString(); 
    }
    public void CountDownTire(int i)
    {
        if(countTire[i] > 0)
        {
            countTire[i]--;
            this.TireObject[i].GetComponent<Text>().text =  countTire[i].ToString();
        }    
    }
    public void CountUpBicycle(int i)
    {
        countBicycle[i]++;
        this.BicycleObject[i].GetComponent<Text>().text = countBicycle[i].ToString(); 
    }
    public void CountDownBicycle(int i)
    {
        if(countBicycle[i] > 0)
        {
            countBicycle[i]--;
            this.BicycleObject[i].GetComponent<Text>().text = countBicycle[i].ToString();
        }    
    }
    public void CountUpPlanting(int i)
    {
        countPlanting[i]++;
        this.PlantingObject[i].GetComponent<Text>().text = countPlanting[i].ToString(); 
    }
    public void CountDownPlanting(int i)
    {
        if(countPlanting[i] > 0)
        {
            countPlanting[i]--;
            this.PlantingObject[i].GetComponent<Text>().text = countPlanting[i].ToString();
        }    
    }
    public void CountUpScooter()
    {
        countScooter++;
        this.ScooterCountText.GetComponent<Text>().text =                                              countScooter.ToString();
    }
    public void CountDownScooter()
    {
        if(countScooter > 0)
        {
            countScooter--;
            this.ScooterCountText.GetComponent<Text>().text =                                      countScooter.ToString();
        }    
    }
    // Start is called before the first frame update
    void Start()
    {
        TireObject = new GameObject[]{Tire1CountText,Tire2CountText};
        BicycleObject = new GameObject[]{Bicycle1CountText,Bicycle2CountText,                                        Bicycle3CountText};
        PlantingObject = new GameObject[]{Planting1CountText,Planting2CountText};
        KitchenSelectController.CountTextArray(TireObject,countTire);
        KitchenSelectController.CountTextArray(BicycleObject,countBicycle);
        KitchenSelectController.CountTextArray(PlantingObject,countPlanting);
        ScooterCountText.GetComponent<Text>().text = countScooter.ToString();
    }
}
