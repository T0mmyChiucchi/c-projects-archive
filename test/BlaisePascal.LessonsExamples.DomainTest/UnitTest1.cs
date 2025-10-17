using BlaisePascal.LessonsExamples.Domain;
using System;

namespace BlaisePascal.LessonsExamples.DomainTest
{
    public class EnemyTest
    {
        [Fact]
        public void EnemyName_WhenTheNameIsValid_TheNameMustBeAssignedCorrectly()
        {
            Enemy newEnemy = new Enemy();
            newEnemy.setName("Stefano");
            Assert.Equal("Stefano", newEnemy.Name);
        }

        [Fact]
        public void EnemyName_WhenTheNameIsEmpty()
        {
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

        //TakeDamage Tests
        [Fact]
        public void EnemyTakeDamage_WhenDamageIsValid30_ShouldReduceHealthNy30()
        {
            Enemy enemy = new Enemy("Goblin", 70);
            int damage = 20;
            enemy.TakeDamage(damage);
            Assert.Equal(50, enemy.Health);
        }
        [Fact]
        public void EnemyTakeDamage_WhenDamageIsNegative_ShouldThrowArgumentException()
        {
            Enemy enemy = new Enemy("Goblin");
            int damage = -20;
            Assert.Throws<ArgumentOutOfRangeException>(() => enemy.TakeDamage(damage));
        }
        [Fact]
        public void EnemyTakeDamage_WhenDamageIsMoreThanTheHealth_ShouldSetHealthTo0()
        {
            Enemy enemy = new Enemy("Goblin", 70);
            int damage = 80;
            enemy.TakeDamage(damage);
            Assert.Equal(0, enemy.Health);
        }
        [Fact]
        public void EnemyTakeDamage_WhenDamageIsEqualToTheHealth_ShouldSetHealthTo0()
        {
            Enemy enemy = new Enemy("Goblin", 70);
            int damage = 70;
            enemy.TakeDamage(damage);
            Assert.Equal(0, enemy.Health);
        }
        [Fact]
        public void EnemyTakeDamage_WhenDamageIsValidate0_ShouldNotReduce_Health()
        {
            Enemy enemy = new Enemy("Goblin", 70);
            int damage = 0;
            enemy.TakeDamage(damage);
            Assert.Equal(70, enemy.Health);
        }
    }
}