using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/index")]
    public ActionResult Index() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/formpizza")]
    public ActionResult FormPizza() { return View(); }

    [Route("/Madlibs")]
    public ActionResult Madlibs(string name, string verb, string noun, string adjective, string noun2, string adverb)
    {
      MadlibVariables myMadlib = new MadlibVariables();
      myMadlib.Name = name;
      myMadlib.Verb = verb;
      myMadlib.Noun = noun;
      myMadlib.Adjective = adjective;
      myMadlib.Noun2 = noun2;
      myMadlib.Adverb = adverb;
      return View(myMadlib);
    }

    [Route("/MadlibsPizza")]
    public ActionResult MadlibsPizza(string person, string adjective, string place, string pluralthing, string food, string song, string pluralthing2, string feeling, string celebrity, string verb)
    {
      MadlibPizzaVariables pizzaMadlib = new MadlibPizzaVariables();
      pizzaMadlib.Person = person;
      pizzaMadlib.Adjective = adjective;
      pizzaMadlib.Place = place;
      pizzaMadlib.PluralThing = pluralthing;
      pizzaMadlib.Food = food;
      pizzaMadlib.Song = song;
      pizzaMadlib.PluralThing2 = pluralthing2;
      pizzaMadlib.Feeling = feeling;
      pizzaMadlib.Celebrity = celebrity;
      pizzaMadlib.Verb = verb;

      return View(pizzaMadlib);
    }

  }
}
