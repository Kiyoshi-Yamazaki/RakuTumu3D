using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
public class UIManeger : MonoBehaviour
{
    [SerializeField] GameObject selectText;
    public static StringBuilder builderText = new StringBuilder();
     [SerializeField] Animator animatorLiving;
     [SerializeField] Animator animatorKitchen;
     [SerializeField] Animator animatorBedRoom;
     [SerializeField] Animator animatorAccessory;
     [SerializeField] Animator animatorOutSide;
     [SerializeField] Animator animatorOthers;
    public void ChangeSelectPage(int i)
    {
       switch (i)
       {
           case 0:
                this.animatorLiving.SetTrigger("LivingTrigger");  
                break;
           case 1:
                this.animatorKitchen.SetTrigger("KitchenTrigger");  
                break;
           case 2:
                this.animatorBedRoom.SetTrigger("BedRoom Trigger");
                break;         
           case 3:
                this.animatorAccessory.SetTrigger("AccessoryPageTrigger");
                break; 
           case 4:
                this.animatorOutSide.SetTrigger ("OutSidePageTrigger");
                break; 
           case 5:
                this.animatorOthers.SetTrigger ("OthersPageTrigger");
                break; 
       }
        builderText.Length = 0;
        // builderText.Clear();
        this.selectText.GetComponent<Text>().text = "";  
    }
    public void BackToMenu(int i)
    {
        switch (i)
        {
            case 0:  //LivingPageからの遷移
                this.animatorLiving.SetTrigger("BackToMenuTrigger");     
                break;
            case 1:
                this.animatorKitchen.SetTrigger("BackToMenuTrigger");
                break;  
            case 2:
                this.animatorBedRoom.SetTrigger
                ("BackToMenuTrigger");
                break;
            case 3:
                this.animatorAccessory.SetTrigger
                ("BackToMenuTrigger");
                break; 
            case 4:
                this.animatorOutSide.SetTrigger
                ("BackToMenuTrigger");
                break;  
            case 5:
                this.animatorOthers.SetTrigger
                ("BackToMenuTrigger");
                break;       
        }
        GetSelectText(); 
    }  
    public void SetSelectText(string st, int i)
    { 
        Text setText = this.selectText.GetComponent<Text>();
         if(i != 0)
        {   
            builderText.Append(st + i.ToString());
            setText.text = builderText.ToString();
        }   
    }
    void GetSelectText()
    {
        for(int a4 = 0;a4 < 4;a4++)
        {
            SetSelectText(SelectTextController1.TVNameArray(a4),LivingselectController.NumTV(a4));
            SetSelectText(SelectTextController1.CupBoardNameArray(a4),KitchenSelectController.NumCupBoard(a4));
        }
        for(int b2 = 0;b2 < 2;b2++)
        {
            SetSelectText(SelectTextController1.TVBoardNameArray(b2),LivingselectController.NumTVBoard(b2));
            SetSelectText(SelectTextController1.LivingBoardNameArray(b2),LivingselectController.NumLivingBoard(b2));
            SetSelectText(SelectTextController1.WMNameArray(b2),KitchenSelectController.NumWM(b2));
            SetSelectText(SelectTextController1.ThreeStageCaseNameArray(b2),AccessorySelectController.NumThreeStageCase(b2));
            SetSelectText(SelectTextController1.CostumCaseNameArray(b2),AccessorySelectController.NumCostumCase(b2));
            SetSelectText(SelectTextController1.TireNameArray(b2),OutSidePageController.NumTire(b2));
            SetSelectText(SelectTextController1.PlantingNameArray(b2),OutSidePageController.NumPlanting(b2));
            SetSelectText(SelectTextController1.KotatuNameArray(b2),OthersPageController.NumKotatu(b2));
            SetSelectText(SelectTextController1.SteelRackNameArray(b2),OthersPageController.NumSteelRack(b2));
            SetSelectText(SelectTextController1.BuddhistAlterNameArray(b2),OthersPageController.NumBuddhistAlter(b2));
        }
        for(int c3 = 0;c3 < 3;c3++)
        {
            SetSelectText(SelectTextController1.SofaNameArray(c3),LivingselectController.NumSofa(c3));
            SetSelectText(SelectTextController1.RGRNameArray(c3),KitchenSelectController.NumRGR(c3));
            SetSelectText(SelectTextController1.DiningTableNameArray(c3),KitchenSelectController.NumDiningTable(c3));
            SetSelectText(SelectTextController1.WardRobeNameArray(c3),BedRoomSlectController.NumWardRobe(c3));
            SetSelectText(SelectTextController1.LowChestNameArray(c3),BedRoomSlectController.NumLowChest(c3));
            SetSelectText(SelectTextController1.BicycleNameArray(c3),OutSidePageController.NumBicycle(c3));
        }
        for(int d5 = 0;d5 < 5;d5++)
        {
            SetSelectText(SelectTextController1.BedNameArray(d5),BedRoomSlectController.NumBed(d5));
        }
        SetSelectText(SelectTextController1.DeskName,BedRoomSlectController.countDesk);
        SetSelectText(SelectTextController1.DeskChairName,                                                                 BedRoomSlectController.countDeskChair);
        SetSelectText(SelectTextController1.cardBoardName,AccessorySelectController.countCardBoard);
        SetSelectText(SelectTextController1.plasticChestName,AccessorySelectController.countPlasticChest);
        SetSelectText(SelectTextController1.BookCaseName,AccessorySelectController.countBookCase);
        SetSelectText(SelectTextController1.ColorBoxName,AccessorySelectController.countColorBox);
        SetSelectText(SelectTextController1.ScooterName,OutSidePageController.countScooter);
        SetSelectText(SelectTextController1.FutonName,OthersPageController.countFuton);
        SetSelectText(SelectTextController1.AirConditionerName,                                                        OthersPageController.countAirConditioner);
        SetSelectText(SelectTextController1.DiningChairName,KitchenSelectController.DiningChairCount);
       
    }   
   private void Start() 
  {
    selectText.GetComponent<Text>().text = builderText.ToString();
  }
}    

