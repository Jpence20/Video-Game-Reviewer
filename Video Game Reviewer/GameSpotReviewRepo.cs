namespace Video_Game_Reviewer
{

    public class GameSpotReviewRepo
	{
        public static Dictionary<string, Reviews> GameSpot()
        {
            Reviews ModernWarfare2 = new("S.E. Doster", "Call of Duty Modern Warfare 2", "Modern Warfare 2 had big shoes to fill, but the campaign includes a large serving of nostalgia and a fun variety of missions.", "Playstation 5", 8);
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
            Reviews SekiroShadowsDieTwice = new("Tamoor Hussain", "Sekiro Shadows Die Twice", "You see someone that you know and they ask you how you are and you just have to say that you're fine, when you're not really fine, but you just can't get into it because they would never understand.", "Playstation 4 ", 9);
            Reviews DevilMayCry5 = new("Matt Espineli", "Devil May Cry 5", "This party is still crazy.", "Xbox One ", 9);
            Reviews ResidentEvil2 = new("Alessandro Fillari", "Resident Evil 2", "Re-enter the survival horror.", "Xbox One,Playstation 4, and PC", 9);
            Reviews SuperSmashBrosUltimate = new("Edmond Tran", "Super Smash Bros Ultimate", "Smash has spirit, oh yes it does.", "Nintendo Switch", 9);
            Reviews AssassinsCreedOdyssey = new("Alessandro Fillari", "Assassin's Creed Odyssey", "Choose your own adventure.", "Playstation 4, Xbox One X, and Xbox One", 8);
            Reviews ShadowOfTheTombRaider = new("Edmond Tran", "Shadow Of The Tomb Raider", "Standing in the shadows.", "Xbox One,Playstation 4, and PC", 6);
            Reviews DeadCells = new("Daniel Starkey", "Dead Cells", "Death sells.", "Xbox One X,Playstation 4 Pro,PC,and Nintendo Switch", 9);
            Reviews OctopathTraveler = new("Peter Brown", "Octopath Traveler", "All for one and one for all.", "Nintendo Switch and PC", 8);
            Reviews HollowKinght = new("Alessandro Barbosa", "Hollow Knight", "A bug's life.", "Nintendo Switch", 9);
            Reviews MonsterHunterWorld = new("Ginny Woo", "Monster Hunter World", "Hunt, feast, survive.", "Playstaion 4", 8);
            Reviews AssassinsCreedOrigins = new("Alessandro Fillari", "Assassin's Creed Origins", "Come for the assassinations, stay for the sights.", "Xbox One X, Playstation 4, and PC", 7);
            Reviews MarioKart8Deluxe = new("Kallie Plagge", "Mario Kart 8 Deluxe", "Joy(-Con) ride.", "Nintendo Switch", 9);
            Reviews Persona5 = new("Lucy James", "Persona 5", "Style and substance.", "Playstation 4", 9);
            Reviews HorizonZeroDawn = new("Peter Brown", "Horizon Zero Dawn", "The call of the wild.", "Playstation 4", 9);
            Reviews Nioh = new("Gamespot Staff", "Nioh", "A walk among the tombstones.", "Playstation 4", 9);
            Reviews GearsOfWar4 = new("Mike Mahardy", "Gears Of War 4", "The next generation.", "Xbox One", 7);
            Reviews Overwatch = new("Mike Mahardy", "Overwatch", "Iceberg theory.", "PC", 9);
            Reviews Uncharted4 = new("Mike Mahardy", "Uncharted 4 A Thief's End", "One more day in paradise.", "Playstation 4", 10);
            Reviews RatchetAndClank = new("Cassidee Moser", "Ratchet And Clank", "The Lombax, the Robot, and the arsenal.", "Playstation 4", 8);
            Reviews DarkSouls3 = new("Mike Mahardy", "Dark Souls 3", "The only way is through.", "Xbox One and Playstation 4", 8);
            Reviews Xcom2 = new("Mike Mahardy", "Xcom 2", "Survival of the fittest.", "PC", 9);
            Reviews Fallout4 = new("Peter Brown", "Fallout 4", "Picking up the pieces.", "Xbox One,Playstation 4, and PC", 9);
            Reviews Halo5Guardians = new("Mike Mahardy", "Halo 5 Guardians", "A shift in the tide.", "Xbox One", 8);
            Reviews UnchartedTheNathanDrakeCollection = new("Mike Mahardy", "Uncharted The Nathan Drake Collection", "From small beginnings.", "Playstation 4", 8);
            Reviews TheWitcher3 = new("Kevin VanOrd", "The Witcher 3 Wild Hunt", "The dark places of the land are full of the habitations of violence.", "Playstation 4", 10);
            Reviews CultOfTheLamb = new("Jessica Howard", "Cult Of The Lamb", "Cult of the Lamb merges the best parts of a roguelike with all the charms of a real-ti", "PC", 9);
            
            Reviews TinyTinasWonderLand = new("Darryn Bonthuys", "Tiny Tina's Wonderlands", "Tiny Tina's Wonderlands is an easily digestible adventure with fantasy flavor, but this Borderlands spin-off struggles to find its own identity.", "PC", 7);
            Reviews ShinMegamiTenseiV = new("Heidi Kmeps", "Shin Megami Tensei V", "Shin Megami Tensei V may be slow-paced, but its strategic turn-based combat and dark, foreboding atmosphere deliver a challenging and rewarding RPG experience.", "Nintendo Switch", 8);
            Reviews GuardiansOfTheGalaxy = new("Jordan Ramee", "Marvel's Guardians Of The Galaxy", "Eidos-Montréal's Guardians of the Galaxy digs into the weird side of Marvel comics to deliver a fulfilling story about the titular heroes.", "Playstation 5", 7);
            Reviews Back4Blood = new("Richard Wakeling", "Back 4 Blood", "Back 4 Blood recaptures the spirit of Left 4 Dead while introducing some engaging modern trappings.", "Playstation 5", 7);
            Reviews FarCry6 = new("Phil Hornshaw", "Far Cry 6", "Though it can be really fun, especially when it descends into absolute chaos, Far Cry 6 is overstuffed and disjointed, with so many ideas that it's tough to focus.", "PC", 7);
            Reviews KenaBridgeOfSpirits = new("Phil Hornshaw", "Kena Bridge Of Spirits", "ena: Bridge of Spirits uses a different perspective on familiar gameplay ideas to create tons of exciting combat and a deep emotional connection with its world.", "Playstation 5", 9);
            Reviews ScarletNexus = new("Heidi Kmeps", "Scarlet Nexus", "The story of Scarlet Nexus might be a mess, but fun action and great character moments make it worth your time.", "Playstation 5, Playstation 4, Pc, Xbox One, and Xbox Series X", 7);
            Reviews ResidentEvilVillage = new("Phil Hornshaw", "Resident Evil Village", "The sequel to Resident Evil 7 leans heavily on Resident Evil 4's brand of action, but adds its own sensibilities to the mix.", "Playstation 5, Playstation 4, Xbox One, Xbox Series X, and PC", 9);
            Reviews Returnal = new("Mike Epstein", "Returnal", "Returnal blends elements of shooters, roguelikes, action games, and horror to redefine bullet hell and conjure a mysterious, moody masterpiece.", "Playstation 5", 9);
            Reviews SackBoyABigAdventure = new("Mike Epstein", "Sackboy A Big Adventure", "Though Sackboy: A Big Adventure's aesthetic is a bit basic, its solid platforming presents a good challenge.", "Playstation 5", 7);
            Reviews BugSnax = new("Mike Epstein", "Bugsnax", "Where the beetles taste like baked potatoes.", "Playstation 5", 8);
            Reviews AssassinsCreedValhalla = new("Jordan Ramee", "Assassins Creed Valhalla", "Though its campaign takes time to get going, Assassin's Creed Valhalla brings a satisfying finish to the current saga of the franchise.", "Xbox Series X", 8);
            Reviews WatchDogsLegion = new("Alessandro Fillari", "Watch Dogs Legion", "Watch Dogs: Legion struggles with tone at times, but its empowering message about unity and justice still shines in a game that is as absurd as it is impactful.", "PC, Playstaion 4 and Xbox One", 8);
            Reviews Crash4 = new("Mike Epstein", "Crash Bandicoot 4 Its About Time", "Crash 4 is a pitch-perfect revival of the classic platformer franchise.", "Xbox One, Playstation 4, and Playstation 5", 8);
            Reviews FinalFantasy7Remake = new("Tamoor Hussain", "Final Fantasy 7 Remake", "Square Enix tells a smaller, more personal Final Fantasy 7 tale and marries it with a smart mashup of action and RPG gameplay to deliver a must-play experience. Its PS5 version realizes the world of Midgar with stunning new detail.", "Playstation 4 ", 10);
            Reviews CallOfDutyModernWarfare = new("Kallie Plagge", "Call Of Duty Modern Warfare", "Modern Warfare stumbles at points, but strong campaign missions and smart multiplayer additions keep it from falling too far.", "Playstation 4 and PC", 7);
            Reviews Control = new("Peter Brown", "Control", "A return to form for Remedy Games.", "Playstation 4 and Xbox One", 8);
            Reviews Rage2 = new("Michael Higham", "Rage 2", "Seize the means of destruction.", "PC", 6);
            Reviews MetroExodus = new("Michael Higham", "Metro Exodus", "Light at the end of the tunnel.", "PC and Playstation 4", 8);
            Reviews SpiderMan = new("Edmond Tran", "Marvel's Spider Man", "Spinning an astonishing tale.", "Playstation 4", 9);
            Reviews KingdomHearts3 = new("Tamoor Hussain", "Kingdom Hearts 3", "Not quite Heartless.", "Playstation 4 and Xbox One", 8);
            Reviews PokemonLetsGoPikachu = new("Jake Dekker", "Pokemon Let's Go Pikachu", "A fresh Pallet.", "Nintendo Switch", 8);
            Reviews PokemonLetsGoEevee = new("Jake Dekker", "Pokemon Let's Go Eevee", "A fresh Pallet.", "Nintendo Switch", 8);
            Reviews Dragonquest = new("Heidi Kemps", "Dragon Quest XI Echoes Of An Elusive Age", "Some magic never fades.", "Playstation 4", 9);
            Reviews FarCry5 = new("Edmond Tran", "Far Cry 5", "The Land Of Plenty", "Playstation 4 and Xbox One", 9);
            Reviews Cuphead = new("Peter Brown", "Cuphead", "Stick and move.", "Xbox One", 9);
            Reviews SoulHacker2 = new("Heidi Kemps", "Soul Hackers 2", "Soul Hackers 2 is a stylish, engaging JRPG with great characters, but dull dungeon design dampens the experience.", "Playstation 5", 7);
            Reviews GhostWireToyko = new("Richard Wakeling", "Ghostwire Tokyo", "Ghostwire: Tokyo's unique supernatural combat and eerily beautiful open-world paper over the cracks of its subpar story and inconsistent side missions.", "Playation 5", 8);
            Reviews DyingLight2 = new("Mark Delaney", "Dying Light 2 Stay Human", "Techland's undead sequel improves upon the strongest element of its predecessor, but things like story and characters drag it down.", "Xbox Series X", 6);
            Reviews PokemonLegendsArceus = new("Steve Watts", "Pokemon Legends Arceus", "Pokemon Legends: Arceus is a significant reimagining of what makes a Pokemon game, with an exciting level of flexibility that's only slightly hampered by a slow early-game grind.", "Nintendo Switch", 8);
            Reviews BattleField2042 = new("Phil HornShaw", "Battlefield 2042", "Although some specialists can feel a bit useless at times, tweaks to the formula with Battlefield 2042 add a lot of interesting gameplay variety.", "PC", 7);
            Reviews Outiders = new("Phil HornShaw", "Outriders", "People Can Fly's Outriders mixes a lot of well-worn shooter and RPG elements to create something that feels fresh, if you can get used to its balance.", "PC, Playstation 4, Xbox One, Playstation 5, and Xbox Series X", 8);
            Reviews ImmortalsFenyxRising = new("Suriel Vazquez", "Immortals Fenyx Rising", "It doesn't match the highs from the games it cribs from, but Immortals Fenyx Rising is a breezy, lighthearted romp.", "Xbox Series X and Playstation 5", 7);
            Reviews APlagueTaleInnocence = new("Khee Hoon Chan", "A Plague Tale Innocence", "Bleak and unsettling.", "Playstation 4, Xbox One, and PC", 8);
          
            Reviews FarCryNewDawn = new("", "Far Cry New Dawn", "Good", "Playstation 4 Pro,Xbox One X, and PC", 7.5);
            Reviews BattlefieldV = new("", "Battlefield V", "Good", "PC", 7.5);
            Reviews Hitman2 = new("", "Hitman 2", "Good", "Xbox One X, Playstation 4 and PC", 7.7);
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
           {"Call of Duty Modern Warfare 2", ModernWarfare2 },
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