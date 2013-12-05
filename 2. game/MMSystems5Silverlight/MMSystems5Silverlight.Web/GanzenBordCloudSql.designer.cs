﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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
    partial void InsertPlayerLobby(PlayerLobby instance);
    partial void UpdatePlayerLobby(PlayerLobby instance);
    partial void DeletePlayerLobby(PlayerLobby instance);
    partial void InsertLobby(Lobby instance);
    partial void UpdateLobby(Lobby instance);
    partial void DeleteLobby(Lobby instance);
    partial void InsertLobbi(Lobbi instance);
    partial void UpdateLobbi(Lobbi instance);
    partial void DeleteLobbi(Lobbi instance);
    partial void InsertPlayer(Player instance);
    partial void UpdatePlayer(Player instance);
    partial void DeletePlayer(Player instance);
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
		
		public System.Data.Linq.Table<PlayerLobby> PlayerLobbies
		{
			get
			{
				return this.GetTable<PlayerLobby>();
			}
		}
		
		public System.Data.Linq.Table<Lobby> Lobbies
		{
			get
			{
				return this.GetTable<Lobby>();
			}
		}
		
		public System.Data.Linq.Table<Lobbi> Lobbis
		{
			get
			{
				return this.GetTable<Lobbi>();
			}
		}
		
		public System.Data.Linq.Table<Player> Players
		{
			get
			{
				return this.GetTable<Player>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PlayerLobby")]
	public partial class PlayerLobby : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlayerId;
		
		private string _HostPlayer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlayerIdChanging(int value);
    partial void OnPlayerIdChanged();
    partial void OnHostPlayerChanging(string value);
    partial void OnHostPlayerChanged();
    #endregion
		
		public PlayerLobby()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HostPlayer", DbType="NChar(25) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lobby")]
	public partial class Lobby : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Hostplayer;
		
		private bool _CanJoinLobby;
		
		private System.Nullable<int> _AantalPlayers;
		
		private System.Nullable<int> _WhosTunrId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHostplayerChanging(string value);
    partial void OnHostplayerChanged();
    partial void OnCanJoinLobbyChanging(bool value);
    partial void OnCanJoinLobbyChanged();
    partial void OnAantalPlayersChanging(System.Nullable<int> value);
    partial void OnAantalPlayersChanged();
    partial void OnWhosTunrIdChanging(System.Nullable<int> value);
    partial void OnWhosTunrIdChanged();
    #endregion
		
		public Lobby()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hostplayer", DbType="Char(25) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Hostplayer
		{
			get
			{
				return this._Hostplayer;
			}
			set
			{
				if ((this._Hostplayer != value))
				{
					this.OnHostplayerChanging(value);
					this.SendPropertyChanging();
					this._Hostplayer = value;
					this.SendPropertyChanged("Hostplayer");
					this.OnHostplayerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanJoinLobby", DbType="Bit NOT NULL")]
		public bool CanJoinLobby
		{
			get
			{
				return this._CanJoinLobby;
			}
			set
			{
				if ((this._CanJoinLobby != value))
				{
					this.OnCanJoinLobbyChanging(value);
					this.SendPropertyChanging();
					this._CanJoinLobby = value;
					this.SendPropertyChanged("CanJoinLobby");
					this.OnCanJoinLobbyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AantalPlayers", DbType="Int")]
		public System.Nullable<int> AantalPlayers
		{
			get
			{
				return this._AantalPlayers;
			}
			set
			{
				if ((this._AantalPlayers != value))
				{
					this.OnAantalPlayersChanging(value);
					this.SendPropertyChanging();
					this._AantalPlayers = value;
					this.SendPropertyChanged("AantalPlayers");
					this.OnAantalPlayersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WhosTunrId", DbType="Int")]
		public System.Nullable<int> WhosTunrId
		{
			get
			{
				return this._WhosTunrId;
			}
			set
			{
				if ((this._WhosTunrId != value))
				{
					this.OnWhosTunrIdChanging(value);
					this.SendPropertyChanging();
					this._WhosTunrId = value;
					this.SendPropertyChanged("WhosTunrId");
					this.OnWhosTunrIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lobbi")]
	public partial class Lobbi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _HostID;
		
		private bool _CanJoinLobby;
		
		private System.Nullable<int> _AantalPlayers;
		
		private System.Nullable<int> _WhosTunrId;
		
		private System.Nullable<bool> _Start;
		
		private string _HostPlayer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHostIDChanging(int value);
    partial void OnHostIDChanged();
    partial void OnCanJoinLobbyChanging(bool value);
    partial void OnCanJoinLobbyChanged();
    partial void OnAantalPlayersChanging(System.Nullable<int> value);
    partial void OnAantalPlayersChanged();
    partial void OnWhosTunrIdChanging(System.Nullable<int> value);
    partial void OnWhosTunrIdChanged();
    partial void OnStartChanging(System.Nullable<bool> value);
    partial void OnStartChanged();
    partial void OnHostPlayerChanging(string value);
    partial void OnHostPlayerChanged();
    #endregion
		
		public Lobbi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HostID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int HostID
		{
			get
			{
				return this._HostID;
			}
			set
			{
				if ((this._HostID != value))
				{
					this.OnHostIDChanging(value);
					this.SendPropertyChanging();
					this._HostID = value;
					this.SendPropertyChanged("HostID");
					this.OnHostIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanJoinLobby", DbType="Bit NOT NULL")]
		public bool CanJoinLobby
		{
			get
			{
				return this._CanJoinLobby;
			}
			set
			{
				if ((this._CanJoinLobby != value))
				{
					this.OnCanJoinLobbyChanging(value);
					this.SendPropertyChanging();
					this._CanJoinLobby = value;
					this.SendPropertyChanged("CanJoinLobby");
					this.OnCanJoinLobbyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AantalPlayers", DbType="Int")]
		public System.Nullable<int> AantalPlayers
		{
			get
			{
				return this._AantalPlayers;
			}
			set
			{
				if ((this._AantalPlayers != value))
				{
					this.OnAantalPlayersChanging(value);
					this.SendPropertyChanging();
					this._AantalPlayers = value;
					this.SendPropertyChanged("AantalPlayers");
					this.OnAantalPlayersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WhosTunrId", DbType="Int")]
		public System.Nullable<int> WhosTunrId
		{
			get
			{
				return this._WhosTunrId;
			}
			set
			{
				if ((this._WhosTunrId != value))
				{
					this.OnWhosTunrIdChanging(value);
					this.SendPropertyChanging();
					this._WhosTunrId = value;
					this.SendPropertyChanged("WhosTunrId");
					this.OnWhosTunrIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Start", DbType="Bit")]
		public System.Nullable<bool> Start
		{
			get
			{
				return this._Start;
			}
			set
			{
				if ((this._Start != value))
				{
					this.OnStartChanging(value);
					this.SendPropertyChanging();
					this._Start = value;
					this.SendPropertyChanged("Start");
					this.OnStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HostPlayer", DbType="Char(25) NOT NULL", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Player")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlayerId;
		
		private string _PlayerNaam;
		
		private string _Wachtwoord;
		
		private int _Locatie;
		
		private System.Nullable<int> _Gewonnen;
		
		private System.Nullable<int> _Verloren;
		
		private string _Lobby;
		
		private System.Nullable<bool> _IsHost;
		
		private System.Nullable<int> _HostID;
		
		private System.Nullable<bool> _Rule_19;
		
		private System.Nullable<bool> _Rule_52;
		
		private System.Nullable<bool> _Rule_32;
		
		private System.Nullable<int> _Diced;
		
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
    partial void OnLocatieChanging(int value);
    partial void OnLocatieChanged();
    partial void OnGewonnenChanging(System.Nullable<int> value);
    partial void OnGewonnenChanged();
    partial void OnVerlorenChanging(System.Nullable<int> value);
    partial void OnVerlorenChanged();
    partial void OnLobbyChanging(string value);
    partial void OnLobbyChanged();
    partial void OnIsHostChanging(System.Nullable<bool> value);
    partial void OnIsHostChanged();
    partial void OnHostIDChanging(System.Nullable<int> value);
    partial void OnHostIDChanged();
    partial void OnRule_19Changing(System.Nullable<bool> value);
    partial void OnRule_19Changed();
    partial void OnRule_52Changing(System.Nullable<bool> value);
    partial void OnRule_52Changed();
    partial void OnRule_32Changing(System.Nullable<bool> value);
    partial void OnRule_32Changed();
    partial void OnDicedChanging(System.Nullable<int> value);
    partial void OnDicedChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerNaam", DbType="NChar(25) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Wachtwoord", DbType="NChar(25) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locatie", DbType="Int NOT NULL")]
		public int Locatie
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lobby", DbType="NChar(25)")]
		public string Lobby
		{
			get
			{
				return this._Lobby;
			}
			set
			{
				if ((this._Lobby != value))
				{
					this.OnLobbyChanging(value);
					this.SendPropertyChanging();
					this._Lobby = value;
					this.SendPropertyChanged("Lobby");
					this.OnLobbyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsHost", DbType="Bit")]
		public System.Nullable<bool> IsHost
		{
			get
			{
				return this._IsHost;
			}
			set
			{
				if ((this._IsHost != value))
				{
					this.OnIsHostChanging(value);
					this.SendPropertyChanging();
					this._IsHost = value;
					this.SendPropertyChanged("IsHost");
					this.OnIsHostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HostID", DbType="Int")]
		public System.Nullable<int> HostID
		{
			get
			{
				return this._HostID;
			}
			set
			{
				if ((this._HostID != value))
				{
					this.OnHostIDChanging(value);
					this.SendPropertyChanging();
					this._HostID = value;
					this.SendPropertyChanged("HostID");
					this.OnHostIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Rule 19]", Storage="_Rule_19", DbType="Bit")]
		public System.Nullable<bool> Rule_19
		{
			get
			{
				return this._Rule_19;
			}
			set
			{
				if ((this._Rule_19 != value))
				{
					this.OnRule_19Changing(value);
					this.SendPropertyChanging();
					this._Rule_19 = value;
					this.SendPropertyChanged("Rule_19");
					this.OnRule_19Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Rule 52]", Storage="_Rule_52", DbType="Bit")]
		public System.Nullable<bool> Rule_52
		{
			get
			{
				return this._Rule_52;
			}
			set
			{
				if ((this._Rule_52 != value))
				{
					this.OnRule_52Changing(value);
					this.SendPropertyChanging();
					this._Rule_52 = value;
					this.SendPropertyChanged("Rule_52");
					this.OnRule_52Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Rule 32]", Storage="_Rule_32", DbType="Bit")]
		public System.Nullable<bool> Rule_32
		{
			get
			{
				return this._Rule_32;
			}
			set
			{
				if ((this._Rule_32 != value))
				{
					this.OnRule_32Changing(value);
					this.SendPropertyChanging();
					this._Rule_32 = value;
					this.SendPropertyChanged("Rule_32");
					this.OnRule_32Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diced", DbType="Int")]
		public System.Nullable<int> Diced
		{
			get
			{
				return this._Diced;
			}
			set
			{
				if ((this._Diced != value))
				{
					this.OnDicedChanging(value);
					this.SendPropertyChanging();
					this._Diced = value;
					this.SendPropertyChanged("Diced");
					this.OnDicedChanged();
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
