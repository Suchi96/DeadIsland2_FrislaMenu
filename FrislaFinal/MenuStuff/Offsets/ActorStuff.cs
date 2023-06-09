using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FrislaFinal.SigScan;
using static FrislaFinal.GetAddress;

namespace FrislaFinal
{
    internal static class ActorStuff
    {

        public static string Health_ = "178";
        public static string GlobalDamageMultiplier_ = "F0";
        public static string HitDetectionRadius_ = "EC";
        public static string HitDetectionHeight_ = "F8";
        public static string MovementSpeed_ = "1E4";
        public static string JumpVelocityZ_ = "194";
        public static string VelocityZ_ = "104";
        public static string MovementMode_ = "1A4";
        public static string bActorEnableCollision_ = "77";
        public static string bInfiniteStaminaExpressionValue_ = "19C";
        public static string bIsInfiniteFury_ = "214";
        public static string MaxBackwardSpeed_ = "CC8";
       
        public static string FallCriticalImpactHeight_ = "DB8";
        public static string FallDamagingImpactHeight_ = "DBC";
        public static string DefaultValueOverride_ = "3C";
        public static string bOverrideDefaultValue_ = "38";
        public static string MaxValueLimit_ = "4C";
        public static string bShowDebugInfo_ = "2B8";
        public static string bShowOverlay_ = "2C0";
  

        public static int bShowOverlay
        {
            set => MemLib.WriteMemory(MyHUD + "+" + bShowOverlay_, "int", value.ToString());
        }
        public static int bShowDebugInfo
        {
            set => MemLib.WriteMemory(MyHUD + "+" + bShowDebugInfo_, "int", value.ToString());
        }


        public static float MaxValueLimit
        {
            get => MemLib.ReadFloat(GlobalDamageModifier + "+" + MaxValueLimit_);
            set => MemLib.WriteMemory(GlobalDamageModifier + "+" + MaxValueLimit_, "float", value.ToString());
        }

        public static float DefaultValueOverride
        {
            get => MemLib.ReadFloat(GlobalDamageModifier + "+" + DefaultValueOverride_);
            set => MemLib.WriteMemory(GlobalDamageModifier + "+" + DefaultValueOverride_, "float", value.ToString());
        }

        public static int bOverrideDefaultValue
        {
            get => MemLib.ReadInt(GlobalDamageModifier + "+" + bOverrideDefaultValue_);
            set => MemLib.WriteMemory(GlobalDamageModifier + "+" + bOverrideDefaultValue_, "int", value.ToString());
        }













        public static float MaxBackwardSpeed
        {
            get => MemLib.ReadFloat(Actor_Character + "+" + MaxBackwardSpeed_);
            set => MemLib.WriteMemory(Actor_Character + "+" + MaxBackwardSpeed_, "float", value.ToString());
        }

        public static float FallCriticalImpactHeight
        {
            get => MemLib.ReadFloat(Actor_Character + "+" + FallCriticalImpactHeight_);
            set => MemLib.WriteMemory(Actor_Character + "+" + FallCriticalImpactHeight_, "float", value.ToString());
        }
        public static float FallDamagingImpactHeight
        {
            get => MemLib.ReadFloat(Actor_Character + "+" + FallDamagingImpactHeight_);
            set => MemLib.WriteMemory(Actor_Character + "+" + FallDamagingImpactHeight_, "float", value.ToString());
        }

        public static int bIsInfiniteFury
        {
            get => MemLib.ReadInt(FuryValues + "+" + bIsInfiniteFury_);
            set => MemLib.WriteMemory(FuryValues + "+" + bIsInfiniteFury_, "int", value.ToString());
        }
        public static int bInfiniteStaminaExpressionValue
        {
            get => MemLib.ReadInt(StaminaComponent + "+" + bInfiniteStaminaExpressionValue_);
            set => MemLib.WriteMemory(StaminaComponent + "+" + bInfiniteStaminaExpressionValue_, "int", value.ToString());
        }
        public static float Health
        {
            get => MemLib.ReadFloat(HealthComponent + "+" + Health_);
            set => MemLib.WriteMemory(HealthComponent + "+" + Health_, "float", value.ToString());
        }
        public static float GlobalDamageMultiplier
        {
            get => MemLib.ReadFloat(DamageComponent + "+" + GlobalDamageMultiplier_);
            set => MemLib.WriteMemory(DamageComponent + "+" + GlobalDamageMultiplier_, "float", value.ToString());
        }

        public static float HitDetectionRadius
        {
            get => MemLib.ReadFloat(AIMeleeTargetComponent + "+" + HitDetectionRadius_);
            set => MemLib.WriteMemory(AIMeleeTargetComponent + "+" + HitDetectionRadius_, "float", value.ToString());
        }
        public static float HitDetectionHeight
        {
            get => MemLib.ReadFloat(AIMeleeTargetComponent + "+" + HitDetectionHeight_);
            set => MemLib.WriteMemory(AIMeleeTargetComponent + "+" + HitDetectionHeight_, "float", value.ToString());
        }

        public static int MovementMode
        {
            get => MemLib.ReadInt(CharacterMovement + "+" + MovementMode_);
            set => MemLib.WriteMemory(CharacterMovement + "+" + MovementMode_, "int", value.ToString());
        }

        public static float VelocityZ
        {
            get => MemLib.ReadFloat(CharacterMovement + "+" + VelocityZ_);
            set => MemLib.WriteMemory(CharacterMovement + "+" + VelocityZ_, "float", value.ToString());
        }
        public static float MovementSpeed
        {
            get => MemLib.ReadFloat(CharacterMovement + "+" + MovementSpeed_);
            set => MemLib.WriteMemory(CharacterMovement + "+" + MovementSpeed_, "float", value.ToString());
        }

        public static float JumpVelocityZ
        {
            get => MemLib.ReadFloat(CharacterMovement + "+" + JumpVelocityZ_);
            set => MemLib.WriteMemory(CharacterMovement + "+" + JumpVelocityZ_, "float", value.ToString());
        }

        public static int bActorEnableCollision
        {
            get => MemLib.ReadInt(Actor_Character + "+" + bActorEnableCollision_);
            set => MemLib.WriteMemory(Actor_Character + "+" + bActorEnableCollision_, "int", value.ToString());
        }

    }
}
