﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDemo2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 HelloWorldResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebDemo2.ServiceReference1.HelloWorldResponse HelloWorld(WebDemo2.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebDemo2.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebDemo2.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 sql 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getall", ReplyAction="*")]
        WebDemo2.ServiceReference1.getallResponse getall(WebDemo2.ServiceReference1.getallRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getall", ReplyAction="*")]
        System.Threading.Tasks.Task<WebDemo2.ServiceReference1.getallResponse> getallAsync(WebDemo2.ServiceReference1.getallRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebDemo2.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebDemo2.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebDemo2.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebDemo2.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getallRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getall", Namespace="http://tempuri.org/", Order=0)]
        public WebDemo2.ServiceReference1.getallRequestBody Body;
        
        public getallRequest() {
        }
        
        public getallRequest(WebDemo2.ServiceReference1.getallRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getallRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sql;
        
        public getallRequestBody() {
        }
        
        public getallRequestBody(string sql) {
            this.sql = sql;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getallResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getallResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebDemo2.ServiceReference1.getallResponseBody Body;
        
        public getallResponse() {
        }
        
        public getallResponse(WebDemo2.ServiceReference1.getallResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getallResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getallResult;
        
        public getallResponseBody() {
        }
        
        public getallResponseBody(string getallResult) {
            this.getallResult = getallResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebDemo2.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebDemo2.ServiceReference1.WebService1Soap>, WebDemo2.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebDemo2.ServiceReference1.HelloWorldResponse WebDemo2.ServiceReference1.WebService1Soap.HelloWorld(WebDemo2.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebDemo2.ServiceReference1.HelloWorldRequest inValue = new WebDemo2.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebDemo2.ServiceReference1.HelloWorldRequestBody();
            WebDemo2.ServiceReference1.HelloWorldResponse retVal = ((WebDemo2.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebDemo2.ServiceReference1.HelloWorldResponse> WebDemo2.ServiceReference1.WebService1Soap.HelloWorldAsync(WebDemo2.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebDemo2.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WebDemo2.ServiceReference1.HelloWorldRequest inValue = new WebDemo2.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebDemo2.ServiceReference1.HelloWorldRequestBody();
            return ((WebDemo2.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebDemo2.ServiceReference1.getallResponse WebDemo2.ServiceReference1.WebService1Soap.getall(WebDemo2.ServiceReference1.getallRequest request) {
            return base.Channel.getall(request);
        }
        
        public string getall(string sql) {
            WebDemo2.ServiceReference1.getallRequest inValue = new WebDemo2.ServiceReference1.getallRequest();
            inValue.Body = new WebDemo2.ServiceReference1.getallRequestBody();
            inValue.Body.sql = sql;
            WebDemo2.ServiceReference1.getallResponse retVal = ((WebDemo2.ServiceReference1.WebService1Soap)(this)).getall(inValue);
            return retVal.Body.getallResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebDemo2.ServiceReference1.getallResponse> WebDemo2.ServiceReference1.WebService1Soap.getallAsync(WebDemo2.ServiceReference1.getallRequest request) {
            return base.Channel.getallAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebDemo2.ServiceReference1.getallResponse> getallAsync(string sql) {
            WebDemo2.ServiceReference1.getallRequest inValue = new WebDemo2.ServiceReference1.getallRequest();
            inValue.Body = new WebDemo2.ServiceReference1.getallRequestBody();
            inValue.Body.sql = sql;
            return ((WebDemo2.ServiceReference1.WebService1Soap)(this)).getallAsync(inValue);
        }
    }
}