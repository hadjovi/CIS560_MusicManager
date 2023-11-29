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
	('Paul Simon', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Buena Vista Social Club', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Ali Farka Touré', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Ry Cooder', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Fela Kuti', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Jimi Hendrix', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Stevie Wonder', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Miriam Makeba', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Tinariwen', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'),
	('Miles Davis', 'ArtistLabelDemo', 'FirstNameDemo', 'LastNameDemo'), -- ablum19
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
	('Kind of Blue'),
	('Back to Black');

-- Insert data into ArtistsAlbum table
INSERT MusicManager.ArtistsAlbum (AlbumID, ArtistID)
VALUES 
    (1, 1),
    (2, 2),
	(3, 3),
	(4, 16),
	(5, 11),
	(6, 12),
	(7, 15),
	(8, 18),
	(9, 13),
	(10, 17),
	(11, 18),
	(12, 19),
	(13, 21),
	(14, 5),
	(15, 6),
	(15, 7),
	(16, 8),
	(17, 9),
	(18, 10),
	(19, 20),
	(20, 4)

-- Insert data into Genre table
INSERT MusicManager.Genre (GenreName)
VALUES 
    ('Progressive Rock'),
    ('Pop'), 
    ('Rock'), 
	('R&B'),  
    ('Electronic'),
	('Hip Hop'),
    ('Indie Pop'),
    ('Blues'),
	('Cuban Son'),
    ('Afrobeat'),
	('Afro-Jazz'),
    ('Jazz'),
	('Genre');

-- Insert data into Song table
INSERT MusicManager.Song (SongName, TrackNumber, AlbumID, GenreID)
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

	('Rehab', 1, 20, 4), -- Belongs to - album20 Back to Black - genre4 R&B
	('You Know Im No Good', 2, 20, 4),
	('Me & Mr Jones', 3, 20, 4),
	('Just Friends', 4, 20, 4),
	('Back to Black', 5, 20, 4),
	('Love Is a Losing Game', 6, 20, 4),
	('Tears Dry on Their Own', 7, 20, 4),
	('Wake Up Alone', 8, 20, 4),
	('Some Unholy War', 9, 20, 4),
	('He Can Only Hold Her', 10, 20, 4),

	('Purple Haze', 1, 4, 3),  -- Belongs to - album4 Purple Haze - genre3 Rock
	('Manic Depression', 2, 4, 3),
	('Hey Joe', 3, 4, 3),
	('Love or Confusion', 4, 4, 3),
	('May This Be Love', 5, 4, 3),
	('I Dont Live Today', 6, 4, 3),
	('The Wind Cries Mary', 7, 4, 3),
	('Fire', 8, 4, 3),
	('Third Stone from the Sun', 9, 4, 3),
	('Foxey Lady', 10, 4, 3),

	('So What', 1, 19, 12), -- Belongs to - album19 Kind of Blue - genre12 Jazz
	('Freddie Freeloader', 2, 19, 12),
	('Blue in Green', 3, 19, 12),
	('All Blues', 4, 19, 12),
	('Flamenco Sketches', 5, 19, 12),

	('Diaraby', 1, 9, 8), -- Belongs to - album9 Talking Timbuktu - genre8 Blues
	('Dofana', 2, 9, 8),
	('In the Heart of the Moon', 3, 9, 8),
	('Ai Du', 4, 9, 8),

	('The Boy in the Bubble', 1, 5, 2), -- Belongs to - album5 Graceland - genre2 Pop
	('Graceland', 2, 5, 2),
	('I Know What I Know', 3, 5, 2),
	('Diamonds on the Soles of Her Shoes', 4, 5, 2),

	('Chan Chan', 1, 6, 9), -- Belongs to - album6  - genre9 
	('De Camino a La Vereda', 2, 6, 9),
	('El Cuarto de Tula', 3, 6, 9),
	('Veinte Años', 4, 6, 9),

	('Alu Jon Jonki Jon', 1, 7, 10), -- Belongs to - album7 - genre10
	('Jeun Ko Ku (Chop Quench)', 2, 7, 10),
	('Eko Ile', 3, 7, 10),
	('Je nwi Temi (Dont Gag Me)', 4, 7, 10),

	('Pata Pata', 1, 8, 11), -- Belongs to - album8  - genre11 
	('Ha Po Zamani', 2, 8, 11),
	('What is Love', 3, 8, 11),
	('Soweto Blues', 4, 8, 11),

	('You Are the Sunshine of My Life', 1, 10, 4),
	('Superstition', 2, 10, 4),
	('Big Brother', 3, 10, 4),
	('I Believe (When I Fall in Love It Will Be Forever)', 4, 10, 4),

	('Pata Pata', 1, 11, 11),
	('Ha Po Zamani', 2, 11, 11),
	('What is Love', 3, 11, 11),
	('Soweto Blues', 4, 11, 11),

	('Imidiwan Ma Tenam', 1, 12, 8),
	('Ya Messinagh', 2, 12, 8),
	('Tameyawt', 3, 12, 8),
	('Wallen', 4, 12, 8),

	('Neria', 1, 13, 11),
	('Wasakara', 2, 13, 11),
	('Dzoka Uyamwe', 3, 13, 11),
	('Pindurai Mambo', 4, 13, 11),

	('Give Life Back to Music', 1, 14, 5),
	('The Game of Love', 2, 14, 5),
	('Giorgio by Moroder', 3, 14, 5),
	('Within', 4, 14, 5),
	('Instant Crush (feat. Julian Casablancas)', 5, 14, 5),
	('Lose Yourself to Dance (feat. Pharrell Williams)', 6, 14, 5),
	('Touch (feat. Paul Williams)', 7, 14, 5),
	('Get Lucky (feat. Pharrell Williams)', 8, 14, 5),
	('Beyond', 9, 14, 5),
	('Motherboard', 10, 14, 5),
	('Fragments of Time (feat. Todd Edwards)', 11, 14, 5),

	('iT', 1, 15, 7),
	('Saint Claude', 2, 15, 7),
	('Tilted', 3, 15, 7),
	('No Harm Is Done (feat. Tunji Ige)', 4, 15, 7),
	('Science Fiction', 5, 15, 7),
	('Paradis Perdus', 6, 15, 7),
	('Half Ladies', 7, 15, 7),
	('Jonathan (feat. Perfume Genius)', 8, 15, 7),
	('Narcissus Is Back', 9, 15, 7),
	('Safe and Holy', 10, 15, 7),

	('Spartiate Spirit', 1, 16, 6),
	('Orthodoxes', 2, 16, 6),
	('Monnaie de singe', 3, 16, 6),
	('Nés sous la même étoile', 4, 16, 6),
	('Lempire du côté obscur', 5, 16, 6),

	('A contre-courant', 1, 17, 2),
	('Lui ou toi', 2, 17, 2),
	('Jen ai marre !', 3, 17, 2),
	('Toc de mac', 4, 17, 2),

	('Ta fête', 1, 18, 6),
	('Papaoutai', 2, 18, 6),
	('Bâtard', 3, 18, 6),
	('Ave', 4, 18, 6);

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
    (1, 100),
	(1, 101),
	(1, 102),
	(1, 105),
	(1, 10),
	(1, 15),
	(1, 19),
	(1, 17),
	(1, 18),
    (2, 25),
	(2, 24),
	(2, 23),
	(2, 22),
	(2, 21),
	(2, 20),
	(2, 29),
	(2, 28),
	(2, 27),
    (3, 37),
	(3, 63),
	(3, 39),
	(3, 38),
	(3, 35),
	(3, 45),
	(3, 33),
	(3, 32),
	(3, 31),
	(3, 30),
    (4, 41),
	(4, 40),
	(4, 49),
	(4, 48),
	(4, 47),
	(4, 44),
	(4, 42),
	(4, 43),
    (5, 54),
	(5, 111),
	(5, 32),
	(5, 53),
	(5, 56),
	(5, 59),
	(5, 55),
	(5, 57),
	(5, 122),
	(5, 51),
	(5, 52),
	(5, 15),
    (6, 120),
	(6, 84),
	(6, 68),
	(6, 65),
	(6, 67),
	(6, 60),
	(6, 63),
	(6, 62),
	(6, 61),
	(6, 6),
    (7, 72),
	(7, 71),
	(7, 74),
	(7, 75),
	(7, 76),
	(7, 79),
	(7, 78),
	(7, 77),
    (8, 14),
	(8, 65),
	(8, 87),
	(8, 82),
	(8, 81),
	(8, 85),
	(8, 83),
	(8, 74),
	(8, 58),
    (9, 97),
	(9, 96),
	(9, 93),
	(9, 91),
	(9, 95),
	(9, 92),
	(10, 105),
	(10, 102),
	(10, 107),
	(10, 108),
	(10, 104),
	(10, 106),
	(10, 103),
	(10, 109),
    (10, 111); 

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
