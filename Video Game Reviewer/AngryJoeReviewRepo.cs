using System;
using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;

namespace Video_Game_Reviewer
{

    public class AngryJoeReviewRepo
    {
        public static Dictionary<string, Reviews> AngryJoe()
        {
            Reviews RedDeadRedemption2 = new("AngryJoe", "Red Dead Redemption 2", "BadAss Seal of Approval", "Playstion 4", 9);
            Reviews GodOfWar = new("AngryJoe", "God Of War", "BadAss Seal of Approval", "Playstation 4 ", 9);
            Reviews Uncharted4 = new("AngryJoe and OtherJoe", "Uncharted 4 A Thiefs End", "BadAss Seal of Approval", "Playstation 4", 9);
            Reviews PlagueTaleRequim = new("Alex", "A Plague Tale Requiem", "Recommended", "Playstation 5", 7);
            Reviews LastOfUsPart1 = new("AngryJoe", "Last Of Us Part 1", "Legenedary Status and BadAss Seal of Approval ", "Playstation 5", 10);
            Reviews TinyTinasWonderLand = new("AngryJoe,OtherJoe, and Alex", "Tiny Tina's Wonderlands", "Meh", "PC", 6);
            Reviews EldenRing = new("AngryJoe", "Elden Ring", "Legenedary Status and BadAss Seal of Approval ", "PC", 10);
            Reviews HorizonForibbenWest = new("AngryJoe", "Horizon Forbidden West", "Great", "Playstation 5", 8);
            Reviews DyingLight2 = new("AngryJoe", "Dying Light 2 Stay Human", "Needs to innovate, for a next time vist", "PC", 6);
            Reviews HaloInfinite = new("AngryJoe", "Halo Infinite ", "Despite its short comings its a good starting point", "Xbox Series X and PC", 7);
            Reviews BattleField2042 = new("AngryJoe", "Battlefield 2042", "4 out of 10 is a generous score, considering the status at the launch of the game.", "PC", 4);
            Reviews GuardiansOfTheGalaxy = new("Alex", "Marvel's Guardians Of The Galaxy", "Whether this is good pickup for you is dependent on your enjoyment of 80's music, the guardians humour, and the lackluster combat", "Playstation 5", 6);
            Reviews Back4Blood = new("AngryJoe", "Back 4 Blood", "This game isn't the game to break the zombie curse for me ", "PC", 5);
            Reviews BioMutant = new("Alex", "Biomutant", "Its an incredibly charming but averageish game ", "PC", 5);
            Reviews ResidentEvilVillage = new("AngryJoe", "Resident Evil Village", "It would have been an 8 with VR, this is basically a redo of resident evil 7 with less impact", "PC", 7);
            Reviews Outiders = new("AngryJoe", "Outriders", "I wanted to Like, it does loot well, but everything else is below average", "PC", 5);
            Reviews Hitman3 = new("Alex", "Hitman 3", "Overall the gameplay is pretty good with some flaws.", "PC", 8);
            Reviews CyberPunk2077 = new("AngryJoe", "Cyberpunk 2077", "Consoles verisons of this game fair much worse then PC, overall a super disappointing release", "PC", 6);
            Reviews AssassinsCreedValhalla = new("Alex", "Assassins Creed Valhalla", "When valhalla gets going ubisoft shows they have the ability to make games I want to play ", "PC", 7);
            Reviews MilesMorales = new("AngryJoe", "Marvel's Spider Man Miles Morales", "With the disappoinint story,boss variety, game length,graphics restrictions, and some sagging gameplay, but it pickups an dnails some character development", "Playstation 5", 7);
            Reviews WatchDogsLegion = new("Alex", "Watch Dogs Legion", "What we got on relase is repetivite gameplay,average overtold story makes this game average", "PC", 4);
            Reviews Avengers = new("AngryJoe", "Marvel's Avengers", "The live service platform fails, and at launch was buggier than Athem", "Playstation 4", 4);
            Reviews GhostOfTsushima = new("AngryJoe", "Ghost Of Tsushima", "BadAss Seal of Approval", "Playstation 4 ", 9);
            Reviews TheLastOfUsPart2 = new("AngryJoe", "The Last Of Us Part 2", "The last of us 2 gets half of everthing right, but the story, characters, and writing makes everything else feel like a hollow victory", "Playstation 4 Pro", 6);
            Reviews Nioh2 = new("Delrith", "Nioh 2", "Nioh 2 is a pretty damn good improvement over the first, but the story made no sense", "Playstation 4 ", 8);
            Reviews AnimalCrossingNewHorizon = new("Delrith", "Animal Crossing New Horizons", "Is a above average game that lack innovation", "Nintendo Switch", 6);
            Reviews FinalFantasy7Remake = new("AngryJoe", "Final Fantasy 7 Remake", "This game is a masterpiece and if you want to know why people love this series, go buy this game", "Playstation 4 ", 9);
            Reviews ResidentEvil3 = new("AngryJoe", "Resident Evil 3", "It feels like dlc for resident evil 2 remake, with cut content, crappy boss battles poorly design levels and not a good multiplayer level", "PC", 6);
            Reviews DoomEternal = new("angryJoe", "Doom Eternal", "Legenedary Status and BadAss Seal of Approval", "PC", 10);
            Reviews OriAndTheWillOfTheWisps = new("AngryJoe, OtherJoe, and Alex", "Ori And The Will Of The Wisps", "Great Game, but the bugs hold it back", "Xbox One", 8);
            Reviews Shenmue3 = new("Delrith", "Shenmue 3", "Shenmue offers a worse version of a 2001 game", "Playstation 4 ", 4);
            Reviews StarWarsJediFallenOrder = new("AngryJoe", "Star Wars Jedi Fallen Order", "This game does what it does really well. BadassSeal of Approval", "PC", 8);
            Reviews Deathstranding = new("AngryJoe", "Death Stranding", "This is not going to be everyone's cup of tea, with some giving this game or higher depending on how they like the game.", "Playstation 4", 7);
            Reviews CallOfDutyModernWarfare = new("AngryJoe", "Call Of Duty Modern Warfare", "Cod misses the top tier, but that doesn't mean its a bad game, its a good frame work to build on", "PC", 7);
            Reviews Medievil = new("Delrith", "Medievil", "The fact that the original was a great game and the fact that it's just general fun, but some points are deducted for some technical issues.", "Playstation 4 ", 7);
            Reviews Borderlands3 = new("AngryJoe", "Borderlands 3", "BadAss Seal of Approval,It should be experienced even with the the weak story and writing", "PC", 8);
            Reviews Control = new("AngryJoe", "Control", "So of the annoyances of the map, dialouge, and middle section, bring down what could have been a great game.", "Playstation 4", 7);
            Reviews APlagueTaleInnocence = new("Delrith", "A Plague Tale Innocence", "BadAss Seal of Approval - it would be a damn shame to miss out on this one", "Playstation 4", 9);
            Reviews DaysGone = new("Delrith", "Days Gone", "Although buggy at sometimes,it kept mecaptivated all the way though", "Playstation 4 ", 8);
            Reviews SekiroShadowsDieTwice = new("Delrith", "Sekiro Shadows Die Twice", "Sekrio lives up to the reputation that FromSoft have made for themselves", "Playstation 4 ", 8);
            Reviews DevilMayCry5 = new("AngryJoe", "Devil May Cry 5", "BadAss Seal of Approval - Capcom is getting the Devil May Cry series back on track", "PC", 9);
            Reviews Anthem = new("AngryJoe", "Anthem", "Bugs, poor launch state, glitches, and lack of content, ruins what could be an average game", "PC ", 4);
            Reviews FarCryNewDawn = new("Delrith", "Far Cry New Dawn", "Overall, the experience felt really short, and feels half of the price of Far Cry 5 and half of the game as well", "PC", 7);
            Reviews ResidentEvil2 = new("AngryJoe", "Resident Evil 2", "BAdAss Seal of Approval - the game has so much content with the four playthroughs for the main story, then the additional modes, makes the experience worth it", "Playstation 4", 9);
            Reviews Fallout76 = new("AngryJoe", "Fallout 76", "It's just awful, boring, and nothing is worst than boring", "PC", 3);
            Reviews BattlefieldV = new("AngryJoe", "BattleField V", "Battlefield is a shadow of its former self, Battlefield V could have show us what Battlfield can be, but fails to do that", "PC", 5);
            Reviews Hitman2 = new("Delrith", "Hitman 2", "Offers dozens of Hours of Amusment", "Playstation 4", 9);
            Reviews AssassinsCreedOdyssey = new("AngryJoe", "Assassin's Creed Odyssey", "This game is capable of a 9, but there is so much content here, but the micro transactions hurt the game", "PC", 7);
            Reviews ShadowOfTheTombRaider = new("AngryJoe", "Shadow Of The Tomb Raider", "The lack of innovation and weakness in the story holds this one from pasting hte debut game in the trilogy", "PC", 7);
            Reviews SpiderMan = new("AngryJoe", "Marvel's Spider Man", " BadAss Seal of Approval - Game has high quality product and an interesting story, and huge open world city with tons of content", "Playstation 4", 9);
            Reviews StateOfDecay2 = new("Delrith", "State Of Decay 2", "i was simply disappoint, every system was below average and the game lacks a lot of interesting features", "PC and Xbox One", 6);
            Reviews AssassinsCreedOrigins = new("Delrith", "Assassin's Creed Origins", "Game is good for a good amount of time,its just not great or amazing ", "PC And Xbox One", 7);
            Reviews Cuphead = new("AngryJoe", "Cuphead", "BadAss Seal of Approval - This game isn't for everyone, but this game from a small team proves to be a stylish and achallenging game", "Xbox One", 10);
            Reviews MassEffectAndromeda = new("AngryJoe", "Mass Effect Andromeda", "When you don't add anything thing new, and mess up on the writing Mass Effect does not live up the previous games.", "PC", 6);
            Reviews BreathOfTheWild = new("AngryJoe", "The Legend Of Zelda Breath Of The Wild", "BadAss Seal of Approval - The way the weapons break, the lack of voice acting and the story holds this back from being a 10 out of 10 game.", "Nintendo Switch", 9);
            Reviews ResidentEvil7 = new("AngryJoe", "Resident Evil 7", "", "Playstation 4 with ProPlaystation VR", 9);
            Reviews UmbrellaCorps = new("AngryJoe", "Umbrella Corps", "", "Playstation 4", 2);








            var reviews = new Dictionary<string, Reviews>
        {
           {"Red Dead Redemption 2",RedDeadRedemption2  },
            {"God Of War",GodOfWar },
            
            {"Unchated 4 A Thiefs End",Uncharted4 },
            {"A Plague Tale Requiem",PlagueTaleRequim },
           
            {"The Last of Us Part 1",LastOfUsPart1 },
          
            {"Elden Ring",EldenRing },
            {"The Last Of Us Part 2",TheLastOfUsPart2 },


            {"The Legend Of Zelda Breath Of The Wild",BreathOfTheWild },
            {"Horizon Forbidden West",HorizonForibbenWest },
            {"Halo Infinite",HaloInfinite },
           
            {"Hitman 3",Hitman3 },
            {"Cyberpunk 2077",CyberPunk2077 },
          
            {"Spider Man Miles Morales",MilesMorales },
          
            {"Ghost Of Tsushima",GhostOfTsushima },
            {"Resident Evil 3",ResidentEvil3 },
            {"Doom Eternal",DoomEternal },
            {"Animal Crossing New Horizons",AnimalCrossingNewHorizon },
            {"Nioh 2",Nioh2 },
            {"Ori And The Will Of The Wisps",OriAndTheWillOfTheWisps },
            {"Star Wars Jedi Fallen Order",StarWarsJediFallenOrder },
          
            {"Borderlands 3",Borderlands3 },
           
            {"Sekiro Shadows Die Twice",SekiroShadowsDieTwice },
            {"Devil May Cry 5",DevilMayCry5 },
            {"Resident Evil 2",ResidentEvil2 },
          
            {"Assassins Creed Odyssey",AssassinsCreedOdyssey },
            {"Shadow Of The Tomb Raider",ShadowOfTheTombRaider },
         
            {"Assassins Creed Origins",AssassinsCreedOrigins },
         

           
         
            {"Uncharted 4 A Thiefs End",Uncharted4 },
            {"Tiny Tinas Wonderland",TinyTinasWonderLand },        
            {"Guardians Of The Galaxy",GuardiansOfTheGalaxy },
            {"Back 4 Blood",Back4Blood },          
            {"Resident Evil Village",ResidentEvilVillage },          
            {"Assassins Creed Valhalla",AssassinsCreedValhalla },
            {"Watch Dogs Legion",WatchDogsLegion },          
            {"Final Fantasy 7 Remake",FinalFantasy7Remake },
            {"Call Of Duty Modern Warfare",CallOfDutyModernWarfare },
            {"Control",Control },           
            {"Spider Man",SpiderMan },          
            {"Cuphead",Cuphead },           
            {"Dying Light 2 Stay Human",DyingLight2 },          
            {"Battlefield 2042", BattleField2042},
            {"Outriders",Outiders },         
            {"A Plague Tale Innocence",APlagueTaleInnocence },
            {"Far Cry New Dawn",FarCryNewDawn },
            {"Battlefield V",BattlefieldV },
            {"Hitman 2", Hitman2},
            {"State Of Decay 2",StateOfDecay2 },
            {"Mass Effect Andromeda",MassEffectAndromeda },
            {"Resident Evil 7",ResidentEvil7 },
            {"Biomutant",BioMutant },
            {"Avengers",Avengers },
            {"Death Stranding",Deathstranding },
            {"Medievil",Medievil },
            {"Days Gone",DaysGone },
            {"Anthem",Anthem },
            {"Shenmue 3",Shenmue3 },
            {"Fallout 76",Fallout76 },
            {"Umbrella Corps",UmbrellaCorps },
        };

            return reviews;
        }
    }
}