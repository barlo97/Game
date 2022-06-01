## Game in Unity - Journal 

A Game in Unity that helps people to learn and memorize keys on the piano, musical interval and chords. 

One of the most effective ways of learning the notes, intervals and chords on the piano is through constant repetition. Although, in the later stages of learning and musical development it's desired that a student improves through his/her own experimental framework it is (I believe) important that he/she aquires good foundation through repetitive tasks.

Repetitive tasks allows a student to become quicker and better, thus reapeting over and over recognizing nots, intervals and chords will make them confident. 

The game that I am developing will be built around repition memorization. At the same time I would like my game to be fun and challenging in a way that awakens competitive spirit - not against someone else , but against themeselves. I would like to engange positive emotions that a player would experience during the gameplay. I would like them to think " Yes, finally! I can recognize this note - or that note " "Yes!!! I finally managed to remember all of the notes" and so on. So in other words I would like them to experience a spirit of success - or succesfull compleition of a certain task or a certain stage of improvement and development. I would like them to feel that the are indeed learning something , so that when they sit in front of the actual piano , or grandpiano they will be confident in what the are doing. 

## First things First - pushing to Github 
The first things that needs to be done is to push the initial project to Github. I have already had a few problems with that - not a surprise, but managed to fix them. The following steps need to be undertaken while pushing a Unity project to Github: 

1.Configure **.gitattribute** and **.gitignore** files 

Those files are important, especially the .gitignore files as it will allow us to ignore all of the unnecessary files from our project. The ones that don't need to be tracked. 


2.**I couldn't push to Github from the Git Bash, because of the LF - CRLF problem. That is why I started using Github Desktop for this project. However, I still prefer the terminal, but bassicaly.** In Unix systems the end of a line is represented with a line feed (LF). In windows a line is represented with a carriage return (CR) and a line feed (LF) thus (CRLF). when you get code from git that was uploaded from a unix system they will only have an LF.If you are a single developer working on a windows machine, and you don't care that git automatically replaces LFs to CRLFs, you can turn this warning off by typing the following in the git command line. I could get rid of this by: 

**git config core.autocrlf true**

3.One useful command I found:\
**rm .git/index.lock**\
This can be used after this error messages appears: **Another git process seems to be running in this repository**




