using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class SelectTextController1 : MonoBehaviour
{
   public static string[] nameTVString = {"・TV(55インチ以上)×","・TV(54インチ以下40インチ以上)×","・TV(39インチ以下25インチ以上)×","・TV(24インチ以下)×"};
    public static string[] nameTVBoardString ={ "・TVボード(45インチ以上)×","・TVボード(44インチ以下)×"};
    public static string[] nameSofaString = {"・ソファー(3人掛け)×","・ソファー(2人掛け)×","・ソファー(1人掛け)×"};
    public static string[] nameLivingBoardString = {"・リビングボード(ガラス)×","・リビングボード(木製)×" };
    public static string[] RGRName = {"・冷蔵庫(4ドア以上)×","・冷蔵庫(3ドア以下,170ℓ以上)×","・冷蔵庫(2ドア以下、170ℓ以下)×"};
    public static string[] WMName ={"・洗濯機(ドラム式)×","・洗濯機(全自動)×"};

    public static string[] CupBoardName ={"・食器棚(幅160ｾﾝﾁ以上(大人3人分))×","・食器棚(幅120ｾﾝﾁ(大人2人分))×","・食器棚(幅60(大人1人分))×","・食器棚(高さ120ｾﾝﾁ、幅60ｾﾝﾁ未満)×"};
    public static string[] DiningTableName ={"・食卓テーブル(6人掛け)×","・食卓テーブル(4人掛け)×","・食卓テーブル(2人掛け)×"};
    public static string[] BedName = {"・ベッド(キング)×", "・ベッド(クイーン)×","・ベッド(ダブル)×", "・ベッド(セミダブル)×","・ベッド(シングル)×"};
    public static string[] WardRobeName = {"・洋服タンス(4枚扉)×","・洋服タンス(3枚扉)×","・洋服タンス(2枚扉以下)×"};
    public static string[] LowChestName = {"・ローチェスト(幅150ｾﾝﾁ)×","・ローチェスト(幅120ｾﾝﾁ)×","・ローチェスト(幅90ｾﾝﾁ未満)×"};
    public static string DeskName = "・机(学習机)×";　　
    public static string electronicPianoName = "・電子ピアノ×";
    public static string cardBoardName = "・ダンボール×";
    public static string plasticChestName = "・プラスチックチェスト×";　
　　 public static　string[] ThreeStageCaseName ={"・3段ケース(横長タイプ)×","・3段ケース(奥長タイプ)×"};
    public static string[] CostumCaseName ={"・衣装ケース(フタ付きタイプ)×","・衣装ケース(引出しタイプ)×"};
    public static string BookCaseName = "・本棚×";
    public static string ColorBoxName = "・カラーBOX×";
    public static string[] TireName ={"・タイヤ(17インチ以上)×","・タイヤ(16インチ以下)×"};
    public static string[] BicycleName ={"・自転車(普通)×","・自転車(電動付き)×","・自転車(スポーツタイプ)×"};
    public static string[] PlantingName ={"・植物(高さ150ｾﾝﾁ以上(大人1人分))×","・植物(小)×"};
    public static string ScooterName = "・スクーター×";
    public static string FutonName = "・布団×";
    public static string AirConditionerName = "・エアコン×";
    public static string[] KotatuName ={"・コタツ(6人掛け)×","・コタツ(4人掛け)×"};
    public static string[] SteelRackName ={"・スチールラック(大)×","・スチールラック(小)×"};
    public static string[] BuddhistAlterName ={"・仏壇(大)×","・仏壇(小)×"};
    public static string DiningChairName = "・ダイニングチェアー×";
     public static string DeskChairName = "・学習椅子×";
    public static string TVNameArray(int i)
    {
        return nameTVString[i];
    }
    public static string TVBoardNameArray(int i)
    {
        return nameTVBoardString[i];
    }
    public static string SofaNameArray(int i)
    {
        return nameSofaString[i];
    }
     public static string LivingBoardNameArray(int i)
    {
        return nameLivingBoardString[i];
    }
     public static string RGRNameArray(int i)
    {
        return RGRName[i];
    }
     public static string WMNameArray(int i)
    {
        return WMName[i];
    }    
     public static string CupBoardNameArray(int i)
    {
        return CupBoardName[i];
    }    
     public static string DiningTableNameArray(int i)
    {
        return DiningTableName[i];
    }    
     public static string BedNameArray(int i)
    {
        return BedName[i];
    }    
     public static string WardRobeNameArray(int i)
    {
        return WardRobeName[i];
    }   
     public static string LowChestNameArray(int i)
    {
        return LowChestName[i];
    }   
     public static string ThreeStageCaseNameArray(int i)
    {
        return ThreeStageCaseName[i];
    }   
     public static string CostumCaseNameArray(int i)
    {
        return CostumCaseName[i];
    }   
     public static string TireNameArray(int i)
    {
        return TireName[i];
    }   
    public static string BicycleNameArray(int i)
    {
        return BicycleName[i];
    }   
    public static string PlantingNameArray(int i)
    {
        return PlantingName[i];
    }   
    public static string KotatuNameArray(int i)
    {
        return KotatuName[i];
    }   
    public static string SteelRackNameArray(int i)
    {
        return SteelRackName[i];
    }  
    public static string BuddhistAlterNameArray(int i)
    {
        return BuddhistAlterName[i];
    }    

   
}
