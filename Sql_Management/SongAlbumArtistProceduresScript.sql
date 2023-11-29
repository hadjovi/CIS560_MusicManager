DROP PROCEDURE IF EXISTS RetrieveAllSongs
GO
CREATE PROCEDURE RetrieveAllSongs 
AS
SELECT S.SongID, S.SongName, S.Playtime, S.TrackNumber, S.GenreID, S.AlbumID
FROM MusicManager.Song AS S
GO
-- EXEC RetrieveAllSongs 


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