using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class AnagramTest
{
    [Test]
    public void checkChar()
    {
        char input = 'a';
        Assert.AreEqual(1, Anagram.InputChar(input));
    }

    [Test]
    public void checkStringPermutations2()
    {
        string input = "ab";
        Assert.AreEqual(2, Anagram.InputString(input));
    }

    [Test]
    public void checkStringPermutations24()
    {
        string input = "abcd";
        Assert.AreEqual(24, Anagram.InputString(input));
    }

    [Test]
    public void checkStringPermutationsFail()
    {
        string input = "aa";
        Assert.AreNotEqual(24, Anagram.InputString(input));
    }

    [Test]
    public void checkString()
    {
        string input = "aa";
        Assert.AreEqual("aa", Anagram.ReturnString(input));
    }

    [Test]
    public void switchString()
    {
        string input = "string";
        Assert.AreEqual("tsring", Anagram.SwitchString(input, 0, 1));
    }

    [Test]
    public void testPermeatations()
    {
        HashSet<string> strings = new HashSet<string>();
        strings.Add("ab");
        strings.Add("ba");

        HashSet<string> returnStrings = Anagram.GetPermeatations("ab");

        Assert.AreEqual(strings.Count, returnStrings.Count);
    }

    [Test]
    public static testBuildList ()
    { 
       string ab = "ab";
       HasheSet<string> abSet = anogram.BuildList (string ab); 
    }
}
