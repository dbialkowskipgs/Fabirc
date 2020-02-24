using Fabric.AbstractFabric.Common.Interfaces;

namespace Fabric.AbstractFabric.ExternalAudit.Model
{
    internal class ExternalAuditors : IAuditors
    {
        public string DisplayAuditor()
        {
            return "External auditor";
        }
    }
}