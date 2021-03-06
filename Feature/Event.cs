﻿namespace Shelter
{
    public class Event
    {
        /// <summary>
        /// Removes every random event that may occur
        /// </summary>
        public static void NoRandomEvents()
        {
            if (MonoSingleton<Vault>.IsInstanceValid && Setting.NoRandomEvent)
            {
                MonoSingleton<Vault>.Instance.EmergencyState.Clean();
            }
        }

        /// <summary>
        /// Start a raider attack on the vault
        /// </summary>
        public static void StartRaiderAttack()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.EmergencyState.RaiderMgr.BeginAttack();
            }
        }

        /// <summary>
        /// Start a ghoul attack on the vault
        /// </summary>
        public static void StartGhoulAttack()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.EmergencyState.GhoulMgr.BeginAttack();
            }
        }

        /// <summary>
        /// Start a DeathClaw attack on the vault
        /// </summary>
        public static void StartDeathClawAttack()
        {
            if (MonoSingleton<Vault>.IsInstanceValid)
            {
                MonoSingleton<Vault>.Instance.EmergencyState.DeathclawMgr.BeginAttack();
            }
        }
    }
}
