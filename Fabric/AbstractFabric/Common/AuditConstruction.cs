using System;

namespace Fabric.AbstractFabric.Common
{
    public class AuditConstruction
    {
        private AuditFactory _auditFactory;

        public AuditConstruction(AuditFactory auditFactory)
        {
            _auditFactory = auditFactory;
        }

        public void MakeAudit()
        {
            var auditType = _auditFactory.CreateAuditType();
            var auditors = _auditFactory.AssignsAuditors();

            Console.WriteLine("Audit type: {0}", auditType.DisplayAuditType());
            Console.WriteLine("Auditors: {0}", auditors.DisplayAuditor());
            Console.WriteLine(Environment.NewLine);
        }
    }
}