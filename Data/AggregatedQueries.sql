DROP PROCEDURE IF EXISTS GetMostPopularGenres
GO
CREATE PROCEDURE GetMostPopularGenres
AS
SELECT G.GenreID,
 G.GenreName,
 COUNT(S.SongID) AS NumberOfSongs
FROM MusicManager.Genre AS G
 INNER JOIN MusicManager.Song AS S ON S.GenreID = G.GenreID
GROUP BY G.GenreID, G.GenreName
ORDER BY NumberOfSongs DESC;
GO
-- EXEC GetMostPopularGenres;



DROP PROCEDURE IF EXISTS ShowCollaboration  
GO
CREATE PROCEDURE ShowCollaboration @ArtistID INT
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
-- EXEC ShowCollaboration @ArtistID = 6;


DROP PROCEDURE IF EXISTS ShowTotalRuntimePerPlaylist
GO
CREATE PROCEDURE ShowTotalRuntimePerPlaylist @PlaylistId INT 
AS
SELECT SPL.PlaylistID,
	(
		SELECT P.PlaylistName
		FROM MusicManager.Playlist AS P
		WHERE P.PlaylistID = SPL.PlaylistID
	) AS PlaylistName,
	COUNT(S.SongName) AS NumberOfSong,
	SUM(S.Playtime) AS TotalPlaytime
FROM MusicManager.SongPlaylistLink AS SPL
	INNER JOIN MusicManager.Song AS S ON S.SongID = SPL.SongID
WHERE SPL.PlaylistID = @PlaylistId
GROUP BY SPL.PlaylistID
--ORDER BY TotalRuntime DESC
GO
-- EXEC ShowTotalRuntimePerPlaylist @PlaylistId = 5;


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