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
// # 2x (1) 暗礁德鲁伊
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

// ### 跳费德
// # 职业：德鲁伊
// # 模式：标准模式
// # 狮鹫年
// #
// # 2x (0) 雷霆绽放 SCH_427
// # 2x (0) 激活
// # 2x (1) 随心口袋
// # 2x (1) 自然研习 SCH_333
// # 1x (2) 铁木树皮
// # 2x (2) 猜重量 DMF_075 
// # 2x (2) 月蚀
// # 2x (2) 月光指引
// # 2x (2) 日蚀
// # 2x (3) 野性成长 CORE_CS2_013
// # 1x (3) 沼泽射线
// # 2x (4) 过度生长 BT_130
// # 1x (5) 野性之心古夫 AV_205 
// # 2x (7) 奥妮克希亚鳞片
// # 2x (8) 塞纳里奥结界
// # 1x (8) 卡扎库杉
// # 1x (9) 织法者玛里苟斯 CS3_034 
// # 1x (10) 团本首领奥妮克希亚
// #
// AAECAZICBuy6A+66A7WKBImLBKWtBISwBAzougObzgPw1AOJ4AOK4AOk4QPR4QOP5AOvgASJnwSunwTPrAQA
// # 想要使用这副套牌，请先复制到剪贴板，再在游戏中创建新套牌。
// # 套牌详情请查看https://hsreplay.net/decks/YOOT57qNGAaf6wj43xkgbh/
// ### 法术德
// # 职业：德鲁伊
// # 模式：标准模式
// # 狮鹫年
// #
// # 2x (0) 雷霆绽放
// # 2x (0) 激活
// # 2x (1) 随心口袋
// # 2x (1) 自然研习
// # 2x (2) 月蚀
// # 2x (2) 月光指引
// # 2x (2) 日蚀
// # 1x (2) 占领冷齿矿洞 AV_295
// # 2x (3) 真菌宝藏 BT_128
// # 2x (3) 月触项链
// # 2x (4) 过度生长
// # 1x (5) 野性之心古夫
// # 2x (5) 萤火成群
// # 2x (5) 树木生长
// # 2x (7) 奥妮克希亚鳞片
// # 1x (8) 塞纳里奥结界
// # 1x (8) 卡扎库杉
// #
// AAECAZICBKThA4mLBLClBISwBA3lugPougPvugObzgPw1AOJ4AOK4AOi4QOM5AOP5AOvgASunwTPrAQA
// # 想要使用这副套牌，请先复制到剪贴板，再在游戏中创建新套牌。
// # 套牌详情请查看https://hsreplay.net/decks/m8tbPIMDkRFjGswg2V2MUd/

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
                 if((card==Card.Cards.SCH_427//雷霆绽放 SCH_427
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.SCH_427)&&!CardsToKeep.Contains(Card.Cards.SCH_427))//野性之心古夫 AV_205
                    {
                        Keep(card,"雷霆绽放");
                    }
                    }   
                }
                 if((card==Card.Cards.AV_295//占领冷齿矿洞 AV_295
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.AV_295))
                    {
                        Keep(card,"占领冷齿矿洞");
                    }
                    }   
                }
                 if((card==Card.Cards.BT_128//真菌宝藏 BT_128
                )){
                    {  
                        Keep(card,"真菌宝藏");
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
                 if((card==Card.Cards.DMF_075//猜重量 DMF_075 
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.DMF_075))
                    {
                        Keep(card,"猜重量");
                    }
                    }   
                }
                 if((card==Card.Cards.CORE_CS2_013//野性成长 CORE_CS2_013
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.CORE_CS2_013))
                    {
                        Keep(card,"野性成长");
                    }
                    }   
                }
                 if((card==Card.Cards.BT_130//过度生长 BT_130
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.BT_130))
                    {
                        Keep(card,"过度生长");
                    }
                    }   
                }
                 if((card==Card.Cards.AV_205//野性之心古夫 AV_205 
                )){
                    {
                       if(!CardsToKeep.Contains(Card.Cards.AV_205))
                    {
                        Keep(card,"野性之心古夫");
                    }
                    }   
                }
                
                if(card==Card.Cards.SCH_427&&flag1+flag2>0//雷霆绽放 Lightning Bloom      SCH_427
                )
                {
                    if(!CardsToKeep.Contains(Card.Cards.SCH_427))
                    {
                        Keep(card,"雷霆绽放 ");
                    }   
                }
               
				
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