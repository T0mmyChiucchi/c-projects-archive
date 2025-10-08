using System;

namespace BlaisePascal.LessonsExamples.DomainTest
{
    public class EnemyTest
    {
        [Fact]
        public void EnemyName_WhenTheNameIsValid_TheNameMustBeAssignedCorrectly()
        {
            Enemy newEnemy = new Enemy();
            newEnemy.SetName("Stefano");
            Assert.Equal("Stefano", newEnemy.GetName());
        }

        [Fact]
        public void EnemyName_WhenTheNameIsEmpty()
        {
            //comment
            Enemy newEnemy = new Enemy();
            Assert.NotNull(newEnemy);
        }






        /*
        [Fact]
        public void Test1()
        {
            Enemy enemyToTest = new Enemy("Stefano", 100);
                enemyToTest.SetName("Carlo");
        }
        */
    }
}