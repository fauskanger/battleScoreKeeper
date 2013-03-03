BattleScoreKeeper
=================

Initially started as an application to keep track of score in a tournament of Tekken 5: Dark Resurrection,
but the 2nd goal is to make it easy to adapt for any similar one on one battle games.

The program keeps track of players, which characters they choose, number of battles, and wins.

Utilizes "sessions" to keep score of tournaments, so one may continue on a previous session at any time.

Total (inter-session) score for the individual player will also be available.

Uses SQL Database Compact Edition to store data;

<h3>Database tables:</h3>


Player
 - id: uniqueidentifier
 - name: nvarchar

Character
 - id: uniqueidentifier
 - name: nvarchar

Battle
 - leftPlayer: uniqueidentifier
 - rightPlayer: uniqueidentifier
 - winner: uniqueidentifier
 - startTime: datetime
 - leftCharacter: uniqueidentifier
 - rightCharacter: uniqueidentifier
 - session: uniqueidentifier
 
Session
 - id: uniqueidentifier
 - Name: nvarchar
 - start: datetime
