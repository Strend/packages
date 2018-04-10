﻿using System.Collections.Generic;

namespace SlotokingUIAuto
{
    static class RCGamesCodes
    {
        /// <summary>
        /// Names and codes for all RC Games
        /// </summary>
        public static Dictionary<int, string> dGames = new Dictionary<int, string>
        {
            {1, "Lucky Lady Charm"},
            {3, "Book Of Ra"},
            {4, "Columbus"},
            {7, "Just Jewels"},
            {8, "Bananas Go Bahamas"},
            {10, "Marco Polo"},
            {11, "Oliver Bar"},
            {12, "Pharaohs Gold 2"},
            {13, "Riches Of India"},
            {16, "Illusionist"},
            {17, "The Money Game"},
            {21, "Queen Of Hearts"},
            {24, "Treasure Jewels"},
            {25, "Attila"},
            {26, "Gryphon's Gold"},
            {27, "Sizzling Hot" },
            {28, "Pharaoh's Gold 2 Deluxe"},
            {29, "Dolphin's Pearl Deluxe" },
            {30, "Lucky Lady Charm Deluxe" },
            {31, "Book Of Ra deluxe" },
            {32, "Queen Of Hearts Deluxe" },
            {44, "Xtra Hot" },
            {47, "Fruits For All" },
            {49, "Crazy Monkey" },
            {52, "Lord Of the Ocean" },
            {57, "Sizzling Hot Deluxe" },
            {64, "Lucky Bugs" },
            {78, "Chip Runner" },
            {79, "Ultra Hot Deluxe" },
            {80, "Always Hot" },
            {84, "Flamenco Roses"},
            {86, "Secret Elixir" },
            {90, "Hot Chance" },
            {91, "Spinning Reels "},
            {92, "Always Hot Deluxe" },
            {93,"Tiki Island" },
            {94, "Lions" },
            {100, "Fruit Sensation" },
            {101, "Plenty On Twenty Hot" },
            {102, "Magic 81" },
            {103, "Northern Light" },
            {112, "Fruits On Fire Deluxe" },
            {114, "Five To One" },
            {115, "Columbus Deluxe" },
            {121, "Disco Fruits" },
            {122, "Bananas" },
            {130, "Space Rocks" },
            {139, "Book Of Ra Deluxe 6" },
            {140, "Pharaoh's Ring" },
            {146, "Golden Fruits" },
            {150, "Fruit Illusion" },
            {151, "Sizzling 6" },
            {152, "Sizzling Gold" },
            {154, "Pharaohs Tomb" },
            {171, "The Shining Princess" },
            {172,"Mask Of The Dragon" },
            {176, "Chili Pepper" },
            {177, "Mega Joker" },
            {178, "Roaring Forties" },
            {179, "Just Jewels Deluxe" },
            {181, "Ultra Sevens" },
            {182, "Serengeti Heat" },
            {184, "Spinning Stars" },
            {185, "Supra Hot" },
            {186, "River Queen" },
            {187, "Magic 27" },
            {188, "Gryphon's Gold Deluxe" },
            {192, "Music Island" },
            {216, "Diamond Shoot" },
            {220, "Faust" },
     };

        public static List<string> lGames = new List<string>()
        {
            {"1"},
            {"3"},
            {"4"},
            {"7"},
            {"8"},
            {"10"},
            {"11"},
            {"12"},
            {"13"},
            {"16"},
            {"17"},
            {"21"},
            {"24"},
            {"25"},
            {"26"},
            {"27"},
            {"28"},
            {"29"},
            {"30"},
            {"31"},
            {"32"},
            {"44"},
            {"47"},
            {"49"},
            {"52"},
            {"57"},
            {"64"},
            {"78"},
            {"79"},
            {"80"},
            {"84"},
            {"86"},
            {"90"},
            {"91"},
            {"92"},
            {"93"},
            {"94"},
            {"100"},
            {"101"},
            {"102"},
            {"103"},
            {"112"},
            {"114"},
            {"115"},
            {"121"},
            {"122"},
            {"130"},
            {"139"},
            {"140"},
            {"146"},
            {"150"},
            {"151"},
            {"152"},
            {"154"},
            {"171"},
            {"172"},
            {"176"},
            {"177"},
            {"178"},
            {"179"},
            {"181"},
            {"182"},
            {"184"},
            {"185"},
            {"186"},
            {"187"},
            {"188"},
            {"192"},
            {"216"},
            {"220"},
     };

        public static string GetGames(int num)
        {
            if (dGames.TryGetValue(num, out string result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}