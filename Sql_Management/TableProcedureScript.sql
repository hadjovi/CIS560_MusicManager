DROP PROCEDURE IF EXISTS LoginFetch
GO
CREATE PROCEDURE LoginFetch @Email NVARCHAR(100), @Password NVARCHAR(100)
AS
SELECT U.UserID,
		U.[Name]
FROM MusicManager.[User] AS U
WHERE U.Email = @Email
AND U.[Password] = @Password
GO
-- EXEC LoginFecth @UserEmail = 'ben@ben.com', @UserPassword = 'passwordB560';
-- EXEC LoginFecth @UserEmail = 'dang@dang.com', @UserPassword = 'passwordD560';



DROP PROCEDURE IF EXISTS UserSignIn
GO
CREATE PROCEDURE UserSignIn @Name NVARCHAR(100), @Email NVARCHAR(100), @Password NVARCHAR(100), @UserID INT OUTPUT
AS
WITH SourceCte(UserName, UserEmail, UserPassword) AS
   (
	SELECT *
	FROM(
		VALUES(@Name, @Email, @Password)
	)NA(UserName, UserEmail, UserPassword)     
   )
MERGE MusicManager.[User] U
USING SourceCte S ON S.UserEmail = U.Email
WHEN NOT MATCHED THEN
   INSERT([Name], Email, [Password])
   VALUES(@Name, @Email, @Password);

SET @UserID = SCOPE_IDENTITY()
GO

-- EXEC UserSignIn @UserName = Ben, @UserEmail = 'ben@ben.com', @UserPassword = 'passwordB560';
-- EXEC UserSignIn @UserName = Dan, @UserEmail = 'dang@dang.com', @UserPassword = 'passwordD560';

DROP PROCEDURE IF EXISTS UserOwnedPlaylistFecth
GO
CREATE PROCEDURE UserOwnedPlaylistFecth @UserId INT
AS
SELECT P.PlaylistID,
		P.PlaylistName,
		P.IsPrivate,
		P.IsDeleted
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


DROP PROCEDURE IF EXISTS CreatePlaylist
GO
CREATE PROCEDURE CreatePlaylist @PlaylistName NVARCHAR(100), @PlaylistOwnerID INT, @IsPrivate BIT, @IsDeleted BIT, @PlaylistID INT OUT
AS
INSERT MusicManager.Playlist (PlaylistName, PlaylistOwnerID, IsPrivate, IsDeleted)
VALUES (@PlaylistName, @PlaylistOwnerID, @IsPrivate, @IsDeleted)	

SET @PlaylistID = SCOPE_IDENTITY()
GO
-- EXEC CreatePlaylist @UserId = 2, @PlaylistName = 'TestPlayList', @IsPrivate = 0;



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



DROP PROCEDURE IF EXISTS RetrieveAllSongs
GO
CREATE PROCEDURE RetrieveAllSongs 
AS
SELECT S.SongID, S.SongName, S.Playtime, S.TrackNumber, S.GenreID, S.AlbumID
FROM MusicManager.Song AS S
GO
-- EXEC RetrieveAllSongs 


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



DROP PROCEDURE IF EXISTS RetrieveAllUsers
GO
CREATE PROCEDURE RetrieveAllUsers 
AS
SELECT U.UserID, U.[Name], U.Email, U.[Password]
FROM MusicManager.[User] AS U
GO
-- EXEC RetrieveAllUsers 



DROP PROCEDURE IF EXISTS RetrieveAllAlbum
GO
CREATE PROCEDURE RetrieveAllAlbum 
AS
SELECT AB.AlbumID, AB.AlbumName
FROM MusicManager.Album AS AB
GO
-- EXEC RetrieveAllUsers


DROP PROCEDURE IF EXISTS RetrieveAllGenre
GO
CREATE PROCEDURE RetrieveAllGenre 
AS
SELECT G.GenreID, G.GenreName
FROM MusicManager.Genre AS G
ORDER BY G.GenreID ASC
GO
-- EXEC RetrieveAllGenre



DROP PROCEDURE IF EXISTS RetrieveAllArtistAlbum
GO
CREATE PROCEDURE RetrieveAllArtistAlbum 
AS
SELECT AA.ArtistsAlbumID,
		AA.ArtistID,
		(
			SELECT A.ArtistName
			FROM MusicManager.Artist AS A
			WHERE A.ArtistID = AA.ArtistID
		) AS ArtistName,
		AA.AlbumID,
		(
			SELECT AB.AlbumName
			FROM MusicManager.Album AS AB
			WHERE AB.AlbumID = AA.AlbumID
		) AS AlbumName
FROM MusicManager.ArtistsAlbum AS AA;
GO
-- EXEC RetrieveAllArtistAlbum 



DROP PROCEDURE IF EXISTS FilterSongByPlaylist
GO
CREATE PROCEDURE FilterSongByPlaylist @PlaylistId INT 
AS
SELECT S.SongID, S.SongName, S.Playtime, S.TrackNumber, S.GenreID, S.AlbumID
FROM MusicManager.Song AS S
WHERE S.SongID IN
(
	SELECT SPL.SongID
	FROM MusicManager.SongPlaylistLink AS SPL
	WHERE SPL.PlaylistID = @PlaylistId
)
GO
-- EXEC FilterSongByPlaylist @PlaylistId = 9;



DROP PROCEDURE IF EXISTS RetrieveAllSongsWithArtistAlbum
GO
CREATE PROCEDURE RetrieveAllSongsWithArtistAlbum 
AS
SELECT S.SongID, 
	S.SongName, 
	S.AlbumID,
	(
		SELECT AB.AlbumName
		FROM MusicManager.Album AS AB
		WHERE AB.AlbumID = S.AlbumID
	) AS AlbumName,
	AA.ArtistID,
	(
		SELECT A.ArtistName
		FROM MusicManager.Artist AS A
		WHERE A.ArtistID = AA.ArtistID
	) AS ArtistName
FROM MusicManager.Song AS S
	INNER JOIN MusicManager.ArtistsAlbum AS AA ON S.AlbumID = AA.AlbumID
GO
-- EXEC RetrieveAllSongsWithArtistAlbum 


DROP PROCEDURE IF EXISTS FilterSongByPlaylist
GO
CREATE PROCEDURE FilterSongByPlaylist @PlaylistId INT 
AS
SELECT S.SongID, S.SongName, S.Playtime, S.TrackNumber, S.GenreID, S.AlbumID
FROM MusicManager.Song AS S
WHERE S.SongID IN
(
	SELECT SPL.SongID
	FROM MusicManager.SongPlaylistLink AS SPL
	WHERE SPL.PlaylistID = @PlaylistId
)
GO
-- EXEC FilterSongByPlaylist @PlaylistId = 9;



DROP PROCEDURE IF EXISTS FilterSongByAlbum
GO
CREATE PROCEDURE FilterSongByAlbum @AlbumId INT 
AS
SELECT S.SongID, S.SongName, S.Playtime, S.TrackNumber, S.GenreID, S.AlbumID
FROM MusicManager.Song AS S
WHERE S.AlbumID = @AlbumId
GO
-- EXEC FilterSongByAlbum @AlbumId = 10;


DROP PROCEDURE IF EXISTS FilterSongByGenre
GO
CREATE PROCEDURE FilterSongByGenre @GenreId INT 
AS
SELECT S.SongID, S.SongName, S.Playtime, S.TrackNumber, S.GenreID, S.AlbumID
FROM MusicManager.Song AS S
WHERE S.GenreID = @GenreId
GO
-- EXEC FilterSongByGenre @GenreId = 4;


DROP PROCEDURE IF EXISTS FilterSongByArtist
GO
CREATE PROCEDURE FilterSongByArtist @ArtistId INT 
AS
SELECT S.SongID, S.SongName, S.Playtime, S.TrackNumber, S.GenreID, S.AlbumID
FROM MusicManager.Song AS S
WHERE S.AlbumID = 
(
	SELECT AA.AlbumID
	FROM MusicManager.ArtistsAlbum AS AA
	WHERE AA.ArtistID = @ArtistId
)
GO
-- EXEC FilterSongByArtist @ArtistId = 2;


DROP PROCEDURE IF EXISTS GetTop10Songs
GO
CREATE PROCEDURE GetTop10Songs 
AS
SELECT TOP 10 SPL.SongID,
	(
		SELECT S.SongName
		FROM MusicManager.Song AS S
		WHERE S.SongID = SPL.SongID
	) AS SongName,
	COUNT(SPL.PlaylistID) AS NumberOfPlaylist
FROM MusicManager.SongPlaylistLink AS SPL
GROUP BY SPL.SongID
ORDER BY NumberOfPlaylist DESC
GO
-- EXEC GetTop10Songs;



-- SELECT ROUND(RAND() * 123, 0) AS Number


--SELECT DISTINCT S.SongID, 
--	S.SongName, 
--	COUNT(SPL.PlaylistID) AS NumberOfPlaylist,
--	S.AlbumID,
--	(
--		SELECT AB.AlbumName
--		FROM MusicManager.Album AS AB
--		WHERE AB.AlbumID = S.AlbumID
--	) AS AlbumName,
--	AA.ArtistID,
--	(
--		SELECT A.ArtistName
--		FROM MusicManager.Artist AS A
--		WHERE A.ArtistID = AA.ArtistID
--	) AS ArtistName
--FROM MusicManager.Song AS S
--	INNER JOIN MusicManager.ArtistsAlbum AS AA ON S.AlbumID = AA.AlbumID
--	INNER JOIN MusicManager.SongPlaylistLink AS SPL ON SPL.SongID = S.SongID
--GROUP BY S.SongID, S.SongName, S.AlbumID, AA.ArtistID
--ORDER BY NumberOfPlaylist DESC


DROP PROCEDURE IF EXISTS ShowTotalRuntime
GO
CREATE PROCEDURE ShowTotalRuntime 
AS
SELECT SPL.SongID,
	S.SongName,
	SUM(S.Playtime) AS TotalRuntime
FROM MusicManager.SongPlaylistLink AS SPL
	INNER JOIN MusicManager.Song AS S ON S.SongID = SPL.SongID
GROUP BY SPL.SongID, S.SongName
ORDER BY TotalRuntime DESC
GO
-- EXEC ShowTotalRuntime;




DROP PROCEDURE IF EXISTS ShowColaboration  
GO
CREATE PROCEDURE ShowColaboration @ArtistID INT
AS
WITH AlbumCTE(AlbumID, AlbumName) AS
(
	SELECT AA.AlbumID,	
	(
		SELECT AB.AlbumName
		FROM MusicManager.Album AS AB
		WHERE AB.AlbumID = AA.AlbumID
	) AS AlbumName
	FROM MusicManager.ArtistsAlbum AS AA 
	WHERE AA.ArtistID = @ArtistID
)
SELECT AA.ArtistID,
	(
		SELECT A.ArtistName
		FROM MusicManager.Artist AS A
		WHERE A.ArtistID = AA.ArtistID
	) AS ArtistName,
	ACTE.AlbumName
FROM MusicManager.ArtistsAlbum AS AA
	INNER JOIN AlbumCTE AS ACTE ON ACTE.AlbumID = AA.AlbumID
WHERE AA.ArtistID <> @ArtistID
GO
-- EXEC ShowColaboration @ArtistID = 6;




DROP PROCEDURE IF EXISTS ShowArtistGenre  
GO
CREATE PROCEDURE ShowArtistGenre @ArtistID INT
AS
WITH SongGenreCTE(AlbumID, SongName, GenreName) AS
(
	SELECT S.AlbumID,
	S.SongName,
	(
		SELECT G.GenreName
		FROM MusicManager.Genre AS G
		WHERE G.GenreID = S.GenreID
	) AS GenreName
	FROM MusicManager.ArtistsAlbum AS AA 
		INNER JOIN MusicManager.Song AS S ON S.AlbumID = AA.AlbumID
	WHERE AA.ArtistID = @ArtistID
)
SELECT AA.ArtistID,
	(
		SELECT A.ArtistName
		FROM MusicManager.Artist AS A
		WHERE A.ArtistID = AA.ArtistID
	) AS ArtistName,
	ACTE.SongName,
	ACTE.GenreName
FROM MusicManager.ArtistsAlbum AS AA
	INNER JOIN SongGenreCTE AS ACTE ON ACTE.AlbumID = AA.AlbumID
WHERE AA.ArtistID <> @ArtistID
GO
-- EXEC ShowArtistGenre @ArtistID = 6;


DROP PROCEDURE IF EXISTS GetUserOriginalPercntage
GO
CREATE PROCEDURE GetUserOriginalPercntage @UserId INT 
AS
CREATE TABLE #OwnedList(PlaylistID INT, PlaylistName NVARCHAR(100), IsPrivate BIT);
CREATE TABLE #SharedList(PlaylistID INT, PlaylistName NVARCHAR(100), IsPrivate BIT);
INSERT INTO #OwnedList
EXEC UserOwnedPlaylistFecth @UserId = @UserId;
INSERT INTO #SharedList
EXEC UserOwnedPlaylistFecth @UserId = @UserId;
Select *
FROM #OwnedList
GO
-- EXEC GetUserOriginalPercntage @UserId = 1;