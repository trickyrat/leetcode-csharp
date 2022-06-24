using System.Threading.Tasks;

namespace Leetcode.WinUI.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
