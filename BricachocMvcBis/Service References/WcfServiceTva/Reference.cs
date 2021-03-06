﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.0
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BricachocMvcBis.WcfServiceTva {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServiceTva.IServiceTva")]
    public interface IServiceTva {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/ChargerLesTvas", ReplyAction="http://tempuri.org/IServiceTva/ChargerLesTvasResponse")]
        BricachocBo.Tva[] ChargerLesTvas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/ChargerLesTvas", ReplyAction="http://tempuri.org/IServiceTva/ChargerLesTvasResponse")]
        System.Threading.Tasks.Task<BricachocBo.Tva[]> ChargerLesTvasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/CreerTva", ReplyAction="http://tempuri.org/IServiceTva/CreerTvaResponse")]
        void CreerTva(BricachocBo.Tva t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/CreerTva", ReplyAction="http://tempuri.org/IServiceTva/CreerTvaResponse")]
        System.Threading.Tasks.Task CreerTvaAsync(BricachocBo.Tva t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/MettreAJourTva", ReplyAction="http://tempuri.org/IServiceTva/MettreAJourTvaResponse")]
        void MettreAJourTva(BricachocBo.Tva t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/MettreAJourTva", ReplyAction="http://tempuri.org/IServiceTva/MettreAJourTvaResponse")]
        System.Threading.Tasks.Task MettreAJourTvaAsync(BricachocBo.Tva t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/Supprimer", ReplyAction="http://tempuri.org/IServiceTva/SupprimerResponse")]
        void Supprimer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/Supprimer", ReplyAction="http://tempuri.org/IServiceTva/SupprimerResponse")]
        System.Threading.Tasks.Task SupprimerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/RechercherTva", ReplyAction="http://tempuri.org/IServiceTva/RechercherTvaResponse")]
        BricachocBo.Tva RechercherTva(int code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTva/RechercherTva", ReplyAction="http://tempuri.org/IServiceTva/RechercherTvaResponse")]
        System.Threading.Tasks.Task<BricachocBo.Tva> RechercherTvaAsync(int code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceTvaChannel : BricachocMvcBis.WcfServiceTva.IServiceTva, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceTvaClient : System.ServiceModel.ClientBase<BricachocMvcBis.WcfServiceTva.IServiceTva>, BricachocMvcBis.WcfServiceTva.IServiceTva {
        
        public ServiceTvaClient() {
        }
        
        public ServiceTvaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceTvaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTvaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTvaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BricachocBo.Tva[] ChargerLesTvas() {
            return base.Channel.ChargerLesTvas();
        }
        
        public System.Threading.Tasks.Task<BricachocBo.Tva[]> ChargerLesTvasAsync() {
            return base.Channel.ChargerLesTvasAsync();
        }
        
        public void CreerTva(BricachocBo.Tva t) {
            base.Channel.CreerTva(t);
        }
        
        public System.Threading.Tasks.Task CreerTvaAsync(BricachocBo.Tva t) {
            return base.Channel.CreerTvaAsync(t);
        }
        
        public void MettreAJourTva(BricachocBo.Tva t) {
            base.Channel.MettreAJourTva(t);
        }
        
        public System.Threading.Tasks.Task MettreAJourTvaAsync(BricachocBo.Tva t) {
            return base.Channel.MettreAJourTvaAsync(t);
        }
        
        public void Supprimer(int id) {
            base.Channel.Supprimer(id);
        }
        
        public System.Threading.Tasks.Task SupprimerAsync(int id) {
            return base.Channel.SupprimerAsync(id);
        }
        
        public BricachocBo.Tva RechercherTva(int code) {
            return base.Channel.RechercherTva(code);
        }
        
        public System.Threading.Tasks.Task<BricachocBo.Tva> RechercherTvaAsync(int code) {
            return base.Channel.RechercherTvaAsync(code);
        }
    }
}
