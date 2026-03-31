using Microsoft.AspNetCore.Mvc;
using OpenShock.Common.Problems;

namespace OpenShock.Common;

public class OpenShockControllerBase : ControllerBase
{
    [NonAction]
    public ObjectResult Problem(OpenShockProblem problem) => problem.ToObjectResult(HttpContext);
}
