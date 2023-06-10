using Shop.Models.Entities;

namespace Shop.Repositories.Interfaces
{
    public interface IRankRepository
    {

        IEnumerable<Rank> Ranks { get; }
    }
}
