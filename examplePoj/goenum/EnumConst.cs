namespace game.data.autogen
{
	static class EnumConst{
		public static int DATA_LEN_EXTERN= 2;//程序用
		public static int ERR_CODE_SUC= 0;//程序用
		public static int FORCE_CLOSE= 60;//程序用
		public static int PROTO_PREFIX_LEN= 10;//程序用
		public static int PHPURL_TEST= 0;//程序用
		public static int DEFAULT_CITY_ID= 1;//新玩家进入游戏所拥有的城市id
		public static int DEFAULT_CITY_SKIN_ID= 1;//玩家新获得城市的皮肤id
		public static int DEFAULT_CITY_MAP_ID= 1;//新玩家进入游戏所在的地图id
		public static int BATTLE_FIGHTER_COUNT= 6;//战斗中英雄总数
		public static int BATTLE_POS_ATTACKER_HEAD= 1;//进攻方位置前锋
		public static int BATTLE_POS_ATTACKER_MID= 2;//进攻方位置中坚
		public static int BATTLE_POS_ATTACKER_TAIL= 3;//进攻方位置后卫
		public static int BATTLE_POS_DEFENCER_HEAD= 11;//防守方位置前锋
		public static int BATTLE_POS_DEFENCER_MID= 12;//防守方位置中坚
		public static int BATTLE_POS_DEFENCER_TAIL= 13;//防守方位置后卫
		public static int BATTLE_POS_DEFENCER_CITY= 20;//防守方城池位置
		public static int HERO_BUY_STATUS= 1;//新得到的武将他的状态
		public static int HERO_DEFAULT_CITY_ID= 1;//新得到的武将默认在的城市id
		public static int BATTLE_EVENT_TYPE_DEAD= 1;//战斗事件：武将挂了
		public static int BATTLE_EVENT_TYPE_DESTROY= 2;//战斗事件：城破了
		public static int HERO_ATTR_IDX_ATT= 0;//武将攻击属性
		public static int HERO_ATTR_IDX_DEF= 1;//武将防守属性
		public static int HERO_ATTR_IDX_STR= 2;//武将谋略属性
		public static int HERO_ATTR_IDX_SIE= 3;//武将攻城属性
		public static int HERO_ATTR_IDX_SPE= 4;//武将速度属性
		public static int HERO_ATTR_IDX_CRI= 5;//武将爆击属性
		public static int HERO_ATTR_IDX_MAX_TROOPS= 6;//武将最大血量属性
		public static int HERO_ATTR_IDX_SUB_DEF= 7;//武将属性破甲率
		public static int HERO_ATTR_IDX_GNORE_HURT_RATE= 8;//武将属性格档
		public static int HERO_ATTR_IDX_DEC_HURT= 9;//武将属性减伤率
		public static int HERO_ATTR_IDX_DODGE= 10;//武将属性闪避率
		public static int HERO_ATTR_IDX_MAX= 11;//武将属性的最大值
		public static int SKILL_CLASS_AUTO= 1;//技能释放类型：被动 (一进入战场就会释放的技能）
		public static int SKILL_CLASS_RATE= 0;//技能释放类型：主动
		public static int SKILL_TYPE_NORMAL_ATK_HERO= 1;//技能类型：普攻打英雄
		public static int SKILL_TYPE_STR_ATK_HERO= 2;//技能类型：谋攻打英雄
		public static int SKILL_TYPE_NORMAL_ATK_CITY= 3;//技能类型：普攻打城
		public static int SKILL_TYPE_STR_ATK_CITY= 4;//技能类型：谋攻打城
		public static int RANDOM_MAX= 1000;//随机数的最大值（即千分比）
		public static int ARMY_POS_HEAD= 1;//队伍位置前锋
		public static int ARMY_POS_MID= 2;//队伍位置中坚
		public static int ARMY_POS_TAIL= 3;//队伍位置后卫(默认会开的）
		public static int HERO_STATUS_FIGHT_OFFSET= 1;//武将状态:行军打仗中 (处理事件也是这个）
		public static int HERO_STATUS_INJURY_OFFSET= 2;//武将状态：重伤
		public static int HERO_STATUS_ADDTROOPS_OFFSET= 4;//武将状态：征兵中
		public static int HERO_STATUS_TRAIN_OFFSET= 8;//武将状态：训练中
		public static int HERO_STATUS_DEFENCE_OFFSET= 16;//武将状态：驻守中  
		public static int MAP_CITY_STATUS_NORMAL= 1;//他人城池状态：正常
		public static int MAP_CITY_STATUS_DESTROY= 2;//他人城池状态：被打爆
		public static int BATTLE_RESULT_WIN= 1;//攻打城池结果：胜利
		public static int BATTLE_RESULT_DEFEAT= 2;//攻打城池结果：失败
		public static int BATTLE_RESULT_DESTROY= 3;//攻打城池结果：摧毁
		public static int NEIGHBOUR_ATTRIBUTE_PLAYER= 0;//真实用户
		public static int NEIGHBOUR_ATTRIBUTE_NPC= 1;//npc
		public static int TOTAL_NEIGHBOR= 3;//邻居的数量
		public static int SPEC_RESCOURCE_DIAMOND= 0;//钻石ID(资源)
		public static int SPEC_RESCOURCE_COIN= 1;//金币ID(资源)
		public static int SPEC_RESCOURCE_WOOD= 2;//木材ID(资源)
		public static int SPEC_RESCOURCE_MINERAL= 3;//黄金ID(资源)
		public static int SPEC_RESCOURCE_GRAIN= 4;//粮草ID(资源)
		public static int SPEC_RESCOURCE_CHIP= 5;//碎片ID(资源)
		public static int SPEC_RESCOURCE_NUM= 6;//资源种类数量
		public static int NEW_BORN_TROOPS= 100;//新弄出来的武将的血量
		public static int BATTLE_QUEUE_MAX= 3;//军队中武将的数量
		public static int SIGN_TYPE_WEEK= 1;//周签到（签到）
		public static int SIGN_TYPE_MONTH= 2;//月签到（签到）
		public static int ARMY_SPEED_PER_SECOND= 80;//军队行军时每秒的速度
		public static int CONF_DEFAULT_SKIN= 0;//默认皮肤颜色(皮肤)
		public static int ARMY_TYPE_ARCHER= 1;//弓兵
		public static int ARMY_TYPE_SPEAR= 2;//枪兵
		public static int ARMY_TYPE_CAVALRY= 3;//骑兵
		public static int NEW_BORN_PLAYER_COIN= 2000;//新玩家初始金币
		public static int NEW_BORN_PLAYER_DIAMOND= 20;//新玩家初始钻石
		public static int NEW_BORN_PLAYER_WOOD= 250000;//新玩家初始木材
		public static int NEW_BORN_PLAYER_MINERAL= 250000;//新玩家初始金矿
		public static int NEW_BORN_PLAYER_CHIP= 300;//新玩家初始碎片
		public static int NEW_BORN_PLAYER_GRAIN= 50000;//新玩家初始粮草
		public static int NEW_BORN_PLAYER_HERO_ID= 1001;//新玩家初始给的武将id
		public static int NEW_BORN_PLAYER_LEVEL= 1;//新玩家初始等级
		public static int BATTLE_RESULT_IDX_MAX= 15;//玩家能查看的战绩为15条
		public static int BATTLE_DEF_RESULT_IDX_MAX= 15;//玩家能查看的防守战绩为15条
		public static int RANK_SCORE_PVE_WIN= 10;//玩家打npc获胜得到的积分
		public static int RANK_SCORE_PVE_DESTROY= 50;//玩家打npc摧毁城池得到的积分
		public static int RANK_SCORE_PVE_FAIL= 5;//玩家打npc失败得减的的积分
		public static int RANK_SCORE_PVP_WIN= 10;//玩家打玩家获胜得到的积分
		public static int RANK_SCORE_PVP_DESTROY= 60;//玩家打玩家摧毁城池得到的积分
		public static int RANK_SCORE_PVP_FAIL= 5;//玩家打玩家失败得到的积分
		public static int RANK_SCORE_INIT= 100;//玩家初始积分
		public static int CAMP_TYPE_WEI= 3;//魏
		public static int CAMP_TYPE_SU= 2;//蜀
		public static int CAMP_TYPE_WU= 1;//吴
		public static int CAMP_TYPE_QUN= 4;//群
		public static int ARMY_RECURIT_CD_SECONDS= 600;//加兵力冷却时间
		public static int BATTLE_WIN_ADD_HERO_EXP= 950;//战斗胜了加的经验
		public static int BATTLE_DEFEAT_ADD_HERO_EXP= 950;//战斗输了加的经验
		public static int EMAIL_DEL_STATUS_DEL= 1;//邮件是已经删除状态
		public static int EMAIL_DEL_STATUS_UN_DEL= 0;//邮件未删除
		public static int EMAIL_READ_STATUS_UNREAD= 0;//邮件未读取
		public static int EMAIL_READ_STATUS_READ= 1;//邮件已读取
		public static int EMAIL_GIFT_STATUS_UNDRAW= 0;//邮件未领取附件
		public static int EMAIL_GIFT_STATUS_DRAW= 1;//邮件已领取附件
		public static int ATTACK_CITY_HERO_VITALITY= 100;//攻击时需要武将体力
		public static int HERO_VITALITY_MAX= 100;//武将体力上限值
		public static double ADD_VITALITY_CD_SECOND= 0.33;//每回复一点体力需要多少秒
		public static int HERO_RECRUIT_TYPE_COIN_1_TIMES= 1;//用银币抽卡1次
		public static int HERO_RECRUIT_TYPE_COIN_10_TIMES= 2;//用银币抽卡10次
		public static int HERO_RECRUIT_TYPE_DIAMOND_1_TIMES= 3;//用金币抽卡1次
		public static int HERO_RECRUIT_TYPE_DIAMOND_10_TIMES= 4;//用金币抽卡10次
		public static int HERO_RECRUIT_SPEC_TIMES= 5;//逢5会有特殊抽奖
		public static int HERO_RECRUIT_TENTH_POOL_ID= 2;//逢10会有特殊抽奖
		public static int HERO_RECRUIT_SPEC_STAR= 5;//抽到5星卡会有次数累计的变化
		public static long RANK_SEASON_DAYS= 14;//每个赛季的天数
		public static int HERO_RECRUIT_FREE_CD= 86400;//免费抽奖的cd
		public static int BUILD_TYPE_MAIN= 15;//建筑类型：主城
		public static int BUILD_TYPE_FARM= 2;//建筑类型：农田
		public static int BUILD_TYPE_WOOD= 3;//建筑类型：树木
		public static int BUILD_TYPE_MINE= 4;//建筑类型：矿山
		public static int BUILD_TYPE_GOLD= 5;//建筑类型：金矿
		public static int BUILD_UNLOCK_TYPE_MAIN_BUILD_LV= 1;//解锁条件：主城达到xx级
		public static int BUILD_UNLOCK_TYPE_PLAYER_LV= 2;//解锁条件：玩家达到xx级
		public static int RES_SPEED_TIMER= 60;//建筑物增加资源的时间单位（秒）即60秒加一次配置配的那个资源生产速度
		public static int ARMY_NUM_MAX_IN_CITY= 5;//一个城市能放的最大军队数
		public static int ROUND_MAX= 50;//战斗中最大回合数
		public static int HERO_BUFF_TYPE_ATR_MODIFY= 1;//buff类型：引起属性变化的类型
		public static int HERO_BUFF_TYPE_ATK_ADD_TROOPS= 2;//buff类型：攻心
		public static int HERO_BUFF_TYPE_SKIP_SKILL= 3;//buff类型：怯战
		public static int HERO_BUFF_TYPE_SKIP_NORMAL_ATTACK= 4;//buff类型：非攻
		public static int HERO_BUFF_TYPE_SKIP_BOTH= 5;//buff类型：混乱
		public static int HERO_BUFF_TYPE_CRAZY= 6;//buff类型：暴走
		public static int HERO_BUFF_TYPE_REDICULE= 7;//buff类型：挑衅
		public static int HERO_BUFF_TYPE_ATTACK_AGAIN= 8;//buff类型：破竹
		public static int HERO_BUFF_TYPE_INSIGHT= 9;//buff类型：洞察
		public static int HERO_BUFF_TYPE_REST= 10;//buff类型：休整
		public static int HERO_BUFF_TYPE_ADD_TROOP= 11;//buff类型：自动回血buff
		public static int HERO_BUFF_TYPE_SUB_TROOP= 12;//buff类型：自动扣血buff
		public static int SKILL_EFF_TYPE_HURT= 1;//技能类型：伤害
		public static int SKILL_EFF_TYPE_CLEAR_BUFF= 2;//技能类型：清空buff
		public static int SKILL_EFF_TYPE_ADD_BUFF= 3;//技能类型：增加buff
		public static int ACTION_TYPE_BLEED_CHANGE= 1;//某个位置他的血量改变了
		public static int ACTION_TYPE_BUFF= 2;//某个位置他的buff改变了
		public static int BUILD_STATUS_LOCK= 0;//建筑物还没解锁
		public static int BUILD_STATUS_UNLOCK= 1;//建筑物已解锁
		public static int ACCELERATE_PERIOD= 180;//用元宝加速的时间长度
		public static int ACCELERATE_PRICE= 1;//每个时间段加速用多少RMB
		public static int SKILL_STAGE_BEFORE_BATTLE= 1;//为战前预备阶段（被动技能）
		public static int SKILL_STAGE_ENTER_BATTLE= 2;//为战前指挥阶段（指挥技能）
		public static int SKILL_STAGE_IN_BATTLE= 3;//为战斗阶段（战斗技能）
		public static int SKILL_TARGET_TYPE_SELF= 1;//自己
		public static int SKILL_TARGET_TYPE_TEAMER= 2;//队友
		public static int SKILL_TARGET_TYPE_ENIMY= 3;//敌方
		public static int SKILL_AREA_SINGLE= 1;//单体
		public static int SKILL_AREA_ALL= 2;//全体
		public static int SKILL_AREA_ROW= 3;//一行
		public static int SKILL_CHOOSETARGET_RANDOM= 1;//随机选目标
		public static int SKILL_CHOOSETARGET_BLOOD= 2;//血量最少
		public static int SKILL_CHOOSETARGET_NEAR= 3;//最近的目标
		public static int SKILL_CHOOSETARGET_FAR= 4;//最远的目标
		public static int SKILL_CMD_SELECT_TARGET= 1;//技能指令：选择目标 参数1为目标，参数2为范围，
		public static int SKILL_CMD_ADD_PASSIVE= 2;//技能指令：加被动（是在战前预备阶段）参数1为buffId
		public static int SKILL_CMD_ADD_BUFF= 3;//技能指令：加buff 参数1为buffId
		public static int SKILL_CMD_SKILL_HERO_DAMG= 4;//技能指令: 给武将技能伤害 参数1为公式  参数2为skillDamg
		public static int SKILL_CMD_SKILL_CITY_DAMG= 5;//技能指令: 给城墙技能伤害 参数1为公式  参数2为skillDamg
		public static int SKILL_BUFF_MAX_TIMES= 3;//破竹，攻击的最大数次
		public static int SKILL_BUFF_STYLE_BAD= 1;//减益buff
		public static int SKILL_BUFF_STYLE_GOOD= 2;//增益buff
		public static int INNER_BUILD_ATTR_COIN= 1;//征收金币具体值
		public static int INNER_BUILD_ATTR_WOOD_LIMIT= 2;//木材存储上限具体值
		public static int INNER_BUILD_ATTR_GRAIN_LIMIT= 3;//粮草存储上限具体值
		public static int INNER_BUILD_ATTR_MINERAL_LIMIT= 4;//矿石存储上限具体值
		public static int INNER_BUILD_ATTR_WOOD_SPEED_INC= 5;//木材生产速度千分比
		public static int INNER_BUILD_ATTR_WOOD_CAPICITY= 6;//木材容量具体值
		public static int INNER_BUILD_ATTR_GRAIN_SPEED_INC= 7;//粮草生产速度千分比
		public static int INNER_BUILD_ATTR_GRAIN_CAPICITY= 8;//粮草容量具体值
		public static int INNER_BUILD_ATTR_MINERAL_SPEED_INC= 9;//矿石生产速度千分比
		public static int INNER_BUILD_ATTR_MINERAL_CAPICITY= 10;//矿石容量具体值
		public static int INNER_BUILD_ATTR_TRAIN_HERO_EXP= 11;//训练武将加经验具体值
		public static int INNER_BUILD_ATTR_TRAIN_HERO_TIME_DEC= 12;//训练时间减少千分比
		public static int INNER_BUILD_ATTR_HERO_RECOVER_TIME_DEC= 13;//重伤恢复时间减少千分比
		public static int INNER_BUILD_ATTR_RECRUIT_TIME_DEC= 14;//征兵时间减少千分比
		public static int INNER_BUILD_ATTR_RECRUIT_RES_DEC= 15;//征兵消耗减少千分比
		public static int INNER_BUILD_ATTR_TEAM_MEMBERS= 16;//配置武将数量具体值
		public static int INNER_BUILD_ATTR_DURABLITY= 17;//耐久具体值
		public static int INNER_BUILD_ATTR_TROOPS= 18;//兵力具体值
		public static int INNER_BUILD_ATTR_ATTACK= 19;//攻击具体值
		public static int INNER_BUILD_ATTR_DEFENCE= 20;//防御具体值
		public static int INNER_BUILD_ATTR_STR= 21;//谋略具体值
		public static int INNER_BUILD_ATTR_ADD_CITY_HURT= 22;//攻城具体值
		public static int INNER_BUILD_ATTR_SPEED= 23;//速度具体值
		public static int INNER_BUILD_ATTR_CRI= 24;//暴击具体值
		public static int INNER_BUILD_ATTR_INC_DURABLITY= 25;//耐久增加程度具体值
		public static int INNER_BUILD_ATTR_INC_TROOPS= 26;//兵力增加程度具体值
		public static int INNER_BUILD_ATTR_INC_ATTACK= 27;//攻击增加程度具体值
		public static int INNER_BUILD_ATTR_INC_DEFENCE= 28;//防御增加程度具体值
		public static int INNER_BUILD_ATTR_INC_STR= 29;//谋略增加程度具体值
		public static int INNER_BUILD_ATTR_INC_ADD_CITY_HURT= 30;//攻城增加程度具体值
		public static int INNER_BUILD_ATTR_INC_SPEED= 31;//速度增加程度具体值
		public static int INNER_BUILD_ATTR_INC_CRI= 32;//暴击增加程度具体值
		public static int INNER_BUILD_ATTR_WOOD_ROB_INC= 33;//木材额外抢夺量千分比
		public static int INNER_BUILD_ATTR_GRAIN_ROB_INC= 34;//粮草额外抢夺量千分比
		public static int INNER_BUILD_ATTR_MINERAL_ROB_INC= 35;//矿石额外抢夺量千分比
		public static int INNER_BUILD_ATTR_WOOD_PROTECT_INC= 36;//木材保护量千分比
		public static int INNER_BUILD_ATTR_GRAIN_PROTECT_INC= 37;//粮草保护量千分比
		public static int INNER_BUILD_ATTR_MINERAL_PROTECT_INC= 38;//矿石保护量千分比
		public static int INNER_BUILD_ATTR_WOOD_LEVEL_LIMIT= 39;//木材等级上限具体值
		public static int INNER_BUILD_ATTR_GRAIN_LEVEL_LIMIT= 40;//粮草等级上限具体值
		public static int INNER_BUILD_ATTR_MINERAL_LEVEL_LIMIT= 41;//矿石等级上限具体值
		public static int INNER_BUILD_ATTR_TEAMS= 42;//最大队伍数
		public static int INNER_BUILD_ATTR_OUT_BUILD_NUMS= 43;//非内政建筑的最大拥有数
		public static int INNER_BUILD_ATTR_GOLD_SPEED_INC= 44;//金币每小时生产速度
		public static int INNER_BUILD_ATTR_GOLD_CAPICITY= 45;//金币容量具体值
		public static int INNER_BUILD_ATTR_GOLD_LEVEL_LIMIT= 46;//矿石等级上限具体值
		public static int INNER_BUILD_ATTR_MAX= 47;//所有属性的最大值
		public static int INNER_BUILD_BASE_COIN= 2500;//征收金币数=2500+X
		public static int INNER_BUILD_BASE_WOOD_LIMIT= 970000;//木材存储上限=5000+X
		public static int INNER_BUILD_BASE_GRAIN_LIMIT= 970000;//粮草存储上限=5000+X
		public static int INNER_BUILD_BASE_MINERAL_LIMIT= 970000;//矿石存储上限=5000+X
		public static int INNER_BUILD_FACTOR_TRAIN_HERO_TIME= 10;//训练的时间=10*部队武将等级之和*(1-训练减少)分钟
		public static int INNER_BUILD_BASE_TRAIN_HERO_TIME= 60;//训练的时间=10*部队武将等级之和*(1-训练减少)分钟
		public static int INNER_BUILD_FACTOR_HERO_RECOVER_TIME= 3;//最终重伤恢复时间=等级*3*(1-重伤恢复时间减少)分钟
		public static int INNER_BUILD_BASE_HERO_RECOVER_TIME= 60;//最终重伤恢复时间=等级*3*(1-重伤恢复时间减少)分钟
		public static int INNER_BUILD_BASE_RECRUIT_TIME= 1;//单个征兵所需时间=1s*(1-X)
		public static int INNER_BUILD_BASE_TODO_NOT_KNOW= 0;//不知道
		public static int INNER_BUILD_BASE_WOOD_LEVEL_LIMIT= 15;//伐木场可升级上限
		public static int INNER_BUILD_BASE_GRAIN_LEVEL_LIMIT= 15;//农田可升级上限
		public static int INNER_BUILD_BASE_MINERAL_LEVEL_LIMIT= 15;//矿场可升级上限
		public static int INNER_BUILD_BASE_GOLD_LEVEL_LIMIT= 15;//矿场可升级上限
		public static int INNER_BUILD_BASE_OUT_BUILD_NUMS= 6;//非内政建筑的最大拥有数  6+x
		public static int INNER_BUILD_ROB_FACTOR= 500;//最终可被抢矿石数量=t.矿石总量*(0.5-(t.矿石保护量-a.矿石额外抢夺量)) 中的0.5
		public static int BUILD_TYPE_INNER_MIN= 1;//内政建筑起始id
		public static int BUILD_TYPE_INNER_NEIWUFU= 1;//内务府
		public static int BUILD_TYPE_INNER_DOULIASI= 2;//都料司
		public static int BUILD_TYPE_INNER_LIANGCANG= 3;//粮仓
		public static int BUILD_TYPE_INNER_YINGZAOFU= 4;//营造府
		public static int BUILD_TYPE_INNER_FAMUCHANG= 5;//伐木场
		public static int BUILD_TYPE_INNER_NONGTIAN= 6;//农田
		public static int BUILD_TYPE_INNER_KUANGCHANG= 7;//矿场
		public static int BUILD_TYPE_INNER_XUNLIANCHANG= 8;//训练场
		public static int BUILD_TYPE_INNER_DIANJIANGTAI= 9;//点将台
		public static int BUILD_TYPE_INNER_YILIAOGUANG= 10;//医疗馆
		public static int BUILD_TYPE_INNER_MUBINGSUO= 11;//募兵所
		public static int BUILD_TYPE_INNER_JILUEFU= 12;//计略府
		public static int BUILD_TYPE_INNER_XIAOCHANG= 13;//校场
		public static int BUILD_TYPE_INNER_TONGSHUAITING= 14;//统帅厅
		public static int BUILD_TYPE_INNER_CHENGZHUFU= 15;//城主府
		public static int BUILD_TYPE_INNER_BINGYING= 16;//兵营
		public static int BUILD_TYPE_INNER_SHANGWUYING= 17;//尚武营
		public static int BUILD_TYPE_INNER_TIEBIYING= 18;//铁臂营
		public static int BUILD_TYPE_INNER_JUNJIYING= 19;//军机营
		public static int BUILD_TYPE_INNER_ZIZHONGYING= 20;//辎重营
		public static int BUILD_TYPE_INNER_JIFENGYING= 21;//疾风营
		public static int BUILD_TYPE_INNER_GONGBINGYING= 22;//工兵营
		public static int BUILD_TYPE_INNER_NEICHENGQIANG= 23;//内城墙
		public static int BUILD_TYPE_INNER_WAICHENGQIANG= 24;//外城墙
		public static int BUILD_TYPE_INNER_BINGYIFU= 25;//兵役府
		public static int BUILD_TYPE_INNER_WUSHENXIANG= 26;//武神像
		public static int BUILD_TYPE_INNER_HUWEIYING= 27;//护卫营
		public static int BUILD_TYPE_INNER_XUEWENFU= 28;//学问府
		public static int BUILD_TYPE_INNER_GONGCHENGYING= 29;//攻城营
		public static int BUILD_TYPE_INNER_MAJIU= 30;//马厩
		public static int BUILD_TYPE_INNER_BACHANG= 31;//靶场
		public static int BUILD_TYPE_INNER_NEISHIFU= 32;//内史府
		public static int BUILD_TYPE_INNER_ZHISUFU= 33;//治粟府
		public static int BUILD_TYPE_INNER_QIXIESUO= 34;//奇械所
		public static int BUILD_TYPE_INNER_FENGHUOTAI= 35;//烽火台
		public static int BUILD_TYPE_INNER_TUNTIANSUO= 36;//屯田所
		public static int BUILD_TYPE_INNER_SHAOSFU= 37;//少府
		public static int BUILD_TYPE_INNER_MAX= 38;//内政建筑结束id(不包含）
		public static int ARMY_MUL_FACTOR= 100;//军队id=cityId*100+xxx(从1开始）
		public static int MAIN_BUILD_INIT_BUILD_ID= 1001;//主城初始化建筑id
		public static int MAIN_BUILD_IDX= 10015;//主城idx
		public static int SHOP_TYPE_TIMES_DAY_LIMIT= 1;//一天能买多少次
		public static int SHOP_TYPE_NORMAL= 0;//普通
		public static int HISTORY_BOOK_ITEM_ID= 1101;//史书itemid
		public static int FIGHT_TOKEN_ITEM_ID= 1102;//战令itemid
		public static int LOC_PLAYER_INFO= 1;//这种资源在玩家身上（钻石,金币,木材,矿石，粮草，碎片）
		public static int LOC_FIGHT_TIMES_ITEM= 2;//史书与战令填2
		public static int LOC_HERO_DIRECT= 3;//武将
		public static int LOC_SPEC_HERO_CHIP= 4;//武将专属碎片
		public static int LOC_HERO_RECRUIT= 5;//走招募流程
		public static int HERO_RECURIT_TIMES_EVENT_TYPE= 1;//招多少次的限制
		public static int HERO_RECURIT_TIMELEN_EVENT_TYPE= 2;//招多少时间长度的限制
		public static int HISTORY_BOOK_INIT= 10;//史书的初始值
		public static int FIGHT_TOKEN_INIT= 10;//战令的初始值
		public static int HISTORY_BOOK_MAX= 50;//史书的最大值
		public static int FIGHT_TOKEN_MAX= 10;//战令的最大值
		public static int HISTORY_BOOK_TIME_INTERVAL= 1800;//史书回复的间隔时长
		public static int FIGHT_TOKEN_TIME_INTERVAL= 1800;//战令回复的间隔时长
		public static int HISTORY_BOOK_EACHTIME= 1;//剧情模式每次消耗的史书数
		public static int FIGHT_TOKEN_EACHTIME= 1;//PK模式每次消耗的战令数
		public static int BOAT_ARROW_MAX= 20;//最多20支箭
		public static int BOAT_ARROW_DAILY_INIT= 5;//每天初始化5支箭
		public static int BOAT_ARROW_INIT= 5;//新玩家初始20支箭
		public static int BOAT_SHARE_MAX_TIMES= 3;//每天最多分享10次
		public static int BOAT_SHARE_GAIN_ARROW= 10;//每次分享获利支箭
		public static int ITEM_TYPE_PLAYER_INFO= 1;//这种资源在玩家身上（钻石,金币,木材,矿石，粮草，碎片）
		public static int ITEM_TYPE_FIGHT_TIMES_ITEM= 2;//史书与战令填2
		public static int ITEM_TYPE_HERO_DIRECT= 3;//武将
		public static int ITEM_TYPE_SPEC_HERO_CHIP= 4;//武将专属碎片
		public static int ITEM_TYPE_HERO_RECRUIT= 5;//走招募流程
		public static int ITEM_TYPE_HERO_EXP= 6;//武将经验
		public static int ITEM_TYPE_DAILY_TASK_STAR= 7;//每日任务里的星星
		public static int ITEM_TYPE_EVENT= 8;//会产生一个事件 (spec_id 填 cfg_event里的id
		public static int SPEC_RESCOURCE_HISTORY_BOOK_TIMES= 101;//史书购买次数给玩家的推送的值
		public static int SPEC_RESCOURCE_FIGHT_TOKEN_TIMES= 102;//战令购买次数给玩家的推送的值
		public static int PVE_LEVEL_START_LEVEL_ID= 1;//玩家一进去就能打的关卡
		public static int MAP_REFRESH_TIME_INTERVAL= 45;//玩家允许刷新的时间间隔
		public static int TASK_FINISH_TYPE_RES_SPEED= 1;//1为某资源产出速度达到一定速度，
		public static int TASK_FINISH_TYPE_BUILD_LEVEL= 2;//2为某建筑达到一定等级，
		public static int TASK_FINISH_TYPE_HERO_LV= 3;//3为任一武将达到一定等级，
		public static int TASK_FINISH_TYPE_FIGHT_NUM_LEVEL= 4;//4为任一战法达到一定等级，
		public static int TASK_FINISH_TYPE_NLEVEL_BUILD_COUNT= 5;//5为某等级以上资源地数量达到一定数量，
		public static int TASK_FINISH_TYPE_RANDOM_EVENT_TIMES= 6;//6为随机事件完成件数
		public static int TASK_FINISH_TYPE_PVE_LEVEL= 7;//7为演武场剧情模式某关卡通关，
		public static int TASK_FINISH_TYPE_NSTAR_HERO_COUNT= 8;//8为所拥有X星及X星以上武将达到一定数量，
		public static int TASK_FINISH_TYPE_CAMP_ROB_TIMES= 9;//9为使用某势力组成的部队成功掠夺玩家达到一定次数
		public static int TASK_FINISH_TYPE_DEFENCE_TIMES= 10;//10为成功抵御其他玩家的掠夺达到一定次数
		public static int TASK_FINISH_TYPE_ARCHERY_TIMES= 11;//11为射箭次数到达一定次数
		public static int TASK_REPLACE_DEFAULT= 1;//任务默认替换显示格式
		public static int TASK_REPLACE_LEFT= 3;//类型在前,数量在后（s%级以上资源地达到s%块）
		public static int TASK_REPLACE_RIGHT= 2;//数量在前,类型在后（超过s%个武将达到s%星级）
		public static int TASK_STYLE_TRUNK= 2;//2为发展任务
		public static int TASK_STYLE_DAILY= 1;//每日任务，
		public static int DAILY_TASK_STAR_MAX= 100;//每日任务完成得到的星奖励超过这个值时，能领一个星星礼包
		public static int HEOR_COMMENT_PAGE_COUNT= 10;//每一页最多10个
		public static int HEOR_COMMENT_COUNT_MAX= 100;//最多100条评论
		public static double TRAIN_BUILDING_IDX= 1.1;//训练的idx
		public static double DEFENCE_BUILDING_IDX= 1.5;//训练的idx
		public static int BUILD_EVENT_GEN_TIME= 10800;//当一个建筑物事件已经超时或者完成后，它再次生成的时间
		public static int BUILD_EVENT_PROTECT_GEN_TIME= 60;//上一个值的保险作用的值
		public static int NPC_SKILL_LEVEL= 10;//pve等等都是最高等级
		public static int HERO_SKILL_LEVEL_MAX= 10;//技能等级只能到10级
		public static int HERO_TROOPS_INIT= 100;//新得到的武将兵力
		public static int EVENT_TYPE_RECRUIT= 1;//招募事件
		public static int EVENT_TYPE_CHARGE= 2;//充值事件
		public static int BATTLE_TROOPS_RELIVE= 100;//在战斗完成的时候，就算全军覆没，也回复这样的兵力
		public static int EVERY_ONE_NEIBORHOUR_PLAYER_ID= 1;//所有玩家都会有同一个领居 1号邻居
		public static int HERO_COMMET_PER_PLAYER_NUM= 5;//每个人只能评论5条
		public static int PUSH_TYPE_NOT_SET= 0;//默认
		public static int PUSH_TYPE_BOAT= 1;//由草船借箭引起的推送
		public static int PUSH_TYPE_EMAIL= 2;//由邮件引起的推送
		public static int PUSH_TYPE_COLLRES= 3;//由收取资源的推送
		public static int PUSH_TYPE_TASK= 4;//做任务得到
		public static int PUSH_TYPE_DAILY_TASK= 5;//做日常任务得到
		public static int NEWER_EVENT_ID_HERO_1= 301;//新手给的招孙尚香的事件(新创号的时候给）
		public static int NEWER_EVENT_ID_HERO_2= 302;//新手给的招关平的事件（招了孙尚香的时候给）
		public static int NEWER_EVENT_ID_HERO_3= 303;//新手给的招关平的事件（招了孙尚香的时候给）
		public static int BATTLE_HERO_TROOP_DEAD_PERCENT= 800;//战斗中兵力真正只有80%损失
		public static int HERO_STATUS_INJURY_TIMEOUT= 60;//重伤后1分钟不能出征
		public static int HELP_ARROW= 1;//草船借箭帮助界面编号
		public static int HELP_FACE= 101;//打脸公告界面编号
		public static int TIMES_IDX_HERO_ACCELERATE_ADD_TROOPS= 1;//程序用  
		public static int ACCELERATE_TROOPS_RMB_FACTOR= 100;//程序用  队伍剩余总时间/100 + 1 公式中的  100
		public static int ACCELERATE_TROOPS_FREE_TIMES= 2;//每天免费加速次数
		public static int HISTORY_BOOK_ID= 1101;//史书的ID
		public static int FIGHT_TOKEN_ID= 1102;//战令的ID
}