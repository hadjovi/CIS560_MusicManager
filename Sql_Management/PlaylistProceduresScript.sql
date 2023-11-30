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



DROP PROCEDURE IF EXISTS CreatePlaylist
GO
CREATE PROCEDURE CreatePlaylist @PlaylistName NVARCHAR(100), @PlaylistOwnerID INT, @IsPrivate BIT, @IsDeleted BIT, @PlaylistID INT OUT
AS
INSERT MusicManager.Playlist (PlaylistName, PlaylistOwnerID, IsPrivate, IsDeleted)
VALUES (@PlaylistName, @PlaylistOwnerID, @IsPrivate, @IsDeleted)	

SET @PlaylistID = SCOPE_IDENTITY()
GO
-- EXEC CreatePlaylist @UserId = 2, @PlaylistName = 'TestPlayList', @IsPrivate = 0;

DROP PROCEDURE IF EXISTS AddFriendPlaylist
GO
CREATE PROCEDURE AddFriendPlaylist @PlaylistID INT, @NewUserId INT, @SharedUserPlaylistID INT OUT
AS
INSERT MusicManager.SharedUserPlaylist (PlaylistID, UserID)
VALUES (@PlaylistID, @NewUserID)	

SET @SharedUserPlaylistID = SCOPE_IDENTITY()
GO


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


DROP PROCEDURE IF EXISTS AddSongToPlaylist
GO
CREATE PROCEDURE AddSongToPlaylist @PlaylistID INT, @SongId INT
AS
INSERT MusicManager.SongPlaylistLink (PlaylistID, SongID)
VALUES (@PlaylistID, @SongId);
GO
-- EXEC AddSongToPlaylist @PlaylistID = 10, @SongId = 1


DROP PROCEDURE IF EXISTS DeleteSongFromPlaylist
GO
CREATE PROCEDURE DeleteSongFromPlaylist @PlaylistID INT, @SongId INT
AS
DELETE FROM MusicManager.SongPlaylistLink
WHERE SongID = @SongId
   AND PlaylistID = @PlaylistID;
GO
-- EXEC DeleteSongFromPlaylist @PlaylistID = 10, @SongId = 1