using System.Threading.Tasks;

namespace Miraculix.Helpers.Interfaces
{
    public interface IRefreshable
    {
        Task Refresh(object[] constructorParams);
    }
}