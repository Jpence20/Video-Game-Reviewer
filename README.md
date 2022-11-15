# Video-Game-Reviewer
The purpose of this project is to be an all in one stop for video game reviews. This includes features such as being to look through reviews of of games from the past 5-7 years from companies like IGN,EasyAllies,GameSpot, and youtube reviewer AngryJoe. These reviews include the name of the reviewer, the game, a review tagline, the system/s that the game was reviews on and the score out of 10. Another feature is that you can write reviews your self. Also you can make a games to play list that will add games to list as you add them with the most recent entry being first in your too play list and asks questions like when you started the game, and what are your thoughts so far. 

## Features
1) Master Loop - This features allows you to go and look at different reviews, write reviews, and add games to list as much as you want and allows you to exit the app whenever you want.
2) Create an additional Class - This can be seen with a parent class of Review and passing on all its properties to the WrittenReview Class and GamesToPlay class, but of these use some if not all the properties from the Reviews class, while also having there own properties.
3) Create a Dictionary - This is how all the Reviews for each company,your written reviews, and the games to a list are saved. So when you search for a review you are pulling an entry from that dictionary and seeing it. For example if you search for The Witcher 3 Wild Hunt in the IGN dictionary it pulls the entry from IGN dictionary and presents it too you.
4) Implement a Regex Expression - For the parts where you can Write a review or add a game to a list, it asks the user to put in a start date in the mm/dd/year format, this expression makes sure that the user puts in that format, and if they don't it asks them to redo it.

### Instructions

When you run the program you will be present with 4 options
1) See Review
2) Make Review
3) Make or See Game List
4) Press any key except 1,2,0r 3 to exit.

From here you can select any of the following, depending on what you want to do.
First if you select See Review you will be presented with choosing from any the review sites to see reviews that they have written, as well as a section to see reviews you have written. 
Once you have Selected a review site, you will then be given a choice of
1)See all Reviews
2)Find a Review
If you select 1 all reviews from the company will be listed.
But if you select 2 you will manually be able to type to find a review.
#### Special Rules for searching for a game
When searching for a specfic game there is certain rules that have to be followed to allowed for the game to show up
1) All words in a game title must be captialized. EX. God Of War would work, while god of war wouldn't.
2) There is no puncatuation at all. Ex The Witcher 3: Wild Hunt, to search for this game you would type it in as The Witcher 3 Wild Hunt.
3) You must use the game's full title. Ex. You couldn't search Breath of the wild, it would have to be The Legend Of Zelda Breath Of The Wild
4) If you search for a game and follow all these rules and still can't find a review for it, that means that company didn't review that game or that game was too old for the scope of this project. 
I will include a text file with all the games that were reviews across the the different reviewers.
Also when searching for a game you reviewed, you will need to search for in the same way you type the name of the game in. Ex When writing your reviewed if you typed in horizon zero dawn, then thats how you would need to search for it, since that was how you type it in.

Note. I would like to update how you search to a more alogrithm based search to where you can type in a name similar to the name and have it pop up, but since dictionaries make you use a specfic key to search that is why these rules are important.

### Instructions Continued
After you get done looking at reviews, you can then choose to either write a review or make a list of games to play. 
Both of these follow similar formats
When you select write review, it will ask you a series of questions such as you name, name of the game, your review, system you played on, time you spent on it, and date you are writing the review. 
From there you can go to see review and select see my reviews and see the review you just wrote.

Then wil the make or see games list, if you select 1 write games into list, it will ask you similar questions to the write review (I still need to go in a change the wording of these questions), after that you can select 2 and see the entries in a list, whith the most recent entry being in position 1, for example if you enter five entries into the list the first entry is in position 5 since it was the first game entered.

I also include a text file with all the games in the program, so if you want to search the reviews for a game, you know what is in there.
