using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            var songs = new Queue<string>(Console.ReadLine().Trim().Split(", "));
            while (songs.Count>0)
            {
                string input = Console.ReadLine();
                string []commnad = input.Split(" ");
                string track = input.Substring(4);
                if (commnad[0] == "Play")
                {
                    RemoveSongFromList(songs);
                }
                else if (commnad[0] == "Add")
                {
                    if (songs.Contains(track))
                    {
                        Console.WriteLine($"{track} is already contained!");
                    }
                    else
                    {
                        AddSongInList(track, songs);
                    }
                }
                else if (commnad[0] == "Show")
                {
                    ShowThePlayList(songs);
                }
            }
            Console.WriteLine("No more songs!");
        }

        private static void ShowThePlayList(Queue<string> songs)
        {
            Console.WriteLine(string.Join(", ",songs));
        }

        private static Queue<string> AddSongInList(string track, Queue<string> songs)
        {
            songs.Enqueue(track);
            return songs;
        }

        private static Queue<string> RemoveSongFromList(Queue<string> songs)
        {
            songs.Dequeue();
            return songs;
        }
    }
}
