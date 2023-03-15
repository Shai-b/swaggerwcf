using System.Runtime.Serialization;
using SwaggerWcf.Attributes;

namespace SwaggerWcf.Test.Service.Data
{
    [DataContract]
    [SwaggerWcfDefinition("author")]
    public class Author
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        [SwaggerWcfProperty(IsNullable = true)]
        public string Name { get; set; }

        [DataMember]
        public Priority[] Priorities { get; set; }
    }

    public enum Priority
    {
        High,
        Low
    }

}
