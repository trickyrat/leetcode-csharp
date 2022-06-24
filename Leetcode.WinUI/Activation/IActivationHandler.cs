using System.Threading.Tasks;

namespace Leetcode.WinUI.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
