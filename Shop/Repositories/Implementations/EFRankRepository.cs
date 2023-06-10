using Shop.Models.Entities;
using Shop.Repositories.Interfaces;

namespace Shop.Repositories.Implementations
{
    public class EFRankRepository : IRankRepository
    {
        public IEnumerable<Rank> Ranks
        {
            get
            {
                return new List<Rank>
                {
                    new Rank {Name = "Vip", Description = "Замечательный ранк для начинающих..."},
                    new Rank {Name = "Vip+", Description = "Замечательный ранк для начинающих..."},
                    new Rank {Name = "MVP", Description = "Замечательный ранк для начинающих..."},
                    new Rank {Name = "MVP+", Description = "Замечательный ранк для начинающих..."},
                    new Rank {Name = "MVP++", Description = "Замечательный ранк для начинающих..."}
                };
            }
        }
    }
}
