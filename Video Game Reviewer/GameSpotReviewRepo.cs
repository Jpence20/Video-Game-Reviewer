namespace Video_Game_Reviewer
{

    public class GameSpotReviewRepo
	{
        public static Dictionary<string, Reviews> GameSpot()
        {
            Reviews modernWarfare2 = new("S.E. Doster", "Call of Duty Modern Warfare 2", "Modern Warfare 2 had big shoes to fill, but the campaign includes a large serving of nostalgia and a fun variety of missions.", "Playstation 5", 8);
            Reviews GothamKnights = new("Mark Delaney", "Gotham Knights", "Gotham Knights takes the Arkham blueprint and reimagines it as a loot-brawler, often feeling similar, but where it's different, it's worse.", "Xbox Series X", 4);
            Reviews PlagueTaleRequim = new("Richard Wakeling", "A Plague Tale Requiem", "A Plague Tale: Requiem eventually expands in scope and improves upon its predecessor's stealth action, but the heartrending story of two siblings battling against the odds is where it truly excels.", "PC", 7);
            Reviews SparksofHope = new("Steve Watts", "Mario + Rabbids: Sparks of Hope", "Mario + Rabbids: Sparks of Hope is an improvement over its predecessor in every way, and one of the best modern Mario spin-offs.", "Nitendo Switch", 9);
            Reviews Overwatch2 = new("Jessica Howard", "Overwatch 2", "Overwatch 2 improves upon the core gameplay and characters fans love, but loses some of its predecessor's spirit in the process.", "PC", 8);
            Reviews Fifa23 = new("Richard Wakeling", "Fifa 23", "FIFA 23 makes incremental improvements to last year's game, but the looming presence of Ultimate Team's microtransactions cast a shadow over everything.", "Playstation 5", 7);
            Reviews Xenoblade3 = new("Jake Dekker", "Xenoblade 3", "Xenoblade Chronicles 3 is another heartfelt adventure paired with some of the best combat in the series.", "Nintendo Switch", 8);
            Reviews EldenRing = new("Tamoor Hussain", "Elden Ring", "From Software's latest is a masterpiece of open-world design that places exploration and player agency at the heart of the experience.", "PC", 10);
            Reviews TheLastOfUsPart2 = new("Kallie Plagge", "The Last Of Us Part 2", "The Last of Us Part II is messy, bleak, and brutal.", "Playstation 4", 8);
            Reviews Persona5Royal = new("Michael Higham", "Persona 5 Royal", "Changing the world takes heart.", "Playstation 4", 10);
            Reviews RedDeadRedemption2 = new("Kallie Plagge", "Red Dead Redemption2", "Yee (and I cannot stress this enough) haw.", "Playstation 4 and Xbox One", 9);
            Reviews GodOfWar = new("Peter Brown", "God of War", "The power of myth.", "Playstation 4", 9);
            Reviews Celeste = new("Oscar Dayus", "Celeste", "A game about climbing a mountain", "Nintendo Switch", 10);
            Reviews SuperMarioOdyssey = new("Peter Brown", "Super Mario Odyssey", "Shoot for the moon.", "Nintendo Switch", 10);
            Reviews BreathOfTheWild = new("Peter Brown", "The Legend Of Zelda Breath Of The Wild", "A breathtaking masterpiece.", "Nintendo Switch", 10);
            Reviews MetalGearSolid5 = new("Peter Brown", "Metal Gear Solid 5 The Phantom Pain", "As it was in the beginning, so shall it be in the end.", "Playstaion 4", 10);
            Reviews GrandTheftAuto5 = new("Carolyn Petit", "Grand Theft Auto 5", "City of Angels and Demons", "Playstation 3", 9);
            Reviews Bayonetta3 = new("Jessica Howard", "Bayonetta 3", "Bayonetta 3 is a show-stopping spectacle that feels familiar in all the right ways while also adding mechanics that are sure to delight old and new fans alike.", "Nintendo Switch", 9);
            Reviews TotalWarWarhammer3 = new("Daniel Starkey", "Total War Warhammer 3", "Skulls for the Skull Throne!", "PC", 9);
            Reviews HorizonForibbenWest = new("Phil Hornshaw", "Horizon Forbidden West", "Horizon Forbidden West sometimes packs in so much that it gets in its own way, but the many well-drawn characters populating its quests keep it compelling.", "Playstation 5", 8);
            Reviews HaloInfinite = new("Jordan Ramee", "Halo Infinite Single Player", "Halo Infinite transforms the series' two-decade-old formula for the better, giving protagonist Master Chief more characterization and implementing an open world.", "Xbox Series X", 9);
            Reviews MetroidDread = new("Steven Petite", "Metroid Dread", "Metroid Dread is a stellar adventure that sticks to its roots and is better off because of it", "Nintendo Switch", 8);
            Reviews TalesOfArise = new("Heidi Kemps", "Tales of Arise", "Tales of Arise is a lengthy, beautiful RPG adventure, but has messy combat and uneven pacing on occasion.", "Playstation 5", 7);
            Reviews GodOfWarRagnarok = new("Tamoor Hussain", "God Of War Ragnarok", "Sony Santa Monica brings back what made the original God of War reboot great and delivers another fantastic story with exceptional writing.", "Playstation 5", 9);
            Reviews DeathLoop = new("Tamoor Hussain", "DeathLoop", "Arkane Lyon's follow-up to Dishonored is a masterclass in open-ended action game design.", "Playstation 5", 10);
            Reviews RatchetAndClankRiftApart = new("Steve Watts", "Ratchet And Clank Rift Apart", "Ratchet & Clank: Rift Apart looks and plays better than ever thanks to new-generation hardware, but it's still the same lovable, goofy series at heart.", "Playstation 5", 9);
            Reviews ItTakesTwo = new("Andrew King", "It Takes Two", "It Takes Two is out of sight.", "Xbox Series X, PC, Playstation 4 and Xbox One", 9);
            Reviews Hitman3 = new("Phil Hornshaw", "Hitman 3", "Hitman 3 doesn't make changes to the World of Assassination formula--instead, it refines it through excellent level design.", "PC", 9);
            Reviews CyberPunk2077 = new("Kallie Plagge", "Cyberpunk 2077", "Cyberpunk 2077 has standout side quests and strong main characters, though its buggy, superficial world and lack of purpose bring it down.", "PC", 7);
            Reviews DemonSouls = new("Kevin VanOrd", "Demon Souls", "Brutally challenging and utterly engrossing, this innovative role-playing game is one of the year's best.", "Playstation 5", 9);
            Reviews MilesMorales = new("Jordan Ramee", "Marvel's Spider Man Miles Morales", "Marvel's Spider-Man: Miles Morales sticks a bit too close to its predecessor in terms of mechanics, but manages to stand on its own through its story and characters.", "Playstation 4", 7);
            Reviews Hades = new("Suriel Vazquez", "Hades", "The reason to keep coming back to Hades isn't just the thrills you'll get battling through hell, but the characters and stories you learn about along the way.", "PC and Nintendo Switch", 9);
            Reviews GhostOfTsushima = new("Edmond Tran", "Ghost Of Tsushima", "Ghost of Tsushima has some dull edges, but strikes a lot of highs with its cinematic stylings.", "Playstation 4", 7);
            Reviews Valorant = new("Michael Higham", "Valorant", "Valorant hooks you match after match with tight, tactical gameplay, albeit in rather barebones fashion.", "PC", 7);
            Reviews ResidentEvil3 = new("Alessandro Fillari", "Resident Evil 3", "The remake of Resident Evil 3 makes a strong first impression, and its online companion game Resistance has some interesting ideas, but they both struggle to follow through.", "Playstation 4", 6);
            Reviews DoomEternal = new("Phil Hornshaw", "Doom Eternal", "Doom Eternal intensifies the battles with Hell's hordes by requiring you to constantly calculate the best ways to rip, tear, and stay alive.", "PC,Nintendo Switch, Xbox One, and playstation 4", 8);
            Reviews AnimalCrossingNewHorizon = new("Kallie Plagge", "Animal Crossing New Horizons", "Animal Crossing: New Horizons gives you more creative freedom and more to do on any given day while preserving what makes the series special.", "Nintendo Switch", 9);
            Reviews Nioh2 = new("Mike Epstein", "Nioh 2", "Nioh 2 is even tougher than the original, and you'll get on its level or happily die trying.", "Playstation 4", 8);
            Reviews OriAndTheWillOfTheWisps = new("Steve Watts", "Ori And The Will Of The Wisps", "oon Studios returns with a sophomore effort every bit as graceful and lovely as Ori and the Blind Forest.", "Xbox One ", 9);
            Reviews StarWarsJediFallenOrder = new("Phil Hornshaw", "Star Wars Jedi Fallen Order", "By increasing difficulty, ratcheting back Force powers, and developing compelling characters, Jedi: Fallen Order delivers a worthy expansion to the Star Wars galaxy.", "Playstation 4 ", 8);
            Reviews PokemonSword = new("Kallie Plagge", "Pokemon Sword", "More like Gen M8.", "Nintendo Switch", 9);
            Reviews PokemonShield = new("Kallie Plagge", "Pokemon Shield", "More like Gen M8.", "Nintendo Switch", 9);
            Reviews LinksAwakening = new("Peter Brown", "The Legend Of Zelda Link's Awakening", "The definitive version of the beloved Game Boy classic arrives on Switch.", "Nintendo Switch", 8);
            Reviews Gears5 = new("Phil Hornshaw", "Gears 5", "With new additions, Gears 5 makes its cover-shooter core more adaptive to different playstyles.", "Xbox One and PC", 7);
            Reviews Borderlands3 = new("Jordan Ramee", "Borderlands 3", "What is up, brothers and sisters? God-Queen Tyreen coming to ya live. We got something real special for ya today.", "PC", 8);
            Reviews AstralChain = new("Michael Higham", "Astral Chain", "There's nothing quite like the look and feel of Astral Chain.", "Nintendo Switch", 8);
            Reviews FireEmblemThreeHouses = new("kallie Plage", "Fire Emblem Three Houses", "I live to teach.", "Nintendo Switch", 9);
          
            Reviews SekiroShadowsDieTwice = new("", "Sekiro Shadows Die Twice", "Amazing", "Playstation 4 Pro", 9.5);
            Reviews DevilMayCry5 = new("", "Devil May Cry 5", "Amazing", "Xbox One X", 9.5);
            Reviews ResidentEvil2 = new("", "Resident Evil 2", "Amazing", "Xbox One,Playstation 4, and PC", 9);
            Reviews SuperSmashBrosUltimate = new("", "Super Smash Bros Ultimate", "Amazing", "Nintendo Switch", 9.4);
            Reviews AssassinsCreedOdyssey = new("", "Assassin's Creed Odyssey", "Amazing", "Playstation 4 Pro,Playstation 4, Xbox One X, and Xbox One", 9.2);
            Reviews ShadowOfTheTombRaider = new("", "Shadow Of The Tomb Raider", "Amazing", "Xbox One X", 9);
            Reviews DeadCells = new("", "Dead Cells", "Amazing", "Xbox One X,Playstation 4 Pro,PC,and Nintendo Switch", 9.5);
            Reviews OctopathTraveler = new("", "Octopath Traveler", "Amazing", "Nintendo Switch", 9.3);
            Reviews HollowKinght = new("", "Hollow Knights", "Amazing", "PC and Nintendo Switch", 9.4);
            Reviews MonsterHunterWorld = new("", "Monster Hunter World", "Amazing", "Playstaion 4 Pro", 9.5);
            Reviews AssassinsCreedOrigins = new("", "Assassin's Creed Origins", "Amazing", "Xbox One X, Playstation 4, and PC", 9);
            Reviews MarioKart8Deluxe = new("", "Mario Kart 8 Deluxe", "Amazing", "Nintendo Switch", 9.3);
            Reviews Persona5 = new("", "Persona 5", "Amazing", "Playstation 4", 9.7);
            Reviews HorizonZeroDawn = new("", "Horizon Zero Dawn", "Amazing", "Playstation 4", 9.3);
            Reviews Nioh = new("", "Nioh", "Amazing", "Playstation 4", 9.6);
            Reviews GearsOfWar4 = new("", "Gears Of War 4", "Amazing", "Xbox One", 9.2);
            Reviews Overwatch = new("", "Overwatch", "Amazing", "PC,Xbox One, and Playstation 4", 9.4);
            Reviews Uncharted4 = new("", "Uncharted 4 A Thief's End", "Amazing", "Playstation 4", 9);
            Reviews RatchetAndClank = new("", "Ratchet And Clank", "Amazing", "Playstation 4", 9);
            Reviews DarkSouls3 = new("", "Dark Souls 3", "Amazing", "PC", 9.5);
            Reviews Xcom2 = new("", "Xcom 2", "Amazing", "PC", 9.3);
            Reviews Fallout4 = new("", "Fallout 4", "Amazing", "Xbox One,Playstation 4, and PC", 9.5);
            Reviews Halo5Guardians = new("", "Halo 5 Guardians", "Amazing", "Xbox One", 9);
            Reviews UnchartedTheNathanDrakeCollection = new("", "Uncharted The Nathan Drake Collection", "Amazing", "Playstation 4", 9);
            Reviews TheWitcher3 = new("", "The Witcher 3", "Amazing", "Playstation 4", 9.3);
            Reviews CultOfTheLamb = new("", "Cult Of The Lamb", "Great", "PC", 8);
            Reviews TinyTinasWonderLand = new("", "Tiny Tina's Wonderlands", "Great", "PC", 8);
            Reviews ShinMegamiTenseiV = new("", "Shin Megami Tensei V", "Great", "Nintendo Switch", 8);
            Reviews GuardiansOfTheGalaxy = new("", "Marvel's Guardians Of The Galaxy", "Great", "Playstation 5", 8);
            Reviews Back4Blood = new("", "Back 4 Blood", "Great", "PC", 8);
            Reviews FarCry6 = new("", "Far Cry 6", "Great", "Xbox Series X", 8);
            Reviews KenaBridgeOfSpirits = new("", "Kena Bridge Of Spirits", "Great", "Playstation 5", 8);
            Reviews ScarletNexus = new("", "Scarlet Nexus", "Great", "Playstation 5", 8);
            Reviews ResidentEvilVillage = new("", "Resident Evil Village", "Great", "Playstation 5", 8);
            Reviews Returnal = new("", "Returnal", "Great", "Playstation 5", 8);
            Reviews SackBoyABigAdventure = new("", "Sackboy A Big Adventure", "Great", "Playstation 5", 8);
            Reviews BugSnax = new("", "Bugsnax", "Great", "Playstation 5", 8);
            Reviews AssassinsCreedValhalla = new("", "Assassins Creed Valhalla", "Great", "Xbox Series X", 8);
            Reviews WatchDogsLegion = new("", "Watch Dogs Legion", "Great", "PC", 8);
            Reviews Crash4 = new("", "Crash Bandicoot 4 Its About Time", "Great", "Playstation 4 Pro", 8);
            Reviews WasteLand3 = new("", "Wasteland 3", "Great", "PC", 8);
            Reviews FinalFantasy7Remake = new("", "Final Fantasy 7 Remake", "Great", "Playstation 4 Pro", 8);
            Reviews CallOfDutyModernWarfare = new("", "Call Of Duty Modern Warfare", "Great", "Xbox Series X", 8.2);
            Reviews Control = new("", "Control", "Great", "Playstation 4 Pro", 8);
            Reviews Rage2 = new("", "Rage 2", "Great", "PC", 8);
            Reviews MetroExodus = new("", "Metro Exodus", "Great", "Xbox One x", 8.5);
            Reviews SpiderMan = new("", "Marvel's Spider Man", "Great", "Playstation 4 Pro", 8.7);
            Reviews KingdomHearts3 = new("", "Kingdom Hearts 3", "Great", "Playstation 4 Pro", 8.7);
            Reviews PokemonLetsGoPikachu = new("", "Pokemon Let's Go Pikachu", "Great", "Nintendo Switch", 8.3);
            Reviews PokemonLetsGoEevee = new("", "Pokemon Let's Go Eevee", "Great", "Nintendo Switch", 8.3);
            Reviews Dragonquest = new("", "Dragon Quest XI Echoes Of An Elusive Age", "Great", "Playstation 4", 8.8);
            Reviews FarCry5 = new("", "Far Cry 5", "Great", "Playstation 4 and Xbox One", 8.9);
            Reviews Cuphead = new("", "Cuphead", "Great", "Xbox One", 8.8);
            Reviews SoulHacker2 = new("", "Soul Hackers 2", "Good", "Xbox Series X", 7);
            Reviews GhostWireToyko = new("", "Ghostwire Tokyo", "Good", "Playation 5", 7);
            Reviews DyingLight2 = new("", "Dying Light 2 Stay Human", "Good", "Xbox Series X", 7);
            Reviews PokemonLegendsArceus = new("", "Pokemon Legends Arceus", "Good", "Nintendo Switch", 7);
            Reviews BattleField2042 = new("", "Battlefield 2042", "Good", "PC", 7);
            Reviews Outiders = new("", "Outriders", "Good", "PC", 7);
            Reviews ImmortalsFenyxRising = new("", "Immortals Fenyx Rising", "Good", "Xbox Series X", 7);
            Reviews APlagueTaleInnocence = new("Steven Petite", "A Plague Tale Innocence", "Good", "Playstation 4", 7);
            Reviews FarCryNewDawn = new("Daemon Harfield", "Far Cry New Dawn", "Good", "Playstation 4 Pro,Xbox One X, and PC", 7.5);
            Reviews BattlefieldV = new("James Duggan", "Battlefield V", "Good", "PC", 7.5);
            Reviews Hitman2 = new("Ryan Mccaffrey", "Hitman 2", "Good", "Xbox One X, Playstation 4 and PC", 7.7);
            Reviews StateOfDecay2 = new("Dan Stapleton", "State Of Decay 2", "Good", "Xbox One", 7.5);
            Reviews MarioRabbidsKingdomBattle = new("Dan Stapleton", "Mario + Rabbids Kingdom Battle", "Good", "Nintendo Switch", 7.7);
            Reviews UnchartedLostLegacy = new("Marty Sliva", "Uncharted The Lost Legacy", "Good", "Playstation 4", 7.5);
            Reviews MassEffectAndromeda = new("Dan Stapleton", "Mass Effect Andromeda", "Good", "Playstation 4 and Xbox One", 7.7);
            Reviews GhostReconWildlands = new("Brian Albert", "Ghost Recon Wildlands", "Good", "Playstation 4, Xbox One, and PC", 7.9);
            Reviews ResidentEvil7 = new("Chloi Rad", "Resident Evil 7", "Good", "Playstation4, Playstation 4 Pro,Playstation VR, and Xbox One", 7.7);
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
          
            {"Xenoblade 3",Xenoblade3 },
          
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
            {"The Witcher 3",TheWitcher3 },
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
            {"Resident Evil 7",ResidentEvil7 },
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