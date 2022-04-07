James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments (dev-branch-JamesAluoch)
$ git clone https://github.com/220328-uta-sh-net-ext/James-Aluoch.git
Cloning into 'James-Aluoch'...
remote: Enumerating objects: 13, done.
remote: Counting objects: 100% (13/13), done.
remote: Compressing objects: 100% (11/11), done.
remote: Total 13 (delta 4), reused 2 (delta 0), pack-reused 0
Receiving objects: 100% (13/13), done.
Resolving deltas: 100% (4/4), done.

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments (dev-branch-JamesAluoch)
$ cd James-Aluoch

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (main)
$ git checkout -b dev-branch-JamesAluoch
Switched to a new branch 'dev-branch-JamesAluoch'

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ touch commandUsed.md

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ notepad commandUsed.md

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git status
On branch dev-branch-JamesAluoch
Untracked files:
  (use "git add <file>..." to include in what will be committed)
        LoginCredential.txt
        commandUsed.md

nothing added to commit but untracked files present (use "git add" to track)

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git add -A

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git status
On branch dev-branch-JamesAluoch
Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        new file:   LoginCredential.txt
        new file:   commandUsed.md


James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git commit -m "Have mad changes to the commandUsed.md file"
[dev-branch-JamesAluoch 8643aa3] Have mad changes to the commandUsed.md file
 2 files changed, 2 insertions(+)
 create mode 100644 LoginCredential.txt
 create mode 100644 commandUsed.md

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git push
fatal: The current branch dev-branch-JamesAluoch has no upstream branch.
To push the current branch and set the remote as upstream, use

    git push --set-upstream origin dev-branch-JamesAluoch


James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git commit -m "Added CommandUsed.md2"
On branch dev-branch-JamesAluoch
nothing to commit, working tree clean

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git pull
remote: Enumerating objects: 4, done.
remote: Counting objects: 100% (4/4), done.
remote: Compressing objects: 100% (2/2), done.
remote: Total 3 (delta 1), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (3/3), 688 bytes | 86.00 KiB/s, done.
From https://github.com/220328-uta-sh-net-ext/James-Aluoch
   2cec2c0..2ddf900  main       -> origin/main
There is no tracking information for the current branch.
Please specify which branch you want to merge with.
See git-pull(1) for details.

    git pull <remote> <branch>

If you wish to set tracking information for this branch you can do so with:

    git branch --set-upstream-to=origin/<branch> dev-branch-JamesAluoch


James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git add .

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git add -A

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git commit
On branch dev-branch-JamesAluoch
nothing to commit, working tree clean

James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$ git push
fatal: The current branch dev-branch-JamesAluoch has no upstream branch.
To push the current branch and set the remote as upstream, use

    git push --set-upstream origin dev-branch-JamesAluoch


James@LAPTOP-SQ8FQ1T7 MINGW64 /c/Revature/James-Aluoch/James-Aluoch/ShellAssignments/James-Aluoch (dev-branch-JamesAluoch)
$
