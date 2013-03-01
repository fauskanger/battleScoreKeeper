using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekken5DarkRessurectionScoreKeeper.Classes
{

    public enum Characters
    {
        NONE, Eddy_Gordo, Baek_Doo_San, Mokujin, Devil_Jin, Raven,
        Asuka_Kazama, Feng_Wei, Ganryu, Wang_Jinrei, Armor_King_II, Jinpachi_Mishima,
        Anna_Williams, Craig_Marduk, Marshall_Law, Hwoarang, King_II, Lili_Rochefort,
        Sergei_Dragunov, Heihachi_Mishima, Christie_Monteiro, Paul_Phoenix, Jack_5, Bruce_Irvin,
        Roger_Jr, Lei_Wulong, Nina_Williams, Steve_Fox, Kazuya_Mishima, Ling_Xiaoyu,
        Jin_Kazama, Lee_Chaolan, Julia_Chang, Yoshimitsu, Bryan_Fury, Kuma_II
    };



    

    class Character
    {

        public static string getCharacterName(Characters character)
        {
            return character.ToString().Replace("_", " ");
        }
        public static string getCharacterName(int index)
        {
            return Enum.GetName(typeof(Characters), index).Replace("_", " ");
        }

        public static Characters getCharacter(int index)
        {
            //return (Characters)Enum.GetValues(typeof(Characters)).GetValue(index);
            return (Characters)(index);
        }
    }
}
