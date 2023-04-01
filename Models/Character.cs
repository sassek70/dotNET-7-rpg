namespace dotNET_7_rpg.Models
{
    public class Character
    {
        public int CharacterId {get; set;}
        public string CharacterName {get; set;} = "";
        public int HitPoints {get; set;} = 10;
        public int Strength {get; set;} = 10;
        public int Defense {get; set;} = 10;
        public int Intelligence {get; set;} = 10;
        public RpgClass Class{get; set;} = RpgClass.Knight;

    }
}