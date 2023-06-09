using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static FrislaFinal.SigScan;
using static FrislaFinal.GetAddress;

namespace FrislaFinal
{
    internal static class InventoryStuff
    {
        public static string ItemUpgradeComponent1_ = "578";
        public static string ItemUpgradeComponent2_ = "578";
        public static string ItemUpgradeComponentMelee_ = "BA0";
        public static string ItemUpgrade2ComponentMelee_ = "BA0";
        public static string ItemSlot1_ = "20";
        public static string ItemSlot2_ = "48";
        public static string Money_ = "70";
        public static string bInfiniteSize_ = "30";

        public static string RequiredRarity_ = "38";
        public static string RequiredLevel1_ = "3C";
        public static string RequiredLevel2_ = "C4";

        public static int RequiredLevel1
        {
            get => MemLib.ReadInt(InstanceData1PTR + "+" + RequiredLevel1_);
            set => MemLib.WriteMemory(InstanceData1PTR + "+" + RequiredLevel1_, "int", value.ToString());
        }
        public static int RequiredLevel2
        {
            get => MemLib.ReadInt(ProceduralItemProperties + "+" + RequiredLevel2_);
            set => MemLib.WriteMemory(ProceduralItemProperties + "+" + RequiredLevel2_, "int", value.ToString());
        }
        public static int RequiredRarity
        {
            get => MemLib.ReadInt(InstanceData1PTR + "+" + RequiredRarity_);
            set => MemLib.WriteMemory(InstanceData1PTR + "+" + RequiredRarity_, "int", value.ToString());
        }

        public static int Money
        {
            get => MemLib.ReadInt(Slots_SlotsMoney + "+" + Money_);
            set => MemLib.WriteMemory(Slots_SlotsMoney + "+" + Money_, "int", value.ToString());
        }
        public static int ItemSlot1
        {
            get => MemLib.ReadInt(Slots_SlotsWeapons + "+" + ItemSlot1_);
            set => MemLib.WriteMemory(Slots_SlotsWeapons + "+" + ItemSlot1_, "int", value.ToString());
        }
        public static int ItemSlot2
        {
            get => MemLib.ReadInt(Slots_SlotsWeapons + "+" + ItemSlot2_);
            set => MemLib.WriteMemory(Slots_SlotsWeapons + "+" + ItemSlot2_, "int", value.ToString());
        }



        public static int ItemUpgradeComponentMelee
        {
            get => MemLib.ReadInt(AddedInventoryItem1 + "+" + ItemUpgradeComponentMelee_);
            set => MemLib.WriteMemory(AddedInventoryItem1 + "+" + ItemUpgradeComponentMelee_, "int", value.ToString());
        }
        public static int ItemUpgradeComponent11
        {
            get => MemLib.ReadInt(AddedInventoryItem1 + "+" + ItemUpgradeComponent1_);
            set => MemLib.WriteMemory(AddedInventoryItem1 + "+" + ItemUpgradeComponent1_, "int", value.ToString());
        }


        public static int ItemUpgradeComponent22
        {
            get => MemLib.ReadInt(AddedInventoryItem2 + "+" + ItemUpgradeComponent2_);
            set => MemLib.WriteMemory(AddedInventoryItem2 + "+" + ItemUpgradeComponent2_, "int", value.ToString());
        }
        public static int ItemUpgrade2ComponentMelee
        {
            get => MemLib.ReadInt(AddedInventoryItem2 + "+" + ItemUpgrade2ComponentMelee_);
            set => MemLib.WriteMemory(AddedInventoryItem2 + "+" + ItemUpgrade2ComponentMelee_, "int", value.ToString());
        }


    }
}
