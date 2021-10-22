using System;
using UnityEngine;

namespace UnityEngine
{
	//----------------------------------------- Game States -----------------------------------------//
	public delegate void CurrentState ();
	
	public enum GAME_STATE
	{
        SPLASH,
		MAIN_MENU,
		AFTERSPLASH,
		FIRSTHELP,
		HELP,
		BUYSHIELDROCKETINGAME,
		INGAME,
		STORY,
		GAMEOVER,
		QUICKPLAY,
		OFFLINE,
		LOADING,
		LEVELSELECTION,
		CHOOSEOPPONENT,
		ABOUT_US,
		SETTINGS,
		SPIN,
		RENT,
		LEAGUE,
		UPGRADE,
		PLAYWITHFRIENDS,
		INVITEFRIENDS,
		CHALLENGEFRIENDS,
		SEARCHUSER,
		LANGUAGE,
		PAUSEMENU,
		GAMEDECISION,
		TUTORIAL,
		SHOP,
		WORKSHOP,
		MISSION,
		SAVEME,
		REWARD,
		LEADERBOARD,
		ENDMISSION,
		HIGHESTSCORE,
		EXIT,
		RESUME,
		RATEUS,
		MINIEXIT,
		ACHIEVEMENT,
		OFFLINELEAGUE,
		SECONDSELECTFORMATION,
		BRAND,
		PROFILE,
        SELECTFORMATION,
        CLUBINFOPAGE,
		OPTION,
		CLUBEXPENSES,
		JIWEMANLOGIN,
		JIWEMANREGISTRATION,
		REGISTRATIONSUCCESS,
		SELECTCITY,
		PLAYERINFORMATION,
		BETTING_COMPANY,
		SHOPFORMATION,
		CLUBMANAGEMENT,
		SEASONLEADERBOARD,
		STADIUMSELECTION,
		FORGETPASSWORD,
    }

	
	public enum INGAME_STATES
	{
		
		NONE,
		GAMEPLAY,
		GAMEFINISHED,
		
	}

	public enum LANGUAGE
	{
		
		ENGLISH,
		JAPANESE,
		GERMAN,
		SPANISH,
		PORTUGESE,
		KOREAN,
		FRENCH,
		RUSSIAN,
		ITALIAN,
		
	}

	
	//----------------------------------------- Image Types -----------------------------------------//
	public enum IMAGE_TYPE
	{
		TEXT_HOWTOPLAY,
		TEXT_HUD,
		TEXT_SCORE,
		TEXT_EXITTEXT,
		TEXT_CIRCLE1,
		TEXT_CIRCLE2,
		TEXT_PLANET1,
		TEXT_PLANET2,
		TEXT_PLANET3,
		TEXT_ALIEN,
		TEXT_SMALLBG,
		TEXT_LEVELFINISHED,
		BTN_LOCKED_LEVELS,
		BTN_NEXTGROUP_ACTIVE,
		BTN_NEXTGROUP_NORMAL,
		BTN_PREVIOUSGROUP_ACTIVE,
		BTN_PREVIOUSGROUP_NORMAL,
		BTN_LEVEL_NORMAL,
		BTN_LEVEL_ACTIVE,
		TEXT_YOULOSE,
		TEXT_CREDITSTEXT,
		TEXT_INGAMEBG,
		TEXT_STAR1_NORMAL,
		TEXT_STAR1_ACTIVE,
		TEXT_LOCK,
		TEXT_AFTERSPLASH,
		TEXT_MAINMENU,
		BTN_PLAY_NORMAL,
		BTN_PLAY_ACTIVE,
		BTN_SETTINGS_NORMAL,
		BTN_SETTINGS_ACTIVE,
		BTN_HELP_NORMAL,
		BTN_HELP_ACTIVE,
		BTN_ABOUTUS_NORMAL,
		BTN_ABOUTUS_ACTIVE,
		TEXT_TITLE,
		TEXT_HELP,
		BTN_BACK_NORMAL,
		BTN_BACK_ACTIVE,
		TEX_ABOUTUS_BG,
		TEXT_CREDITS,
		TEX_MUZ_SOUND,
		TEX_STRIP_BLUE,
		TEX_MUSIC,
		TEX_STRIP_ORG,
		TEX_SOUND,
		TEXT_LOADING,
		TEXT_LEVEL_NORMAL,
		TEXT_LEVEL_ACTIVE,
		TEXT_FAKESCREEN,
		TEXT_FACE,
		BTN_FB_NORMAL,
		BTN_FB_ACTIVE,
		BTN_GPLUS_NORMAL,
		BTN_GPLUS_ACTIVE,

		TEXT_STICKMAN,
		BTN_PAUSE_NORMAL,
		BTN_PAUSE_ACTIVE,
		BTN_ARROW_LEFT_NORMAL,
		BTN_ARROW_LEFT_ACTIVE,
		BTN_ARROW_RIGHT_NORMAL,
		BTN_ARROW_RIGHT_ACTIVE,
		TEXT_LIFEBAR_BG,
		TEXT_LIFEBAR,
		TEXT_GRADIENT,
		BTN_MAINMENU_NORMAL,
		BTN_MAINMENU_ACTIVE,
		BTN_RESUME_NORMAL,
		BTN_RESUME_ACTIVE,
		BTN_RESTART_NORMAL,
		BTN_RESTART_ACTIVE,
		TEXT_PAUSEPOPUP,
		TEXT_PAUSETEXT,
		TEXT_ABOUTUSTEXT,
		TEXT_ABOUTUSPOPUP,
		BTN_LEVEL1_ACTIVE,
		BTN_LEVEL1_NORMAL,
		BTN_LEVEL2_ACTIVE,
		BTN_LEVEL2_NORMAL,
		BTN_LEVEL3_ACTIVE,
		BTN_LEVEL3_NORMAL,
		BTN_LEVEL4_ACTIVE,
		BTN_LEVEL4_NORMAL,
		BTN_LEVEL5_NORMAL,
		BTN_LEVEL5_ACTIVE,
		TEXT_LEVELTEXT,
		BTN_SOUND_ON,
		BTN_SOUND_OFF,
		TEXT_HELPTEXT,
		BTN_NEXTLEVEL_ACTIVE,
		BTN_NEXTLEVEL_NORMAL,
		TEXT_LEVELCLEAREDTEXT,
		BTN_PLAYAGAIN_ACTIVE,
		BTN_PLAYAGAIN_NORMAL,
		TEXT_YOULOSETEXT,
		TEXT_MUSICTEXT,
		TEXT_SETTINGS_TEXT,
		TEXT_SOUND_TEXT,
		BTN_NO_ACTIVE,
		BTN_NO_NORMAL,
		BTN_YES_ACTIVE,
		BTN_YES_NORMAL,
		TEXT_EXITPOPUP,
		TEX_BLACK,



		BTN_MENU_NORMAL,
		BTN_MENU_ACTIVE,
		BTN_BACK_RIGHT_NORMAL,

		BTN_HOME_ACTIVE,
		BTN_HOME_NORMAL,

		BTN_KICK_ACTIVE,
		BTN_KICK_NORMAL,
		BTN_POWER_ACTIVE,
		BTN_POWER_NORMAL,
		BTN_PUNCH_ACTIVE,
		BTN_PUNCH_NORMAL,
		BTN_BLOCK_ACTIVE,
		BTN_BLOCK_NORMAL,
		BTN_COMBO_ACTIVE,
		BTN_COMBO_NORMAL,
		BTN_BLOCK_FADE,
		BTN_COMBO_FADE,
		BTN_KICK_FADE,
		BTN_POWER_FADE,
		BTN_PUNCH_FADE,
		BTN_RESTARTWIN_NORMAL,
		BTN_RESTARTWIN_ACTIVE,


		Stickman_black,
		Stickman_blue,
		Stickman_green,
		Stickman_red,

		_fakescreen,

		TEX_ARROW_1,
		TEX_ARROW_2,
		TEX_ARROW_3,
		TEX_ARROW_4,
		TEX_ARROW_5,
		TEX_ARROW_6,
		TEX_ARROW_7,
		TEX_ARROW_8,
		TEX_TRANSPARENT_BG,
		TEXT_WINPOPUP,


		TEXT_CHOOSELANGUAGE_ENGLISH,
		TEXT_CHOOSELANGUAGE_FRENCH,
		TEXT_CHOOSELANGUAGE_GERMAN,
		TEXT_CHOOSELANGUAGE_ITALIAN,
		TEXT_CHOOSELANGUAGE_JAPANESE,
		TEXT_CHOOSELANGUAGE_KOREAN,
		TEXT_CHOOSELANGUAGE_PORTUGESE,
		TEXT_CHOOSELANGUAGE_RUSSIAN,
		TEXT_CHOOSELANGUAGE_SPANISH,

		TEXT_CREDITS_ENGLISH,
		TEXT_CREDITS_FRENCH,
		TEXT_CREDITS_GERMAN,
		TEXT_CREDITS_ITALIAN,
		TEXT_CREDITS_JAPANESE,
		TEXT_CREDITS_KOREAN,
		TEXT_CREDITS_PORTUGESE,
		TEXT_CREDITS_RUSSIAN,
		TEXT_CREDITS_SPANISH,
		TEXT_EXITTEXT_ENGLISH,
		TEXT_EXITTEXT_FRENCH,
		TEXT_EXITTEXT_GERMAN,
		TEXT_EXITTEXT_ITALIAN,
		TEXT_EXITTEXT_JAPANESE,
		TEXT_EXITTEXT_KOREAN,
		TEXT_EXITTEXT_PORTUGESE,
		TEXT_EXITTEXT_RUSSIAN,
		TEXT_EXITTEXT_SPANISH,

		TEXT_HELPTEXTENGLISH,
		TEXT_HELPTEXTFRENCH,
		TEXT_HELPTEXTGERMAN,
		TEXT_HELPTEXTITALIAN,
		TEXT_HELPTEXTJAPANESE,
		TEXT_HELPTEXTKOREAN,
		TEXT_HELPTEXTPORTUGESE,
		TEXT_HELPTEXTRUSSIAN,
		TEXT_HELPTEXTSPANISH,

		TEXT_HELPTEXTENGLISH1,
		TEXT_HELPTEXTFRENCH1,
		TEXT_HELPTEXTGERMAN1,
		TEXT_HELPTEXTITALIAN1,
		TEXT_HELPTEXTJAPANESE1,
		TEXT_HELPTEXTKOREAN1,
		TEXT_HELPTEXTPORTUGESE1,
		TEXT_HELPTEXTRUSSIAN1,
		TEXT_HELPTEXTSPANISH1,

		TEXT_HOWTOPLAY_ENGLISH,
		TEXT_HOWTOPLAY_FRENCH,
		TEXT_HOWTOPLAY_GERMAN,
		TEXT_HOWTOPLAY_ITALIAN,
		TEXT_HOWTOPLAY_JAPANESE,
		TEXT_HOWTOPLAY_KOREAN,
		TEXT_HOWTOPLAY_PORTUGESE,
		TEXT_HOWTOPLAY_RUSSIAN,
		TEXT_HOWTOPLAY_SPANISH,
		TEXT_INSTRUCTION,
		TEXT_LEVELFINISHED_ENGLISH,
		TEXT_LEVELFINISHED_FRENCH,
		TEXT_LEVELFINISHED_GERMAN,
		TEXT_LEVELFINISHED_ITALIAN,
		TEXT_LEVELFINISHED_JAPANESE,
		TEXT_LEVELFINISHED_KPREAN,
		TEXT_LEVELFINISHED_PORTUGESE,
		TEXT_LEVELFINISHED_RUSSIAN,
		TEXT_LEVELFINISHED_SPANISH,
		TEXT_PAUSETEXT_ENGLISH,
		TEXT_PAUSETEXT_FRENCH,
		TEXT_PAUSETEXT_GERMAN,
		TEXT_PAUSETEXT_ITALIAN,
		TEXT_PAUSETEXT_JAPANESE,
		TEXT_PAUSETEXT_KOREAN,
		TEXT_PAUSETEXT_PORTUGESE,
		TEXT_PAUSETEXT_RUSSIAN,
		TEXT_PAUSETEXT_SPANISH,
		TEXT_SCORE_ENGLISH,
		TEXT_SCORE_FRENCH,
		TEXT_SCORE_GERMAN,
		TEXT_SCORE_ITALIAN,
		TEXT_SCORE_JAPANESE,
		TEXT_SCORE_KOREAN,
		TEXT_SCORE_PORTUGESE,
		TEXT_SCORE_RUSSIAN,
		TEXT_SCORE_SPANISH,
		TEXT_SPLASH,
		TEXT_SWIPE,
		TEXT_TAP,
		TEXT_TAPHERE2,
		TEXT_TAPTEXT,
		TEXT_TITLE_ENGLISH,
		TEXT_TITLE_FRENCH,
		TEXT_TITLE_GERMAN,
		TEXT_TITLE_ITALIAN,
		TEXT_TITLE_JAPANESE,
		TEXT_TITLE_KOREAN,
		TEXT_TITLE_PORTUGESE,
		TEXT_TITLE_RUSSIAN,
		TEXT_TITLE_SPANISH,
		TEXT_TUTORIAL_ENGLISH,
		TEXT_TUTORIAL_FRENCH,
		TEXT_TUTORIAL_GERMAN,
		TEXT_TUTORIAL_ITALIAN,
		TEXT_TUTORIAL_JAPANESE,
		TEXT_TUTORIAL_KOREAN,
		TEXT_TUTORIAL_PORTUGESE,
		TEXT_TUTORIAL_RUSSIAN,
		TEXT_TUTORIAL_SPANISH,


		BTN_ARROWLEFT_ACTIVE,
		BTN_ARROWLEFT_NORMAL,
		BTN_ARROWRIGHT_ACTIVE,
		BTN_ARROWRIGHT_NORMAL,
		TEXT_ENGLISH,
		TEXT_FRENCH,
		TEXT_GERMAN,
		TEXT_ITALIAN,
		TEXT_JAPANESE,
		TEXT_KOREAN,
		TEXT_PORTUGESE,
		TEXT_RUSSIAN,
		TEXT_SPANISH,

		
		
	}
	//----------------------------------------- Sound Clips -----------------------------------------//
	public enum SOUND_CLIP
	{
		TAPSOUND,
		BUTTON_CLICK,
		ROCKET,
		BG,
		GET,
		LOSE,
		COINS,
		INGAMEBG,
		STORYBG,
		BOMB,
		DESTROYBALL,
		fall,
		dragoneat,
		coinsound,
		DRAGONSCREAM,

	}
	//----------------------------------------- Player states ---------------------------------------//
	public enum MONKEYSTATES
	{
		IDLE,
		EAT,
		LOSE,
	
	}
	//------------------------------------------ Enemy states ----------------------------------------//
	public enum ENEMY_STATES
	{
		
		IDLE,
		RUN,
		WALK,
		PUNCH_1,
		PUNCH_2,
		DOUBLE_PUNCH,
		BLOCK,
		KICK,
		JUMP_KICK,
		DEATH_FAR,
		DEATH_NEAR,
		HURT,
		HARD_HURT,
		HARD_HURT_KICK,
		HARD_HURT_PUNCH,
		JUMP,
		COMBO_GRAB_LEG_HURT,
		COMBO_2_HURT,
		COMBO_3_HURT,
		COMBO_3_KICK_HURT,
		COMBO_3_NO_KICK_HURT,
		COMBO_4_HURT,
		COMBO_4_KICK_HURT_1,
		COMBO_4_NO_KICK_HURT_1,
		COMBO_4_KICK_HURT_2,
		COMBO_4_NO_KICK_HURT_2,
		COMBO_5_HURT,
		COMBO_5_KICK_HURT,
		COMBO_5_NO_KICK_HURT,
		COMBO_6_HURT,
		FALL_BACK,
		GET_UP,
		SOMER_SAULT,
		ROUND_OFF_BACK,
		BLOCK_COMBO
	}
	//---------------
	public enum TUTORIAL
	{
		OFF_TUTORIAL,
		PUNCH_BUTTON_TUTORIAL,
		KICK_BUTTON_TUTORIAL,
	}	
}