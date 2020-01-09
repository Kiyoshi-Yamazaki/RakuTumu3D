using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Prefab
{
    public GameObject NameObject;
    public float Volume,Height,Width,Depth,Area;
    public int Count;
    public Prefab(GameObject NameObject,float Height,float Volume, float Width, float Depth, int Count,float Area)
    {
        this.NameObject = NameObject;
        this.Volume = Volume;
        this.Height = Height;
        this.Width = Width;
        this.Depth = Depth;
        this.Count = Count;
        this.Area = Area;
    }
}
public class PrefabGenerator : MonoBehaviour
{
    Transform SideWall,BackWall,FrontWall,BottomWall,TopWall;
    [SerializeField] Transform SideWall2t,BackWall2t,FrontWall2t,BottomWall2t,TopWall2t,SideWall3t,BackWall3t,FrontWall3t,BottomWall3t,TopWall3t,SideWall4t,BackWall4t,FrontWall4t,BottomWall4t,TopWall4t;
    GameObject NowChosenObject,OneBeforeObject;
    [SerializeField] GameObject cardboardS,RGR1,RGR2,RGR3,BedMat1,BedMat2,BedMat3,BedMat4,BedMat5,Bookcase,DiningChair,DeskChair,ColorBox,CostumCase2,CupBoard1,CupBoard2,CupBoard3,CupBoard4,KitchenTable1,KitchenTable2,KitchenTable3,LivingBoard2,LivingBoard1,Sofa1,Sofa2,Sofa3,Desk,ThreeStageCase1,ThreeStageCase2,Tire2,Tire1,TV1,TV2,TV3,TV4,TVBoard1,TVBoard2,WardRobe1,WardRobe2,WardRobe3,WM1,WM2,LowChest1,LowChest2,LowChest3;
    List<Prefab> _AccessoryPrefabList,_FurniturePrefabList,FurniturePrefabCountList,_GetOnPrefabList,GetOnPrefabCountList;
    IEnumerable<Prefab> AccessoryPrefabCountList,FurniturePrefabSpaceList;
    Vector3 NowChosenObjectPosition,hitAxisXPosition,hitAxisYPosition,hitAxisZPosition,hitBoxPosition;
    RaycastHit hitAxisX,hitAxisY,hitAxisZ,hitBox;
    float SumHeight,ZAxisSpace,sumArea,SumHeightChecker,ZAxisMaxSpace ;
    int WM1Count,WM2Count,BedMat1Count,BedMat2Count,BedMat3Count,BedMat4Count,BedMat5Count,BookcaseCount,CupBoard1Count,CupBoard2Count,CupBoard3Count,CupBoard4Count,KitchenTable1Count,KitchenTable2Count,KitchenTable3Count,LivingBoard1Count,LivingBoard2Count,Sofa1Count,Sofa2Count,Sofa3Count,DeskCount,Tire1Count,Tire2Count,TV1Count,TV2Count,TV3Count,TV4Count,TVBoard1Count,TVBoard2Count,WardRobe1Count,WardRobe2Count,WardRobe3Count,RGR1Count,RGR2Count,RGR3Count,createdCount,remainingCardBoardSCount,colorBoxCount,LowChest1Count,LowChest2Count,LowChest3Count,DeskChairCount,DiningChairCount,cardboardSCount,cardboardYAxisCount;
    List<GameObject> PrefabCreatedList;
    List<Vector3> LowPositionList;
    bool isAdd = true;
    bool isPositionAdd = true;
    [SerializeField] Camera simulator2tCamera,simulator3tCamera,simulator4tCamera;
    List<Prefab> AccessoryPrefabSetting()
    {
        List<Prefab> prefabList = new List<Prefab>()
        {
          new Prefab(NameObject:cardboardS,Volume:0.027f,Height:0.3f,Width:0.3f,Depth:0.3f,                                                                                  Count:cardboardSCount = AccessorySelectController.countCardBoard,Area:0.09f),
          new Prefab(NameObject:ThreeStageCase1,Volume:0.174f,Height:0.73f,Width:0.56f,Depth:0.41f,                                                                       Count:AccessorySelectController.NumThreeStageCase(0),Area:0.23f),
          new Prefab(NameObject:ThreeStageCase2,Volume:0.16f,Height:0.73f,Width:0.62f,Depth:0.35f,                                                                        Count:AccessorySelectController.NumThreeStageCase(1),Area:0.217f),
          new Prefab(NameObject:CostumCase2,Volume:0.071f,Height:0.32f,Width:0.7f,Depth:0.4f,                                                                               Count:AccessorySelectController.NumCostumCase(1),Area:0.28f),
        };
        return prefabList;
    }
     List<Prefab> FurniturePrefabSetting()
    {
        List<Prefab> FurnitureprefabList = new List<Prefab>()
        {
             new Prefab(NameObject:BedMat1,Volume:1.05f,Height:1.95f,Width:1.8f,Depth:0.3f,                                                                    Count:BedMat1Count = BedRoomSlectController.NumBed(0),Area:0.9f),
             new Prefab(NameObject:BedMat2,Volume:0.94f,Height:1.95f,Width:1.6f,Depth:0.3f,                                                                    Count:BedMat2Count = BedRoomSlectController.NumBed(1),Area:0.8f),
             new Prefab(NameObject:BedMat3,Volume:0.82f,Height:1.95f,Width:1.4f,Depth:0.3f,                                                                    Count:BedMat3Count = BedRoomSlectController.NumBed(2),Area:0.7f),
             new Prefab(NameObject:BedMat4,Volume:0.7f,Height:1.95f,Width:1.2f,Depth:0.3f,                                                                    Count:BedMat4Count = BedRoomSlectController.NumBed(3),Area:0.6f),
             new Prefab(NameObject:BedMat5,Volume:0.585f,Height:1.95f,Width:1.0f,Depth:0.3f,                                                                    Count:BedMat5Count = BedRoomSlectController.NumBed(4),Area:0.5f),
             new Prefab(NameObject:TVBoard1,Volume:0.028f,Height:1.4f,Width:0.4f,Depth:0.5f,                                                                Count:TVBoard1Count =  LivingselectController.NumTVBoard(0),Area:0.2f),
             new Prefab(NameObject:TVBoard2,Volume:0.18f,Height:0.9f,Width:0.5f,Depth:0.4f,                                                                Count:TVBoard2Count = LivingselectController.NumTVBoard(1),Area:0.2f),
             new Prefab(NameObject:Sofa1,Volume:1.176f,Height:2.1f,Width:0.8f,Depth:0.7f,                                                                   Count:Sofa1Count = LivingselectController.NumSofa(0),Area:0.56f),
             new Prefab(NameObject:Sofa2,Volume:0.576f,Height:1.6f,Width:0.6f,Depth:0.6f,                                                                   Count:Sofa2Count = LivingselectController.NumSofa(1),Area:0.36f),
             new Prefab(NameObject:Sofa3,Volume:0.422f,Height:0.75f,Width:0.75f,Depth:0.75f,                                                                Count:Sofa3Count = LivingselectController.NumSofa(2),Area:0.563f),
             new Prefab(NameObject:WardRobe1,Volume:1.824f,Height:1.9f,Width:1.6f,Depth:0.6f,                                                               Count:WardRobe1Count = BedRoomSlectController.NumWardRobe(0),Area:0.96f),
             new Prefab(NameObject:WardRobe2,Volume:1.296f,Height:1.8f,Width:1.2f,Depth:0.6f,                                                               Count:WardRobe2Count = BedRoomSlectController.NumWardRobe(1),Area:0.72f),
             new Prefab(NameObject:WardRobe3,Volume:0.648f,Height:1.8f,Width:0.6f,Depth:0.6f,                                                               Count:WardRobe3Count = BedRoomSlectController.NumWardRobe(2),Area:0.36f),
             new Prefab(NameObject:Desk,Volume:0.456f,Height:0.8f,Width:0.95f,Depth:0.6f,                                                                   Count:DeskCount = BedRoomSlectController.countDesk,Area:0.57f),
             new Prefab(NameObject:RGR1,Volume:0.902f,Height:1.84f,Width:0.7f,Depth:0.7f,                                                                   Count:RGR1Count = KitchenSelectController.NumRGR(0),Area:0.49f),
             new Prefab(NameObject:RGR2,Volume:0.673f,Height:1.7f,Width:0.66f,Depth:0.6f,                                                                   Count:RGR2Count = KitchenSelectController.NumRGR(1),Area:0.396f),
             new Prefab(NameObject:RGR3,Volume:0.36f,Height:1.2f,Width:0.6f,Depth:0.5f,                                                                    Count:RGR3Count = KitchenSelectController.NumRGR(2),Area:0.3f),
             new Prefab(NameObject:WM1,Volume:0.504f,Height:1.2f,Width:0.7f,Depth:0.6f,                                                                     Count: WM1Count = KitchenSelectController.NumWM(0),Area:0.42f),
             new Prefab(NameObject:WM2,Volume:0.39f,Height:1.0f,Width:0.65f,Depth:0.6f,                                                                  Count:WM2Count = KitchenSelectController.NumWM(1),Area:0.39f),
             new Prefab(NameObject:CupBoard1,Volume:1.56f,Height:1.95f,Width:1.6f,Depth:0.5f,                                                              Count:CupBoard1Count = KitchenSelectController.NumCupBoard(0),Area:0.8f),
             new Prefab(NameObject:CupBoard2,Volume:1.17f,Height:1.95f,Width:1.2f,Depth:0.5f,                                                              Count:CupBoard2Count = KitchenSelectController.NumCupBoard(1),Area:0.6f),
             new Prefab(NameObject:CupBoard3,Volume:0.585f,Height:1.95f,Width:0.5f,Depth:0.6f,                                                              Count:CupBoard3Count = KitchenSelectController.NumCupBoard(2),Area:0.3f),
             new Prefab(NameObject:CupBoard4,Volume:0.36f,Height:1.2f,Width:0.5f,Depth:0.6f,                                                               Count:CupBoard4Count = KitchenSelectController.NumCupBoard(3),Area:0.3f),
             new Prefab(NameObject:Bookcase,Volume:0.729f,Height:1.8f,Width:0.9f,Depth:0.45f,                                                               Count:BookcaseCount = AccessorySelectController.countBookCase,Area:0.405f),
             new Prefab(NameObject:LivingBoard1,Volume:0.36f,Height:1.2f,Width:0.5f,Depth:0.6f,                                                        Count:LivingBoard1Count = LivingselectController.NumLivingBoard(0),Area:0.3f),
             new Prefab(NameObject:LivingBoard2,Volume:0.36f,Height:1.2f,Width:0.5f,Depth:0.6f,                                                          Count:LivingBoard1Count = LivingselectController.NumLivingBoard(1),Area:0.3f),
             new Prefab(NameObject:LowChest1,Volume:0.506f,Height:1.5f,Width:0.75f,Depth:0.45f,                                                          Count:LowChest1Count = BedRoomSlectController.NumLowChest(0),Area:0.338f),
             new Prefab(NameObject:LowChest2,Volume:0.405f,Height:1.2f,Width:0.75f,Depth:0.45f,                                                          Count:LowChest2Count = BedRoomSlectController.NumLowChest(1),Area:0.338f),
             new Prefab(NameObject:LowChest3,Volume:0.203f,Height:0.9f,Width:0.5f,Depth:0.45f,                                                          Count:LowChest3Count = BedRoomSlectController.NumLowChest(2),Area:0.225f),
        };
        return FurnitureprefabList;
    }
     List<Prefab> GetOnPrefabSetting()
    {
        List<Prefab> GetOnPrefabList = new List<Prefab>()
        { 
            new Prefab(NameObject:Tire1,Volume:0.038f,Height:0.3f,Width:0.75f,Depth:0.75f,                                                                    Count:Tire1Count = OutSidePageController.NumTire(0),Area:0.563f),
            new Prefab(NameObject:Tire2,Volume:0.169f,Height:0.15f,Width:0.5f,Depth:0.5f,                                                                    Count:Tire2Count = OutSidePageController.NumTire(1),Area:0.25f),
            
            new Prefab(NameObject:ColorBox,Volume:0.092f,Height:0.9f,Width:0.3f,Depth:0.4f,                                                                   Count:colorBoxCount = AccessorySelectController.countColorBox,Area:0.12f),
            new Prefab(NameObject:TV1,Volume:0.208f,Height:0.8f,Width:0.2f,Depth:1.3f,                                                                    Count:TV1Count = LivingselectController.NumTV(0),Area:0.26f),
            new Prefab(NameObject:TV2,Volume:0.12f,Height:0.6f,Width:0.2f,Depth:1.0f,                                                                    Count:TV2Count = LivingselectController.NumTV(1),Area:0.2f),
            new Prefab(NameObject:TV3,Volume:0.08f,Height:0.5f,Width:0.2f,Depth:0.8f,                                                                    Count:TV3Count = LivingselectController.NumTV(2),Area:0.16f),
            new Prefab(NameObject:TV4,Volume:0.035f,Height:0.35f,Width:0.2f,Depth:0.5f,                                                                    Count:TV4Count = LivingselectController.NumTV(3),Area:0.1f),
            new Prefab(NameObject:DeskChair,Volume:0.36f,Height:0.6f,Width:1.0f,Depth:0.6f,                                                                    Count:DeskChairCount = BedRoomSlectController.countDeskChair,Area:0.6f),
            new Prefab(NameObject:DiningChair,Volume:0.18f,Height:0.45f,Width:0.8f,Depth:0.5f,                                                                    Count:DiningChairCount = KitchenSelectController.DiningChairCount,Area:0.4f),
            
        };
        return GetOnPrefabList;
    }    
      void GetNowChosenObjectPositionX()
      {
          if(OneBeforeObject != null)
          {
              NowChosenObjectPosition.x = NowChosenObjectPosition.x-(OneBeforeObject.transform.localScale.x/2-NowChosenObject.transform.localScale.x/2);
          }
      }  
      void GetNowChosenObjectPositionY()
      {
          if(OneBeforeObject != null)
          {
              NowChosenObjectPosition.y = NowChosenObjectPosition.y-(OneBeforeObject.transform.localScale.y/2-NowChosenObject.transform.localScale.y/2);
          }
      }  
      void GetNowChosenObjectPositionZ()
      {
           if(OneBeforeObject != null)
          {
              NowChosenObjectPosition.z = NowChosenObjectPosition.z+(OneBeforeObject.transform.localScale.z/2-NowChosenObject.transform.localScale.z/2);
          }
      }  
      void GetRowPosition()
      {
           hitBoxPosition = new Vector3(
                            BottomWall.position.x+BottomWall.localScale.x/2,
                            BackWall.transform.position.y,
                            BackWall.transform.position.z);
           if(Physics.BoxCast(hitBoxPosition,new Vector3(0.1f,ZAxisMaxSpace,ZAxisMaxSpace),new Vector3(-1,0,0),out hitBox))
           {
               NowChosenObjectPosition.x = hitBox.point.x+NowChosenObject.transform.localScale.x/2;
               LowPositionList.Add(hitBox.point);
           }
      }  
    // Start is called before the first frame update
    void Awake() {
        AccessoryPrefabSetting();
        FurniturePrefabSetting();
        GetOnPrefabSetting();
        _AccessoryPrefabList = AccessoryPrefabSetting(); 
        _FurniturePrefabList = FurniturePrefabSetting();
        _GetOnPrefabList = GetOnPrefabSetting();
    }
    void Start()
    {
         AccessoryPrefabCountList = _AccessoryPrefabList.Where(pre => pre.Count > 0);
         FurniturePrefabCountList = _FurniturePrefabList.Where(pre => pre.Count > 0).ToList();
         GetOnPrefabCountList = _GetOnPrefabList.Where(pre => pre.Count > 0).ToList();
         LowPositionList = new List<Vector3>(){};
         GetSumArea();
         GetTruckSize();
    }
    void GetSumArea ()
    {
        sumArea = AccessoryPrefabCountList.Sum(x => x.Area) + FurniturePrefabCountList.Sum(x => x.Area);
        if(cardboardSCount >= 6f){sumArea += (cardboardSCount/6)*0.09f;}
        if(Tire1Count > 0){sumArea += 0.563f;}
    }
    void GetTruckSize()
    {    
         if(0 < sumArea && sumArea <= 4.5f)
        {
            SideWall = SideWall2t;
            BackWall = BackWall2t;
            FrontWall = FrontWall2t;
            BottomWall = BottomWall2t;
            TopWall = TopWall2t;
            simulator2tCamera.enabled = true;
            simulator3tCamera.enabled = false;
            simulator4tCamera.enabled = false;
            cardboardYAxisCount = 6;
            SumHeightChecker = 1.8f;
            ZAxisMaxSpace = 1.65f;
        }
        else if (4.5 < sumArea && sumArea <= 8.91f)
        {
            SideWall = SideWall3t;
            BackWall = BackWall3t;
            FrontWall = FrontWall3t;
            BottomWall = BottomWall3t;
            TopWall = TopWall3t;
            simulator2tCamera.enabled = false;
            simulator3tCamera.enabled = true;
            simulator4tCamera.enabled = false;
            cardboardYAxisCount = 7;
            SumHeightChecker = 2.1f;
            ZAxisMaxSpace = 2.15f;
        }
        else
        {
            SideWall = SideWall4t;
            BackWall = BackWall4t;
            FrontWall = FrontWall4t;
            BottomWall = BottomWall4t;
            TopWall = TopWall4t;
            simulator2tCamera.enabled = false;
            simulator3tCamera.enabled = false;
            simulator4tCamera.enabled = true;
            cardboardYAxisCount = 7;
            SumHeightChecker = 2.1f;
            ZAxisMaxSpace = 2.25f;
        }
    }
　　 public void PrefabCreate()
    {
        PrefabCreatedList = new List<GameObject>(){};
       foreach(var obj in AccessoryPrefabCountList)
       {
           if(isAdd)
           {
                NowChosenObject = AccessoryPrefabCountList.Select(x => x.NameObject).First();
                NowChosenObjectPosition = new Vector3(
                BackWall.position.x+BackWall.localScale.x/2+NowChosenObject.transform.localScale.x/2,
                BottomWall.position.y+BottomWall.localScale.y/2+NowChosenObject.transform.localScale.y/2,
                SideWall.position.z-SideWall.localScale.z/2-NowChosenObject.transform.localScale.z/2);
                isAdd = false;
           }
           NowChosenObject = obj.NameObject;
           GetNowChosenObjectPositionY();
           GetNowChosenObjectPositionZ();
           GetNowChosenObjectPositionX();
           for(int i = 1;i <= obj.Count;i++)
           {
               if(NowChosenObject == cardboardS && i > obj.Count-obj.Count%cardboardYAxisCount )
               {
                   Prefab cardboardSPlus = new Prefab(NameObject:cardboardS,Volume:0.027f,Height:0.3f,Width:0.3f,Depth:0.3f,                                                     Count:remainingCardBoardSCount = AccessorySelectController.countCardBoard%cardboardYAxisCount,Area:0.09f);
                   GetOnPrefabCountList.Add(cardboardSPlus);
                    break;
               }
                 SumHeight += obj.Height; 
                if(SumHeight > SumHeightChecker)
               {
                    SumHeight = obj.Height;
                    NowChosenObjectPosition.z -= NowChosenObject.transform.localScale.z;
                    NowChosenObjectPosition.y = BottomWall.position.y+BottomWall.localScale.y/2+NowChosenObject.transform.localScale.y/2;
               }
               if(Mathf.Abs(FrontWall.position.z+FrontWall.transform.localScale.z-NowChosenObjectPosition.z) <= NowChosenObject.transform.localScale.z/2){
                   GetRowPosition();
                   NowChosenObjectPosition.y = BottomWall.position.y+BottomWall.localScale.y/2+NowChosenObject.transform.localScale.y/2;
                   NowChosenObjectPosition.z = SideWall.position.z-SideWall.localScale.z/2-NowChosenObject.transform.localScale.z/2;
               }
               Instantiate(NowChosenObject,NowChosenObjectPosition,NowChosenObject.transform.rotation);
               PrefabCreatedList.Add(NowChosenObject);
               OneBeforeObject = PrefabCreatedList.Last();
               NowChosenObjectPosition.y += NowChosenObject.transform.localScale.y;
                if(SumHeight >= SumHeightChecker)
               {
                    SumHeight = 0;
                    NowChosenObjectPosition.z -= NowChosenObject.transform.localScale.z; 
                    NowChosenObjectPosition.y = SideWall.position.y-SideWall.transform.localScale.y/2+NowChosenObject.transform.localScale.y/2;
               }
              
           }
       }
        if(AccessoryPrefabCountList.Any(x => x != null))
        {
            if(NowChosenObjectPosition.y == SideWall.position.y-SideWall.transform.localScale.y/2                                                                                 +NowChosenObject.transform.localScale.y/2)
            {
                ZAxisSpace = Mathf.Abs((FrontWall.position.z+FrontWall.localScale.z)-(NowChosenObjectPosition.z                                                                +NowChosenObject.transform.localScale.z/2));
                NowChosenObjectPosition.z += NowChosenObject.transform.localScale.z/2;
                if(!FurniturePrefabCountList.Exists(x => x.Width <= ZAxisSpace))
                {
                    GetRowPosition();
                }
            }
            else
            {  
                ZAxisSpace = Mathf.Abs((FrontWall.position.z+FrontWall.localScale.z)-                                                                (NowChosenObjectPosition.z-NowChosenObject.transform.localScale.z/2));
                NowChosenObjectPosition.z -= NowChosenObject.transform.localScale.z/2;
            }
        }
         else
        {
            ZAxisSpace = ZAxisMaxSpace;
            NowChosenObject = FurniturePrefabCountList.Where(z => z.Width <= ZAxisSpace)
                                                  .OrderByDescending(z => z.Width).Select(x => x.NameObject).First();
            NowChosenObjectPosition = new Vector3(
                BackWall.position.x+BackWall.localScale.x/2+NowChosenObject.transform.localScale.x/2,
                BottomWall.position.y+BottomWall.localScale.y/2+NowChosenObject.transform.localScale.y/2,
                SideWall.position.z-SideWall.localScale.z/2-NowChosenObject.transform.localScale.z/2);
            PrefabCreatedList = new List<GameObject>(){};
        }
        while (FurniturePrefabCountList.Any(x => x != null))
        {
             if(!FurniturePrefabCountList.Exists(x => x.Width <= ZAxisSpace))
            {
                GetRowPosition();
                ZAxisSpace = ZAxisMaxSpace;
                 NowChosenObjectPosition.z = SideWall.position.z-SideWall.localScale.z/2-NowChosenObject.transform.localScale.z/2;
            }
            NowChosenObject = FurniturePrefabCountList.Where(z => z.Width <= ZAxisSpace)
                                                  .OrderByDescending(z => z.Width).Select(x => x.NameObject).First();
            GetNowChosenObjectPositionX();
            NowChosenObjectPosition.y = SideWall.position.y-SideWall.transform.localScale.y/2+NowChosenObject.transform.localScale.y/2;
            if(ZAxisSpace != ZAxisMaxSpace){NowChosenObjectPosition.z -= NowChosenObject.transform.localScale.z/2;}
            else{GetNowChosenObjectPositionZ();}
            Instantiate(NowChosenObject,NowChosenObjectPosition,NowChosenObject.transform.rotation);
            Prefab NewFurniturePrefab = FurniturePrefabCountList.Where(z => z.Width <= ZAxisSpace).OrderByDescending(x => x.Width).First();
            NewFurniturePrefab.Count -= 1;
            FurniturePrefabCountList.Add(NewFurniturePrefab);
            FurniturePrefabCountList.Where(z => z.Width <= ZAxisSpace).OrderByDescending(x => x.Width).ToList().RemoveAt(0);
            PrefabCreatedList.Add(NowChosenObject);
            OneBeforeObject = PrefabCreatedList.Last();
            ZAxisSpace = Mathf.Abs((FrontWall.position.z+FrontWall.localScale.z)-                                                                        (NowChosenObjectPosition.z-NowChosenObject.transform.localScale.z/2));
            NowChosenObjectPosition.z -= NowChosenObject.transform.localScale.z/2;
            FurniturePrefabCountList = FurniturePrefabCountList.Where(pre => pre.Count > 0).ToList();
        }
         
        while (GetOnPrefabCountList.Any(x => x != null))
        {
            NowChosenObject = GetOnPrefabCountList.Select(x => x.NameObject).First();
             int NowChosenObjectCount =GetOnPrefabCountList.Select(x => x.Count).First();
             if(NowChosenObject.transform.localScale.z >= ZAxisSpace)
             {
                  GetRowPosition();
                ZAxisSpace = ZAxisMaxSpace;
                NowChosenObjectPosition.z = SideWall.position.z-SideWall.localScale.z/2-NowChosenObject.transform.localScale.z/2;
             }
            GetNowChosenObjectPositionX();
            NowChosenObjectPosition.y = SideWall.position.y-SideWall.transform.localScale.y/2+NowChosenObject.transform.localScale.y/2;
            if(ZAxisSpace != ZAxisMaxSpace){NowChosenObjectPosition.z -= NowChosenObject.transform.localScale.z/2;}
            else{GetNowChosenObjectPositionZ();}
            Prefab NewGetOnPrefab = GetOnPrefabCountList.First();
            if(NowChosenObject == Tire1 || NowChosenObject == Tire2 )
            {
                Instantiate(NowChosenObject,NowChosenObjectPosition,NowChosenObject.transform.rotation);
                
                {  
                    SumHeight = 0;
                    for(int i = 1;i < NowChosenObjectCount;i++)
                    {
                        SumHeight += NowChosenObject.transform.localScale.y; 
                        if(SumHeight > SumHeightChecker)
                        {
                            SumHeight = NowChosenObject.transform.localScale.y;
                            NowChosenObjectPosition.z -= NowChosenObject.transform.localScale.z;
                            NowChosenObjectPosition.y = BottomWall.position.y+BottomWall.localScale.y/2+NowChosenObject.transform.localScale.y/2;
                        }
                        NowChosenObjectPosition.y += NowChosenObject.transform.localScale.y;
                        Instantiate(NowChosenObject,NowChosenObjectPosition,NowChosenObject.transform.rotation);
                        NewGetOnPrefab.Count -= 1;
                    }
                }
                 ZAxisSpace = Mathf.Abs((FrontWall.position.z+FrontWall.localScale.z)-                                                                        (NowChosenObjectPosition.z-NowChosenObject.transform.localScale.z/2));
                  NowChosenObjectPosition.z -= NowChosenObject.transform.localScale.z/2;
                
            }
            else
            {  
                Vector3 startPosition = new Vector3 (
                       BackWall.position.x+BackWall.localScale.x/2, 
                       TopWall.position.y-TopWall.localScale.y/2,
                       FrontWall.position.z+FrontWall.localScale.z/2           
                       );
                if(isPositionAdd)
                {
                    LowPositionList.Insert(0,startPosition);
                    isPositionAdd = false;
                }
                
                Vector3 boxcastPosition = new Vector3 (
                        startPosition.x+NowChosenObject.transform.localScale.x/2,
                        startPosition.y,
                        startPosition.z+NowChosenObject.transform.localScale.z/2
                        );
                Vector3 boxObjectScale = new Vector3 (
                        NowChosenObject.transform.localScale.x,
                        0.05f,
                        NowChosenObject.transform.localScale.z
                        );
                 int lowPositionCount = 0;
                double d = BottomWall.localScale.z/NowChosenObject.transform.localScale.z;
                int columsCount = (int)d;
                for(int i = 1;i <= columsCount*LowPositionList.Count;i++)
                {
                     
                    if(Physics.BoxCast(boxcastPosition,boxObjectScale*0.5f,new Vector3(0,-1,0),out hitBox))
                    {
                        if(hitBox.point.y+NowChosenObject.transform.localScale.y < TopWall.transform.position.y-TopWall.transform.localScale.y)
                        {
                            Vector3 generationPoint = new Vector3 (
                                boxcastPosition.x,
                                hitBox.point.y+NowChosenObject.transform.localScale.y/2,
                                boxcastPosition.z
                            );
                            
                            Instantiate(NowChosenObject,generationPoint,NowChosenObject.transform.rotation);
                             break;
                        }    
                         boxcastPosition.z += NowChosenObject.transform.localScale.z;
                        if(i%columsCount == 0)
                        {
                             lowPositionCount++;
                             boxcastPosition.x = LowPositionList[lowPositionCount].x+NowChosenObject.transform.localScale.x/2;
                             boxcastPosition.z = startPosition.z+NowChosenObject.transform.localScale.z/2;
                        } 
                    }
                }
            }
            if(!GetOnPrefabCountList.Exists(x => x.Width <= ZAxisSpace))
            {
                GetRowPosition();
                ZAxisSpace = ZAxisMaxSpace;
                NowChosenObjectPosition.z = SideWall.position.z-SideWall.localScale.z/2-NowChosenObject.transform.localScale.z/2;
            }
            if(NowChosenObject == DiningChair){NewGetOnPrefab.Count -= 2;}
            else{NewGetOnPrefab.Count -= 1;}
            GetOnPrefabCountList.Add(NewGetOnPrefab);
            GetOnPrefabCountList.RemoveAt(0);   
            GetOnPrefabCountList = GetOnPrefabCountList.Where(pre => pre.Count > 0).ToList();           
        }                 
    }
            // Update is called once per frame
    void Update()
    {
        
    }
}
