using System;
using System.Collections.Generic;
using System.Linq;
using SmartBot.Database;
using SmartBot.Plugins.API;

// ### 快枪快马，杀出一个痛快
// # 职业：德鲁伊
// # 模式：标准模式
// # 狮鹫年
// #
// # 2x (1) 播种施肥 Sow the Soil      SW_422
// # 2x (1) 活泼的松鼠 Vibrant Squirrel      SW_439 
// # 2x (1)自然研习 Nature Studies      SCH_333 
// # 2x (1) 萌物来袭 Adorable Infestation      SCH_617 
// # 2x (2) 前沿哨所 Far Watch Post      BAR_074 
// # 2x (2) 劳累的驮骡 Encumbered Pack Mule      SW_306 
// # 1x (2) 卖花女郎 Florist      SW_060 
// # 2x (2) 噬骨殴斗者 Bonechewer Brawler      BT_715 
// # 2x (2) 施肥 Composting      SW_437 
// # 2x (2) 狂野蟾蜍 Toad of the Wilds      BAR_743 
// # 2x (2) 钢鬃卫兵 Razormane Battleguard      BAR_537 
// # 2x (3) 艾露恩神谕者 Oracle of Elune      SW_419 
// # 1x (3) 贪婪的书虫 Voracious Reader      SCH_142 
// # 2x (4) 花园猎豹 Park Panther      SW_431 
// # 1x (5) 教师的爱宠 Teacher's Pet      SCH_244 
// # 2x (5) 树木生长 Arbor Up      YOP_026 
// # 1x (5) 格雷布 Greybough      DMF_734 
// 吵吵机器人 Annoy-o-Tron      CORE_GVG_085 
// 农夫 Peasant      SW_319
// 旅行商人 Traveling Merchant      SW_307 
// 魔法乌鸦 Enchanted Raven      CORE_KAR_300
// 迷梦幼龙  YOP_025 
// 大导师野爪 Shan'do Wildclaw ID：SCH_607 
// 荆棘护卫 Thorngrowth Sentries ID：BAR_533 
// # 
// AAECAbSKAwSSzQPG0QOm4QPE+QMN174Dm84DudIDjOQD9+gDuewDku4DiPQDyfUD7PUD0fYDgfcDhPcDAA==
// # 
// # 想要使用这副套牌，请先复制到剪贴板，然后在游戏中点击“新套牌”进行粘贴。
// ### 野兽德
// # 职业：德鲁伊
// # 模式：标准模式
// # 狮鹫年
// #
// # 2x (1) 萌物来袭
// # 2x (1) 自然研习
// # 2x (1) 活泼的松鼠
// # 2x (1) 暗礁德鲁伊 DED_001
// # 2x (1) 播种施肥
// # 1x (2) 野性之力
// # 2x (2) 荆棘护卫
// # 2x (2) 月光指引
// # 2x (2) 应急木工
// # 2x (2) 堆肥
// # 2x (3) 霜狼巢屋
// # 2x (3) 艾露恩神谕者
// # 1x (4) 空军指挥官穆维里克 AV_293
// # 2x (5) 树木生长
// # 2x (7) 霜刃豹头领 AV_291
// # 2x (7) 幽影猫头鹰 DMF_060
// #
// AAECAZICAtmfBJSlBA6bzgO50gOV4AOM5AOt7APJ9QPs9QOB9wOE9wOsgASvgASwgATnpAS4vgQA
// # 想要使用这副套牌，请先复制到剪贴板，再在游戏中创建新套牌。
// # 套牌详情请查看https://hsreplay.net/decks/KSMoUD7PB3K1s5vVkqRxGd/

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
                 if((card==Card.Cards.SW_419//艾露恩神谕者 Oracle of Elune      SW_419 
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.SW_419))
                    {
                        Keep(card,"艾露恩神谕者");
                    }
                    }   
                }
                 if((card==Card.Cards.SCH_333//自然研习 Nature Studies      SCH_333  
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.SCH_333))
                    {
                        Keep(card,"自然研习");
                    }
                    }   
                }
                 if((card==Card.Cards.SCH_617//萌物来袭 Adorable Infestation      SCH_617  
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.SCH_617))
                    {
                        Keep(card,"萌物来袭");
                    }
                    }   
                }
                 if((card==Card.Cards.BAR_533//荆棘护卫 Thorngrowth Sentries ID：BAR_533 
                )){
                    {
                        Keep(card,"荆棘护卫");
                    }   
                }
                 if((card==Card.Cards.AV_219//群羊指挥官 Ram Commander ID：AV_219
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.AV_219))
                    {
                        Keep(card,"群羊指挥官");
                    }
                    }   
                }
                 if((card==Card.Cards.AV_360//霜狼巢屋 Frostwolf Kennels ID：AV_360 
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.AV_360))
                    {
                        Keep(card,"霜狼巢屋");
                    }
                    }   
                }
                 if((card==Card.Cards.DED_003//应急木工 Jerry Rig Carpenter ID：DED_003 
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.DED_003))
                    {
                        Keep(card,"应急木工");
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
                        Keep(card,"活泼的松鼠");
                }
                  if(card==Card.Cards.DED_001//活泼的松鼠 Vibrant Squirrel      SW_439 
                )
                {
                        Keep(card,"暗礁德鲁");
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
                        Keep(card,"农夫");
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