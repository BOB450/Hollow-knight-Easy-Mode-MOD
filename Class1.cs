using System;
using Modding;

namespace HollowModEasy
{
    public class Class1 : Mod
    {
        public Class1() : base("Easy Mode By BOB450") { }

        public override void Initialize()
        {
            Log("Inits");
            //ModHooks.Instance.RecordKillForJournalHook += OnKill;
            // ModHooks.Instance.TakeHealthHook += OnHealthTaken;
            ModHooks.Instance.NewGameHook += NewGame;
           

        }

        private void NewGame()
        {
            PlayerData.instance.AddToMaxHealth(3);
        }
    }
}
//By BOB450