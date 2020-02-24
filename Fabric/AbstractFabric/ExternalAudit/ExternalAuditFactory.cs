using Fabric.AbstractFabric.Common;
using Fabric.AbstractFabric.Common.Interfaces;
using Fabric.AbstractFabric.ExternalAudit.Model;

namespace Fabric.AbstractFabric.ExternalAudit
{
    internal class ExternalAuditFactory : AuditFactory
    {
        public override IAuditType CreateAuditType()
        {
            return new Model.ExternalAudit();
        }

        public override IAuditors AssignsAuditors()
        {
            return new ExternalAuditors();
        }
    }
}