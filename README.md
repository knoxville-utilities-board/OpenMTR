# OpenMTR

## Required Software
 - Download/Install [Visual Studio 2017 Community Edition](https://www.visualstudio.com/downloads/)
 - Download/Install [Git](https://git-scm.com/downloads)
 - Download/Install (Optional) [Github Desktop App](https://desktop.github.com/)

## Getting Started
- Pull down this project using ``git clone https://github.com/OpenMTR/OpenMTR.git``
- Open this project with Visual Studio
- In Visual Studio navigate to Tool -> nuget Package Manager -> Package Manager Console
- Paste the following line into the Package Manager Console ``Install-Package OpenCvSharp3-AnyCPU -Version 3.3.1.20171117``

## Develop
- Create a new branch off of master using ``git checkout -b matt-update-readme``. Dasherize your branch name to reflect what you are doing ``bryan-fix-bug``, ``alan-refactor-method``, ``nick-add-documentation``
- When you are ready to save, commit your work either via the desktop app or git command line using ``git add .`` which adds all of your changes to be ready for commit.
- Then using this command you can commit your changes ``git commit -m "chore: Added information to allow a user to pull down and run locally"``
- When you are satisfied with your changes and you have already committed them to your branch create a pull request (PR) in Github. This will allow others to review your changes and if they are good merge them in.
- When merging a PR into master make sure you use the "Squash and Merge Option". This basically squashes all of your commits into one with your PR message being noted in the commit history of the project.
test PR jenkins integration
