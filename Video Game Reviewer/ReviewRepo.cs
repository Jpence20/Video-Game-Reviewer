using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Xml.Schema;

namespace Video_Game_Reviewer
{
    public class ReviewRepo
    {



        public static Dictionary<string, Reviews> IGNReviews()
        {
            Reviews modernWarfare2 = new("Matt Purslow", "Call of Duty Modern Warfare 2", "Okay", "Playstation 5", 6);
            Reviews GothamKnights = new("Travis Northup", "Gotham Knights", "Mediocre", "Xbox Series X", 5);
            Reviews PlagueTaleRequim = new("Travis Northup", "A Plague Tale Requiem", "Great", "Xbox Series X", 8);
            Reviews SparksofHope = new("Dan Stapleton", "Mario + Rabbids: Sparks of Hope", "Amazing", "Nitendo Switch", 9);
            Reviews Overwatch2 = new("Simon Cardy", "Overwatch 2", "Great", "All Platforms", 8);
            Reviews Fifa23 = new("Jordan Oloman", "Fifa 23", "Good", "PC, Playstation 5 and Xbox Series X", 7);
            Reviews LastOfUsPart1 = new("Luke Reilly", "Last Of Us Part 1", "Amazing", "Playstation 5", 9);
            Reviews Xenoblade3 = new("Travis Northup", "Xenoblade 3", "Great", "Nintendo Switch", 8);
            Reviews TheQuarry = new("Thomas Wilde", "The Quarry", "Good", "PC", 7);
            Reviews EldenRing = new("Mitchell Saltzman", "Elden Ring", "MasterPiece", "PC,Xbox Series X, and Playstation 5", 10);
            Reviews TheLastOfUsPart2 = new("Jonathon Dornbush", "The Last Of Us Part 2", "Masterpiece", "Playstation 4",10);
            Reviews Persona5Royal = new("Leana Hafer", "Persona 5 Royal", "MasterPiece", "Playstation 4", 10);
            Reviews RedDeadRedemption2 = new("Luke Reilly", "Red Dead Redemption2", "MasterPiece", "Playstation 4 and Xbox One", 10);
            Reviews GodOfWar = new("Jonathon Dornbush", "God of War", "Masterpiece", "Playstation 4", 10);
            Reviews Celeste = new("Tom Marks", "Celeste", "MasterPiece", "PC,Xbox One,Playstation 4 , Nintendo Switch", 10);
            Reviews SuperMarioOdyssey = new("Ryan Mcaffrey", "Super Mario Odyssey","MasterPiece", "Nintendo Switch", 10);
            Reviews BreathOfTheWild = new("Jose Otero", "The Legend Of Zelda Breath Of The Wild", "MasterPiece","Nintendo Switch", 10);
            Reviews MetalGearSolid5 = new("Vince Ingenito", "Metal Gear Solid 5 The Phantom Pain", "MasterPiece", "Playstaion 4", 10);
            Reviews GrandTheftAuto5 = new("Keza MacDonald", "Grand Theft Auto 5", "MasterPiece", "Playstation 3 and Xbox 360",10);
            Reviews Bayonetta3 = new("Mithchell Saltzman", "Bayonetta 3", "Amazing", "Nintendo Switch", 9);
            Reviews TotalWarWarhammer3 = new("Leana Hafer", "Total War Warhammer 3", "Amazing", "PC", 9);
            Reviews HorizonForibbenWest = new("Simon Cardy", "Horizon Forbidden West", "Amazing", "Playstation 5", 9);
            Reviews HaloInfinite = new("Ryan Mccaffrey", "Halo Infinite Single Player", "Amazing", "Xbox Series X and PC", 9);
            Reviews MetroidDread = new("Samuel Claiborn", "Metroid Dread", "Amazing", "Nintendo Switch", 9);
            Reviews TalesOfArise = new("Terence Wiggins", "Tales of Arise", "Amazing", "Playstation 5, Xbox Series X, and PC", 9);
            Reviews GodOfWarRagnarok = new("Simon Cardy", "God Of War Ragnarok", "MasterPiece", "Playstation 5", 10);
            Reviews DeathLoop = new("Matt Purslow", "DeathLoop", "MasterPiece", "Playstation 5", 10);
            Reviews RatchetAndClankRiftApart = new("Jonathon Dornbush", "Ratchet And Clank Rift Apart", "Amazing", "Playstation 5", 9);
            Reviews ItTakesTwo = new("Tristan Ogilive", "It Takes Two", "Amazing", "Xbox Series X", 9);
            Reviews Hitman3 = new("Luke Reilly", "Hitman 3", "Amazing", "Xbox Series X", 9);
            Reviews CyberPunk2077 = new("Tom Marks", "Cyberpunk 2077", "Amazing", "PC", 9);
            Reviews DemonSouls = new("Mitchell Saltzman", "Demon Souls", "Amazing", "Playstation 5", 9);
            Reviews MilesMorales = new("Jonathon Dornbush", "Marvel's Spider Man Miles Morales", "Amazing", "Playstation 5", 9);
            Reviews Hades = new("Nick Limon", "Hades", "Amazing", "PC", 9);
            Reviews GhostOfTsushima = new("Mitchell Saltzman", "Ghost Of Tsushima", "Amazing", "Playstation4 Pro", 9);
            Reviews Valorant = new("Kyle Campbell", "Valorant", "Amazing", "PC", 9);
            Reviews ResidentEvil3 = new("Lucy O'Brien", "Resident Evil 3", "Amazing", "Playstation 4 Pro", 9);
            Reviews DoomEternal = new("Ryan Mccaffrey", "Doom Eternal", "Amazing", "PC", 9);
            Reviews AnimalCrossingNewHorizon = new("Samuel Claiborn", "Animal Crossing New Horizons", "Amazing", "Nintendo Switch", 9);
            Reviews Nioh2 = new("Mitchell Saltzman", "Nioh 2", "Amazing", "Playstation 4", 9);
            Reviews OriAndTheWillOfTheWisps = new("Brandin Tyrrel", "Ori And The Will Of The Wisps", "Amazing", "Xbox One X", 9);
            Reviews StarWarsJediFallenOrder = new("Dan Stapleton", "Star Wars Jedi Fallen Order", "Amazing", "PC,Xbox One X, and Playstation 4 Pro", 9);
            Reviews PokemonSword = new("Casey Defreitas", "Pokemon Sword", "Amazing", "Nintendo Switch", 9);
            Reviews PokemonShield = new("Casey Defreitas", "Pokemon Shield", "Amazing", "Nintendo Switch", 9);
            Reviews LinksAwakening = new("Joe Skrebels", "The Legend Of Zelda Link's Awakening", "Amazing", "Nintendo Switch", 9);
            Reviews Gears5 = new("Ryan Mccaffrey", "Gears 5","Amazing" ,"Xbox One X", 9);
            Reviews Borderlands3 = new("James Duggan", "Borderlands 3", "Amazing", "PC", 9);
            Reviews AstralChain = new("Steven Petite", "Astral Chain", "Amazing", "Nintendo Switch", 9);
            Reviews FireEmblemThreeHouses = new("Brendan Graeber", "Fire Emblem Three Houses", "Amazing", "Nintendo Switch", 9.5);
            Reviews SekiroShadowsDieTwice = new("Brandin Tyrrel", "Sekiro Shadows Die Twice", "Amazing", "Playstation 4 Pro", 9.5);
            Reviews DevilMayCry5 = new("Mitchell Saltzman", "Devil May Cry 5", "Amazing", "Xbox One ", 9.5);
            Reviews ResidentEvil2 = new("Daemon Hatfield", "Resident Evil 2", "Amazing", "Xbox One,Playstation 4, and PC", 9);
            Reviews SuperSmashBrosUltimate = new("Tom Marks", "Super Smash Bros Ultimate", "Amazing", "Nintendo Switch", 9.4);
            Reviews AssassinsCreedOdyssey = new("Brandin Tyrrel", "Assassin's Creed Odyssey", "Amazing", "Playstation 4 Pro,Playstation 4,and Xbox One", 9.2);
            Reviews ShadowOfTheTombRaider = new("Lucy O'Brien", "Shadow Of The Tomb Raider", "Amazing", "Xbox One X", 9);
            Reviews DeadCells = new("Brandin Tyrrel", "Dead Cells", "Amazing", "Xbox One X,Playstation 4 Pro,PC,and Nintendo Switch", 9.5);
            Reviews OctopathTraveler = new("Seth G.Macy", "Octopath Traveler", "Amazing", "Nintendo Switch", 9.3);
            Reviews HollowKinght = new("Tom Marks", "Hollow Knight", "Amazing", "PC and Nintendo Switch", 9.4);
            Reviews MonsterHunterWorld = new("Joe Skrebels", "Monster Hunter World", "Amazing", "Playstaion 4 Pro", 9.5);
            Reviews AssassinsCreedOrigins = new("Alanah Pearce", "Assassin's Creed Origins", "Amazing", "Xbox One X, Playstation 4, and PC", 9);
            Reviews MarioKart8Deluxe = new("Jose Otero", "Mario Kart 8 Deluxe", "Amazing", "Nintendo Switch", 9.3);
            Reviews Persona5 = new("Andrew Goldfarb", "Persona 5", "Amazing", "Playstation 4", 9.7);
            Reviews HorizonZeroDawn = new("Lucy O'Brien", "Horizon Zero Dawn", "Amazing", "Playstation 4", 9.3);
            Reviews Nioh = new("Chloi Rad", "Nioh", "Amazing", "Playstation 4", 9.6);
            Reviews GearsOfWar4 = new("Ryan Mccaffrey", "Gears Of War 4", "Amazing", "Xbox One", 9.2);
            Reviews Overwatch = new("Vince Ingenito", "Overwatch", "Amazing", "PC,Xbox One, and Playstation 4", 9.4);
            Reviews Uncharted4 = new("Lucy O'Brien","Uncharted 4 A Thief's End", "Amazing", "Playstation 4", 9);
            Reviews RatchetAndClank = new("Marty Sliva", "Ratchet And Clank", "Amazing", "Playstation 4", 9);
            Reviews DarkSouls3 = new("Chloi Rad", "Dark Souls 3", "Amazing", "PC", 9.5);
            Reviews Xcom2 = new("Dan Stapleton", "Xcom 2", "Amazing", "PC", 9.3);
            Reviews Fallout4 = new("Dan Stapleton", "Fallout 4", "Amazing", "Xbox One,Playstation 4, and PC", 9.5);
            Reviews Halo5Guardians = new("Brian Albert", "Halo 5 Guardians", "Amazing", "Xbox One", 9);
            Reviews UnchartedTheNathanDrakeCollection = new("Vince Ingenito", "Uncharted The Nathan Drake Collection", "Amazing", "Playstation 4", 9);
            Reviews TheWitcher3 = new("Vince Ingenito", "The Witcher 3 Wild Hunt", "Amazing", "Playstation 4", 9.3);
            Reviews CultOfTheLamb = new("Tom Marks", "Cult Of The Lamb", "Great", "PC", 8);
            Reviews TinyTinasWonderLand = new("Travis Northup", "Tiny Tina's Wonderlands", "Great", "PC", 8);
            Reviews ShinMegamiTenseiV = new("Leana Hafer", "Shin Megami Tensei V", "Great", "Nintendo Switch", 8);
            Reviews GuardiansOfTheGalaxy = new("Tom Marks", "Marvel's Guardians Of The Galaxy", "Great", "Playstation 5", 8);
            Reviews Back4Blood = new("Kyle Campbell", "Back 4 Blood", "Great", "PC", 8);
            Reviews FarCry6 = new("Jon Ryan", "Far Cry 6", "Great", "Xbox Series X", 8);
            Reviews KenaBridgeOfSpirits = new("Mitchell Saltzman", "Kena Bridge Of Spirits","Great","Playstation 5", 8);
            Reviews ScarletNexus = new("Mitchell Saltzman", "Scarlet Nexus", "Great", "Playstation 5", 8);
            Reviews ResidentEvilVillage = new("Tristan Ogilvie", "Resident Evil Village", "Great", "Playstation 5", 8);
            Reviews Returnal = new("Mitchell Saltzman", "Returnal", "Great", "Playstation 5", 8);
            Reviews SackBoyABigAdventure = new("Tom Marks", "Sackboy A Big Adventure", "Great", "Playstation 5", 8);
            Reviews BugSnax = new("Simon Cardy", "Bugsnax", "Great", "Playstation 5", 8);
            Reviews AssassinsCreedValhalla = new("Brandin Tyrrel", "Assassins Creed Valhalla", "Great", "Xbox Series X", 8);
            Reviews WatchDogsLegion = new("Dan Stapleton", "Watch Dogs Legion", "Great", "PC", 8);
            Reviews Crash4 = new("Jonathon Dornbush", "Crash Bandicoot 4 Its About Time", "Great", "Playstation 4 Pro", 8);
            Reviews WasteLand3 = new("Leif Johnson", "Wasteland 3", "Great", "PC", 8);
            Reviews FinalFantasy7Remake = new("Tom Marks", "Final Fantasy 7 Remake", "Great", "Playstation 4 Pro", 8);
            Reviews CallOfDutyModernWarfare = new("Ryan Mccaffrey", "Call Of Duty Modern Warfare", "Great", "Xbox Series ", 8.2);
            Reviews Control = new("Jonathon Dornbush", "Control", "Great", "Playstation 4 Pro", 8);
            Reviews Rage2 = new("Dan Stapleton", "Rage 2", "Great", "PC", 8);
            Reviews MetroExodus = new("Tristan Ogilvie", "Metro Exodus", "Great", "Xbox One X", 8.5);
            Reviews SpiderMan = new("Jonathon Dornbush", "Marvel's Spider Man", "Great", "Playstation 4 Pro", 8.7);
            Reviews KingdomHearts3 = new("Jonathon Dornbush", "Kingdom Hearts 3", "Great", "Playstation 4 Pro", 8.7);
            Reviews PokemonLetsGoPikachu = new("Miranda Sanchez", "Pokemon Let's Go Pikachu", "Great", "Nintendo Switch", 8.3);
            Reviews PokemonLetsGoEevee = new("Miranda Sanchez", "Pokemon Let's Go Eevee", "Great", "Nintendo Switch", 8.3);
            Reviews Dragonquest = new("Jared Petty", "Dragon Quest XI Echoes Of An Elusive Age", "Great", "Playstation 4", 8.8);
            Reviews FarCry5 = new("Daemon Hatfield", "Far Cry 5", "Great", "Playstation 4 and Xbox One", 8.9);
            Reviews Cuphead = new("Joe Skrebels", "Cuphead", "Great", "Xbox One", 8.8);
            Reviews SoulHacker2 = new("Cameron Hawkins", "Soul Hackers 2", "Good", "Xbox Series X", 7);
            Reviews GhostWireToyko = new("Cam Shea", "Ghostwire Tokyo", "Good", "Playation 5", 7);
            Reviews DyingLight2 = new("Travis Northup", "Dying Light 2 Stay Human", "Good", "Xbox Series X", 7);
            Reviews PokemonLegendsArceus = new("Rebekah Valentine", "Pokemon Legends Arceus", "Good", "Nintendo Switch", 7);
            Reviews BattleField2042 = new("stella Chung", "Battlefield 2042", "Good", "PC", 7);
            Reviews Outiders = new("Jon Ryan", "Outriders", "Good", "PC", 7);
            Reviews ImmortalsFenyxRising = new("Cam Shea", "Immortals Fenyx Rising", "Good", "Xbox Series X", 7);
            Reviews APlagueTaleInnocence = new("Steven Petite", "A Plague Tale Innocence", "Good", "Playstation 4", 7);
            Reviews FarCryNewDawn = new("Daemon Harfield", "Far Cry New Dawn", "Good", "Playstation 4 Pro,Xbox One X, and PC", 7.5);
            Reviews BattlefieldV = new("James Duggan", "Battlefield V", "Good", "PC", 7.5);
            Reviews Hitman2 = new("Ryan Mccaffrey", "Hitman 2", "Good", "Xbox One X, Playstation 4 and PC", 7.7);
            Reviews StateOfDecay2 = new("Dan Stapleton", "State Of Decay 2", "Good", "Xbox One", 7.5);
            Reviews MarioRabbidsKingdomBattle = new("Dan Stapleton", "Mario + Rabbids Kingdom Battle", "Good", "Nintendo Switch", 7.7);
            Reviews UnchartedLostLegacy = new("Marty Sliva", "Uncharted The Lost Legacy", "Good", "Playstation 4", 7.5);
            Reviews MassEffectAndromeda = new("Dan Stapleton", "Mass Effect Andromeda", "Good", "Playstation 4 and Xbox One", 7.7);
            Reviews GhostReconWildlands = new("Brian Albert", "Ghost Recon Wildlands", "Good", "Playstation 4, Xbox One, and PC", 7.9);
            Reviews ResidentEvil7 = new("Chloi Rad", "Resident Evil 7 Biohazard", "Good", "Playstation4, Playstation 4 Pro,Playstation VR, and Xbox One", 7.7);
            Reviews BioMutant = new("Luke Reilly", "Biomutant", "Okay", "Xbox Series X", 6);
            Reviews Avengers = new("Tom Marks", "Marvel's Avengers", "Okay", "Playstation 4 Pro", 6);
            Reviews Deathstranding = new("Tristan Ogilive", "Death Stranding", "Okay", "Playstation 4 Pro", 6.8);
            Reviews Medievil = new("Travis Northup", "Medievil", "Okay", "Playstation 4 Pro", 6.5);
            Reviews DaysGone = new("Lucy O'Brien", "Days Gone", "Okay", "Playstation 4 Pro", 6.5);
            Reviews GhostReconBreakpoint = new("Brandin Tyrrel", "Ghost Recon Breakpoint", "Okay", "Xbox One X", 6);
            Reviews WolfenSteinYoungBlood = new("Dan Stapleton", "Wolfenstein Youngblood", "Okay", "PC", 6.5);
            Reviews Anthem = new("James Duggan", "Anthem", "Okay", "PC", 6.5);
            Reviews StarWarsBattlefront2 = new("Tom Marks", "Star Wars Battlefront 2", "Okay", "PC", 6.5);
            Reviews GrandTheftAutoTheTrilogy = new("Tristan Ogilive", "Grand Theft Auto The Trilogy", "Mediocre", "Playstation 5", 5);
            Reviews Shenmue3 = new("Kyle Hilliard", "Shenmue 3", "Mediocre", "Playstation 4", 5.9);
            Reviews Crackdown3 = new("Brandin Tyrrel", "Crackdown 3", "Mediocre", "Xbox One X and PC", 5);
            Reviews Fallout76 = new("Brandin Tyrrel", "Fallout 76", "Mediocre", "PC,Xbox One X, and Playstation 4 Pro", 5);
            Reviews AlienIsolation = new("Ryan Mccaffrey", "Alien Isolation", "Mediocre", "Xbox One, Playstation 4, and PC", 5);
            Reviews BabylonsFall = new("Justin Koreis", "Babylons Fall", "Bad", "Playstation 5", 4);

            
            
            
            var reviews = new Dictionary<string, Reviews>
        {
            {"Call of Duty Modern Warfare 2", modernWarfare2 },
            {"Gotham Knights", GothamKnights },
            {"A Plague Tale Requiem",PlagueTaleRequim },
            {"Mario + Rabbids Sparks of Hope", SparksofHope },
            {"Overwatch 2",Overwatch2 },
            {"Fifa 23",Fifa23 },
            {"The Last of Us Part 1",LastOfUsPart1 },
            {"Xenoblade 3",Xenoblade3 },
            {"The Quarry",TheQuarry },
            {"Elden Ring",EldenRing },
            {"The Last Of Us Part 2",TheLastOfUsPart2 },
            {"Persona 5 Royal",Persona5Royal },
            {"Red Dead Redemption 2",RedDeadRedemption2 },
            {"God Of War",GodOfWar },
            {"Celeste",Celeste },
            {"Super Mario Odyssey",SuperMarioOdyssey },
            {"The Legend Of Zelda Breath Of The Wild",BreathOfTheWild },
            {"Metal Gear Solid 5 The Phantom Pain",MetalGearSolid5 },
            {"Grand Theft Auto 5",GrandTheftAuto5 },
            {"Bayonetta 3",Bayonetta3 },
           
            {"Total War Warhammer 3",TotalWarWarhammer3 },
            {"Horizon Forbidden West",HorizonForibbenWest },
            {"Halo Infinite",HaloInfinite },
            {"Metroid Dread",MetroidDread },
            {"Tales Of Arise",TalesOfArise },
            {"God Of War Ragnarok",GodOfWarRagnarok },
            {"Deathloop",DeathLoop },
            {"Ratchet And Clank Rift Apart",RatchetAndClankRiftApart },
            {"It Takes Two",ItTakesTwo },
            {"Hitman 3",Hitman3 },
            {"Cyberpunk 2077",CyberPunk2077 },
            {"Demon Souls",DemonSouls },
            {"Spider Man Miles Morales",MilesMorales },
            {"Hades",Hades },
            {"Ghost Of Tsushima",GhostOfTsushima },
            {"Valorant",Valorant },
            {"Resident Evil 3",ResidentEvil3 },
            {"Doom Eternal",DoomEternal },
            {"Animal Crossing New Horizons",AnimalCrossingNewHorizon },
            {"Nioh 2",Nioh2 },
            {"Ori And The Will Of The Wisps",OriAndTheWillOfTheWisps },
            {"Star Wars Jedi Fallen Order",StarWarsJediFallenOrder },
            {"Pokemon Sword",PokemonSword },
            {"Pokemon Shield",PokemonShield },
            {"The Legend Of Zelda Link's Awakening",LinksAwakening },
            {"Gears 5",Gears5 },
            {"Borderlands 3",Borderlands3 },
            {"Astral Chain",AstralChain },
            {"Fire Emblem Three Houses",FireEmblemThreeHouses },
            {"Sekiro Shadows Die Twice",SekiroShadowsDieTwice },
            {"Devil May Cry 5",DevilMayCry5 },
            {"Resident Evil 2",ResidentEvil2 },
            {"Super Smash Bros Ultimate",SuperSmashBrosUltimate },
            {"Assassins Creed Odyssey",AssassinsCreedOdyssey },
            {"Shadow Of The Tomb Raider",ShadowOfTheTombRaider },
            {"Dead Cells",DeadCells },
            {"Octopath Traveler",OctopathTraveler },
            {"Hollow Knight",HollowKinght },
            {"Monster Hunter World",MonsterHunterWorld },
            {"Assassins Creed Origins",AssassinsCreedOrigins },
            {"Mario Kart 8 Deluxe",MarioKart8Deluxe },
            {"Persona 5",Persona5 },
            {"Horizon Zero Dawn",HorizonZeroDawn },
            {"Nioh",Nioh },
            {"Gears Of War 4",GearsOfWar4 },
            {"Overwatch",Overwatch },
            {"Uncharted 4 A Thiefs End",Uncharted4 },
            {"Ratchet And Clank",RatchetAndClank },
            {"Dark Souls 3",DarkSouls3 },
            {"Xcom 2",Xcom2 },
            {"Fallout 4",Fallout4 },
            {"Halo 5 Guardians",Halo5Guardians },
            {"Uncharted The Nathan Drake Collection",UnchartedTheNathanDrakeCollection },
            {"The Witcher 3 Wild Hunt",TheWitcher3 },
            {"Cult Of The Lamb",CultOfTheLamb },
            {"Tiny Tinas Wonderland",TinyTinasWonderLand },
            {"Shin Megami Tensei V",ShinMegamiTenseiV },
            {"Guardians Of The Galaxy",GuardiansOfTheGalaxy },
            {"Back 4 Blood",Back4Blood },
            {"Far Cry 6",FarCry6 },
            {"Kena Bridge Of Spirits",KenaBridgeOfSpirits },
            {"Scarlet Nexus",ScarletNexus },
            {"Resident Evil Village",ResidentEvilVillage },
            {"Returnal",Returnal },
            {"Sackboy A Big Adventure",SackBoyABigAdventure },
            {"Bugsnax",BugSnax },
            {"Assassins Creed Valhalla",AssassinsCreedValhalla },
            {"Watch Dogs Legion",WatchDogsLegion },
            {"Crash Bandicoot 4 Its About Time",Crash4 },
            {"Wasteland 3", WasteLand3},
            {"Final Fantasy 7 Remake",FinalFantasy7Remake },
            {"Call Of Duty Modern Warfare",CallOfDutyModernWarfare },
            {"Control",Control },
            {"Rage 2",Rage2 },
            {"Metro Exodus",MetroExodus },
            {"Spider Man",SpiderMan },
            {"Kingdom Hearts 3",KingdomHearts3 },
            {"Pokemon Lets Go Pikachu",PokemonLetsGoPikachu },
            {"Pokemon Lets Go Eevee",PokemonLetsGoEevee },
            {"Dragon Quest XI Echoes Of An Elusive Age",Dragonquest },
            {"Far Cry 5",FarCry5 },
            {"Cuphead",Cuphead },
            {"Soul Hackers 2",SoulHacker2 },
            {"Ghostwire Tokyo",GhostWireToyko },
            {"Dying Light 2 Stay Human",DyingLight2 },
            {"Pokemon Legends Arceus",PokemonLegendsArceus },
            {"Battlefield 2042", BattleField2042},
            {"Outriders",Outiders },
            {"Immortals Fenyx Rising",ImmortalsFenyxRising },
            {"A Plague Tale Innocence",APlagueTaleInnocence },
            {"Far Cry New Dawn",FarCryNewDawn },
            {"Battlefield V",BattlefieldV },
            {"Hitman 2", Hitman2},
            {"State Of Decay 2",StateOfDecay2 },
            {"Mario + Rabbids Kingdom Battle",MarioRabbidsKingdomBattle },
            {"Uncharted The Lost Legacy",UnchartedLostLegacy },
            {"Mass Effect Andromeda",MassEffectAndromeda },
            {"Ghost Recon Wildlands",GhostReconWildlands },
            {"Resident Evil 7 Biohazard",ResidentEvil7 },
            {"Biomutant",BioMutant },
            {"Avengers",Avengers },
            {"Death Stranding",Deathstranding },
            {"Medievil",Medievil },
            {"Days Gone",DaysGone },
            {"Ghost Recon Breakpoint",GhostReconBreakpoint },
            {"Wolfenstein Youngblood",WolfenSteinYoungBlood },
            {"Anthem",Anthem },
            {"Star Wars Battlefront 2",StarWarsBattlefront2 },
            {"Grand Theft Auto The Trilogy",GrandTheftAutoTheTrilogy },
            {"Shenmue 3",Shenmue3 },
            {"Crackdown 3",Crackdown3 },
            {"Fallout 76",Fallout76 },
            {"Alien Isolation",AlienIsolation },
            {"Babylons Fall",BabylonsFall },









        };

            return reviews;
        }
       
        
       

      





    }
}