using OrchardCore.Workflows.Models;
using System;
using System.Threading.Tasks;

namespace OrchardCore.Workflows.Services
{
    public interface IWorkflowFaultHandler
    {
        Task OnWorkflowFaultAsync(IWorkflowManager workflowManager,
            WorkflowExecutionContext workflowContext,
            ActivityContext activityContext,
            Exception exception);
    }
}
