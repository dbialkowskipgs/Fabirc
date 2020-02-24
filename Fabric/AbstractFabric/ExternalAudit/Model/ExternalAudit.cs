using Fabric.AbstractFabric.Common.Interfaces;

namespace Fabric.AbstractFabric.ExternalAudit.Model
{
    internal class ExternalAudit : IAuditType
    {
        public string DisplayAuditType()
        {
            return "External audit";
        }
    }
}