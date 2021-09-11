﻿using Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PlayerController
    {
        //TODO: insertarlo a la BD
        public Player CreatePlayer(string docNumber, string name)
        {
            Player player = new Player(docNumber, "0", name, 0);
            return player;
        }

        //TODO: extract of BD
        public static void Update(Player player, List<string> roundInfo)
        {

            player.TotalScore += int.Parse(roundInfo[2]);
            player.RoundId = roundInfo[0].ToString();

            return;
        }

        public static void EndGame(Player player, int roundNumber)
        {
            player.RoundId = roundNumber.ToString();
            return;
        }
    }
}