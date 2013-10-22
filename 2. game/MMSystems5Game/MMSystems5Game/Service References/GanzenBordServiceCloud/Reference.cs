﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace MMSystems5Game.GanzenBordServiceCloud {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/MMSystems5Silverlight.Web.DTO")]
    public partial class Player : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int GewonnenField;
        
        private int LocatieField;
        
        private int PlayerIdField;
        
        private string PlayerNaamField;
        
        private int VerlorenField;
        
        private string WachtwoordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Gewonnen {
            get {
                return this.GewonnenField;
            }
            set {
                if ((this.GewonnenField.Equals(value) != true)) {
                    this.GewonnenField = value;
                    this.RaisePropertyChanged("Gewonnen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Locatie {
            get {
                return this.LocatieField;
            }
            set {
                if ((this.LocatieField.Equals(value) != true)) {
                    this.LocatieField = value;
                    this.RaisePropertyChanged("Locatie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PlayerId {
            get {
                return this.PlayerIdField;
            }
            set {
                if ((this.PlayerIdField.Equals(value) != true)) {
                    this.PlayerIdField = value;
                    this.RaisePropertyChanged("PlayerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlayerNaam {
            get {
                return this.PlayerNaamField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayerNaamField, value) != true)) {
                    this.PlayerNaamField = value;
                    this.RaisePropertyChanged("PlayerNaam");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Verloren {
            get {
                return this.VerlorenField;
            }
            set {
                if ((this.VerlorenField.Equals(value) != true)) {
                    this.VerlorenField = value;
                    this.RaisePropertyChanged("Verloren");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Wachtwoord {
            get {
                return this.WachtwoordField;
            }
            set {
                if ((object.ReferenceEquals(this.WachtwoordField, value) != true)) {
                    this.WachtwoordField = value;
                    this.RaisePropertyChanged("Wachtwoord");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GanzenBordServiceCloud.IGanzenbordService")]
    public interface IGanzenbordService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IGanzenbordService/DoWork", ReplyAction="http://tempuri.org/IGanzenbordService/DoWorkResponse")]
        System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState);
        
        void EndDoWork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IGanzenbordService/Gooi", ReplyAction="http://tempuri.org/IGanzenbordService/GooiResponse")]
        System.IAsyncResult BeginGooi(System.AsyncCallback callback, object asyncState);
        
        int EndGooi(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IGanzenbordService/Inloggen", ReplyAction="http://tempuri.org/IGanzenbordService/InloggenResponse")]
        System.IAsyncResult BeginInloggen(string naam, string wachtwoord, System.AsyncCallback callback, object asyncState);
        
        MMSystems5Game.GanzenBordServiceCloud.Player EndInloggen(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IGanzenbordService/MaakAccount", ReplyAction="http://tempuri.org/IGanzenbordService/MaakAccountResponse")]
        System.IAsyncResult BeginMaakAccount(string PlayerNaam, string Wachtwoord, System.AsyncCallback callback, object asyncState);
        
        void EndMaakAccount(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGanzenbordServiceChannel : MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GooiCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GooiCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InloggenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public InloggenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MMSystems5Game.GanzenBordServiceCloud.Player Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MMSystems5Game.GanzenBordServiceCloud.Player)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GanzenbordServiceClient : System.ServiceModel.ClientBase<MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService>, MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService {
        
        private BeginOperationDelegate onBeginDoWorkDelegate;
        
        private EndOperationDelegate onEndDoWorkDelegate;
        
        private System.Threading.SendOrPostCallback onDoWorkCompletedDelegate;
        
        private BeginOperationDelegate onBeginGooiDelegate;
        
        private EndOperationDelegate onEndGooiDelegate;
        
        private System.Threading.SendOrPostCallback onGooiCompletedDelegate;
        
        private BeginOperationDelegate onBeginInloggenDelegate;
        
        private EndOperationDelegate onEndInloggenDelegate;
        
        private System.Threading.SendOrPostCallback onInloggenCompletedDelegate;
        
        private BeginOperationDelegate onBeginMaakAccountDelegate;
        
        private EndOperationDelegate onEndMaakAccountDelegate;
        
        private System.Threading.SendOrPostCallback onMaakAccountCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public GanzenbordServiceClient() {
        }
        
        public GanzenbordServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GanzenbordServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GanzenbordServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GanzenbordServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DoWorkCompleted;
        
        public event System.EventHandler<GooiCompletedEventArgs> GooiCompleted;
        
        public event System.EventHandler<InloggenCompletedEventArgs> InloggenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> MaakAccountCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService.BeginDoWork(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDoWork(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService.EndDoWork(System.IAsyncResult result) {
            base.Channel.EndDoWork(result);
        }
        
        private System.IAsyncResult OnBeginDoWork(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService)(this)).BeginDoWork(callback, asyncState);
        }
        
        private object[] OnEndDoWork(System.IAsyncResult result) {
            ((MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService)(this)).EndDoWork(result);
            return null;
        }
        
        private void OnDoWorkCompleted(object state) {
            if ((this.DoWorkCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DoWorkCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DoWorkAsync() {
            this.DoWorkAsync(null);
        }
        
        public void DoWorkAsync(object userState) {
            if ((this.onBeginDoWorkDelegate == null)) {
                this.onBeginDoWorkDelegate = new BeginOperationDelegate(this.OnBeginDoWork);
            }
            if ((this.onEndDoWorkDelegate == null)) {
                this.onEndDoWorkDelegate = new EndOperationDelegate(this.OnEndDoWork);
            }
            if ((this.onDoWorkCompletedDelegate == null)) {
                this.onDoWorkCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDoWorkCompleted);
            }
            base.InvokeAsync(this.onBeginDoWorkDelegate, null, this.onEndDoWorkDelegate, this.onDoWorkCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService.BeginGooi(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGooi(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService.EndGooi(System.IAsyncResult result) {
            return base.Channel.EndGooi(result);
        }
        
        private System.IAsyncResult OnBeginGooi(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService)(this)).BeginGooi(callback, asyncState);
        }
        
        private object[] OnEndGooi(System.IAsyncResult result) {
            int retVal = ((MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService)(this)).EndGooi(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGooiCompleted(object state) {
            if ((this.GooiCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GooiCompleted(this, new GooiCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GooiAsync() {
            this.GooiAsync(null);
        }
        
        public void GooiAsync(object userState) {
            if ((this.onBeginGooiDelegate == null)) {
                this.onBeginGooiDelegate = new BeginOperationDelegate(this.OnBeginGooi);
            }
            if ((this.onEndGooiDelegate == null)) {
                this.onEndGooiDelegate = new EndOperationDelegate(this.OnEndGooi);
            }
            if ((this.onGooiCompletedDelegate == null)) {
                this.onGooiCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGooiCompleted);
            }
            base.InvokeAsync(this.onBeginGooiDelegate, null, this.onEndGooiDelegate, this.onGooiCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService.BeginInloggen(string naam, string wachtwoord, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginInloggen(naam, wachtwoord, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MMSystems5Game.GanzenBordServiceCloud.Player MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService.EndInloggen(System.IAsyncResult result) {
            return base.Channel.EndInloggen(result);
        }
        
        private System.IAsyncResult OnBeginInloggen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string naam = ((string)(inValues[0]));
            string wachtwoord = ((string)(inValues[1]));
            return ((MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService)(this)).BeginInloggen(naam, wachtwoord, callback, asyncState);
        }
        
        private object[] OnEndInloggen(System.IAsyncResult result) {
            MMSystems5Game.GanzenBordServiceCloud.Player retVal = ((MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService)(this)).EndInloggen(result);
            return new object[] {
                    retVal};
        }
        
        private void OnInloggenCompleted(object state) {
            if ((this.InloggenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.InloggenCompleted(this, new InloggenCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void InloggenAsync(string naam, string wachtwoord) {
            this.InloggenAsync(naam, wachtwoord, null);
        }
        
        public void InloggenAsync(string naam, string wachtwoord, object userState) {
            if ((this.onBeginInloggenDelegate == null)) {
                this.onBeginInloggenDelegate = new BeginOperationDelegate(this.OnBeginInloggen);
            }
            if ((this.onEndInloggenDelegate == null)) {
                this.onEndInloggenDelegate = new EndOperationDelegate(this.OnEndInloggen);
            }
            if ((this.onInloggenCompletedDelegate == null)) {
                this.onInloggenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnInloggenCompleted);
            }
            base.InvokeAsync(this.onBeginInloggenDelegate, new object[] {
                        naam,
                        wachtwoord}, this.onEndInloggenDelegate, this.onInloggenCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService.BeginMaakAccount(string PlayerNaam, string Wachtwoord, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginMaakAccount(PlayerNaam, Wachtwoord, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService.EndMaakAccount(System.IAsyncResult result) {
            base.Channel.EndMaakAccount(result);
        }
        
        private System.IAsyncResult OnBeginMaakAccount(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string PlayerNaam = ((string)(inValues[0]));
            string Wachtwoord = ((string)(inValues[1]));
            return ((MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService)(this)).BeginMaakAccount(PlayerNaam, Wachtwoord, callback, asyncState);
        }
        
        private object[] OnEndMaakAccount(System.IAsyncResult result) {
            ((MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService)(this)).EndMaakAccount(result);
            return null;
        }
        
        private void OnMaakAccountCompleted(object state) {
            if ((this.MaakAccountCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.MaakAccountCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void MaakAccountAsync(string PlayerNaam, string Wachtwoord) {
            this.MaakAccountAsync(PlayerNaam, Wachtwoord, null);
        }
        
        public void MaakAccountAsync(string PlayerNaam, string Wachtwoord, object userState) {
            if ((this.onBeginMaakAccountDelegate == null)) {
                this.onBeginMaakAccountDelegate = new BeginOperationDelegate(this.OnBeginMaakAccount);
            }
            if ((this.onEndMaakAccountDelegate == null)) {
                this.onEndMaakAccountDelegate = new EndOperationDelegate(this.OnEndMaakAccount);
            }
            if ((this.onMaakAccountCompletedDelegate == null)) {
                this.onMaakAccountCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnMaakAccountCompleted);
            }
            base.InvokeAsync(this.onBeginMaakAccountDelegate, new object[] {
                        PlayerNaam,
                        Wachtwoord}, this.onEndMaakAccountDelegate, this.onMaakAccountCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService CreateChannel() {
            return new GanzenbordServiceClientChannel(this);
        }
        
        private class GanzenbordServiceClientChannel : ChannelBase<MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService>, MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService {
            
            public GanzenbordServiceClientChannel(System.ServiceModel.ClientBase<MMSystems5Game.GanzenBordServiceCloud.IGanzenbordService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("DoWork", _args, callback, asyncState);
                return _result;
            }
            
            public void EndDoWork(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("DoWork", _args, result);
            }
            
            public System.IAsyncResult BeginGooi(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("Gooi", _args, callback, asyncState);
                return _result;
            }
            
            public int EndGooi(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("Gooi", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginInloggen(string naam, string wachtwoord, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = naam;
                _args[1] = wachtwoord;
                System.IAsyncResult _result = base.BeginInvoke("Inloggen", _args, callback, asyncState);
                return _result;
            }
            
            public MMSystems5Game.GanzenBordServiceCloud.Player EndInloggen(System.IAsyncResult result) {
                object[] _args = new object[0];
                MMSystems5Game.GanzenBordServiceCloud.Player _result = ((MMSystems5Game.GanzenBordServiceCloud.Player)(base.EndInvoke("Inloggen", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginMaakAccount(string PlayerNaam, string Wachtwoord, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = PlayerNaam;
                _args[1] = Wachtwoord;
                System.IAsyncResult _result = base.BeginInvoke("MaakAccount", _args, callback, asyncState);
                return _result;
            }
            
            public void EndMaakAccount(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("MaakAccount", _args, result);
            }
        }
    }
}