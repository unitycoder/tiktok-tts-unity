using System.Collections.Generic;
using UnityEngine;

namespace UnityLibrary.Examples
{
    public class SetSpeakers : MonoBehaviour
    {
        public TMPro.TMP_Dropdown dropdownTarget;

        public int defaultSpeakerIndex = 0;

        void Start()
        {
            if (dropdownTarget == null)
            {
                Debug.LogError("GetSpeakers: dropdownTarget is null");
                return;
            }

            dropdownTarget.ClearOptions();

            // NOTE japanese characters did work, so using values instead of keys
            dropdownTarget.AddOptions(new List<string>(Speakers.Values));

            dropdownTarget.value = defaultSpeakerIndex;
        }

        Dictionary<string, string> Speakers = new Dictionary<string, string>
        {
            {"Game On","en_male_jomboy"}, // 0
            {"Jessie","en_us_002"},
            {"Warm","es_mx_002"},  // 2
            {"Wacky","en_male_funny"},
            {"Scream","en_us_ghostface"},
            {"Empathetic","en_female_samc"},  // 5
            {"Serious","en_male_cody"},
            {"Beauty Guru","en_female_makeup"},
            {"Bestie","en_female_richgirl"},
            {"Trickster","en_male_grinch"},
            {"Joey","en_us_006"},
            {"Story Teller","en_male_narration"},  // 11
            {"Mr.GoodGuy","en_male_deadpool"},
            {"Narrator","en_uk_001"},
            {"Male English UK","en_uk_003"},
            {"Metro","en_au_001"},
            {"Alfred","en_male_jarvis"},
            {"ashmagic","en_male_ashmagic"},
            {"olantekkers","en_male_olantekkers"},
            {"Lord Cringe","en_male_ukneighbor"},
            {"Mr.Meticulous","en_male_ukbutler"},
            {"Debutante","en_female_shenna"},
            {"Varsity","en_female_pansino"},
            {"Marty","en_male_trevor"},
            {"Pop Lullaby","en_female_f08_twinkle"},
            {"Classic Electric","en_male_m03_classical"},
            {"Bae","en_female_betty"},
            {"Cupid","en_male_cupid"},
            {"Granny","en_female_grandma"},
            {"Cozy","en_male_m2_xhxs_m03_christmas"},  // 30
            {"Author","en_male_santa_narration"},
            {"Caroler","en_male_sing_deep_jingle"},
            {"Santa","en_male_santa_effect"},
            {"NYE 2023","en_female_ht_f08_newyear"},
            {"Magician","en_male_wizard"},
            {"Opera","en_female_ht_f08_halloween"},
            {"Euphoric","en_female_ht_f08_glorious"},
            {"Hypetrain","en_male_sing_funny_it_goes_up"},
            {"Melodrama","en_female_ht_f08_wonderful_world"},
            {"Quirky Time","en_male_m2_xhxs_m03_silly"},
            {"Peaceful","en_female_emotional"},
            {"Toon Beat","en_male_m03_sunshine_soon"},
            {"Open Mic","en_female_f08_warmy_breeze"},
            {"Jingle","en_male_m03_lobby"},
            {"Thanksgiving","en_male_sing_funny_thanksgiving"},
            {"Cottagecore","en_female_f08_salut_damour"},  // 45
            {"Professor","en_us_007"},
            {"Scientist","en_us_009"},
            {"Confidence","en_us_010"},
            {"Smooth","en_au_002"},
            {"Ghost Face","en_us_ghostface"},
            {"Chewbacca","en_us_chewbacca"},
            {"C3PO","en_us_c3po"},
            {"Stitch","en_us_stitch"},
            {"Stormtrooper","en_us_stormtrooper"},
            {"Rocket","en_us_rocket"},
            {"Madame Leota","en_female_madam_leota"},
            {"Ghost Host","en_male_ghosthost"},
            {"Pirate","en_male_pirate"},
            {"French-Male 1","fr_001"},  // 59
            {"French-Male 2","fr_002"},
            {"Spanish (Spain)-Male","es_002"},
            {"Spanish MX-Male","es_mx_002"},
            {"Portuguese BR-Female 1","br_001"},
            {"Portuguese BR-Female 2","br_003"},  // 63
            {"Portuguese BR-Female 3","br_004"},
            {"Portuguese BR-Male","br_005"},
            {"Ivete Sangalo","bp_female_ivete"},
            {"Ludmilla","bp_female_ludmilla"},
            {"Lhays Macedo","pt_female_lhays"},
            {"Laizza","pt_female_laizza"},  // 69
            {"Galvão Bueno","pt_male_bueno"},
            {"German-Female","de_001"},
            {"German-Male","de_002"},
            {"Indonesian-Female","id_001"},
            {"Japanese-Female 1","jp_001"},
            {"Japanese-Female 2","jp_003"},
            {"Japanese-Female 3","jp_005"},
            {"Japanese-Male","jp_006"},
            {"りーさ","jp_female_fujicochan"},  // 77
            {"世羅鈴","jp_female_hasegawariona"},
            {"Morio’s Kitchen","jp_male_keiichinakano"},
            {"夏絵ココ","jp_female_oomaeaika"},
            {"低音ボイス","jp_male_yujinchigusa"},
            {"四郎","jp_female_shirou"},
            {"玉川寿紀","jp_male_tamawakazuki"},  // 83
            {"庄司果織","jp_female_kaorishoji"},
            {"八木沙季","jp_female_yagishaki"},
            {"ヒカキン","jp_male_hikakin"},
            {"丸山礼","jp_female_rei"},
            {"修一朗","jp_male_shuichiro"},
            {"マツダ家の日常","jp_male_matsudake"},
            {"まちこりーた","jp_female_machikoriiita"},  // 90
            {"モジャオ","jp_male_matsuo"},
            {"モリスケ","jp_male_osada"},
            {"Korean-Male 1","kr_002"},
            {"Korean-Female","kr_003"},  // 94
            {"Korean-Male 2","kr_004"},
            {"Female","BV074_streaming"},
            {"Male","BV075_streaming"},
            {"Alto","en_female_f08_salut_damour"},
            {"Tenor","en_male_m03_lobby"},
            {"Sunshine Soon","en_male_m03_sunshine_soon"},  // 100
            {"Warmy Breeze","en_female_f08_warmy_breeze"},
            {"Glorious","en_female_ht_f08_glorious"},  // 102
            {"It Goes Up","en_male_sing_funny_it_goes_up"},
            {"Chipmunk","en_male_m2_xhxs_m03_silly"},
            {"Dramatic","en_female_ht_f08_wonderful_world"}
        };
    }
}
