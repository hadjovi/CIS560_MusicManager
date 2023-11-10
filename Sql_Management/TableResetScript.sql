USE master;

-- DROP the tables in right order
DROP Table IF EXISTS MusicManager.Artist;
DROP Table IF EXISTS MusicManager.ArtistsAlbum;
DROP Table IF EXISTS MusicManager.Album;
DROP Table IF EXISTS MusicManager.Song;
DROP Table IF EXISTS MusicManager.Genre;
DROP Table IF EXISTS MusicManager.SongPlaylistLink;
DROP Table IF EXISTS MusicManager.Playlist;
DROP Table IF EXISTS MusicManager.Song; 
DROP Table IF EXISTS MusicManager.SharedUserPlaylist;

-- DROP the schema
DROP SCHEMA IF EXISTS MusicManager
Go

-- Create the "MusicManager" schema
CREATE SCHEMA MusicManager
GO

-- Step 1: Create the "User" table
CREATE TABLE MusicManager.Artist(
    ArtistId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    ArtistName VARCHAR(50) NOT NULL,
);