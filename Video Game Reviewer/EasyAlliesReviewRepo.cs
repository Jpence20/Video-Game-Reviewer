using System;
using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;


namespace Video_Game_Reviewer
{
    public class EasyAlliesReviewsRepo
    {
        public static Dictionary<string, Reviews> EasyAllies()
        {
            Reviews RedDeadRedemption2 = new("Brandon Jones", "Red Dead Redemption 2", "Rockstar achieves a new level of open world immersion in the second chapter of their wild west epic. Big choices lead to surprising consequences, and lots of customization options generate an attachment to your surroundings. Incredible visuals and spontaneous events create a beautiful, breathing world to explore.", "Playstion 4 Pro", 10);
            Reviews GodOfWar = new("Michael Huber", "God Of War", "God of War reinvents the franchise with deep combat and rewarding exploration.", "Playstation 4 Pro", 10);
            Reviews ShadowOfTheColossus = new("Michael Damiani", "Shadow Of The Colossus", "Shadow of the Colossus is a masterclass effort from BluePoint Games that sets a new standard for remakes.", "Playstation 4 Pro", 10);
            Reviews SuperMarioOdyssey = new("Michael Damiani", "Super Mario Odyssey", "Mario's new Odyssey embraces the past while simultaneous forging a bold new path forward to deliver something truly special.", "Nintendo Switch", 10);
            Reviews Persona5 = new("Ben Moore", "Persona 5", "Persona 5 is a sleek and sassy RPG that will easily steal your heart.", "Playstation 4 Pro", 10);
            Reviews TheLastGuardian = new("Daniel Bloodworth", "The Last Guardian", "Building on the strengths of its predecessors, The Last Guardian presents a majestic and memorable adventure.", "Playstation 4", 10);
            Reviews Uncharted4 = new("Michael Huber", "Uncharted 4 A Thiefs End", "Nathan Drake's treasure-hunting adventures come to an exciting, yet thoughtful conclusion, dazzling with exquisite craftsmanship.", "Playstation 4", 10);
            Reviews PlagueTaleRequim = new("Michael Huber", "A Plague Tale Requiem", "A Plague Tale: Requiem is a solid continuation of Hugo and Amicia's heartfelt journey, offering new depth to the brutal world.", "Playstation 5", 8);
            Reviews SparksofHope = new("Michael Damiani", "Mario + Rabbids: Sparks of Hope", "Mario + Rabbids: Sparks of Hope is a splendid sequel that addresses several of its predecessor's shortcomings and expands its horizons with a revamped combat system and a terrific new take on exploration.", "Nitendo Switch", 8.5);
            Reviews Xenoblade3 = new("Michael Damiani", "Xenoblade Chronicle 3", "Xenoblade Chronicles 3 is a fantastic follow-up that takes some of the best parts of its predecessors, and weaves them into something impressive.", "Nintendo Switch", 9);
            Reviews LastOfUsPart1 = new("Michael Huber", "Last Of Us Part 1", "Naughty Dog looks to leverage the power of the PlayStation 5 to further realize their original vision of The Last of Us, but the improved visuals contribute to a different vibe that isn’t always better. ", "Playstation 5", 8.5);
            Reviews GhostWireToyko = new("Michael Huber", "Ghostwire Tokyo", "Ghostwire: Tokyo is full of supernatural twists and turns, with combat mechanics that feel viscerally satisfying as you wander the streets of its eerily abandoned city.", "Playation 5", 8);
            Reviews TinyTinasWonderLand = new("Ben Moore", "Tiny Tina's Wonderlands", "Wonderlands doesn't reinvent the wheel, but proves there's still joy worth mining from the established Borderlands template, while its tabletop-inspired presentation feels playful and authentic.", "PC", 8);
            Reviews EldenRing = new("Bradley Ellis", "Elden Ring", "Elden Ring is an unforgettable journey that masterfully weaves in its excellent combat with an expertly crafted world, resulting in one of the best open-world games around.", "PC", 9.5);
            Reviews HorizonForibbenWest = new("Brandon Jones", "Horizon Forbidden West", "Horizon Forbidden West takes all the notes gathered from the first game and fashions one of the deepest and most satisfying action games in recent memory.", "Playstation 5", 9);
            Reviews DyingLight2 = new("Ben Moore", "Dying Light 2 Stay Human", "Dying Light 2 is an enjoyable and ambitious game that unfortunately bites off more than it can chew.", "PC", 7);
            Reviews PokemonLegendsArceus = new("Ben Moore", "Pokemon Legends Arceus", "Pokémon Legends: Arceus is exactly the kind of shake-up the series has sorely needed.", "Nintendo Switch", 8);
            Reviews HaloInfinite = new("Ben Moore", "Halo Infinite ", "Halo Infinite is a bold new direction for the series occasionally hampered by significant missteps.", "Xbox Series X and PC", 8);
            Reviews BattleField2042 = new("Michael Huber", "Battlefield 2042", "Battlefield 2042 continues to amplify the massive scale of its warzones, but de-emphasized teamwork and a shaky launch show that it still needs some more time in the oven.", "PC", 7);
            Reviews ShinMegamiTenseiV = new("Ben Moore", "Shin Megami Tensei V", "Shin Megami Tensei V is brutally unforgiving but also one of the most satisfying RPGs in recent memory.", "Nintendo Switch", 9);
            Reviews GuardiansOfTheGalaxy = new("Michael Huber", "Marvel's Guardians Of The Galaxy", "Guardians of the Galaxy offers a fresh take on the familiar team, filled with heart and humor.", "Playstation 5", 8);
            Reviews Back4Blood = new("Michael Huber", "Back 4 Blood", "Back 4 Blood isn't as memorable as its predecessors, but there's a firm foundation to get the party started.", "PC", 7.5);
            Reviews MetroidDread = new("Ben Moore", "Metroid Dread", "Metroid Dread is the very definition of a must-play title.", "Nintendo Switch", 9.5);
            Reviews FarCry6 = new("Ben Moore", "Far Cry 6", "Far Cry 6 manages to be more than just another Far Cry thanks to a strong story and wonderfully chaotic moments.", "PC", 8);
            Reviews KenaBridgeOfSpirits = new("Michael Damiani", "Kena Bridge Of Spirits", "Kena: Bridge of Spirits is a remarkable first effort from Ember Lab that showcases a beautiful world and a touching story.", "Playstation 5", 8);
            Reviews DeathLoop = new("Ben Moore", "DeathLoop", "Deathloop is a mind-bendingly good time.", "Playstation 5", 8);
            Reviews TalesOfArise = new("Michael Damiani", "Tales of Arise", "Tales of Arise brings much needed changes for Bandai Namco's long-running RPG series with stunning new visuals, a refined combat system, and a somber narrative.", "Playstation 5", 8.5);
            Reviews BioMutant = new("Brandon Jones", "Biomutant", "This open-world rampage has lots of ways to customize the combat, traversal, and moral compass of your half-sized hero. Unfortunately, all of these modes and options could have used a little more time in the chop shop.", "Playstation 4 Verison Reviewd on Playstation 5", 6.5);
            Reviews ScarletNexus = new("Michael Damiani", "Scarlet Nexus", "Scarlet Nexus sets itself apart with its inventive battle systems and captivating world, but does it stumble by asking you to complete two campaigns in order to fully appreciate its narrative?", "Playstation 5", 8);
            Reviews RatchetAndClankRiftApart = new("Michael Huber", "Ratchet And Clank Rift Apart", "Rift Apart is a must play-summer blockbuster with heart. *Review Copy Provided by PlayStation", "Playstation 5", 8.5);
            Reviews ResidentEvilVillage = new("Michael Huber", "Resident Evil Village", "Resident Evil Village balances frantic terror with slow creeping fear in an unforgettable setting.", "Playstation 5", 9);
            Reviews Returnal = new("Bradley Ellis", "Returnal", "Returnal is a great new step for Housemarque on the PS5, thanks to its excellent gameplay, intriguing narrative, and replayability.", "Playstation 5", 8.5);
            Reviews Outiders = new("Michael Huber", "Outriders", "A rocky launch and outdated presentation weigh down a rewarding co-op shooter.", "Playstation 5", 7);
            Reviews Hitman3 = new("Michael Huber", "Hitman 3", "The World of Assassination trilogy comes to a gratifying ending in one of the best entries in the series.", "Xbox Series X", 9);
            Reviews CyberPunk2077 = new("Ben Moore", "Cyberpunk 2077", "The glitz and glamour of Night City unfortunately doesn't cover up its rampant bug infestation.", "PC", 7.5);
            Reviews SackBoyABigAdventure = new("Bradley Ellis", "Sackboy A Big Adventure", "Sackboy: A Big Adventure moves away from providing creation tools, but it's still a jolly platformer filled with all the charm you'd expect from one of his outings. ", "Playstation 5", 8);
            Reviews ImmortalsFenyxRising = new("Michael Damiani", "Immortals Fenyx Rising", "Immortals Fenyx Rising delivers a stylized open world odyssey that revels in its mythology.", "Playstation 5", 8);
            Reviews AssassinsCreedValhalla = new("Michael Huber", "Assassins Creed Valhalla", "Assassin's Creed Valhalla thrusts you into the middle of an epic Viking saga that's a pleasure to get lost in.", "Xbox One, Xbox One X, and Xbox Series X", 8.5);
            Reviews DemonSouls = new("Bradley Ellis", "Demon Souls", "Demon's Souls on the PS5 is one of the finest examples of a remake out there thanks to its stunning visuals, great music, and numerous quality of life improvements.", "Playstation 5", 9);
            Reviews BugSnax = new("Daniel BloodWorth", "Bugsnax", "Bugsnax is a delightfully goofy way to start the generation with more personal storytelling than you might expect.", "Playstation 5", 7.5);
            Reviews MilesMorales = new("Brandon Jones", "Marvel's Spider Man Miles Morales", "Miles Morales and the PlayStation 5 are both ready for their big debut, eager to show people what they're made of. The campaign is shorter than the first game, but the map is still full of stories and skirmishes worthy of an amazing hero.", "Playstation 5", 9);
            Reviews WatchDogsLegion = new("Brandon Jones", "Watch Dogs Legion", "Dedsec is now openly recruiting for its troubled London branch, giving you a few dozen personalities to manage as you cause chaos and uncover the city's biggest secrets. Does the overall story in Legion suffer by not having a central protagonist? Or has Watch Dogs discovered the future of the franchise?", "PC", 8);
            Reviews Crash4 = new("Michael Damiani", "Crash Bandicoot 4 Its About Time", "It’s been a long wait, but Crash Bandicoot returns to form in this sequel that lives up to its namesake.", "Playstation 4 Pro", 8.5);
            Reviews Hades = new("Michael Huber", "Hades", "Hades masterfully blends tight combat, storytelling, and varied upgrades to keep you coming back for more.", "PC", 9.5);
            Reviews Avengers = new("Brandon Jones", "Marvel's Avengers", "Crystal Dynamics has met its match with this ambitious action multiplayer slugfest. It's repetitive and buggy, but it also has an emotionally impactful campaign and a roster that ultimately feels very diverse. Based on the game's roadmap, it will one day be much greater at no cost, but is it worth suiting up now to start the grind?", "Playstation 4 Pro", 7);
            Reviews GhostOfTsushima = new("Bradley Ellis", "Ghost Of Tsushima", "Ghost of Tsushima is a captivating journey through ancient Japan with fluid swordplay and a gorgeous world to explore.\r\n", "Playstation4 Pro", 8.5);
            Reviews TheLastOfUsPart2 = new("Michael Huber", "The Last Of Us Part 2", "The Last of Us Part II is an utterly essential tale about love and hate that takes a challenging look below the surface. ", "Playstation 4 Pro", 9.5);
            Reviews Nioh2 = new("Ben Moore", "Nioh 2", "Nioh 2 refines what is great about the original game while also repeating a few mistakes.", "Playstation 4 Pro", 8);
            Reviews AnimalCrossingNewHorizon = new("Brandon Jones", "Animal Crossing New Horizons", "After a few weeks with the latest Animal Crossing, our craving for catching rare bugs and improving our island hasn't calmed one bit. The series' first console release in over a decade has some slow parts, but enough has been improved to make it a difficult vacation to leave behind.", "Nintendo Switch", 9);
            Reviews FinalFantasy7Remake = new("Bradley Ellis", "Final Fantasy 7 Remake", "Final Fantasy VII Remake is an ambitious retelling that feels right at home in the modern era.", "Playstation 4 Pro", 9);
            Reviews ResidentEvil3 = new("Michael Huber", "Resident Evil 3", "Resident Evil 3 is an action-packed journey through the streets of Raccoon City with fear chasing you every step of the way.", "Playstation 4 Pro", 8.5);
            Reviews DoomEternal = new("Ben Moore", "Doom Eternal", "Doom Eternal is a masterful shooter that's willing to push players to new heights.", "PC", 9.5);
            Reviews OriAndTheWillOfTheWisps = new("Michael Damiani", "Ori And The Will Of The Wisps", "Ori’s second adventure outshines the original with improved combat, new boss battles, and another emotional tale.", "PC", 9.5);
            Reviews Shenmue3 = new("Michael Huber", "Shenmue 3", "Despite some glaring issues, Shenmue 3 authentically captures the spirit of its predecessors.", "Playstation 4 Pro", 7);
            Reviews PokemonSword = new("Ben Moore", "Pokemon Sword", "While a lot of Pokémon Sword delights, there are also a number of things holding the games back.", "Nintendo Switch", 7);
            Reviews PokemonShield = new("Ben Moore", "Pokemon Shield", "While a lot of Pokémon Shield delights, there are also a number of things holding the games back.", "Nintendo Switch", 7);
            Reviews StarWarsJediFallenOrder = new("Brad Ellis", "Star Wars Jedi Fallen Order", "Star Wars Jedi: Fallen Order is a fantastic title and stands as one of the best Star Wars games yet.", "Playstation 4 Pro", 9);
            Reviews Deathstranding = new("Ben Moore", "Death Stranding", "Death Stranding is a fearless game that often stumbles, but is still fascinating overall.", "Playstation 4 Pro", 8);
            Reviews CallOfDutyModernWarfare = new("Michael Huber", "Call Of Duty Modern Warfare", "Call of Duty: Modern Warfare provides a more thoughtful campaign and expands the breadth of multiplayer options to deliver some of the best content the series has seen in years.\r\n", "Playstation 4 Pro", 8.5);
            Reviews Medievil = new("Bradley Ellis", "Medievil", "MediEvil is a solid remake that wonderfully updates the visuals, music, and controls while remaining faithful to the PS1 original.", "Playstation 4 Pro", 7);
            Reviews Borderlands3 = new("Daniel BloodWorth", "Borderlands 3", "Borderlands 3 isn’t a huge step forward, but its ridiculous brand of mayhem confidently expands on the distinctive strengths of the series.", "Xbox One X", 8.5);
            Reviews LinksAwakening = new("Michael Damiani", "The Legend Of Zelda Link's Awakening", "Despite some performance issues, the remake of Link’s Awakening for Switch is an unbelievable adventure and an absolute must-play.", "Nintendo Switch", 9);
            Reviews Gears5 = new("Bradley Ellis", "Gears 5", "Along with solid multiplayer, improvements in both the campaign structure and the story help Gears 5 to elevate the series once again.", "Xbox One X", 8);
            Reviews AstralChain = new("Ben Moore", "Astral Chain", "Despite a meager story, Astral Chain is still packed with incredible action.", "Nintendo Switch", 8);
            Reviews Control = new("Michael Huber", "Control", "Control blends storytelling and action as you try to unravel the mysteries of a paranormal agency in crisis.", "Playstation 4 Pro", 9);
            Reviews FireEmblemThreeHouses = new("Ben Moore", "Fire Emblem Three Houses", "Fire Emblem: Three Houses slowly builds up its characters in a way where you can’t help but get invested amid the complex battles.", "Nintendo Switch", 8.5);
            Reviews Rage2 = new("Michael Huber", "Rage 2", "Rage 2 has incredible combat, but not much else.", "Playstation 4 Pro", 7);
            Reviews APlagueTaleInnocence = new("Michael Huber", "A Plague Tale Innocence", "Strong characters and compelling mysteries complement feelings of vulnerability as you try to sneak past threatening guards and horrifying swarms of rats.", "Playstation 4 Pro", 8);
            Reviews DaysGone = new("Brandon Jones", "Days Gone", "Standing out from the ravenous zombie genre, Days Gone brings a lot of heart and massive open-world freaker hordes. It's ambitious in the length of its campaign and the size of its map, but some things just don't work as they should. ", "Playstation 4 Pro", 7.5);
            Reviews SekiroShadowsDieTwice = new("Bradley Ellis", "Sekiro Shadows Die Twice", "Sekiro: Shadows Die Twice is an exhilarating journey. Though it can feel daunting, overcoming each challenge it throws your way fills you with a triumphant sense of accomplishment.", "Playstation 4 Pro", 9.5);
            Reviews DevilMayCry5 = new("Ben Moore", "Devil May Cry 5", "Devil May Cry 5 has some of the best combat yet seen in an action game.", "Xbox One X", 9);
            Reviews Anthem = new("Brandon Jones", "Anthem", "Fans that have waited for Anthem will have to wait a bit longer until it's up to speed with a lot of the competition. Long load times, repetitive missions, and a lack of end-game surprises take a lot of excitement out of what is otherwise a beautiful game with inventive controls.", "Playstation 4 Pro", 6.0);
            Reviews MetroExodus = new("Ben Moore", "Metro Exodus", "Despite a few technical problems, Metro Exodus creates a vast and intensely compelling world.", "PC", 8.5);
            Reviews Crackdown3 = new("Brandon Jones", "Crackdown 3", "After a lot of time in the oven, Crackdown 3 comes out half-baked. The world isn't much to look at, and unless you're really hungry for a co-op action game, have Games Pass, or miss the series terribly, there are much more impressive, recent entries in this genre.", "Xbox One", 5.5);
            Reviews FarCryNewDawn = new("Michael Huber", "Far Cry New Dawn", "Far Cry New Dawn offers a leaner take on Ubisoft’s open world, but doesn't take many risks.", "Playstation 4 Pro", 7);
            Reviews KingdomHearts3 = new("Bradley Ellis", "Kingdom Hearts 3", "Kingdom Hearts III serves as the culmination of the entire series thanks to its engaging combat, wonderful Disney worlds, and strong resolution.", "Playstation 4 Pro", 9.5);
            Reviews ResidentEvil2 = new("Michael Huber", "Resident Evil 2", "The remake of Resident Evil 2 honors its legacy while bringing modern improvements that make the terror feel brand new.", "Playstation 4 Pro", 9);
            Reviews SuperSmashBrosUltimate = new("Michael Damiani", "Super Smash Bros Ultimate", "Super Smash Bros. Ultimate delivers on its namesake and proves to be an amazing fighting game with fantastic single player content and addictive multiplayer.", "Nintendo Switch", 9);
            Reviews Fallout76 = new("Ben Moore", "Fallout 76", "Fallout 76 is barren of good ideas and littered with giant bugs, far too closely resembling the wasteland it depicts.", "PC", 2);
            Reviews BattlefieldV = new("Michael Huber", "BattleField V", "Battlefield V makes meaningful changes that emphasize teamwork more than ever.", "PC", 8);
            Reviews PokemonLetsGoPikachu = new("Michael Damiani", "Pokemon Let's Go Pikachu", "Pokémon: Let’s Go, Pikachu! does introduce several new features and is a good entry point for newcomers to the series, but it ultimately leaves veterans yearning for more.", "Nintendo Switch", 7.5);
            Reviews PokemonLetsGoEevee = new("Micheal Damiani", "Pokemon Let's Go Eevee", "Pokémon:  Let’s Go, Eevee! does introduce several new features and is a good entry point for newcomers to the series, but it ultimately leaves veterans yearning for more. ", "Nintendo Switch", 7.5);
            Reviews Hitman2 = new("Michael Huber", "Hitman 2", "Hitman 2 builds on a solid foundation to deliver an abundance of ways to fulfill Agent 47's lethal contracts.", "Playstation 4 Pro", 8.0);
            Reviews AssassinsCreedOdyssey = new("Michael Huber", "Assassin's Creed Odyssey", "Assassin’s Creed Odyssey builds on the franchise's legacy in meaningful ways.", "Playstation 4 Pro", 9);
            Reviews ShadowOfTheTombRaider = new("Bradley Ellis", "Shadow Of The Tomb Raider", "Shadow of the Tomb Raider is an exciting adventure with a strong sense of discovery and exploration.", "Xbox One X", 8.5);
            Reviews SpiderMan = new("Brandon Jones", "Marvel's Spider Man", "insomniac Games has given us Spider-man on a scale he’s never faced before. They’ve crammed their story full of surprises, with multiple villains to bring down, and a set of trusted friends and tricky gadgets to even the odds. Will this big-budget re-telling of Spidey in his prime connect with fans?", "Playstation 4 Pro", 9.5);
            Reviews Dragonquest = new("Ben Moore", "Dragon Quest XI Echoes Of An Elusive Age", "Dragon Quest XI is a sprawling adventure filled with incredible warmth.", "Playstation 4 Pro", 9);
            Reviews DeadCells = new("Michael Huber", "Dead Cells", "Dead Cells pushes players to the limit for a challenging and rewarding adventure.", "Playstation 4 Pro", 8.0);
            Reviews OctopathTraveler = new("Ben Moore", "Octopath Traveler", "Octopath Traveler's distinct style is only matched by its excellent combat.", "Nintendo Switch", 8);
            Reviews StateOfDecay2 = new("Ben Moore", "State Of Decay 2", "State of Decay 2 is a game full of promise blanketed by bugs and an undercooked structure.", "PC and Xbox One X", 6.0);
            Reviews FarCry5 = new("Brandon Jones", "Far Cry 5", "This year’s Far Cry is heavier than most, but even a morose story can’t keep a good soldier down. By expanding the map and the bond with your AI teammates, the minute to minute madness has never been so personal.", "Playstation 4 Pro", 8);
            Reviews AssassinsCreedOrigins = new("Michael Huber", "Assassin's Creed Origins", "Assassins Creed refines a decade old formula and tells an engaging story in a unique setting.", "Xbox One X", 7);
            Reviews Cuphead = new("Brad Ellis", "Cuphead", "Cuphead's stand out visuals and fantastic encounters provide a thrilling challenge.", "Xbox One",9);
            Reviews MarioRabbidsKingdomBattle = new("Michael Damiani", "Mario + Rabbids Kingdom Battle", "Blending strategy elements from popular contemporaries with the sarcastic humor of the Rabbids series and the charm of the Mario universe, Kingdom Battle is the result of a beautiful oddball marriage.", "Nintendo Switch", 9);
            Reviews UnchartedLostLegacy = new("Michael Huber", "Uncharted The Lost Legacy", "An increased emphasis on puzzles and two charismatic leads make Uncharted: The Lost Legacy an adventure worth taking.", "Playstation 4 Pro", 9);
            Reviews MarioKart8Deluxe = new("Michael Damiani", "Mario Kart 8 Deluxe", "With an overhauled battle mode and several new additions, Mario Kart 8 Deluxe proves it's more than a simple port.", "Nintendo Switch", 9);
            Reviews MassEffectAndromeda = new("Daniel Bloodworth", "Mass Effect Andromeda", "Despite making some clear strides forward, the next chapter of Mass Effect gets off to a troubled start.", "Playstation 4", 6);
            Reviews BreathOfTheWild = new("Michael Damiani", "The Legend Of Zelda Breath Of The Wild", "Link's newest adventure is a radical departure that abandons many of the series' established elements in favor a more open world that constantly encourages and rewards you for exploring the unknown.", "Nintendo Switch", 9);
            Reviews HorizonZeroDawn = new("Brandon Jones", "Horizon Zero Dawn", "This highly-anticipated PS4 exclusive aims to live up to the hype it's generated by creating futuristic battles unlike anything we've played before. In a game about solving mysteries, big and small, how rewarding are the payoffs in the story. Horizon is big and beautiful, but is it a world worth taming?", "Playstation 4", 8);
            Reviews Nioh = new("Ben Moore", "Nioh", "Nioh is an exceptional action game set in a world of demons, warlords, and powerful magic.", "Playstation 4 Pro", 9);
            Reviews ResidentEvil7 = new("Michael Huber", "Resident Evil 7", "Resident Evil 7 breaks new ground while honoring its origins.", "Playstation 4 with ProPlaystation VR", 9);
            Reviews Overwatch = new("Brad Ellis", "Overwatch", "Overwatch takes its place among the best multiplayer shooters with a focus on a fun and diverse cast of heroes.", "PC", 9);
            Reviews DarkSouls3 = new("Ben Moore", "Dark Souls 3", "Dark Souls III combines many of the best aspects from previous games into something special.", "PC, Playstation 4, and Xbox One", 9);
            Reviews GodOfWarRagnarok = new("Michael Huber", "God Of War Ragnarok", "God of War Ragnarok doesn't have the same impact as 2018's dramatic reinvention, but it still stands tall as another epic adventure for the legendary Ghost of Sparta.", "Playstation 5", 9);
            Reviews UmbrellaCorps = new("Michael Huber", "Umbrella Corps", "We had a bad feeling about Umbrella Corps from the start, but the final game is even worse than we'd guessed.", "Playstation 4", 2);

            var reviews = new Dictionary<string, Reviews>
        {
            {"Red Dead Redemption 2",RedDeadRedemption2  },
            {"God Of War",GodOfWar },
            {"Shadow Of The Colossus",ShadowOfTheColossus },
            {"Super Mario Odyssey",SuperMarioOdyssey },
            {"Persona 5",Persona5 },
            {"The Last Guardian",TheLastGuardian },
            {"Unchated 4 A Thiefs End",Uncharted4 },
            {"A Plague Tale Requiem",PlagueTaleRequim },
            {"Mario + Rabbids Sparks of Hope", SparksofHope },
            {"The Last of Us Part 1",LastOfUsPart1 },
            {"Xenoblade 3",Xenoblade3 },
            {"Elden Ring",EldenRing },
            {"The Last Of Us Part 2",TheLastOfUsPart2 },
        
           
            {"The Legend Of Zelda Breath Of The Wild",BreathOfTheWild },
            {"Horizon Forbidden West",HorizonForibbenWest },
            {"Halo Infinite",HaloInfinite },
            {"Metroid Dread",MetroidDread },
            {"Tales Of Arise",TalesOfArise },
            {"God Of War Ragnarok",GodOfWarRagnarok },
            {"Deathloop",DeathLoop },
            {"Ratchet And Clank Rift Apart",RatchetAndClankRiftApart },
            {"Hitman 3",Hitman3 },
            {"Cyberpunk 2077",CyberPunk2077 },
            {"Demon Souls",DemonSouls },
            {"Spider Man Miles Morales",MilesMorales },
            {"Hades",Hades },
            {"Ghost Of Tsushima",GhostOfTsushima },
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
            {"Assassins Creed Origins",AssassinsCreedOrigins },
            {"Mario Kart 8 Deluxe",MarioKart8Deluxe },
      
            {"Horizon Zero Dawn",HorizonZeroDawn },
            {"Nioh",Nioh },
            {"Overwatch",Overwatch },
            {"Uncharted 4 A Thiefs End",Uncharted4 },
            {"Dark Souls 3",DarkSouls3 },
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
            {"Resident Evil 7",ResidentEvil7 },
            {"Biomutant",BioMutant },
            {"Avengers",Avengers },
            {"Death Stranding",Deathstranding },
            {"Medievil",Medievil },
            {"Days Gone",DaysGone },
            {"Anthem",Anthem },
            {"Shenmue 3",Shenmue3 },
            {"Crackdown 3",Crackdown3 },
            {"Fallout 76",Fallout76 },
            {"Umbrella Corps",UmbrellaCorps },
        





        };
       
            
            return reviews;
        }
    }
}