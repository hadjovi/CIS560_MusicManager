USE MusicDB;

SELECT *
FROM MusicDB.dbo.MusicData;

SELECT DISTINCT MD.artist_names
FROM MusicDB.dbo.MusicData AS MD
ORDER BY MD.artist_names ASC;

SELECT DISTINCT *
FROM MusicDB.dbo.spotifySongs AS SS;


SELECT DISTINCT SS.track_artist AS ArtistName,
		N'ArtistLabelDemo' AS ArtistLabel,
		 N'FirstNameDemo' AS ArtistFirstName,
		 N'LastNameDemo' AS ArtistLastName
FROM MusicDB.dbo.spotifySongs AS SS
ORDER BY SS.track_artist ASC;

SELECT DISTINCT SS.track_album_name AS AlbumName,
		SS.track_artist AS ArtistName
FROM MusicDB.dbo.spotifySongs AS SS
ORDER BY SS.track_artist ASC;

SELECT DISTINCT SS.track_artist
FROM MusicDB.dbo.spotifySongs AS SS
ORDER BY SS.track_artist ASC;

SELECT SS.track_artist
FROM spotifySongs AS SS
ORDER BY SS.track_artist ASC;