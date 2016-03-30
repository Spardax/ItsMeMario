﻿using System.Drawing;
using EloBuddy;
using EloBuddy.SDK.Menu;

namespace Mario_s_Lux
{
    internal class Menus
    {
        public static Menu FirstMenu;
        public static Menu ComboMenu;
        public static Menu HarassMenu;
        public static Menu AutoHarassMenu;
        public static Menu LaneClearMenu;
        public static Menu LasthitMenu;
        public static Menu JungleClearMenu;
        public static Menu KillStealMenu;
        public static Menu DrawingsMenu;
        public static Menu MiscMenu;

        public static ColorSlide QColorSlide;
        public static ColorSlide WColorSlide;
        public static ColorSlide EColorSlide;
        public static ColorSlide RColorSlide;
        public static ColorSlide DamageIndicatorColorSlide;

        public static void CreateMenu()
        {
            FirstMenu = MainMenu.AddMenu("Mario`s "+Player.Instance.ChampionName, Player.Instance.ChampionName.ToLower() + "marios");
            ComboMenu = FirstMenu.AddSubMenu("• Combo", "combomenuid");
            HarassMenu = FirstMenu.AddSubMenu("• Harass", "harassmenuid");
            AutoHarassMenu = FirstMenu.AddSubMenu("• AutoHarass", "autoharassmenuid");
            LaneClearMenu = FirstMenu.AddSubMenu("• LaneClear", "laneclearmenuid");
            LasthitMenu = FirstMenu.AddSubMenu("• LastHit", "lasthitmenuid");
            JungleClearMenu = FirstMenu.AddSubMenu("• JungleClear", "jungleclearmenuid");
            KillStealMenu = FirstMenu.AddSubMenu("• KillSteal", "killstealmenuid");
            MiscMenu = FirstMenu.AddSubMenu("• Misc", "miscmenuid");
            DrawingsMenu = FirstMenu.AddSubMenu("• Drawings", "drawingsmenuid");

            ComboMenu.AddGroupLabel("Spells");
            ComboMenu.CreateCheckBox("Use Q", "qUse");
            ComboMenu.CreateCheckBox("Use E", "eUse");
            ComboMenu.CreateCheckBox("Use Smart Combo", "smartCombo");

            HarassMenu.AddGroupLabel("Spells");
            HarassMenu.CreateCheckBox("Use Q", "qUse");
            HarassMenu.CreateCheckBox("Use E", "eUse");
            HarassMenu.AddGroupLabel("Settings");
            HarassMenu.CreateSlider("Mana must be lower than [{0}%] to use Harass spells", "manaSlider", 30);

            AutoHarassMenu.AddGroupLabel("Spells");
            AutoHarassMenu.CreateCheckBox("Use Q", "qUse");
            AutoHarassMenu.CreateCheckBox("Use E", "eUse");
            AutoHarassMenu.AddGroupLabel("Settings");
            AutoHarassMenu.CreateSlider("Mana must be lower than [{0}%] to use Harass spells", "manaSlider", 30);

            LaneClearMenu.AddGroupLabel("Spells");
            LaneClearMenu.CreateCheckBox("Use Q", "qUse");
            LaneClearMenu.CreateCheckBox("Use E", "eUse");
            LaneClearMenu.AddGroupLabel("Settings");
            LaneClearMenu.CreateSlider("Mana must be lower than [{0}%] to use Harass spells", "manaSlider", 30);

            LasthitMenu.AddGroupLabel("Spells");
            LasthitMenu.CreateCheckBox("Use Q", "qUse");
            LasthitMenu.CreateCheckBox("Use E", "eUse");
            LasthitMenu.AddGroupLabel("Settings");
            LasthitMenu.CreateSlider("Mana must be lower than [{0}%] to use Harass spells", "manaSlider", 30);

            JungleClearMenu.AddGroupLabel("Spells");
            JungleClearMenu.CreateCheckBox("Use Q", "qUse");
            JungleClearMenu.CreateCheckBox("Use E", "eUse");
            JungleClearMenu.AddGroupLabel("Settings");
            JungleClearMenu.CreateSlider("Mana must be lower than [{0}%] to use Harass spells", "manaSlider", 30);

            KillStealMenu.AddGroupLabel("Spells");
            KillStealMenu.CreateCheckBox("Use Q", "qUse");
            KillStealMenu.CreateCheckBox("Use E", "eUse");
            KillStealMenu.CreateCheckBox("Use R", "rUse");
            KillStealMenu.AddGroupLabel("Settings");
            KillStealMenu.CreateSlider("Mana must be lower than [{0}%] to use Harass spells", "manaSlider", 30);

            MiscMenu.AddGroupLabel("Settings");
            

            DrawingsMenu.AddGroupLabel("Setting");
            DrawingsMenu.CreateCheckBox("Draw Spell`s range only if they are ready.", "readyDraw");
            DrawingsMenu.CreateCheckBox("Draw damage indicator.", "damageDraw");
            DrawingsMenu.CreateCheckBox("Draw damage indicator percent.", "perDraw");
            DrawingsMenu.CreateCheckBox("Draw damage indicator statistics.", "statDraw", false);
            DrawingsMenu.AddGroupLabel("Spells");
            DrawingsMenu.CreateCheckBox("Draw Q.", "qDraw");
            DrawingsMenu.CreateCheckBox("Draw W.", "wDraw");
            DrawingsMenu.CreateCheckBox("Draw E.", "eDraw");
            DrawingsMenu.CreateCheckBox("Draw R.", "rDraw");
            DrawingsMenu.AddGroupLabel("Drawings Color");
            QColorSlide = new ColorSlide(DrawingsMenu, "qColor", Color.Red, "Q Color:");
            WColorSlide = new ColorSlide(DrawingsMenu, "wColor", Color.Purple, "W Color:");
            EColorSlide = new ColorSlide(DrawingsMenu, "eColor", Color.Orange, "E Color:");
            RColorSlide = new ColorSlide(DrawingsMenu, "rColor", Color.DeepPink, "R Color:");
            DamageIndicatorColorSlide = new ColorSlide(DrawingsMenu, "healthColor", Color.YellowGreen, "DamageIndicator Color:");
        }
    }
}