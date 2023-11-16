-- Insert data into Artist table
INSERT MusicManager.Artist (ArtistName, ArtistLabel, ArtistFirstName, ArtistLastName)
VALUES 
    ('The Beatles', 'Apple Records', 'John', 'Lennon'),
    ('Queen', 'EMI Records', 'Freddie', 'Mercury'),
    ('Taylor Swift', 'Republic Records', 'Taylor', 'Swift');
    -- ... (insert at least 50 rows)

-- Insert data into Album table
INSERT MusicManager.Album (AlbumName)
VALUES 
    ('Abbey Road'),
    ('A Night at the Opera'),
    ('1989');
    -- ... (insert at least 50 rows)

-- Insert data into ArtistsAlbum table
INSERT MusicManager.ArtistsAlbum (AlbumID, ArtistID)
VALUES 
    (1, 1), -- The Beatles contributed to Abbey Road
    (2, 2), -- Queen contributed to A Night at the Opera
    (3, 3); -- Taylor Swift contributed to 1989
    -- ... (insert at least 50 rows)

-- Insert data into Genre table
INSERT MusicManager.Genre (GenreName)
VALUES 
    ('Rock'),
    ('Pop'),
    ('Country');
    -- ... (insert at least 50 rows)

-- Insert data into Song table
INSERT MusicManager.Song (SongName, Playtime, TrackNumber, GenreID, AlbumID)
VALUES 
    ('Come Together', 240, 1, 1, 1),
    ('Bohemian Rhapsody', 354, 1, 2, 2),
    ('Shake It Off', 219, 1, 3, 3);
    -- ... (insert at least 50 rows)

-- Insert data into User table
INSERT MusicManager.[User] ([Name], Email, [Password])
VALUES 
    ('user1', 'user1@example.com', 'password1'),
    ('user2', 'user2@example.com', 'password2'),
    ('user3', 'user3@example.com', 'password3');
    -- ... (insert at least 50 rows)

-- Insert data into Playlist table
INSERT MusicManager.Playlist (PlaylistName, PlaylistOwnerID, IsPrivate, IsDeleted)
VALUES 
    ('Favorites', 1, 0, 0), -- Playlist owned by user1
    ('Party Mix', 2, 1, 0), -- Playlist owned by user2
    ('Workout Jams', 3, 1, 0); -- Playlist owned by user3
    -- ... (insert at least 50 rows)

-- Insert data into SongPlaylistLink table
INSERT MusicManager.SongPlaylistLink (PlaylistID, SongID)
VALUES 
    (1, 1), -- Come Together in Favorites
    (2, 2), -- Bohemian Rhapsody in Party Mix
    (3, 3); -- Shake It Off in Workout Jams
    -- ... (insert at least 50 rows)

-- Insert data into SharedUserPlaylist table
INSERT MusicManager.SharedUserPlaylist (PlaylistID, UserID)
VALUES 
    (1, 2), -- user2 has access to Favorites
    (2, 3), -- user3 has access to Party Mix
    (3, 1); -- user1 has access to Workout Jams
    -- ... (insert at least 50 rows)
