USE master;

-- DROP the tables in right order
DROP Table IF EXISTS MusicManager.ArtistsAlbum;
DROP Table IF EXISTS MusicManager.Artist;
DROP Table IF EXISTS MusicManager.SongPlaylistLink;
DROP Table IF EXISTS MusicManager.Song;
DROP Table IF EXISTS MusicManager.Album;
DROP Table IF EXISTS MusicManager.Genre;
DROP Table IF EXISTS MusicManager.SharedUserPlaylist;
DROP Table IF EXISTS MusicManager.Playlist; 
DROP Table IF EXISTS MusicManager.[User];


-- DROP the schema
DROP SCHEMA IF EXISTS MusicManager
Go

-- Create the "MusicManager" schema
CREATE SCHEMA MusicManager AUTHORIZATION [dbo];
GO


-- Create tables
CREATE TABLE MusicManager.Artist(
    ArtistID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ArtistName NVARCHAR(100) NOT NULL UNIQUE,
	ArtistLabel NVARCHAR(100) NOT NULL,
	ArtistFirstName NVARCHAR(100) NOT NULL,
	ArtistLastName NVARCHAR(100) NOT NULL
);

CREATE TABLE MusicManager.Album(
    AlbumID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    AlbumName NVARCHAR(200) NOT NULL
);

CREATE TABLE MusicManager.ArtistsAlbum(
    ArtistsAlbumID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    AlbumID INT NOT NULL,
	ArtistID INT NOT NULL,
	
	CONSTRAINT [UK_Artist_and_Album] UNIQUE (AlbumID,ArtistID),
	CONSTRAINT FK_ArtistAlbum_Album FOREIGN KEY (AlbumID) REFERENCES MusicManager.Album(AlbumID),
    CONSTRAINT FK_ArtistAlbum_Artist FOREIGN KEY (ArtistID) REFERENCES MusicManager.Artist(ArtistID)
);

CREATE TABLE MusicManager.Genre(
    GenreID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    GenreName NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE MusicManager.Song(
    SongID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    SongName NVARCHAR(100) NOT NULL,
	Playtime INT NOT NULL DEFAULT 0,
	TrackNumber INT NOT NULL,
	GenreID INT NOT NULL,
	AlbumID INT NOT NULL,

	CONSTRAINT [UK_Song_and_Album] UNIQUE (SongName,AlbumID),
	CONSTRAINT [UK_Track_and_Album] UNIQUE (TrackNumber,AlbumID),
	CONSTRAINT FK_Song_Album FOREIGN KEY (AlbumID) REFERENCES MusicManager.Album(AlbumID),
    CONSTRAINT FK_Song_Genre FOREIGN KEY (GenreID) REFERENCES MusicManager.Genre(GenreID)
);

CREATE TABLE MusicManager.[User](
    UserID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL UNIQUE,
	[Password] NVARCHAR(100) NOT NULL
);

CREATE TABLE MusicManager.Playlist(
    PlaylistID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    PlaylistName NVARCHAR(100) NOT NULL,
	PlaylistOwnerID INT NOT NULL,
	IsPrivate BIT NOT NULL DEFAULT 1,
	IsDeleted BIT NOT NULL DEFAULT 0,

	CONSTRAINT FK_Playlist_Song FOREIGN KEY (PlaylistOwnerID) REFERENCES MusicManager.[User](UserID)
);

CREATE TABLE MusicManager.SongPlaylistLink(
    LinkID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    PlaylistID INT NOT NULL,
	SongID INT NOT NULL,
	
	CONSTRAINT [UK_PlaylistID_and_SongID] UNIQUE (PlaylistID,SongID),
	CONSTRAINT FK_SongPlaylistLink_Playlist FOREIGN KEY (PlaylistID) REFERENCES MusicManager.Playlist(PlaylistID),
    CONSTRAINT FK_SongPlaylistLink_Song FOREIGN KEY (SongID) REFERENCES MusicManager.Song(SongID)
);

CREATE TABLE MusicManager.SharedUserPlaylist(
    SharedUserPlaylistID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    PlaylistID INT NOT NULL,
	UserID INT NOT NULL,
	
	CONSTRAINT [UK_PlaylistID_and_UserID] UNIQUE (PlaylistID,UserID),
	CONSTRAINT FK_SharedUserPlaylist_Playlist FOREIGN KEY (PlaylistID) REFERENCES MusicManager.Playlist(PlaylistID),
    CONSTRAINT FK_SharedUserPlaylist_User FOREIGN KEY (UserID) REFERENCES MusicManager.[User](UserID)
);