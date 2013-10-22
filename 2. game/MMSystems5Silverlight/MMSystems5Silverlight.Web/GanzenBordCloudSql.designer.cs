﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MMSystems5Silverlight.Web
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GanzenBordDataBase")]
	public partial class GanzenBordCloudSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLobby(Lobby instance);
    partial void UpdateLobby(Lobby instance);
    partial void DeleteLobby(Lobby instance);
    partial void InsertPlayer(Player instance);
    partial void UpdatePlayer(Player instance);
    partial void DeletePlayer(Player instance);
    partial void InsertPlayerLobby(PlayerLobby instance);
    partial void UpdatePlayerLobby(PlayerLobby instance);
    partial void DeletePlayerLobby(PlayerLobby instance);
    #endregion
		
		public GanzenBordCloudSqlDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["GanzenBordDataBaseConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GanzenBordCloudSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GanzenBordCloudSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GanzenBordCloudSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GanzenBordCloudSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Lobby> Lobbies
		{
			get
			{
				return this.GetTable<Lobby>();
			}
		}
		
		public System.Data.Linq.Table<Player> Players
		{
			get
			{
				return this.GetTable<Player>();
			}
		}
		
		public System.Data.Linq.Table<PlayerLobby> PlayerLobbies
		{
			get
			{
				return this.GetTable<PlayerLobby>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lobby")]
	public partial class Lobby : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LobbyId;
		
		private string _LobbyNaam;
		
		private bool _IsBeschikbaar;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLobbyIdChanging(int value);
    partial void OnLobbyIdChanged();
    partial void OnLobbyNaamChanging(string value);
    partial void OnLobbyNaamChanged();
    partial void OnIsBeschikbaarChanging(bool value);
    partial void OnIsBeschikbaarChanged();
    #endregion
		
		public Lobby()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LobbyId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LobbyId
		{
			get
			{
				return this._LobbyId;
			}
			set
			{
				if ((this._LobbyId != value))
				{
					this.OnLobbyIdChanging(value);
					this.SendPropertyChanging();
					this._LobbyId = value;
					this.SendPropertyChanged("LobbyId");
					this.OnLobbyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LobbyNaam", DbType="NChar(10)")]
		public string LobbyNaam
		{
			get
			{
				return this._LobbyNaam;
			}
			set
			{
				if ((this._LobbyNaam != value))
				{
					this.OnLobbyNaamChanging(value);
					this.SendPropertyChanging();
					this._LobbyNaam = value;
					this.SendPropertyChanged("LobbyNaam");
					this.OnLobbyNaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsBeschikbaar", DbType="Bit NOT NULL")]
		public bool IsBeschikbaar
		{
			get
			{
				return this._IsBeschikbaar;
			}
			set
			{
				if ((this._IsBeschikbaar != value))
				{
					this.OnIsBeschikbaarChanging(value);
					this.SendPropertyChanging();
					this._IsBeschikbaar = value;
					this.SendPropertyChanged("IsBeschikbaar");
					this.OnIsBeschikbaarChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Player")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlayerId;
		
		private string _PlayerNaam;
		
		private string _Wachtwoord;
		
		private System.Nullable<int> _Locatie;
		
		private System.Nullable<int> _Gewonnen;
		
		private System.Nullable<int> _Verloren;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlayerIdChanging(int value);
    partial void OnPlayerIdChanged();
    partial void OnPlayerNaamChanging(string value);
    partial void OnPlayerNaamChanged();
    partial void OnWachtwoordChanging(string value);
    partial void OnWachtwoordChanged();
    partial void OnLocatieChanging(System.Nullable<int> value);
    partial void OnLocatieChanged();
    partial void OnGewonnenChanging(System.Nullable<int> value);
    partial void OnGewonnenChanged();
    partial void OnVerlorenChanging(System.Nullable<int> value);
    partial void OnVerlorenChanged();
    #endregion
		
		public Player()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerNaam", DbType="NChar(10)")]
		public string PlayerNaam
		{
			get
			{
				return this._PlayerNaam;
			}
			set
			{
				if ((this._PlayerNaam != value))
				{
					this.OnPlayerNaamChanging(value);
					this.SendPropertyChanging();
					this._PlayerNaam = value;
					this.SendPropertyChanged("PlayerNaam");
					this.OnPlayerNaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Wachtwoord", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Wachtwoord
		{
			get
			{
				return this._Wachtwoord;
			}
			set
			{
				if ((this._Wachtwoord != value))
				{
					this.OnWachtwoordChanging(value);
					this.SendPropertyChanging();
					this._Wachtwoord = value;
					this.SendPropertyChanged("Wachtwoord");
					this.OnWachtwoordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locatie", DbType="Int")]
		public System.Nullable<int> Locatie
		{
			get
			{
				return this._Locatie;
			}
			set
			{
				if ((this._Locatie != value))
				{
					this.OnLocatieChanging(value);
					this.SendPropertyChanging();
					this._Locatie = value;
					this.SendPropertyChanged("Locatie");
					this.OnLocatieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gewonnen", DbType="Int")]
		public System.Nullable<int> Gewonnen
		{
			get
			{
				return this._Gewonnen;
			}
			set
			{
				if ((this._Gewonnen != value))
				{
					this.OnGewonnenChanging(value);
					this.SendPropertyChanging();
					this._Gewonnen = value;
					this.SendPropertyChanged("Gewonnen");
					this.OnGewonnenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Verloren", DbType="Int")]
		public System.Nullable<int> Verloren
		{
			get
			{
				return this._Verloren;
			}
			set
			{
				if ((this._Verloren != value))
				{
					this.OnVerlorenChanging(value);
					this.SendPropertyChanging();
					this._Verloren = value;
					this.SendPropertyChanged("Verloren");
					this.OnVerlorenChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PlayerLobby")]
	public partial class PlayerLobby : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LobbyId;
		
		private int _PlayerId;
		
		private string _HostPlayer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLobbyIdChanging(int value);
    partial void OnLobbyIdChanged();
    partial void OnPlayerIdChanging(int value);
    partial void OnPlayerIdChanged();
    partial void OnHostPlayerChanging(string value);
    partial void OnHostPlayerChanged();
    #endregion
		
		public PlayerLobby()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LobbyId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LobbyId
		{
			get
			{
				return this._LobbyId;
			}
			set
			{
				if ((this._LobbyId != value))
				{
					this.OnLobbyIdChanging(value);
					this.SendPropertyChanging();
					this._LobbyId = value;
					this.SendPropertyChanged("LobbyId");
					this.OnLobbyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="Int NOT NULL")]
		public int PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HostPlayer", DbType="NChar(10)")]
		public string HostPlayer
		{
			get
			{
				return this._HostPlayer;
			}
			set
			{
				if ((this._HostPlayer != value))
				{
					this.OnHostPlayerChanging(value);
					this.SendPropertyChanging();
					this._HostPlayer = value;
					this.SendPropertyChanged("HostPlayer");
					this.OnHostPlayerChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591