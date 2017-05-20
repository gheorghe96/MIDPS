# lab1
This is first laboratory, that consists of git setup, learning basics of commiting, branching, etc.

Steps taken:
* [Create repository on github](#create-repository-on-github)
* [Initializing git](#initializing-git-on-local-machine)
* [Adding .gitignore](#adding-gitignore)
* [Creating second branch](#creating-second-branch)
* [Merging branches](#merging-branches)
* [Conflict solving](#conflict-solving)
* [Creating tags](#creating-tags)

### Create repository on github
![Creating web repository on github]

### Initializing git on local machine

```sh
$ git clone https://github.com/gheorghe96/MIDPS
```

```
Cloning into 'midps'...
remote: Counting objects: 3, done.
remote: Total 3 (delta 0), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (3/3), done.
```
### Adding .gitignore
![Creating commit to add .gitignore]

```sh
$ echo '' > .gitignore
$ git status
$ git add .
$ git commit -m "Added .gitingore"
```
### Creating second branch

```sh
$ git checkout -b 0.2-dev
Switched to a new branch '0.2-dev'

```

### Merging branches
![Merging branches]

```sh
$ git merge master
Updating d9abf04..f569c5a
Fast-forward
 README.md      | 14 +++++++++++-
 lab1/README.md | 67 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++-
 2 files changed, 79 insertions(+), 2 deletions(-)
```

### Conflict solving
![Conflict solving]

```sh
$ git merge master
error: Merging is not possible because you have unmerged files.
hint: Fix them up in the work tree, and then use 'git add/rm <file>'
hint: as appropriate to mark resolution and make a commit.
fatal: Exiting because of an unresolved conflict.
```
making needed changes to conflict files, after that
```sh
$ git add .
```

### Creating tags
![Creating tags]

```sh
git tag 0.1-dev
```
