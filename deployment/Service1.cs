﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://fonlow.com/WorkflowDemo", ConfigurationName="IService")]
public interface IService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://fonlow.com/WorkflowDemo/IService/GetData", ReplyAction="http://fonlow.com/WorkflowDemo/IService/GetDataResponse")]
    [return: System.ServiceModel.MessageParameterAttribute(Name="vv")]
    string GetData(string v);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://fonlow.com/WorkflowDemo/IService/GetData", ReplyAction="http://fonlow.com/WorkflowDemo/IService/GetDataResponse")]
    [return: System.ServiceModel.MessageParameterAttribute(Name="vv")]
    System.Threading.Tasks.Task<string> GetDataAsync(string v);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceChannel : IService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceClient : System.ServiceModel.ClientBase<IService>, IService
{
    
    public ServiceClient()
    {
    }
    
    public ServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string GetData(string v)
    {
        return base.Channel.GetData(v);
    }
    
    public System.Threading.Tasks.Task<string> GetDataAsync(string v)
    {
        return base.Channel.GetDataAsync(v);
    }
}