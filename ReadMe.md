# Game in Unity - Journal 

A Game in Unity that helps people to learn and memorize keys on the piano, musical interval and chords.

One of the most effective ways of learning the notes, intervals and chords on the piano is through constant repetition. Although, in the later stages of learning and musical development it's desired that a student improves through his/her own experimental framework it is (I believe) important that he/she aquires good foundation through repetitive tasks.

Repetitive tasks allow a student to become quicker and better, thus repeating over and over recognizing notes, intervals and chords will make them confident. 

The game that I am developing will be built around repition and memorization. At the same time I would like my game to be fun and challenging in a way that awakens competitive spirit - not against someone else , but against themeselves. I would like to engage positive emotions that a player would experience during the gameplay. I would like them to think " Yes, finally! I can recognize this note - or that note " "Yes!!! I finally managed to remember all of the notes" and so on. So in other words I would like them to experience a spirit of success - or succesfull completion of a certain task or a certain stage of improvement and development. I would like them to feel that the are indeed learning something , so that when they sit in front of the actual piano , or a grandpiano they will be confident in what the are doing.

# The Game Idea

This game would ideally be for  phone or tablet- android - or ios or any other system. It could also be played on a regular computer or laptop, however the design would be primarily for a phone and tablet/ipad.

**Level 1 - Single Notes/Keys**

The Idea of the game is to have a letter (displayed on some sort of nicely designed cube that is representing the key from the piano ) constatly moving towards the piano keys  ( which are displayed in front of the player at a certain distance ). The player's task is to match the letter with the corresponding key on the piano. For example A ----> A on the piano , B ----> B on the piano, C ---> C on the piano ( same for all of the white and black keys). When the letter hits the piano in the right place, a player gets 1 point, the letter is moving forward, new piano keys are generated and the player needs to match the new letter again (The previous letter is changed into a new one in the same place). This is repeated for a number of times until a certain amount of points is scored that allows a player to unlock the next level . The pace at which the letter is moving increases gradually - starts slowly and then slightly increases and goes faster. This gradually  decreases the time that a player has to match a letter with a corresponding place on the piano.

**Level 2 - Intervals**

Interval is a difference in pitch between two sounds. On the piano it is a difference between two keys. 
At the second level a player will need to match two letters that correspond to two places on the piano. The rest of the architecture would be similar to Level 1. A player can control two letters - that means there needs to be some kind of mechanism that allows to switch between two letters - unless I can control them at the same time. 

The difficulty of this level can also be increased and different sublevels can be added or simply diffrent difficulty modes can be added. The first difficulty mode could only focus on the player matching two letters to the piano: 

A & B ---> A & B on the piano.

A second difficulty mode could be a scenario where only one letter is presented and the second is empty - at the same time there is an Interval that a user needs to match (displayed in the centre or somewhere on the screen ) to the piano. This would look something like this : (Extremely raw example in paint):\

**Note: Major 2nd is just an example , this could any other interval.**

![](Images/Level2.png)




Before each difficulty mode it would be best to have a short animated tutorial about the intervals and this could even be applied to each individual intervals - it would be most likely best to do it before each of the interval with a short explanation - and then have the player to repeat the same interval , however starting from different notes each time.

In fact, before each section and level there should be a short animated tutorial with a brief explanation about the upcoming interval or chord and on how to complete the secion and/or level.





**Level 3 - Chords**
A musical chord comprises of three or more notes. 

A player needs to match three letters to the piano and the rest of the architecture and mechanism similar to Level 1 and 2. Here I could also do different difficulty modes, similar to Level 2. For example: 

**1st Difficulty Mode:** Three out of three letters are displayed, and the player needs to match all of them with their corresponding places on the piano.\
**2nd Difficulty Mode:** Two out of three letters are displayed, and there is displayed Interval on screen that indacates how the player needs to match the letter with the piano keys.\
**2nd Difficulty Mode:** One out of three letters is displayed, there is displayed Interval on screen that indacates how the player needs to match the letter with the piano keys.

By adding such difficulty modes - not only the player learns the keys on the piano , by the names of the intervals and chords. This widens the players' musical knoweldge and hopefully will help them when they actually sit in front of the piano. 

## First things First - pushing to Github 
The first things that needs to be done is to push the initial project to Github. I have already had a few problems with that - not a surprise, but managed to fix them. The following steps need to be undertaken while pushing a Unity project to Github: 

1.Configure **.gitattribute** and **.gitignore** files 

Those files are important, especially the .gitignore files as it will allow us to ignore all of the unnecessary files from our project. The ones that don't need to be tracked. 


2.**I couldn't push to Github from the Git Bash, because of the LF - CRLF problem. That is why I started using Github Desktop for this project. However, I still prefer the terminal, but bassicaly.** In Unix systems the end of a line is represented with a line feed (LF). In windows a line is represented with a carriage return (CR) and a line feed (LF) thus (CRLF). when you get code from git that was uploaded from a unix system they will only have an LF.If you are a single developer working on a windows machine, and you don't care that git automatically replaces LFs to CRLFs, you can turn this warning off by typing the following in the git command line. I could get rid of this by: 

**git config core.autocrlf true**

3.One useful command I found:\
**rm .git/index.lock**\
This can be used after this error messages appears: **Another git process seems to be running in this repository**




<div align="right"> 

[Next Page -->](./First_Steps.md) 

</div>
