﻿using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MMSystems5Game
{
    public class GameState:BaseViewModel
    {

        private string _turn;
        public string Turn
        {
            get { return _turn; }
            set { _turn = value; RaisePropChanged("Turn"); }
        }
        public GameState()
        {
            App.client1.GamestateCompleted += client1_GamestateCompleted;
            Turn = "wachten";
           
        }

        void client1_GamestateCompleted(object sender, GanzenBordServiceCloud.GamestateCompletedEventArgs e)
        {
            if (e.Result != null)
            {



                App.gamestate = e.Result;
                App.pionsetter.Start();
                Turn = e.Result.turn.PlayerNaam;

                if (!App.gamestate.Start)
                {


                    if (!App.plaats)
                    {
                        foreach (var item in App.gamestate.players)
                        {
                            if (item.PlayerId == App.player.PlayerId)
                            {
                                if (item.Locatie == 63)
                                    MessageBox.Show("U hebt gewonnen");

                                else if (item.Locatie != 63)
                                    MessageBox.Show("U hebt Verloren :(");


                                if (item.IsHost)
                                    App.stophost.StopHost(App.player);

                                if (!item.IsHost)
                                    App.exitlobby.ExitLobby(App.player);

                                App.gametimer.Stop();
                            }
                        }
                        App.maakaccount.navigatielobby();

                    }
                }

                if (App.player.PlayerId == e.Result.turn.PlayerId)
                {
                    App.dice.Turn = true;
                    App.KanGooien = true;
                }

                else if (App.player.PlayerId != e.Result.turn.PlayerId)
                {
                    App.dice.Turn = false;
                }

                //Plaatsen van de pionen.
                //Kleur van pionen wordt toegewezen aan de rangschikking van players in database

                if (e.Result.players.Count > 0)
                {
                    App.geel.playerid = e.Result.players[0].PlayerId;
                    App.geel.locatie = e.Result.players[0].Locatie;


                    if (e.Result.players.Count > 1)
                    {
                        App.blauw.playerid = e.Result.players[1].PlayerId;
                        App.blauw.locatie = e.Result.players[1].Locatie;

                        if (e.Result.players.Count > 2)
                        {
                            App.rood.playerid = e.Result.players[2].PlayerId;
                            App.rood.locatie = e.Result.players[2].Locatie;

                            if (e.Result.players.Count > 3)
                            {
                                App.groen.playerid = e.Result.players[3].PlayerId;
                                App.geel.locatie = e.Result.players[3].Locatie;
                            }
                        }
                    }
                }
            }
        }

      
        public void status(GanzenBordServiceCloud.Player player)
        {
            App.client1.GamestateAsync(player);
        }
    }
}
