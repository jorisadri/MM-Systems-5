﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMSystems5Game
{
    public class JoinVM
    {

        public string playjoin { get; set; }
        public JoinVM()
        {
            App.client1.JoinLobbyCompleted += client1_JoinLobbyCompleted;
        
        }

        void client1_JoinLobbyCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            App.player.IsHost = false;
        }

        public void Join(GanzenBordServiceCloud.Lobby lobby, GanzenBordServiceCloud.Player player)
        {
            try
            {
                if (lobby!=null && player!=null)
                {
                    App.client1.JoinLobbyAsync(lobby, player);
                    App.player.Lobby = lobby.HostPlayer;
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}