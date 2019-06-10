using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            List<Artist> mountV = Artists
                .Where(i => i.Hometown == "Mount Vernon")
                .ToList();

            string mountVArt = $"The only artist in Mount Verson is {mountV[0].RealName}, age {mountV[0].Age}.";
            System.Console.WriteLine(mountVArt);

            //Who is the youngest artist in our collection of artists?
            List<Artist> age = Artists
                .OrderBy(i => i.Age)
                .ToList();

            string youngest = $"The youngest artist is {age[0].RealName}, age {age[0].Age}.";
            System.Console.WriteLine(youngest);
            
            //Display all artists with 'William' somewhere in their real name
            List<Artist> willy = Artists
                .Where(i => i.RealName
                    .Contains("William"))
                .ToList();

            string willies = $"There are {willy.Count} artist that contain the name 'William', there names are:";
            for (int i = 0;i < willy.Count;i++)
            {
                willies += $" {willy[i].RealName},";
            }
            System.Console.WriteLine(willies);

            //Display the 3 oldest artist from Atlanta
            List<Artist> old = Artists
                .Where(i => i.Hometown == "Atlanta")
                .OrderByDescending(i => i.Age)
                .ToList();
            string oldest = $"The three oldest artists from Atlanta are {old[0].RealName} age {old[0].Age}, {old[1].RealName} age {old[1].Age}, and {old[2].RealName} age {old[2].Age}.";
            System.Console.WriteLine(oldest);

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
	        // Console.WriteLine(Groups.Count);
        }


    }
}
