// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        var otherobj = obj as FacialFeatures;
        return (this.EyeColor == otherobj.EyeColor && this.PhiltrumWidth == otherobj.PhiltrumWidth);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj1)
    {
        if (obj1 == null) return false;
        var personFace = obj1 as Identity;
        return (this.Email == personFace.Email && this.FacialFeatures.Equals(personFace.FacialFeatures));
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures);
    }
}

public class Authenticator
{
    HashSet<Identity> addedIdentities = new HashSet<Identity>();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        var theAdmin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
        return identity.Equals(theAdmin);
    }

    public bool Register(Identity identity)
    {
        return addedIdentities.Add(identity);
    }

    public bool IsRegistered(Identity identity)
    {
        return addedIdentities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return ReferenceEquals(identityA, identityB);
    }
}
