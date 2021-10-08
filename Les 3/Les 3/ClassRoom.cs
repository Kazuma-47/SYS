using System;
using System.Collections.Generic;
using System.Text;

namespace Les_3
{
    class ClassRoom
    {
        Tiles[][] tiles = new Tiles[5][];
        enemy[] enemies = new enemy[3];
        enemy Enemy = new enemy();

        void tilesvullen()
        {
            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i] = new Tiles[2];
            }
        }
        void enemy()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                
            }
        }

   
}
