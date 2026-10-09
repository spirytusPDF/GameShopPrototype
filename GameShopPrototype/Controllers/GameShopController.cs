using Microsoft.AspNetCore.Mvc;

namespace GameShopPrototype.Controllers
{
    public class GameShopController : Controller
    {
        private static List<GameModel> _games = new List<GameModel>()
        {
            new GameModel(1, "Twisted metal", "Racing Combat", "7.8")
        };
        public IActionResult Index()
        {
            return View(_games);
        }

        public IActionResult Details(int id)
        {
            var game = _games.First(g=>g.ID == id);
            if (game == null) throw new Exception("NO game found");
            return View(game);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GameModel game)
        {
            _games.Add(game);
            return View("Index", _games);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _games.Remove(_games.First(g=>g.ID == id));

            return View("Index", _games);
        }

        [HttpGet]
        public IActionResult Completed()
        {
            var completedGames = _games.Where(g=>g.IsCompleted ==true).ToList();
            return View(completedGames);
        }

        [HttpPost]
        public IActionResult Completed(int id)
        {
            _games.First(g => g.ID == id).IsCompleted = true;
            return View("Index", _games);
        }
    }
}
