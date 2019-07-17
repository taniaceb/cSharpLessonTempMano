using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.Game
{
    class GameScreen
    {
        private int _width = 0;
        private int _height = 0;
        private Hero _hero;
        private List<Enemy> _enemy = new List<Enemy>();

        public GameScreen (int width, int height)
        {
            _width = width;
            _height = height;

        }

        public void SetHero (Hero hero)
        {
            _hero = hero;
        }

        public void MoveHeroRight()
        {

            if (_hero.GetX() <= _width)
            {
                _hero.MoveRight();
            }
           else
            {
                Console.WriteLine("Negalime judeti i desine");
            }
           
            
        }

        public void MoveHeroLeft()
        {
            if (_hero.GetX() >= 0)
            {
                _hero.MoveLeft();
            }
            else
            {
                Console.WriteLine("Negalime judeti i kaire");
            }

           
        }

        public void AddEnemy(Enemy enemy)
        {
           _enemy.Add(enemy);

           
            }


        }

        public void MoveAllEnemiesDown(List<Enemy>)
        {
            for (int i=0; i<enemy_number; i++)
            _enemy.MoveDown();
        }



    }
}
