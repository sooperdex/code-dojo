/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 19/02/2015
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using NUnit.Framework;

namespace CodeDojo.Anagram.UnitTests
{
	[TestFixture]
	public class AnagramTests
	{
        [Test]
        public void TestLetterSwitching()
        {
            const string text = "string";
            Assert.AreEqual("tsring", Anagram.SwitchLetters(text, 0, 1), "string should now be tsring");
        }

        [Test]
        public void TestSameLetterSwitch()
        {
            const string text = "string";
            Assert.AreEqual("string", Anagram.SwitchLetters(text, 0, 0), "string should be equal to string");
        }

        [Test]
        public void TestIncorrectIndexSwitch()
        {
            const string text = "string";
            Assert.AreEqual("string", Anagram.SwitchLetters(text, 0, -1), "string should be equal to string");
            Assert.AreEqual("string", Anagram.SwitchLetters(text, -1, 0), "string should be equal to string");

            Assert.AreEqual("string", Anagram.SwitchLetters(text, 0, 10), "string should be equal to string");
            Assert.AreEqual("string", Anagram.SwitchLetters(text, 10, 0), "string should be equal to string");
        }
        
        [Test]
        public void Test2StringAnagram()
        {
        	const string text = "ab";
        	
        	IList results = new ArrayList();
        	results.Add("ab");
        	results.Add("ba");
        	
        	Assert.AreEqual(results, Anagram.Process(text), "expect results to match");
        }
        
        
        [Test]
        public void TestShiftLetters()
        {
        	const string text = "string";
        	
        	Assert.AreEqual("ringst", Anagram.ShiftLetters(text, 2), "wo should be rolling letters");
        	
        	Assert.AreEqual(text, Anagram.ShiftLetters(text, 10), "should have 'string'");
        	Assert.AreEqual(text, Anagram.ShiftLetters(text, -1), "should have 'string'");
        }
        
        [Test]
        public void Test3StringAnagram()
        {
        	const string text = "abc";
        	
        	IList results = new ArrayList();
        	results.Add("abc");
        	results.Add("bac");
        	results.Add("cba");
        	results.Add("acb");
        	results.Add("bca");
        	results.Add("cab");
        	
        	Assert.AreEqual(results, Anagram.Process(text), "expect results to match");
        }
        
        [Test]
        public void Test4StringAnagram()
        {
        	const string text = "abcd";
        	
        	Assert.IsTrue(24 == Anagram.Process(text).Count, "expect results to be 24");
        }
	}
}
