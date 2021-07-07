using JanHoffmann.Red.Data.DataStoring.Contract.Messages;
using JanHoffmann.Red.Logic.Domain.Audiation.Contract;

namespace JanHoffmann.Red.Logic.Business.AudiationWorkflows
{
    internal class EntityChangedAuditationWorkflow
    {
        private readonly IAuditor _auditor;

        public EntityChangedAuditationWorkflow(IAuditor auditor)
        {
            _auditor = auditor;
        }

        public void Process(EntityChangedMessage message)
        {
            _auditor.Log($"{message.Type.Name} changed: {message.ChangeType}");
        }
    }
}
