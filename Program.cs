using System;

namespace FunWithMusic
{
    class MusicGenre
    {
        enum Genre
        {
            Country,
            Pop,
            Reggae,
            Indy,
            Folk,
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private double Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, double length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title= title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(double length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("What is the Artist's Name?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the name of the Album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            double tempLength = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the genre?");
            Console.WriteLine("C - Country\nP - Pop\nR - Reggae\nI - Indy\nF - Folk");
            Genre tempGenre = Genre.Country;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'R':
                    tempGenre = Genre.Reggae;
                    break;
                case 'I':
                    tempGenre = Genre.Indy;
                    break;
                case 'F':
                    tempGenre = Genre.Folk;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music moreMusic = music;
            Console.WriteLine("What is the next song on the Album?");
            moreMusic.setTitle(Console.ReadLine());
            Console.WriteLine("What is the length of the song?");
            moreMusic.setLength(double.Parse(Console.ReadLine()));
            Console.WriteLine("Here is the first song: ");
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine("Here is the second song: ");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}