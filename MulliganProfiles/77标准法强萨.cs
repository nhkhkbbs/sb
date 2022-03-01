using System;
using System.Collections.Generic;
using System.Linq;
using SmartBot.Database;
using SmartBot.Plugins.API;

// ### 法强萨
// # 职业：萨满祭司
// # 模式：标准模式
// # 狮鹫年
// #
// # 2x (0) 雷霆绽放 SCH_427
// # 2x (1) 闪电箭
// # 2x (1) 电击学徒
// # 2x (1) 强行透支
// # 2x (1) 始生研习 SCH_270
// # 2x (1) 冷风
// # 2x (2) 破霰元素 AV_260 
// # 2x (2) 大地崩陷
// # 2x (2) 冰霜撕咬 AV_259 
// # 2x (3) 艳丽的金刚鹦鹉 DED_509 
// # 2x (3) 毒蛇神殿传送门
// # 1x (3) 原初地下城历险家 WC_005 
// # 2x (4) 蛮爪洞穴 AV_268
// # 2x (4) 多系施法者 DED_524 
// # 2x (6) 雪落守护者 AV_255 
// # 1x (8) 元素使者布鲁坎
// #
// AAECAaoIAuPuA8ORBA7buAPNzgPw1AOJ5APq5wOF+gPTgASogQS5kQT5kQSVkgTckgTblAT5nwQA
// # 想要使用这副套牌，请先复制到剪贴板，再在游戏中创建新套牌。
// # 套牌详情请查看https://hsreplay.net/decks/3zdp1X5kIA1byIKl51JT5f/

namespace SmartBot.Mulligan
{
    [Serializable]
    public class DefaultMulliganProfile : MulliganProfile
    {
        List<Card.Cards> CardsToKeep = new List<Card.Cards>();

        private readonly List<Card.Cards> WorthySpells = new List<Card.Cards>
        {
            
        };

        public List<Card.Cards> HandleMulligan(List<Card.Cards> choices, Card.CClass opponentClass,
            Card.CClass ownClass)
        {
            bool HasCoin = choices.Count >= 4;

            int flag1=0;//艾露恩神谕者 Oracle of Elune      SW_419
            int flag2=0;//钢鬃卫兵 Razormane Battleguard      BAR_537 
            int flag3=0;//噬骨殴斗者 Bonechewer Brawler      BT_715
            int flag4=0;//狂野蟾蜍 Toad of the Wilds      BAR_743 
            int flag5=0;//播种施肥 Sow the Soil      SW_422
            int flag6=0;//活泼的松鼠 Vibrant Squirrel      SW_439 
            int flag7=0;//前沿哨所 Far Watch Post      BAR_074 
            int flag8=0;//吵吵机器人 Annoy-o-Tron      CORE_GVG_085 
            int flag9=0;//雷霆绽放 Lightning Bloom      SCH_427 
            int flag10=0;//农夫 Peasant      SW_319
            int flag11=0;//银色侍从 Argent Squire      CORE_EX1_008 
            int flag12=0;//劳累的驮骡 Encumbered Pack Mule      SW_306 
            int flag13=0;//施肥 Composting      SW_437  
            int flag14=0;//新生刺头 Intrepid Initiate      SCH_231
            int flag15=0;//魔法乌鸦 Enchanted Raven      CORE_KAR_300
               int DRUID=0;
            int HUNTER=0;
            int MAGE=0;
            int PALADIN=0;
            int PRIEST=0;
            int ROGUE=0;
            int SHAMAN=0;
            int WARLOCK=0;
            int WARRIOR=0;
            int DEMONHUNTER=0;
              Bot.Log("对阵职业"+opponentClass);

            if(opponentClass==Card.CClass.PALADIN){
            PALADIN+=1;
            }
            if(opponentClass==Card.CClass.DRUID){
            DRUID+=1;
            }
            if(opponentClass==Card.CClass.HUNTER){
            HUNTER+=1;
            }
            if(opponentClass==Card.CClass.MAGE){
            MAGE+=1;
            }
            if(opponentClass==Card.CClass.PRIEST){
            PRIEST+=1;
            }
            if(opponentClass==Card.CClass.ROGUE){
            ROGUE+=1;
            }
            if(opponentClass==Card.CClass.SHAMAN){
            SHAMAN+=1;
            }
            if(opponentClass==Card.CClass.WARLOCK){
            WARLOCK+=1;
            }
            if(opponentClass==Card.CClass.WARRIOR){
            WARRIOR+=1;
            }
            if(opponentClass==Card.CClass.DEMONHUNTER){
            DEMONHUNTER+=1;
            }
            foreach (Card.Cards card in choices)
            {
                if(card==Card.Cards.SW_419//艾露恩神谕者 Oracle of Elune      SW_419  
                ){flag1+=1;}
                
                if(card==Card.Cards.BAR_537//钢鬃卫兵 Razormane Battleguard      BAR_537 
                ){flag2+=1;}
                
                if(card==Card.Cards.BT_715//噬骨殴斗者 Bonechewer Brawler      BT_715
                ){flag3+=1;}
                
                if(card==Card.Cards.BAR_743 //狂野蟾蜍 Toad of the Wilds      BAR_743 
                ){flag4+=1;}
                
                if(card==Card.Cards.SW_422//播种施肥 Sow the Soil      SW_422
                ){flag5+=1;}

                if(card==Card.Cards.SW_439//活泼的松鼠 Vibrant Squirrel      SW_439 
                ){flag6+=1;}

                if(card==Card.Cards.BAR_074//前沿哨所 Far Watch Post      BAR_074 
                ){flag7+=1;}
                 
                if(card==Card.Cards.CORE_GVG_085//吵吵机器人 Annoy-o-Tron      CORE_GVG_085 
                ){flag8+=1;}

                if(card==Card.Cards.SCH_427//雷霆绽放 Lightning Bloom      SCH_427 
                ){flag9+=1;}
                if(card==Card.Cards.SW_319//农夫 Peasant      SW_319
                ){flag10+=1;}
                if(card==Card.Cards.CORE_EX1_008//银色侍从 Argent Squire      CORE_EX1_008
                ){flag11+=1;}
                if(card==Card.Cards.SW_306//劳累的驮骡 Encumbered Pack Mule      SW_306  
                ){flag12+=1;}
                if(card==Card.Cards.SW_437//施肥 Composting      SW_437
                ){flag13+=1;}
                if(card==Card.Cards.SCH_231//新生刺头 Intrepid Initiate      SCH_231
                ){flag14+=1;}
                if(card==Card.Cards.CORE_KAR_300//魔法乌鸦 Enchanted Raven      CORE_KAR_300
                ){flag15+=1;}
            }

            foreach (Card.Cards card in choices)
            {
                 if((card==Card.Cards.SCH_427//艾露恩神谕者 Oracle of Elune      SCH_427 
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.SCH_427))
                    {
                        Keep(card,"雷霆绽放");
                    }
                    }   
                }
                 if((card==Card.Cards.AV_260//荆棘护卫 Thorngrowth Sentries ID：AV_260 
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.AV_260))
                    {
                        Keep(card,"破霰元素");
                    }
                    }   
                }
                 if((card==Card.Cards.WC_005//群羊指挥官 Ram Commander ID：WC_005
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.WC_005))
                    {
                        Keep(card,"原初地下城历险家");
                    }
                    }   
                }
                 if((card==Card.Cards.AV_268//霜狼巢屋 Frostwolf Kennels ID：AV_268 
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.AV_268))
                    {
                        Keep(card,"蛮爪洞穴");
                    }
                    }   
                }
                 if((card==Card.Cards.SCH_270//始生研习 SCH_270
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.SCH_270))
                    {
                        Keep(card,"始生研习");
                    }
                    }   
                }
                   if(card==Card.Cards.BAR_075// 十字路口哨所 BAR_075 
                ){ if(!CardsToKeep.Contains(Card.Cards.BAR_075)&&MAGE+ROGUE+PRIEST+WARLOCK+DEMONHUNTER>0)
                    {
                        Keep(card,"十字路口哨所");
                    }
                }

                if(card==Card.Cards.BAR_537//钢鬃卫兵 Razormane Battleguard      BAR_537 
                )
                {
                       if(!CardsToKeep.Contains(Card.Cards.BAR_537))
                    {
                        Keep(card,"钢鬃卫兵");
                    }
                }
                if(card==Card.Cards.YOP_025// 迷梦幼龙  YOP_025 
                )
                 {
                       if(!CardsToKeep.Contains(Card.Cards.YOP_025)&&flag2+flag3+flag4+flag8+flag12>=2)
                    {
                        Keep(card,"迷梦幼龙");
                    }
                }
                  if(card==Card.Cards.AV_137// 深铁穴居人  AV_137 
                ){ 
                        Keep(card,"深铁穴居人");
                    
                }
                  if(card==Card.Cards.SCH_607// 大导师野爪 Shan'do Wildclaw ID：SCH_607 
                ){ 
                        Keep(card,"大导师野爪");
                    
                }
                  if(card==Card.Cards.AV_100// 德雷克塔尔 Drek'Thar ID：AV_100
                ){ 
                        Keep(card,"德雷克塔尔");
                    
                }
                // if(card==Card.Cards.SCH_244//教师的爱宠 Teacher's Pet      SCH_244 
                // )
                // {
                //        if(!CardsToKeep.Contains(Card.Cards.SCH_244)&&flag2+flag3+flag4+flag8+flag12>=2)
                //     {
                //         Keep(card,"教师的爱宠");
                //     }
                // }
                // if(card==Card.Cards.DMF_734//格雷布 Greybough      DMF_734 
                // )
                // {
                //        if(!CardsToKeep.Contains(Card.Cards.DMF_734)&&flag2+flag3+flag4+flag8+flag12>=2)
                //     {
                //         Keep(card,"格雷布");
                //     }
                // }
              // if(card==Card.Cards.SW_306&&flag2>0&&flag3+flag4+flag8==0)//劳累的驮骡 Encumbered Pack Mule      SW_306 
              //   {
              //        if(!CardsToKeep.Contains(Card.Cards.SW_306))
              //       {
              //           Keep(card,"劳累的驮骡");
              //       }
              //   }
                if(card==Card.Cards.BT_715)//噬骨殴斗者 Bonechewer Brawler      BT_715
                {
                  if(!CardsToKeep.Contains(Card.Cards.BT_715))
                    {
                        Keep(card,"噬骨殴斗者");
                    }
                }
                // if(card==Card.Cards.BT_722)//防护改装师 BT_722 
                // {
                //    if(!CardsToKeep.Contains(Card.Cards.BT_722))
                //     {
                //         Keep(card,"防护改装师");
                //     }
                // }
                if(card==Card.Cards.BAR_743&&flag2>0)//狂野蟾蜍 Toad of the Wilds      BAR_743 
                {
                        Keep(card,"2狂野蟾蜍 ");   
                }
                if(card==Card.Cards.CORE_GVG_085&&flag2>0)//吵吵机器人 Annoy-o-Tron      CORE_GVG_085 
                {
                        Keep(card,"吵吵机器人 ");   
                }
                // if(card==Card.Cards.SW_422//播种施肥 Sow the Soil      SW_422
                // )
                // {
                //    if(!CardsToKeep.Contains(Card.Cards.SW_422))
                //     {
                //         Keep(card,"播种施肥");
                //     }
                // }
                if(card==Card.Cards.CORE_KAR_300//魔法乌鸦 Enchanted Raven      CORE_KAR_300
                )
                {
                   if(!CardsToKeep.Contains(Card.Cards.CORE_KAR_300))
                    {
                        Keep(card,"魔法乌鸦");
                    }
                }
                if(card==Card.Cards.SW_439//活泼的松鼠 Vibrant Squirrel      SW_439 
                )
                {
                   if(!CardsToKeep.Contains(Card.Cards.SW_439))
                    {
                        Keep(card,"活泼的松鼠");
                    }
                }
                  if(card==Card.Cards.DED_001//活泼的松鼠 Vibrant Squirrel      SW_439 
                )
                {//暗礁德鲁伊 Druid of the Reef ID：DED_001 

                   if(!CardsToKeep.Contains(Card.Cards.DED_001))
                    {
                        Keep(card,"暗礁德鲁");
                    }
                }
                if(card==Card.Cards.CORE_EX1_008//银色侍从 Argent Squire      CORE_EX1_008
                )
                {
                   if(!CardsToKeep.Contains(Card.Cards.CORE_EX1_008))
                    {
                        Keep(card,"银色侍从");
                    }
                }
                if(card==Card.Cards.SW_319//农夫 Peasant      SW_319
                )
                {
                   if(!CardsToKeep.Contains(Card.Cards.SW_319))
                    {
                        Keep(card,"农夫");
                    }
                }
                if(card==Card.Cards.SCH_231//新生刺头 Intrepid Initiate      SCH_231
                )
                {
                   if(!CardsToKeep.Contains(Card.Cards.SCH_231))
                    {
                        Keep(card,"新生刺头");
                    }
                }
                if(card==Card.Cards.BAR_074//前沿哨所 Far Watch Post      BAR_074
                )
                {
                   if(!CardsToKeep.Contains(Card.Cards.BAR_074))
                    {
                        Keep(card,"前沿哨所");
                    }
                }
                // if(card==Card.Cards.SW_437//施肥 Composting      SW_437
                // )
                // {
                //    if(!CardsToKeep.Contains(Card.Cards.SW_437))
                //     {
                //         Keep(card,"施肥");
                //     }
                // }
                // if(card==Card.Cards.BAR_743//狂野蟾蜍 Toad of the Wilds      BAR_743 
                // )
                // {
                //    if(!CardsToKeep.Contains(Card.Cards.BAR_743))
                //     {
                //         Keep(card,"狂野蟾蜍");
                //     }
                // }
                if(card==Card.Cards.SCH_427&&flag1+flag2>0//雷霆绽放 Lightning Bloom      SCH_427
                )
                {
                    if(!CardsToKeep.Contains(Card.Cards.SCH_427))
                    {
                        Keep(card,"雷霆绽放 ");
                    }   
                }
                // if(card==Card.Cards.BAR_076//莫尔杉哨所 Mor'shan Watch Post      BAR_076
                // )
                // {
                //     if(!CardsToKeep.Contains(Card.Cards.BAR_076)&&flag1+flag2>=1)
                //     {
                //         Keep(card,"留1莫尔杉哨所 ");
                //     }   
                // }
                // if(card==Card.Cards.WC_005//原初地下城历险家 Primal Dungeoneer      WC_005 
                // )
                // {
                //     if(!CardsToKeep.Contains(Card.Cards.WC_005))
                //     {
                //         Keep(card,"留1原初地下城历险家");
                //     }   
                // }
                // if(card==Card.Cards.CORE_BOT_533//凶恶的雨云 Menacing Nimbus      CORE_BOT_533 
                // )
                // {
                //      Keep(card,"留2凶恶的雨云 ");
                // }
                // if(card==Card.Cards.SW_025//拍卖行木槌 Auctionhouse Gavel      SW_025 
                // )
                // {
                //      Keep(card,"留2拍卖行木槌 ");
                // }

                // if(card==Card.Cards.BT_292//阿达尔之手 Hand of A'dal      BT_292  
                // ){
                //     if(!CardsToKeep.Contains(Card.Cards.BT_292)
                //     )
                //     {
                //         Keep(card,"留一张阿达尔之手");
                //     }
                // }                

                // if(card==Card.Cards.YOP_031//螃蟹骑士 Crabrider      YOP_031 
                // ){
                //     if(!CardsToKeep.Contains(Card.Cards.YOP_031)
                //        && HasCoin==true)
                //     {
                //         Keep(card,"后手留一张螃蟹骑士");
                //     }
                // }

                // if(card==Card.Cards.DMF_194//赤鳞驯龙者 Redscale Dragontamer      DMF_194
                // ){
                //     if(!CardsToKeep.Contains(Card.Cards.DMF_194)
                //        && HasCoin==true)
                //     {
                //         Keep(card,"后手留一张赤鳞驯龙者 Redscale Dragontamer");
                //     }
                // }


                // if(card==Card.Cards.CORE_FP1_007//蛛魔之卵 Nerubian Egg      CORE_FP1_007 
                // ){
                //     {
                //         if(!CardsToKeep.Contains(Card.Cards.CORE_FP1_007)
                //         )
                //         {
                //         Keep(card,"留一张蛛魔之卵 Nerubian Egg");
                //         } 
                //     }  //蛛魔之卵 Nerubian Egg      CORE_FP1_007
                // }

                // if(card==Card.Cards.DMF_704//笼斗管理员 Cagematch Custodian      DMF_704 
                // ){
                //     if(!CardsToKeep.Contains(Card.Cards.DMF_704)
                //        && HasCoin==true)
                //     {
                //         Keep(card,"后手留一张莫戈尔·莫戈尔格 Murgur Murgurgle");
                //     }
                //     else
                //     {
                //         if(!CardsToKeep.Contains(Card.Cards.DMF_704)
                //         && flag1+flag2+flag3>=1
                //         )
                //         {
                //         Keep(card,"先手有1费留一张莫戈尔·莫戈尔格 Murgur Murgurgle");
                //         } 
                //     }  //笼斗管理员 Cagematch Custodian      DMF_704 
                // }

                // //留第一张逝者之剑 Sword of the Fallen      BAR_875
                // if(card==Card.Cards.BAR_875)
                // {
                //     if(!CardsToKeep.Contains(Card.Cards.BAR_875))
                //     {
                //         Keep(card,"留第一张逝者之剑 Sword of the Fallen");
                //     }   
                // }
				
				
				// //有逝者之剑 Sword of the Fallen      BAR_875留北卫军指挥官 Northwatch Commander      BAR_876
        //         if(card==Card.Cards.BAR_876 && flag7>=1
        //         && HasCoin==true
        //          )
				// {Keep(card,"后手有逝者之剑 Sword of the Fallen留北卫军指挥官 Northwatch Commander");}


        
            }
            return CardsToKeep;
        }

        private void Keep(Card.Cards id, string log = "")
        {
            CardsToKeep.Add(id);
            if(log != "")
                Bot.Log(log);
        }

    }
}//德：DRUID 猎：HUNTER 法：MAGE 骑：PALADIN 牧：PRIEST 贼：ROGUE 萨：SHAMAN 术：WARLOCK 战：WARRIOR 瞎：DEMONHUNTER