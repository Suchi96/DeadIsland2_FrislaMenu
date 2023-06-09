using System;
using static FrislaFinal.SigScan;

namespace FrislaFinal
{
    internal static class GetAddress
    {
        public static string GEngine => MemLib.ReadLong(GEngine_BaseAddress).ToString("X2");

        public static string Engine_GameInstance => MemLib.ReadLong(GEngine + "+EA8").ToString("X2");

        public static string GameInstance_LocalPlayers => MemLib.ReadLong(Engine_GameInstance + "+38").ToString("X2");

        public static string Unknown_ => MemLib.ReadLong(GameInstance_LocalPlayers + "+0").ToString("X2");

        public static string Player_PlayerController => MemLib.ReadLong(Unknown_ + "+30").ToString("X2");
        public static string Actor_Character => MemLib.ReadLong(Player_PlayerController + "+2F0").ToString("X2");
        // ---BASE STUFF ENDS HERE--- //

        public static string HealthComponent => MemLib.ReadLong(Actor_Character + "+948").ToString("X2");
        public static string DamageComponent => MemLib.ReadLong(Actor_Character + "+958").ToString("X2");

        public static string GlobalDamageModifier => MemLib.ReadLong(DamageComponent + "+F8").ToString("X2");

        public static string AIMeleeTargetComponent => MemLib.ReadLong(Actor_Character + "+970").ToString("X2");

        public static string CharacterMovement => MemLib.ReadLong(Actor_Character + "+328").ToString("X2");

        public static string FuryValues => MemLib.ReadLong(Player_PlayerController + "+788").ToString("X2");

        public static string StaminaComponent => MemLib.ReadLong(Actor_Character + "+950").ToString("X2");

        public static string MyHUD => MemLib.ReadLong(Actor_Character + "+18A8").ToString("X2");










        public static string PlayerState => MemLib.ReadLong(Actor_Character + "+2D0").ToString("X2");

        public static string InventoryActor => MemLib.ReadLong(PlayerState + "+3D8").ToString("X2");

        public static string InventoryComponent => MemLib.ReadLong(InventoryActor + "+2B8").ToString("X2");

        public static string Categories => MemLib.ReadLong(InventoryComponent + "+120").ToString("X2");
     
        public static string Categories1 => MemLib.ReadLong(Categories + "+8").ToString("X2");//WEAPON DATA
        public static string Categories2 => MemLib.ReadLong(Categories + "+18").ToString("X2");//MONEY DATA
  
        public static string Slots_SlotsMoney => MemLib.ReadLong(Categories2 + "+1A0").ToString("X2");//MONEY DATA

        public static string Slots_SlotsWeapons => MemLib.ReadLong(Categories1 + "+1A0").ToString("X2");//WEAPON DATA

        public static string AddedInventoryItem1 => MemLib.ReadLong(Slots_SlotsWeapons + "+10").ToString("X2");//ITEM THAT GOT ADDED FIRST TO INVENTORY
        public static string AddedInventoryItem2 => MemLib.ReadLong(Slots_SlotsWeapons + "+38").ToString("X2");//ITEM THAT GOT ADDED SECOND TO INVENTORY

        public static string ItemUpgradeComponent1 => MemLib.ReadLong(AddedInventoryItem1 + "+578").ToString("X2");

      

        public static string InstanceData1PTR => MemLib.ReadLong(AddedInventoryItem1 + "+3D8").ToString("X2");

        public static string ProceduralItemProperties => MemLib.ReadLong(InstanceData1PTR + "+60").ToString("X2");



        public static string ItemUpgradeComponent2 => MemLib.ReadLong(AddedInventoryItem2 + "+578").ToString("X2");

    }
}

