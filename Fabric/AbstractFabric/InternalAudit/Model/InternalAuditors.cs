using Fabric.AbstractFabric.Common.Interfaces;

namespace Fabric.AbstractFabric.InternalAudit.Model
{
    internal class InternalAuditors : IAuditors
    {
        public string DisplayAuditor()
        {
            return "Internal auditor";
        }
    }
}