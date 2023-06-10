using Microsoft.AspNetCore.Mvc;
using Shop.Repositories.Interfaces;

namespace Shop.Controllers
{
    public class RankController : Controller
    {
        private readonly IRankRepository RankRepository;

        public RankController(IRankRepository RankRepository)
        {
            this.RankRepository = RankRepository;
        }

        public ViewResult List()
        {
            var Ranks = RankRepository.Ranks;
            return View(Ranks);
        }
    }
}
