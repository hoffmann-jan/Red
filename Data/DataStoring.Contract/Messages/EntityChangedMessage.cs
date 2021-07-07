using System;

namespace JanHoffmann.Red.Data.DataStoring.Contract.Messages
{
    public class EntityChangedMessage
    {
        public Type Type { get; set; }
        public ChangeType ChangeType { get; set; }
        public object Entity { get; set; }
    }
}
