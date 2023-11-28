-- Insert data into Artist table
INSERT MusicManager.Artist (ArtistName, ArtistLabel, ArtistFirstName, ArtistLastName)
VALUES 
    ('Pink Floyd', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'), -- plays in album1 The Dark Side of the Moon
    ('Michael Jackson', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'), -- plays in album2 Thriller
    ('The Beatles', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'), -- plays in album3 Abbey Road
	('Amy Winehouse', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Daft Punk', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Christine', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('The Queens', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('IAM', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Alizée', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Stromae', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Ali Farka Touré', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Paul Simon', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Buena Vista Social Club', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Ali Farka Touré', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Ry Cooder', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Fela Kuti', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Jimi Hendrix', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Stevie Wonder', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Miriam Makeba', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Tinariwen', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Oliver Mtukudzi', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo');


-- Insert data into Album table
INSERT MusicManager.Album (AlbumName)
VALUES 
    ('The Dark Side of the Moon'), 
    ('Thriller'),
    ('Abbey Road'),
	('Purple Haze'),
    ('Graceland'),
    ('Buena Vista Social Club'),
	('Afrodisiac'),
    ('Mama Africa'),
    ('Talking Timbuktu'),
	('Talking Book'),
    ('Pata Pata'),
	('Tassili'),
	('Tuku Music'),
	('Random Access Memories'),
	('Chaleur Humaine'),
	('La Vie Est Belle'),
	('Alizée En Concert'),
	('Racine Carrée'),
	('Back to Black');

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
    ('Progressive Rock'), -- Goes with album1 The Dark Side of the Moon
    ('Pop'), -- Goes with album2 Thriller
    ('Rock'),  -- Goes with album3 Abbey Road
	('R&B'),  -- Goes with album19 Back to Black
    ('Album'),
	('Album'),
    ('Album'),
    ('Album'),
	('Album'),
    ('Album'),
    ('Album');

-- Insert data into Song table
INSERT MusicManager.Song (SongName, TrackNumber, GenreID, AlbumID)
VALUES 
    ('Speak to Me', 1, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('Breathe', 2, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('On the Run', 3, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
	('Time', 4, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('The Great Gig in the Sky', 5, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('Money', 6, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
	('Us and Them', 7, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('Any Colour You Like', 8, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('Brain Damage', 9, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
	('Eclipse', 10, 1, 1),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock

    ('Wanna Be Startin Somethin', 1, 2, 2), -- Belongs to - album2 Thriller - genre2 Pop
    ('Baby Be Mine', 2, 2, 2),
	('The Girl Is Mine', 3, 2, 2),
    ('Thriller', 4, 2, 2),
    ('Beat It', 5, 2, 2),
	('Billie Jean', 6, 2, 2),
    ('Human Nature', 7, 2, 2),
    ('P.Y.T. (Pretty Young Thing)', 8, 2, 2),
	('The Lady in My Life', 9, 2, 2),

    ('Come Together', 1, 3, 3),  -- Belongs to - album3 Abbey Road - genre3 Rock
	('Something', 2, 3, 3),
	('Maxwells Silver Hammer', 3, 3, 3),
	('Oh! Darling', 4, 3, 3),
	('Octopus Garden', 5, 3, 3),
	('I Want You (She is So Heavy)', 6, 3, 3),
	('Here Comes the Sun', 7, 3, 3),
	('Because', 8, 3, 3),
	('You Never Give', 9, 3, 3),

	('Rehab', 1, 19, 4), -- Belongs to - album19 Back to Black - genre4 R&B
	('You Know Im No Good', 2, 19, 4),
	('Me & Mr Jones', 3, 19, 4),
	('Just Friends', 4, 19, 4),
	('Back to Black', 5, 19, 4),
	('Love Is a Losing Game', 6, 19, 4),
	('Tears Dry on Their Own', 7, 19, 4),
	('Wake Up Alone', 8, 19, 4),
	('Some Unholy War', 9, 19, 4),
	('He Can Only Hold Her', 10, 19, 4),

	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
	('Music', 1, 1, 1),
    ('On the Run', 3, 1, 1);

-- Insert data into User table
INSERT MusicManager.[User] ([Name], Email, [Password])
VALUES 
    ('Ben', 'ben@ben.com', 'passwordB560'),
    ('Hursen', 'hursen@hursen.com', 'passwordH560'),
    ('Dennis', 'dennis@dennis.com', 'passwordD560');

-- Insert data into Playlist table
INSERT MusicManager.Playlist (PlaylistName, PlaylistOwnerID, IsPrivate, IsDeleted)
VALUES 
    ('Favorites', 1, 1, 0), -- Playlist 1 owned by Ben 
    ('Party Mix', 1, 1, 0), -- Playlist 2 owned by Ben
    ('Workout Jams', 1, 1, 0), -- Playlist 3 owned by Ben
	('Midnight Melodies', 1, 0, 0), -- Playlist 4 owned by Ben
    ('Eclectic Vibes', 1, 0, 0), -- Playlist 5 owned by Ben
    ('Urban Groove Sessions', 1, 0, 0), -- Playlist 6 owned by Ben
	('Acoustic Serenity', 1, 1, 0), -- Playlist 7 owned by Ben
	('Retro Rewind Jams', 2, 1, 0), -- Playlist 8 owned by Hursen
    ('Indie Discoveries', 2, 0, 0), -- Playlist 9 owned by Hursen
    ('Chillwave Chronicles', 2, 0, 0); -- Playlist 10 owned by Hursen

-- Insert data into SongPlaylistLink table
INSERT MusicManager.SongPlaylistLink (PlaylistID, SongID)
VALUES 
    (1, 1), -- Come Together in Favorites
    (2, 2), -- Bohemian Rhapsody in Party Mix
    (3, 3); 

-- Insert data into SharedUserPlaylist table
INSERT MusicManager.SharedUserPlaylist (PlaylistID, UserID)
VALUES 
    (4, 3), -- Dennis has access to Midnight Melodies
    (5, 3), -- Dennis has access to Eclectic Vibes
    (6, 3), -- Dennis has access to Urban Groove Sessions
	(9, 3), -- Dennis has access to Indie Discoveries
    (10, 3), -- Dennis has access to Chillwave Chronicles
	(9, 1), -- Ben has access to Indie Discoveries
    (10, 1); -- Ben has access to Chillwave Chronicles
