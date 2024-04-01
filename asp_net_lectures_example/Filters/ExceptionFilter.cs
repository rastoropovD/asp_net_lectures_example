using Microsoft.AspNetCore.Mvc.Filters;

namespace asp_net_lectures_example.Filters;


public sealed class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        throw new NotImplementedException();
    }
}



public sealed class ExceptionFilterAsync : IAsyncExceptionFilter
{
    public Task OnExceptionAsync(ExceptionContext context)
    {
        throw new NotImplementedException();
    }
}