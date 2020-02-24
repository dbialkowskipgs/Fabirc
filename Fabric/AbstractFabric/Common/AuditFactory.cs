using Fabric.AbstractFabric.Common.Interfaces;

namespace Fabric.AbstractFabric.Common
{
    public abstract class AuditFactory
    {
        public abstract IAuditType CreateAuditType();

        public abstract IAuditors AssignsAuditors();
    }
}