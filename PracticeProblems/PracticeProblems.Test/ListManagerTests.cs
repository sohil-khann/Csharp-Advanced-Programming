using NUnit.Framework;
using System.Collections.Generic;
using PracticeProblems.App;

namespace PracticeProblems.Test
{
    public class ListManagerTests // Unit tests for the ListManager class
    {
        private ListManager listManager;
        private List<int> list;

        [SetUp]
        public void Setup()
        {
            listManager = new ListManager();
            list = new List<int>();
        }

        [Test]
        public void AddElement_ShouldIncreaseListSize()
        {
            // Arrange
            int element = 10;

            // Act
            listManager.AddElement(list, element);

            // Assert
            Assert.That(list.Count, Is.EqualTo(1));
            Assert.That(list[0], Is.EqualTo(element));
        }

        [Test]
        public void RemoveElement_ShouldDecreaseListSize()
        {
            // Arrange
            list.Add(10);
            list.Add(20);

            // Act
            listManager.RemoveElement(list, 10);

            // Assert
            Assert.That(list.Count, Is.EqualTo(1));
            Assert.That(list.Contains(10), Is.False);
        }

        [Test]
        public void GetSize_ShouldReturnCorrectSize()
        {
            // Arrange
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            int size = listManager.GetSize(list);

            // Assert
            Assert.That(size, Is.EqualTo(3));
        }
    }
}
