using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Do you believe in magic?");
Console.WriteLine("------------------------");
// printing simple introduction on landing page

List<Spell> allSpells = GetAllSpells();
SpellBook goodBook = MakeGoodSpellBook(allSpells);
SpellBook evilBook = MakeEvilSpellBook(allSpells);
// GetAllSpells returns list of spells
// MakeGoodSpellBook returns a list of the good spells
// MakeEvilSpellBook returns a list of the evil spells

DisplaySpellBook(goodBook);
Console.WriteLine();
DisplaySpellBook(evilBook);

void DisplaySpellBook(SpellBook book)
// does not return anything hints void
{
    Console.WriteLine(book.Title);
    foreach (Spell aSpell in book.Spells)
    {
        Console.WriteLine($"  {aSpell.Name}");
    }
}

SpellBook MakeEvilSpellBook(List<Spell> allSpells)
{
    SpellBook evilBook = new SpellBook();
    evilBook.Title = "Evil Book";
    evilBook.Spells = allSpells.Where(spell => spell.IsEvil).ToList();

    return evilBook;
}

SpellBook MakeGoodSpellBook(List<Spell> allSpells)
// input is all the spells and returns SpellBook (read code right to left)
{
    SpellBook goodBook = new SpellBook();
    // create a spellbook called goodbook
    goodBook.Title = "Good Book";
    goodBook.Spells = allSpells.Where(spell => !spell.IsEvil).ToList();
    // filter spells that are not evil

    return goodBook;
}

List<Spell> GetAllSpells()
{
    List<Spell> allSpells = new List<Spell>() {
        // {} object initializer braces to set the properties of the object (spell)
        new Spell() {
            Name = "Turn enemy into a newt",
            IsEvil = true,
            EnergyReqired = 5.1
        },
        new Spell() {
            Name = "Conjure some gold for a local charity",
            IsEvil = false,
            EnergyReqired = 2.99
        },
        new Spell() {
            Name = "Give a deaf person the ability to heal",
            IsEvil = false,
            EnergyReqired = 12.2
        },
        new Spell() {
            Name = "Make yourself emperor of the universe",
            IsEvil = true,
            EnergyReqired = 100.0
        },
        new Spell() {
            Name = "Convince your relatives your political views are correct",
            IsEvil = false,
            EnergyReqired = 2921.5
        }
    };

    return allSpells;
    // returns all spells
}

public class SpellBook
{
    public string Title { get; set; }
    public List<Spell> Spells { get; set; }
    // list of spells defined below in spells
}

public class Spell
// 3 properties name , is evil or not and an integer
{
    public string Name { get; set; }
    public bool IsEvil { get; set; }
    public double EnergyReqired { get; set; }
}
