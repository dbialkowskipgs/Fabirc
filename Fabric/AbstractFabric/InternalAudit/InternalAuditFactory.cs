using Fabric.AbstractFabric.Common;
using Fabric.AbstractFabric.Common.Interfaces;
using Fabric.AbstractFabric.InternalAudit.Model;

namespace Fabric.AbstractFabric.InternalAudit
{
    internal class InternalAuditFactory : AuditFactory
    {
        public override IAuditType CreateAuditType()
        {
            return new Model.InternalAudit();
        }

        public override IAuditors AssignsAuditors()
        {
            return new InternalAuditors();
        }
    }
}