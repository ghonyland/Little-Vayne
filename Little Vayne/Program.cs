using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color

namespace Little Vayne
{
    class Program
    {
        private static String championName = "Vayne";
        public static Obj_AI_Hero Player;
        private static Menu _menu;
        private static Orbwalking.Orbwalker _orbwalker;
        private static Spell Q, W, E, R;

        private static void Game_OnGameLoad(EventArgs args)
        {
            Player = ObjectManager.Player;
            if (Player.ChampionName != championName)
            {
                return;
            }

            _menu = new Menu(("Little Vayne", "little.vayne", true);
            var orbwalkerMenu = new Menu("OrbWalker", "little.vayne.orbwalker");
            _orbwalker = new Orbwalking.Orbwalker(orbwalkerMenu);

            _menu.AddSubMenu(orbwalkerMenu);

            TargetSelector.AddToMenu(_menu);

            var comboMenu = new Menu("Combo", "little.vayne.combo");
            {
                comboMenu.AddItem(new MenuItem("little.vayne.combo.useq", "Use Q").SetValue(true));
                comboMenu.AddItem(new MenuItem("little.vayne.combo.usee", "Use E").SetValue(true));
                comboMenu.AddItem(new MenuItem("little.vayne.combo.user", "Use R").SetValue(true));
                
            }
            _menu.AddSubMenu(comboMenu);

            var harassMenu = new Menu("Harass", "little.vayne.harass");
            {
                harassMenu.AddItem(new MenuItem("little.vayne.harass.useq", "Use Q").SetValue(true));
                harassMenu.AddItem(new MenuItem("little.vayne.harass.usee", "Use E").SetValue(true));
                
            }
            _menu.AddSubMenu(harassMenu);

            _menu.AddToMainMenu();

        }

        {
            Game.PrintChat("Little Vayne Loaded !");
        }
        