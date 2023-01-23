// See https://aka.ms/new-console-template for more information
using System;

abstract class Character
{
    public string characterType;

    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}

class Warrior : Character
{

    public Warrior() : base("Warrior")
    {

    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
        {
            return 10;
        }
        else
        {
            return 6;
        }
        return 0;
    }
}

class Wizard : Character
{
    public bool prepareASpell;
    public Wizard() : base("Wizard")
    {

    }

    public override int DamagePoints(Character target)
    {
        if (prepareASpell == true)
        {
            return 12;
        }
        if (prepareASpell == false)
        {
            return 3;
        }
        return 0;

    }

    public void PrepareSpell()
    {
        prepareASpell = true;
    }
    public override bool Vulnerable()
    {
        if (prepareASpell != true)
        {
            return true;
        }
        else
        {
            return false;
        };
    }
}
