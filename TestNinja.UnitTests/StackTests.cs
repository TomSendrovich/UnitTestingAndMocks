using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<int?> _stack;

        [SetUp]
        public void SetUp() 
        {
            _stack = new Stack<int?>();
        }

        [Test]
        public void Push_ObjectIsNull_ReturnArgumentNullExceptionException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidObject_AddObjectToStack()
        {
            _stack.Push(1);

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_StackIsEmpty_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_StackIsEmpty_ReturnInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackIsNotEmpty_ReturnObjectOnTop()
        {
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);
            
            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Pop_StackIsNotEmpty_RemoveObjectOnTop()
        {
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);

            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_StackIsEmpty_ReturnInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackIsNotEmpty_ReturnObjectOnTop()
        {
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);
            
            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Peek_StackIsNotEmpty_DoesNotRemoveObject()
        {
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);
            
            _stack.Peek();

            Assert.That(_stack.Count, Is.EqualTo(3));
        }
    }
}
