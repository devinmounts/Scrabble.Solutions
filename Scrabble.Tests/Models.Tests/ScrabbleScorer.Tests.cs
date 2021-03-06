using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Tests
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void GetWordString_ReturnWordString_String()
        {
            //Arrange
            string testString = "cat";
            ScrabbleScorer inputWord = new ScrabbleScorer(testString);

            //Act
            string result = inputWord.GetWordString();

            //Assert
            Assert.AreEqual(testString, result);
        }

        [TestMethod]
        public void SetWordString_ReturnNewWordString_String()
        {
            //Arrange
            string testString = "cat";
            ScrabbleScorer inputWord = new ScrabbleScorer(testString);

            //Act
            string newTestString = "dog";
            inputWord.SetWordString(newTestString);
            string result = inputWord.GetWordString();

            //Assert
            Assert.AreEqual(newTestString, result);
        }

        [TestMethod]
        public void StringToArray_ReturnStringArray_Char()
        {
            //Arrange
            string testString = "cat";
            ScrabbleScorer inputWord = new ScrabbleScorer(testString);

            //Act
            char[] testArray = { 'c', 'a', 't' };
            char[] charArray = inputWord.StringToArray(inputWord.GetWordString());

            //Assert
            CollectionAssert.AreEqual(testArray, charArray);

        }
    }
}
