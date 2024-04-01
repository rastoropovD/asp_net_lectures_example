using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace asp_net_lectures_example.Filters;

public sealed class ResultFilter : IResultFilter
{
    public void OnResultExecuting(ResultExecutingContext context)
    {
        throw new NotImplementedException();
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        throw new NotImplementedException();
    }
}


public sealed class ResultFilterAsync : IAsyncResultFilter
{
    public Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        throw new NotImplementedException();
    }
}