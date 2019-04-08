using Capgemini.Xrm.Audit.Core.Interfaces;
using Capgemini.Xrm.Audit.Core.Loggers;
using Capgemini.Xrm.Audit.DataAccess.Repos;
using Capgemini.Xrm.Audit.Reports;
using Capgemini.Xrm.Audit.Reports.Generators;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Xrm.SolutionAudit.Console
{
    class Program
    {
        private static readonly string _downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        private static string _crmConnectionString;
        private static ILogger _logger;

        static void Main(string[] args)
        {
            var _logger = new ConsoleLogger();
            var repository = new SolutionRepository(new CrmServiceClient(CrmConnectionString), _logger);
            var solutionAuditor = new CrmAuditor(repository, _logger);
            var publisherFilter = new List<string> { "Dynamics 365" };

            var crmInstance = solutionAuditor.AuditCrmInstance(InstanceName, publisherFilter);

            var excelReport = new ExcelReport(_downloadsPath);
            excelReport.SaveSolutionAudit(crmInstance);

            var xmlReport = new XmlReport(_downloadsPath);
            xmlReport.SaveSolutionAudit(crmInstance);

            var htmlReport = new HtmlReport(_downloadsPath);
            htmlReport.SaveSolutionAudit(crmInstance);

            var jsonReport = new JsonReport(_downloadsPath);
            jsonReport.SaveSolutionAudit(crmInstance);
        }

        private static string CrmConnectionString
        {
            get
            {
                return _crmConnectionString = _crmConnectionString ??
                                              ConfigurationManager.ConnectionStrings["Crm"].ConnectionString;
            }
        }

        protected static string InstanceName
        {
            get
            {
                var stringArray = CrmConnectionString.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                var firstItem = stringArray.First(x => x.ToLower().Trim().StartsWith("url="));
                var instanceName = firstItem.ToLower().Trim().Replace("url=", "").Replace("https://", "");
                return instanceName;
            }
        }
    }
}
