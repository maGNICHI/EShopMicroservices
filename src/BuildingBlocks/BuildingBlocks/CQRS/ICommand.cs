using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    //doesn't return any response
    public interface ICommand : ICommand<Unit>
    {
    }
    //that means command will returning this response type
    //we can pass i request generics
    //this first abstraction
    //2st abstraction  define regular interface
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
