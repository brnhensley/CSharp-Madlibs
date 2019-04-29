namespace Madlibs.Models
{
  public class MadlibVariables
  {
    private string _name;
    private string _verb;
    private string _noun;
    private string _adjective;
    private string _noun2;
    private string _adverb;

    public string Name { get => _name; set => _name = value;}
    public string Verb { get => _verb; set => _verb = value;}
    public string Noun { get => _noun; set => _noun = value;}
    public string Adjective { get => _adjective; set => _adjective = value;}
    public string Noun2 { get => _noun2; set => _noun2 = value;}
    public string Adverb { get => _adverb; set => _adverb = value;}
  }

  public class MadlibPizzaVariables
  {
    private string _person;
    private string _adjective;
    private string _place;
    private string _pluralThing;
    private string _food;
    private string _song;
    private string _pluralThing2;
    private string _feeling;
    private string _celebrity;
    private string _verb;

    public string Person { get => _person; set => _person = value;}
    public string Adjective { get => _adjective; set => _adjective = value;}
    public string Place { get => _place; set => _place = value;}
    public string PluralThing { get => _pluralThing; set => _pluralThing = value;}
    public string Food { get => _food; set => _food = value;}
    public string Song { get => _song; set => _song = value;}
    public string PluralThing2 { get => _pluralThing2; set => _pluralThing2 = value;}
    public string Feeling { get => _feeling; set => _feeling = value;}
    public string Celebrity { get => _celebrity; set => _celebrity = value;}
    public string Verb { get => _verb; set => _verb = value;}
  }
}
