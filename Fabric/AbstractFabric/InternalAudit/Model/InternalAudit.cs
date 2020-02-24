using Fabric.AbstractFabric.Common.Interfaces;

namespace Fabric.AbstractFabric.InternalAudit.Model
{
    internal class InternalAudit : IAuditType
    {
        public string DisplayAuditType()
        {
            return "Internal audit";
        }
    }
}