using MediatR;

namespace ATSProServer.Application.Messaging
{
    public interface ICommand <out TResponse>: IRequest<TResponse>
    {
    }
}
