
using System;
using System.Collections.Generic;

class PlaylistApp
{
    static Stack<string> previousSongs = new Stack<string>(); // Using Stack to store previous songs
    static Queue<string> upcomingSongs = new Queue<string>(); // Using Queue to store upcoming songs

    static void Main(string[] args)
    {
        bool startProgram = true;

        while (startProgram)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a song to your playlist");
            Console.WriteLine("2. Play the next song in your playlist");
            Console.WriteLine("3. Skip the next song");
            Console.WriteLine("4. Rewind one song");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddSongToPlaylist();
                    break;
                case 2:
                    PlayNextSong();
                    break;
                case 3:
                    SkipNextSong();
                    break;
                case 4:
                    RewindOneSong();
                    break;
                case 5:
                    startProgram = false;
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Ooops...Invalid option. Please choose again."); // Setting a default case if users input invalid numbers/options
                    Console.WriteLine();
                    break;
            }
        }
    }

    static void AddSongToPlaylist()
    {
        Console.WriteLine("Enter a Song Name:");
        string songName = Console.ReadLine();
        upcomingSongs.Enqueue(songName); // Enquene will help us to add a song to the end of the playlist.so, Any new song added, will be added at the end of the playlist rather than in the first position. 
        Console.WriteLine($"Song \"{songName}\" has been added to your playlist.");
    }

    static void PlayNextSong()
    {
        if (upcomingSongs.Count > 0)
        {
            string currentSong = upcomingSongs.Dequeue(); // 
            previousSongs.Push(currentSong);
            Console.WriteLine($"Now playing \"{currentSong}\"");
            Console.WriteLine($"Next song: {(upcomingSongs.Count > 0 ? upcomingSongs.Peek() : "none queued")}"); // Use of a a ternary operator (? :) and peek retrieves the next songs without removing it
        }
        else
        {
            Console.WriteLine("Ooops...Playlist is empty."); // if there is no next songs
        }
    }

    static void SkipNextSong()
    {
        if (upcomingSongs.Count > 0)
        {
            string skippedSong = upcomingSongs.Dequeue();
            Console.WriteLine($"Skipped \"{skippedSong}\"");
            Console.WriteLine($"Next song: {(upcomingSongs.Count > 0 ? upcomingSongs.Peek() : "none queued")}");
        }
        else
        {
            Console.WriteLine("Ooops...Playlist is empty.");
        }
    }

    static void RewindOneSong()
    {
        if (previousSongs.Count > 0)
        {
            string previousSong = previousSongs.Pop();
            upcomingSongs.Enqueue(previousSong);
            Console.WriteLine($"Rewind to \"{previousSong}\"");
            Console.WriteLine($"Next song: {(upcomingSongs.Count > 0 ? upcomingSongs.Peek() : "none queued")}");
        }
        else
        {
            Console.WriteLine("Ooops...No previous songs available.");
        }
    }
}

