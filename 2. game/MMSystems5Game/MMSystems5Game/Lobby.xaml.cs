﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace MMSystems5Game
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            (App.Current as App).client1 = new GanzenBordServiceCloud.GanzenbordServiceClient();
            (App.Current as App).client1.BeschikbareLobbysCompleted += client1_BeschikbareLobbysCompleted;
            (App.Current as App).client1.MaakLobbyCompleted += client1_MaakLobbyCompleted;
            (App.Current as App).client1.LobbyInfoCompleted += client1_LobbyInfoCompleted;
            (App.Current as App).client1.JoinLobbyCompleted += client1_JoinLobbyCompleted;
            
        }

        void client1_JoinLobbyCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            
        }

        void client1_LobbyInfoCompleted(object sender, GanzenBordServiceCloud.LobbyInfoCompletedEventArgs e)
        {
           LijstSpelersInLobby.ItemsSource = e.Result;
        }

      

        void client1_MaakLobbyCompleted(object sender, GanzenBordServiceCloud.MaakLobbyCompletedEventArgs e)
        {
            MessageBox.Show("gelukt");
            
            (App.Current as App).client1.BeschikbareLobbysAsync();
            (App.Current as App).player.Lobby = (App.Current as App).player.PlayerNaam;
        }

        void client1_BeschikbareLobbysCompleted(object sender, GanzenBordServiceCloud.BeschikbareLobbysCompletedEventArgs e)
        {

            ListAvaibleLobbys.ItemsSource = e.Result;
            //foreach (var item in e.Result)
            //{
            //    ListAvaibleLobbys.Items.Add(item.HostPlayer);
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/GameView.xaml"), UriKind.Relative));
        }

        private void ListAvaibleLobbys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
      
            (App.Current as App).client1.LobbyInfoAsync((GanzenBordServiceCloud.Lobby)ListAvaibleLobbys.SelectedValue);
            

            
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            { 
                (App.Current as App).client1.BeschikbareLobbysAsync();

            }
            catch (Exception)
            {
                
                throw;
            }
         
        }

      

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            (App.Current as App).client1.MaakLobbyAsync((App.Current as App).player);
        }
    }
}