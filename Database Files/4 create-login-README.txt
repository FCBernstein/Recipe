script to create login and user is excluded from this repo.
create a file called create-login.sql (this file is ignored by git ignore in this repo)
add the following script to that file

--Important note: create login in master
--use Master
create login [loginname] with PASSWORD = '[password]'

--Important: Switch to HeartyHearthDB
create user [username] from login [loginname]