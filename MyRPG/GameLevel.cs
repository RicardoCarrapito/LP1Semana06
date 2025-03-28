using System;
using System.Net.NetworkInformation;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        private Enemy[] rooms;
        private Hardness difficulty;

        public GameLevel(int numberOfRooms, Hardness difficulty)
        {
            rooms = new Enemy[numberOfRooms];
            this.difficulty = difficulty;
        }

        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            rooms[roomIndex] = enemy;
        }
        public Hardness GetHardness()
        {
            return difficulty;
        }

        public int GetNumRooms()
        {
            return rooms.Length;
        }

        public int GetNumEnemies()
        {
            int soma = 0;
            foreach (var enemy in rooms)
            {
                if (enemy != null)
                {
                    soma++;
                }
            }
            return soma;
        }

        public void PrintEnemies()
        {
            for (int r = 0; r < rooms.Length; r++)
            {
                if (rooms[r] != null)
                {
                    Console.WriteLine($"Room {((r).ToRoman())}: {rooms[r].GetName()}");
                }
            }
        }
    }
}