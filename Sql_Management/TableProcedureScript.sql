DROP PROCEDURE IF EXISTS LoginFecth
GO
CREATE PROCEDURE LoginFecth @UserEmail NVARCHAR(100), @UserPassword NVARCHAR(100)
AS
SELECT U.UserID,
		U.[Name]
FROM MusicManager.[User] AS U
WHERE U.Email = @UserEmail
AND U.[Password] = @UserPassword
GO
-- EXEC LoginFecth @UserEmail = 'ben@ben.com', @UserPassword = 'passwordB560';


DROP PROCEDURE IF EXISTS UserOwnedPlaylistFecth
GO
CREATE PROCEDURE UserOwnedPlaylistFecth @UserId INT
AS
SELECT P.PlaylistID,
		P.PlaylistName,
		P.IsPrivate
FROM MusicManager.Playlist AS P
WHERE P.PlaylistOwnerID = @UserId
AND P.IsDeleted = 0
GO
-- EXEC UserOwnedPlaylistFecth @UserId = 1;
-- EXEC UserOwnedPlaylistFecth @UserId = 2;



DROP PROCEDURE IF EXISTS SharedPlaylistFecth
GO
CREATE PROCEDURE SharedPlaylistFecth @UserId INT
AS
SELECT P.PlaylistID,
		P.PlaylistName,
		P.IsPrivate
FROM MusicManager.Playlist AS P
WHERE P.PlaylistID IN
(
	SELECT SUP.PlaylistID
	FROM MusicManager.SharedUserPlaylist AS SUP
	WHERE SUP.UserID = @UserId
)
AND P.IsDeleted = 0
AND P.IsPrivate = 0
GO
-- EXEC SharedPlaylistFecth @UserId = 1;
-- EXEC SharedPlaylistFecth @UserId = 3;


DROP PROCEDURE IF EXISTS SetOwnedPlaylistPublic
GO
CREATE PROCEDURE SetOwnedPlaylistPublic @UserId INT, @PlaylistId INT
AS
UPDATE MusicManager.Playlist
SET
	IsPrivate = 0
WHERE PlaylistID = @PlaylistId
	AND PlaylistOwnerID = @UserId
	AND IsPrivate <> 0
	AND IsDeleted = 0	
GO
-- EXEC SetOwnedPlaylistPublic @UserId = 1, @PlaylistId = 3;



DROP PROCEDURE IF EXISTS SetOwnedPlaylistPrivate
GO
CREATE PROCEDURE SetOwnedPlaylistPrivate @UserId INT, @PlaylistId INT
AS
UPDATE MusicManager.Playlist
SET
	IsPrivate = 1
WHERE PlaylistID = @PlaylistId
	AND PlaylistOwnerID = @UserId
	AND IsPrivate <> 1
	AND IsDeleted = 0	
GO
-- EXEC SetOwnedPlaylistPrivate @UserId = 2, @PlaylistId = 9;
-- EXEC SetOwnedPlaylistPrivate @UserId = 1, @PlaylistId = 4;



DROP PROCEDURE IF EXISTS DeleteOwnedPlaylist
GO
CREATE PROCEDURE DeleteOwnedPlaylist @UserId INT, @PlaylistId INT
AS
UPDATE MusicManager.Playlist
SET
	IsDeleted = 1
WHERE PlaylistID = @PlaylistId
	AND PlaylistOwnerID = @UserId
	AND IsDeleted <> 1	
GO
-- EXEC DeleteOwnedPlaylist @UserId = 2, @PlaylistId = 9;
-- EXEC DeleteOwnedPlaylist @UserId = 1, @PlaylistId = 4;