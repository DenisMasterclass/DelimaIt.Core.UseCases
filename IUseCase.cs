using DelimaIt.Core.UseCases.Outputs;
using System.Threading;
using System.Threading.Tasks;

namespace DelimaIt.Core.UseCases
{
    public interface IUseCase<in TInput,TOutput> where TInput : notnull,IRequest<TOutput> where TOutput : notnull
    {
        Task<Output<TOutput>> ExecuteAsync(TInput request,CancellationToken cancellationToken);
    }
}
