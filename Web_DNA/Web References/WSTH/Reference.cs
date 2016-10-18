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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace BaoCao_Web.WSTH {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="THServiceSoap", Namespace="http://tempuri.org/")]
    public partial class THService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getCustomerInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback W_BillOperationCompleted;
        
        private System.Threading.SendOrPostCallback payW_BillOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkPay_BillOperationCompleted;
        
        private System.Threading.SendOrPostCallback Check_PhiDNOperationCompleted;
        
        private System.Threading.SendOrPostCallback getSearchKHOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public THService() {
            this.Url = global::BaoCao_Web.Properties.Settings.Default.BaoCao_Web_WSTH_THService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getCustomerInfoCompletedEventHandler getCustomerInfoCompleted;
        
        /// <remarks/>
        public event W_BillCompletedEventHandler W_BillCompleted;
        
        /// <remarks/>
        public event payW_BillCompletedEventHandler payW_BillCompleted;
        
        /// <remarks/>
        public event checkPay_BillCompletedEventHandler checkPay_BillCompleted;
        
        /// <remarks/>
        public event Check_PhiDNCompletedEventHandler Check_PhiDNCompleted;
        
        /// <remarks/>
        public event getSearchKHCompletedEventHandler getSearchKHCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCustomerInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getCustomerInfo(string db, string ten, string matkhau) {
            object[] results = this.Invoke("getCustomerInfo", new object[] {
                        db,
                        ten,
                        matkhau});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getCustomerInfoAsync(string db, string ten, string matkhau) {
            this.getCustomerInfoAsync(db, ten, matkhau, null);
        }
        
        /// <remarks/>
        public void getCustomerInfoAsync(string db, string ten, string matkhau, object userState) {
            if ((this.getCustomerInfoOperationCompleted == null)) {
                this.getCustomerInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCustomerInfoOperationCompleted);
            }
            this.InvokeAsync("getCustomerInfo", new object[] {
                        db,
                        ten,
                        matkhau}, this.getCustomerInfoOperationCompleted, userState);
        }
        
        private void OngetCustomerInfoOperationCompleted(object arg) {
            if ((this.getCustomerInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCustomerInfoCompleted(this, new getCustomerInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/W_Bill", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet W_Bill(string db, string ten, string matkhau) {
            object[] results = this.Invoke("W_Bill", new object[] {
                        db,
                        ten,
                        matkhau});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void W_BillAsync(string db, string ten, string matkhau) {
            this.W_BillAsync(db, ten, matkhau, null);
        }
        
        /// <remarks/>
        public void W_BillAsync(string db, string ten, string matkhau, object userState) {
            if ((this.W_BillOperationCompleted == null)) {
                this.W_BillOperationCompleted = new System.Threading.SendOrPostCallback(this.OnW_BillOperationCompleted);
            }
            this.InvokeAsync("W_Bill", new object[] {
                        db,
                        ten,
                        matkhau}, this.W_BillOperationCompleted, userState);
        }
        
        private void OnW_BillOperationCompleted(object arg) {
            if ((this.W_BillCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.W_BillCompleted(this, new W_BillCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/payW_Bill", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool payW_Bill(string id, string ten, string matkhau) {
            object[] results = this.Invoke("payW_Bill", new object[] {
                        id,
                        ten,
                        matkhau});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void payW_BillAsync(string id, string ten, string matkhau) {
            this.payW_BillAsync(id, ten, matkhau, null);
        }
        
        /// <remarks/>
        public void payW_BillAsync(string id, string ten, string matkhau, object userState) {
            if ((this.payW_BillOperationCompleted == null)) {
                this.payW_BillOperationCompleted = new System.Threading.SendOrPostCallback(this.OnpayW_BillOperationCompleted);
            }
            this.InvokeAsync("payW_Bill", new object[] {
                        id,
                        ten,
                        matkhau}, this.payW_BillOperationCompleted, userState);
        }
        
        private void OnpayW_BillOperationCompleted(object arg) {
            if ((this.payW_BillCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.payW_BillCompleted(this, new payW_BillCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkPay_Bill", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet checkPay_Bill(string id, string ten, string matkhau) {
            object[] results = this.Invoke("checkPay_Bill", new object[] {
                        id,
                        ten,
                        matkhau});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void checkPay_BillAsync(string id, string ten, string matkhau) {
            this.checkPay_BillAsync(id, ten, matkhau, null);
        }
        
        /// <remarks/>
        public void checkPay_BillAsync(string id, string ten, string matkhau, object userState) {
            if ((this.checkPay_BillOperationCompleted == null)) {
                this.checkPay_BillOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckPay_BillOperationCompleted);
            }
            this.InvokeAsync("checkPay_Bill", new object[] {
                        id,
                        ten,
                        matkhau}, this.checkPay_BillOperationCompleted, userState);
        }
        
        private void OncheckPay_BillOperationCompleted(object arg) {
            if ((this.checkPay_BillCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkPay_BillCompleted(this, new checkPay_BillCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Check_PhiDN", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Check_PhiDN(string DanhBo, out int Phi) {
            object[] results = this.Invoke("Check_PhiDN", new object[] {
                        DanhBo});
            Phi = ((int)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Check_PhiDNAsync(string DanhBo) {
            this.Check_PhiDNAsync(DanhBo, null);
        }
        
        /// <remarks/>
        public void Check_PhiDNAsync(string DanhBo, object userState) {
            if ((this.Check_PhiDNOperationCompleted == null)) {
                this.Check_PhiDNOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheck_PhiDNOperationCompleted);
            }
            this.InvokeAsync("Check_PhiDN", new object[] {
                        DanhBo}, this.Check_PhiDNOperationCompleted, userState);
        }
        
        private void OnCheck_PhiDNOperationCompleted(object arg) {
            if ((this.Check_PhiDNCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Check_PhiDNCompleted(this, new Check_PhiDNCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getSearchKH", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getSearchKH(string shs, string diachi, string madot) {
            object[] results = this.Invoke("getSearchKH", new object[] {
                        shs,
                        diachi,
                        madot});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getSearchKHAsync(string shs, string diachi, string madot) {
            this.getSearchKHAsync(shs, diachi, madot, null);
        }
        
        /// <remarks/>
        public void getSearchKHAsync(string shs, string diachi, string madot, object userState) {
            if ((this.getSearchKHOperationCompleted == null)) {
                this.getSearchKHOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetSearchKHOperationCompleted);
            }
            this.InvokeAsync("getSearchKH", new object[] {
                        shs,
                        diachi,
                        madot}, this.getSearchKHOperationCompleted, userState);
        }
        
        private void OngetSearchKHOperationCompleted(object arg) {
            if ((this.getSearchKHCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getSearchKHCompleted(this, new getSearchKHCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getCustomerInfoCompletedEventHandler(object sender, getCustomerInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCustomerInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCustomerInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void W_BillCompletedEventHandler(object sender, W_BillCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class W_BillCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal W_BillCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void payW_BillCompletedEventHandler(object sender, payW_BillCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class payW_BillCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal payW_BillCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void checkPay_BillCompletedEventHandler(object sender, checkPay_BillCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkPay_BillCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkPay_BillCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void Check_PhiDNCompletedEventHandler(object sender, Check_PhiDNCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Check_PhiDNCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Check_PhiDNCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public int Phi {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getSearchKHCompletedEventHandler(object sender, getSearchKHCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getSearchKHCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getSearchKHCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591