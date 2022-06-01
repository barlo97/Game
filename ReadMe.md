## Game in Unity

A Game in Unity that helps people to learn and memorize keys on the piano, musical interval and chords. 

## First things First - pushing to Github 
The first things that needs to be done is to push the initial project to Github. I have already had a few problems with that - not a surprise, but managed to fix them. The following steps need to be undertaken while pushing a Unity project to Github: 

1.Configure **.gitattribute** and **.gitignore** files 

Those files are important, especially the .gitignore files as it will allow us to ignore all of the unnecessary files from our project. The ones that don't need to be tracked. 


2.**I couldn't push to Github from the Git Bash, because of the LF - CRLF problem. That is why I started using Github Desktop for this project. However, I still prefer the terminal, but bassicaly.** In Unix systems the end of a line is represented with a line feed (LF). In windows a line is represented with a carriage return (CR) and a line feed (LF) thus (CRLF). when you get code from git that was uploaded from a unix system they will only have an LF.If you are a single developer working on a windows machine, and you don't care that git automatically replaces LFs to CRLFs, you can turn this warning off by typing the following in the git command line. I could get rid of this by: 

**git config core.autocrlf true**

3.One useful command I found: /
**rm .git/index.lock**
This can used after this error messages appears: **Another git process seems to be running in this repository**

