1. When does Git perform a fast-forward merge and when is a merge commit created?
Git performs a fast-forward merge when the main branch has no new commits after a feature branch was created. In this situation Git only moves the main branch pointer forward to the latest commit of the feature branch.
A merge commit is created when both branches have new commits. Git must combine the histories of both branches, so it creates a new commit that joins them.

2. What is the practical difference between merge and rebase?
Merge combines two branches and usually creates a merge commit. This keeps the full history and shows when branches were joined.
Rebase moves commits from one branch on top of another branch. This makes the history cleaner and more linear, but it changes the commit history.

3. How was the merge conflict resolved in this repository?
A merge conflict was created by changing the same line in `Program.cs` on the `main` branch and on the `feature-conflict` branch.
When merging, Git showed the conflict inside the file. The conflict was resolved manually by editing the file and choosing the final version of the startup message. After removing the conflict markers, the changes were committed.