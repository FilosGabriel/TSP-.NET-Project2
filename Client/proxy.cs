﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelAPI
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Event", Namespace="http://schemas.datacontract.org/2004/07/ModelAPI", IsReference=true)]
    public partial class Event : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid EventIdField;
        
        private ModelAPI.Media MediaField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid EventId
        {
            get
            {
                return this.EventIdField;
            }
            set
            {
                this.EventIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ModelAPI.Media Media
        {
            get
            {
                return this.MediaField;
            }
            set
            {
                this.MediaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Media", Namespace="http://schemas.datacontract.org/2004/07/ModelAPI", IsReference=true)]
    public partial class Media : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DateOfCreationField;
        
        private bool DeletedField;
        
        private string DescriptionField;
        
        private ModelAPI.Event[] EventField;
        
        private string FormatField;
        
        private string FullPathField;
        
        private System.Guid MediaIdField;
        
        private string NameField;
        
        private ModelAPI.People[] PeopleField;
        
        private ModelAPI.Place[] PlaceField;
        
        private ModelAPI.Tag[] TagField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfCreation
        {
            get
            {
                return this.DateOfCreationField;
            }
            set
            {
                this.DateOfCreationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ModelAPI.Event[] Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Format
        {
            get
            {
                return this.FormatField;
            }
            set
            {
                this.FormatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullPath
        {
            get
            {
                return this.FullPathField;
            }
            set
            {
                this.FullPathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid MediaId
        {
            get
            {
                return this.MediaIdField;
            }
            set
            {
                this.MediaIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ModelAPI.People[] People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ModelAPI.Place[] Place
        {
            get
            {
                return this.PlaceField;
            }
            set
            {
                this.PlaceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ModelAPI.Tag[] Tag
        {
            get
            {
                return this.TagField;
            }
            set
            {
                this.TagField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="People", Namespace="http://schemas.datacontract.org/2004/07/ModelAPI", IsReference=true)]
    public partial class People : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private ModelAPI.Media[] MediaField;
        
        private string NameField;
        
        private System.Guid PeopleIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ModelAPI.Media[] Media
        {
            get
            {
                return this.MediaField;
            }
            set
            {
                this.MediaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid PeopleId
        {
            get
            {
                return this.PeopleIdField;
            }
            set
            {
                this.PeopleIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Place", Namespace="http://schemas.datacontract.org/2004/07/ModelAPI", IsReference=true)]
    public partial class Place : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private ModelAPI.Media MediaField;
        
        private string NameField;
        
        private System.Guid PlaceIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ModelAPI.Media Media
        {
            get
            {
                return this.MediaField;
            }
            set
            {
                this.MediaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid PlaceId
        {
            get
            {
                return this.PlaceIdField;
            }
            set
            {
                this.PlaceIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tag", Namespace="http://schemas.datacontract.org/2004/07/ModelAPI", IsReference=true)]
    public partial class Tag : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private ModelAPI.Media MediaField;
        
        private string NameField;
        
        private System.Guid TagIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ModelAPI.Media Media
        {
            get
            {
                return this.MediaField;
            }
            set
            {
                this.MediaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid TagId
        {
            get
            {
                return this.TagIdField;
            }
            set
            {
                this.TagIdField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IWcf")]
public interface IWcf
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/GetByIdEvent", ReplyAction="http://tempuri.org/IEventWCF/GetByIdEventResponse")]
    ModelAPI.Event GetByIdEvent(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/GetByIdEvent", ReplyAction="http://tempuri.org/IEventWCF/GetByIdEventResponse")]
    System.Threading.Tasks.Task<ModelAPI.Event> GetByIdEventAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/GetAllEvent", ReplyAction="http://tempuri.org/IEventWCF/GetAllEventResponse")]
    ModelAPI.Event[] GetAllEvent();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/GetAllEvent", ReplyAction="http://tempuri.org/IEventWCF/GetAllEventResponse")]
    System.Threading.Tasks.Task<ModelAPI.Event[]> GetAllEventAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/InsertEvent", ReplyAction="http://tempuri.org/IEventWCF/InsertEventResponse")]
    void InsertEvent(ModelAPI.Event iEvent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/InsertEvent", ReplyAction="http://tempuri.org/IEventWCF/InsertEventResponse")]
    System.Threading.Tasks.Task InsertEventAsync(ModelAPI.Event iEvent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/UpdateEvent", ReplyAction="http://tempuri.org/IEventWCF/UpdateEventResponse")]
    void UpdateEvent(ModelAPI.Event iEvent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/UpdateEvent", ReplyAction="http://tempuri.org/IEventWCF/UpdateEventResponse")]
    System.Threading.Tasks.Task UpdateEventAsync(ModelAPI.Event iEvent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/DeleteEvent", ReplyAction="http://tempuri.org/IEventWCF/DeleteEventResponse")]
    void DeleteEvent(ModelAPI.Event iEvent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventWCF/DeleteEvent", ReplyAction="http://tempuri.org/IEventWCF/DeleteEventResponse")]
    System.Threading.Tasks.Task DeleteEventAsync(ModelAPI.Event iEvent);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/GetByIdMedia", ReplyAction="http://tempuri.org/IMediatWCF/GetByIdMediaResponse")]
    ModelAPI.Media GetByIdMedia(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/GetByIdMedia", ReplyAction="http://tempuri.org/IMediatWCF/GetByIdMediaResponse")]
    System.Threading.Tasks.Task<ModelAPI.Media> GetByIdMediaAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/GetAllMedia", ReplyAction="http://tempuri.org/IMediatWCF/GetAllMediaResponse")]
    ModelAPI.Media[] GetAllMedia();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/GetAllMedia", ReplyAction="http://tempuri.org/IMediatWCF/GetAllMediaResponse")]
    System.Threading.Tasks.Task<ModelAPI.Media[]> GetAllMediaAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/GetAllNotDeletedMedia", ReplyAction="http://tempuri.org/IMediatWCF/GetAllNotDeletedMediaResponse")]
    ModelAPI.Media[] GetAllNotDeletedMedia();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/GetAllNotDeletedMedia", ReplyAction="http://tempuri.org/IMediatWCF/GetAllNotDeletedMediaResponse")]
    System.Threading.Tasks.Task<ModelAPI.Media[]> GetAllNotDeletedMediaAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/FindByContentTypeMedia", ReplyAction="http://tempuri.org/IMediatWCF/FindByContentTypeMediaResponse")]
    ModelAPI.Media[] FindByContentTypeMedia(string searchI, string type);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/FindByContentTypeMedia", ReplyAction="http://tempuri.org/IMediatWCF/FindByContentTypeMediaResponse")]
    System.Threading.Tasks.Task<ModelAPI.Media[]> FindByContentTypeMediaAsync(string searchI, string type);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/InsertMedia", ReplyAction="http://tempuri.org/IMediatWCF/InsertMediaResponse")]
    void InsertMedia(ModelAPI.Media media);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/InsertMedia", ReplyAction="http://tempuri.org/IMediatWCF/InsertMediaResponse")]
    System.Threading.Tasks.Task InsertMediaAsync(ModelAPI.Media media);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/UpdateMedia", ReplyAction="http://tempuri.org/IMediatWCF/UpdateMediaResponse")]
    void UpdateMedia(ModelAPI.Media media);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/UpdateMedia", ReplyAction="http://tempuri.org/IMediatWCF/UpdateMediaResponse")]
    System.Threading.Tasks.Task UpdateMediaAsync(ModelAPI.Media media);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/DeleteMedia", ReplyAction="http://tempuri.org/IMediatWCF/DeleteMediaResponse")]
    void DeleteMedia(ModelAPI.Media media);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMediatWCF/DeleteMedia", ReplyAction="http://tempuri.org/IMediatWCF/DeleteMediaResponse")]
    System.Threading.Tasks.Task DeleteMediaAsync(ModelAPI.Media media);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/GetByIdPeople", ReplyAction="http://tempuri.org/IPersonWCF/GetByIdPeopleResponse")]
    ModelAPI.People GetByIdPeople(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/GetByIdPeople", ReplyAction="http://tempuri.org/IPersonWCF/GetByIdPeopleResponse")]
    System.Threading.Tasks.Task<ModelAPI.People> GetByIdPeopleAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/GetAllPeople", ReplyAction="http://tempuri.org/IPersonWCF/GetAllPeopleResponse")]
    ModelAPI.People[] GetAllPeople();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/GetAllPeople", ReplyAction="http://tempuri.org/IPersonWCF/GetAllPeopleResponse")]
    System.Threading.Tasks.Task<ModelAPI.People[]> GetAllPeopleAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/InsertPeople", ReplyAction="http://tempuri.org/IPersonWCF/InsertPeopleResponse")]
    void InsertPeople(ModelAPI.People people);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/InsertPeople", ReplyAction="http://tempuri.org/IPersonWCF/InsertPeopleResponse")]
    System.Threading.Tasks.Task InsertPeopleAsync(ModelAPI.People people);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/UpdatePeople", ReplyAction="http://tempuri.org/IPersonWCF/UpdatePeopleResponse")]
    void UpdatePeople(ModelAPI.People people);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/UpdatePeople", ReplyAction="http://tempuri.org/IPersonWCF/UpdatePeopleResponse")]
    System.Threading.Tasks.Task UpdatePeopleAsync(ModelAPI.People people);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/DeletePeople", ReplyAction="http://tempuri.org/IPersonWCF/DeletePeopleResponse")]
    void DeletePeople(ModelAPI.People people);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWCF/DeletePeople", ReplyAction="http://tempuri.org/IPersonWCF/DeletePeopleResponse")]
    System.Threading.Tasks.Task DeletePeopleAsync(ModelAPI.People people);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/GetByIdTag", ReplyAction="http://tempuri.org/ITagWCF/GetByIdTagResponse")]
    ModelAPI.Tag GetByIdTag(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/GetByIdTag", ReplyAction="http://tempuri.org/ITagWCF/GetByIdTagResponse")]
    System.Threading.Tasks.Task<ModelAPI.Tag> GetByIdTagAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/GetAllTag", ReplyAction="http://tempuri.org/ITagWCF/GetAllTagResponse")]
    ModelAPI.Tag[] GetAllTag();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/GetAllTag", ReplyAction="http://tempuri.org/ITagWCF/GetAllTagResponse")]
    System.Threading.Tasks.Task<ModelAPI.Tag[]> GetAllTagAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/InsertTag", ReplyAction="http://tempuri.org/ITagWCF/InsertTagResponse")]
    void InsertTag(ModelAPI.Tag tag);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/InsertTag", ReplyAction="http://tempuri.org/ITagWCF/InsertTagResponse")]
    System.Threading.Tasks.Task InsertTagAsync(ModelAPI.Tag tag);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/UpdateTag", ReplyAction="http://tempuri.org/ITagWCF/UpdateTagResponse")]
    void UpdateTag(ModelAPI.Tag tag);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/UpdateTag", ReplyAction="http://tempuri.org/ITagWCF/UpdateTagResponse")]
    System.Threading.Tasks.Task UpdateTagAsync(ModelAPI.Tag tag);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/DeleteTag", ReplyAction="http://tempuri.org/ITagWCF/DeleteTagResponse")]
    void DeleteTag(ModelAPI.Tag tag);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagWCF/DeleteTag", ReplyAction="http://tempuri.org/ITagWCF/DeleteTagResponse")]
    System.Threading.Tasks.Task DeleteTagAsync(ModelAPI.Tag tag);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IWcfChannel : IWcf, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class WcfClient : System.ServiceModel.ClientBase<IWcf>, IWcf
{
    
    public WcfClient()
    {
    }
    
    public WcfClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public WcfClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WcfClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WcfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public ModelAPI.Event GetByIdEvent(System.Guid id)
    {
        return base.Channel.GetByIdEvent(id);
    }
    
    public System.Threading.Tasks.Task<ModelAPI.Event> GetByIdEventAsync(System.Guid id)
    {
        return base.Channel.GetByIdEventAsync(id);
    }
    
    public ModelAPI.Event[] GetAllEvent()
    {
        return base.Channel.GetAllEvent();
    }
    
    public System.Threading.Tasks.Task<ModelAPI.Event[]> GetAllEventAsync()
    {
        return base.Channel.GetAllEventAsync();
    }
    
    public void InsertEvent(ModelAPI.Event iEvent)
    {
        base.Channel.InsertEvent(iEvent);
    }
    
    public System.Threading.Tasks.Task InsertEventAsync(ModelAPI.Event iEvent)
    {
        return base.Channel.InsertEventAsync(iEvent);
    }
    
    public void UpdateEvent(ModelAPI.Event iEvent)
    {
        base.Channel.UpdateEvent(iEvent);
    }
    
    public System.Threading.Tasks.Task UpdateEventAsync(ModelAPI.Event iEvent)
    {
        return base.Channel.UpdateEventAsync(iEvent);
    }
    
    public void DeleteEvent(ModelAPI.Event iEvent)
    {
        base.Channel.DeleteEvent(iEvent);
    }
    
    public System.Threading.Tasks.Task DeleteEventAsync(ModelAPI.Event iEvent)
    {
        return base.Channel.DeleteEventAsync(iEvent);
    }
    
    public ModelAPI.Media GetByIdMedia(System.Guid id)
    {
        return base.Channel.GetByIdMedia(id);
    }
    
    public System.Threading.Tasks.Task<ModelAPI.Media> GetByIdMediaAsync(System.Guid id)
    {
        return base.Channel.GetByIdMediaAsync(id);
    }
    
    public ModelAPI.Media[] GetAllMedia()
    {
        return base.Channel.GetAllMedia();
    }
    
    public System.Threading.Tasks.Task<ModelAPI.Media[]> GetAllMediaAsync()
    {
        return base.Channel.GetAllMediaAsync();
    }
    
    public ModelAPI.Media[] GetAllNotDeletedMedia()
    {
        return base.Channel.GetAllNotDeletedMedia();
    }
    
    public System.Threading.Tasks.Task<ModelAPI.Media[]> GetAllNotDeletedMediaAsync()
    {
        return base.Channel.GetAllNotDeletedMediaAsync();
    }
    
    public ModelAPI.Media[] FindByContentTypeMedia(string searchI, string type)
    {
        return base.Channel.FindByContentTypeMedia(searchI, type);
    }
    
    public System.Threading.Tasks.Task<ModelAPI.Media[]> FindByContentTypeMediaAsync(string searchI, string type)
    {
        return base.Channel.FindByContentTypeMediaAsync(searchI, type);
    }
    
    public void InsertMedia(ModelAPI.Media media)
    {
        base.Channel.InsertMedia(media);
    }
    
    public System.Threading.Tasks.Task InsertMediaAsync(ModelAPI.Media media)
    {
        return base.Channel.InsertMediaAsync(media);
    }
    
    public void UpdateMedia(ModelAPI.Media media)
    {
        base.Channel.UpdateMedia(media);
    }
    
    public System.Threading.Tasks.Task UpdateMediaAsync(ModelAPI.Media media)
    {
        return base.Channel.UpdateMediaAsync(media);
    }
    
    public void DeleteMedia(ModelAPI.Media media)
    {
        base.Channel.DeleteMedia(media);
    }
    
    public System.Threading.Tasks.Task DeleteMediaAsync(ModelAPI.Media media)
    {
        return base.Channel.DeleteMediaAsync(media);
    }
    
    public ModelAPI.People GetByIdPeople(System.Guid id)
    {
        return base.Channel.GetByIdPeople(id);
    }
    
    public System.Threading.Tasks.Task<ModelAPI.People> GetByIdPeopleAsync(System.Guid id)
    {
        return base.Channel.GetByIdPeopleAsync(id);
    }
    
    public ModelAPI.People[] GetAllPeople()
    {
        return base.Channel.GetAllPeople();
    }
    
    public System.Threading.Tasks.Task<ModelAPI.People[]> GetAllPeopleAsync()
    {
        return base.Channel.GetAllPeopleAsync();
    }
    
    public void InsertPeople(ModelAPI.People people)
    {
        base.Channel.InsertPeople(people);
    }
    
    public System.Threading.Tasks.Task InsertPeopleAsync(ModelAPI.People people)
    {
        return base.Channel.InsertPeopleAsync(people);
    }
    
    public void UpdatePeople(ModelAPI.People people)
    {
        base.Channel.UpdatePeople(people);
    }
    
    public System.Threading.Tasks.Task UpdatePeopleAsync(ModelAPI.People people)
    {
        return base.Channel.UpdatePeopleAsync(people);
    }
    
    public void DeletePeople(ModelAPI.People people)
    {
        base.Channel.DeletePeople(people);
    }
    
    public System.Threading.Tasks.Task DeletePeopleAsync(ModelAPI.People people)
    {
        return base.Channel.DeletePeopleAsync(people);
    }
    
    public ModelAPI.Tag GetByIdTag(System.Guid id)
    {
        return base.Channel.GetByIdTag(id);
    }
    
    public System.Threading.Tasks.Task<ModelAPI.Tag> GetByIdTagAsync(System.Guid id)
    {
        return base.Channel.GetByIdTagAsync(id);
    }
    
    public ModelAPI.Tag[] GetAllTag()
    {
        return base.Channel.GetAllTag();
    }
    
    public System.Threading.Tasks.Task<ModelAPI.Tag[]> GetAllTagAsync()
    {
        return base.Channel.GetAllTagAsync();
    }
    
    public void InsertTag(ModelAPI.Tag tag)
    {
        base.Channel.InsertTag(tag);
    }
    
    public System.Threading.Tasks.Task InsertTagAsync(ModelAPI.Tag tag)
    {
        return base.Channel.InsertTagAsync(tag);
    }
    
    public void UpdateTag(ModelAPI.Tag tag)
    {
        base.Channel.UpdateTag(tag);
    }
    
    public System.Threading.Tasks.Task UpdateTagAsync(ModelAPI.Tag tag)
    {
        return base.Channel.UpdateTagAsync(tag);
    }
    
    public void DeleteTag(ModelAPI.Tag tag)
    {
        base.Channel.DeleteTag(tag);
    }
    
    public System.Threading.Tasks.Task DeleteTagAsync(ModelAPI.Tag tag)
    {
        return base.Channel.DeleteTagAsync(tag);
    }
}
