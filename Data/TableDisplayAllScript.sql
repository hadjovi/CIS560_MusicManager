SELECT *
FROM MusicManager.Artist;
-----------------------------------------
SELECT *
FROM MusicManager.Album;
-----------------------------------------
SELECT *
FROM MusicManager.ArtistsAlbum;

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
-----------------------------------------

SELECT *
FROM MusicManager.Genre;
-----------------------------------------
SELECT *
FROM MusicManager.Song;
-----------------------------------------
SELECT *
FROM MusicManager.[User];
-----------------------------------------
SELECT *
FROM MusicManager.Playlist;
-----------------------------------------
SELECT *
FROM MusicManager.SongPlaylistLink;
-----------------------------------------
SELECT *
FROM MusicManager.SharedUserPlaylist;
-----------------------------------------