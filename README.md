# C# BASICS
Regarding Self-Paced Learning Paths

## IMPORTANT GIT-GITHUB Commands (DAY - 1)

BASIC COMMANDS (Git-GitHub):

Git is the open-source distributed version control system that facilitates GitHub activities on the laptop or desktop.
* Track changes to code over time.
* Rollback to earlier versions if needed.

GitHub is the cloud hosting platform for Git Repositories.
* It provides the Web UI for repositories.

git --version
git config --global.user.name "SYED"
git config --global.user.email "hello.fsyedrx@ibm.com"

git config --list

git init my-project            
cd my-project                // Change Directory to Master Branch

git clone https://github.com/BenimOsman/MongoDB-Basics
echo "Hello all Git" > hi.txt

git add hi.txt 
git commit -m "hi.txt"

git branch sub-branch
git checkout sub-branch

git add hello.txt
git checkout master
