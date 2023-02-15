using MediatR;

namespace ATSProServer.Application.Messaging
{
    public interface IQuery <out TResponse> : IRequest<TResponse>
    {
    }
}
