using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beans
{
    public class Constants
    {
        public const int OFFSET_BORDER = 3;
        public const int BLOCK_ROW_COUNT = 9;
        public const int BLOCK_COLUMN_COUNT = 13;
        public const int BLOCK_SIZE = 72;
        public const int BLOCK_RADIUS = (BLOCK_SIZE / 2);
        public const int BEANS_COUNT_EASY = 5;
        public const int BEANS_COUNT_HARD = 7;
        public const int PATH_TYPE = 99;

        public const Double ANIMATION_STEP_BLOCK = 0.05; // Second

        public const String BEAN_PATH_TEMPLATE = "ms-appx:///Assets/bean_00{0}.png";

        public const String BEANS_SETTING_MAXSCORE = "BeansSettingMaxScore";
        public const String BEANS_SETTING_PLAY_BACKGROUNDMUSIC = "BeansSettingPlayBackgroundMusic";
        public const String BEANS_SETTING_GAME_MODE = "BeansSettingGameMode"; // 5=easy、7=hard
        public const String BEANS_SETTING_EASYMODE_SCORE = "BeansSettingEasyModeScore";
        public const String BEANS_SETTING_HARDMODE_SCORE = "BeansSettingHardModeScore";
        public const String BEANS_SETTING_STUPID_MODE = "BeansSettingStupidMode"; // 0 = AStar, 1 = Mouse
    }
}
