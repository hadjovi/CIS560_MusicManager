---------------------------------------------- Tables Creation ---------------------------------------------------------------
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
	Playtime INT NOT NULL DEFAULT ROUND(RAND() * 100, 0),
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


---------------------------------------------- Tables Insertion ---------------------------------------------------------------
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
INSERT MusicManager.Song (SongName, TrackNumber, AlbumID, GenreID, Playtime)
VALUES 
    ('Speak to Me', 1, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('Breathe', 2, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('On the Run', 3, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
	('Time', 4, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('The Great Gig in the Sky', 5, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('Money', 6, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
	('Us and Them', 7, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('Any Colour You Like', 8, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
    ('Brain Damage', 9, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock
	('Eclipse', 10, 1, 1, ROUND(RAND() * 100, 0)),		-- Belong to - album1 The Dark Side of the Moon - genre1 Progressive Rock

    ('Wanna Be Startin Somethin', 1, 2, 2, ROUND(RAND() * 100, 0)), -- Belongs to - album2 Thriller - genre2 Pop
    ('Baby Be Mine', 2, 2, 2, ROUND(RAND() * 100, 0)),
	('The Girl Is Mine', 3, 2, 2, ROUND(RAND() * 100, 0)),
    ('Thriller', 4, 2, 2, ROUND(RAND() * 100, 0)),
    ('Beat It', 5, 2, 2, ROUND(RAND() * 100, 0)),
	('Billie Jean', 6, 2, 2, ROUND(RAND() * 100, 0)),
    ('Human Nature', 7, 2, 2, ROUND(RAND() * 100, 0)),
    ('P.Y.T. (Pretty Young Thing)', 8, 2, 2, ROUND(RAND() * 100, 0)),
	('The Lady in My Life', 9, 2, 2, ROUND(RAND() * 100, 0)),

    ('Come Together', 1, 3, 3, ROUND(RAND() * 100, 0)),  -- Belongs to - album3 Abbey Road - genre3 Rock
	('Something', 2, 3, 3, ROUND(RAND() * 100, 0)),
	('Maxwells Silver Hammer', 3, 3, 3, ROUND(RAND() * 100, 0)),
	('Oh! Darling', 4, 3, 3, ROUND(RAND() * 100, 0)),
	('Octopus Garden', 5, 3, 3, ROUND(RAND() * 100, 0)),
	('I Want You (She is So Heavy)', 6, 3, 3, ROUND(RAND() * 100, 0)),
	('Here Comes the Sun', 7, 3, 3, ROUND(RAND() * 100, 0)),
	('Because', 8, 3, 3, ROUND(RAND() * 100, 0)),
	('You Never Give', 9, 3, 3, ROUND(RAND() * 100, 0)),

	('Rehab', 1, 20, 4, ROUND(RAND() * 100, 0)), -- Belongs to - album20 Back to Black - genre4 R&B
	('You Know Im No Good', 2, 20, 4, ROUND(RAND() * 100, 0)),
	('Me & Mr Jones', 3, 20, 4, ROUND(RAND() * 100, 0)),
	('Just Friends', 4, 20, 4, ROUND(RAND() * 100, 0)),
	('Back to Black', 5, 20, 4, ROUND(RAND() * 100, 0)),
	('Love Is a Losing Game', 6, 20, 4, ROUND(RAND() * 100, 0)),
	('Tears Dry on Their Own', 7, 20, 4, ROUND(RAND() * 100, 0)),
	('Wake Up Alone', 8, 20, 4, ROUND(RAND() * 100, 0)),
	('Some Unholy War', 9, 20, 4, ROUND(RAND() * 100, 0)),
	('He Can Only Hold Her', 10, 20, 4, ROUND(RAND() * 100, 0)),

	('Purple Haze', 1, 4, 3, ROUND(RAND() * 100, 0)),  -- Belongs to - album4 Purple Haze - genre3 Rock
	('Manic Depression', 2, 4, 3, ROUND(RAND() * 100, 0)),
	('Hey Joe', 3, 4, 3, ROUND(RAND() * 100, 0)),
	('Love or Confusion', 4, 4, 3, ROUND(RAND() * 100, 0)),
	('May This Be Love', 5, 4, 3, ROUND(RAND() * 100, 0)),
	('I Dont Live Today', 6, 4, 3, ROUND(RAND() * 100, 0)),
	('The Wind Cries Mary', 7, 4, 3, ROUND(RAND() * 100, 0)),
	('Fire', 8, 4, 3, ROUND(RAND() * 100, 0)),
	('Third Stone from the Sun', 9, 4, 3, ROUND(RAND() * 100, 0)),
	('Foxey Lady', 10, 4, 3, ROUND(RAND() * 100, 0)),

	('So What', 1, 19, 12, ROUND(RAND() * 100, 0)), -- Belongs to - album19 Kind of Blue - genre12 Jazz
	('Freddie Freeloader', 2, 19, 12, ROUND(RAND() * 100, 0)),
	('Blue in Green', 3, 19, 12, ROUND(RAND() * 100, 0)),
	('All Blues', 4, 19, 12, ROUND(RAND() * 100, 0)),
	('Flamenco Sketches', 5, 19, 12, ROUND(RAND() * 100, 0)),

	('Diaraby', 1, 9, 8, ROUND(RAND() * 100, 0)), -- Belongs to - album9 Talking Timbuktu - genre8 Blues
	('Dofana', 2, 9, 8, ROUND(RAND() * 100, 0)),
	('In the Heart of the Moon', 3, 9, 8, ROUND(RAND() * 100, 0)),
	('Ai Du', 4, 9, 8, ROUND(RAND() * 100, 0)),

	('The Boy in the Bubble', 1, 5, 2, ROUND(RAND() * 100, 0)), -- Belongs to - album5 Graceland - genre2 Pop
	('Graceland', 2, 5, 2, ROUND(RAND() * 100, 0)),
	('I Know What I Know', 3, 5, 2, ROUND(RAND() * 100, 0)),
	('Diamonds on the Soles of Her Shoes', 4, 5, 2, ROUND(RAND() * 100, 0)),

	('Chan Chan', 1, 6, 9, ROUND(RAND() * 100, 0)), -- Belongs to - album6  - genre9 
	('De Camino a La Vereda', 2, 6, 9, ROUND(RAND() * 100, 0)),
	('El Cuarto de Tula', 3, 6, 9, ROUND(RAND() * 100, 0)),
	('Veinte Años', 4, 6, 9, ROUND(RAND() * 100, 0)),

	('Alu Jon Jonki Jon', 1, 7, 10, ROUND(RAND() * 100, 0)), -- Belongs to - album7 - genre10
	('Jeun Ko Ku (Chop Quench)', 2, 7, 10, ROUND(RAND() * 100, 0)),
	('Eko Ile', 3, 7, 10, ROUND(RAND() * 100, 0)),
	('Je nwi Temi (Dont Gag Me)', 4, 7, 10, ROUND(RAND() * 100, 0)),

	('Pata Pata', 1, 8, 11, ROUND(RAND() * 100, 300)), -- Belongs to - album8  - genre11 
	('Ha Po Zamani', 2, 8, 11, ROUND(RAND() * 100, 0)),
	('What is Love', 3, 8, 11, ROUND(RAND() * 100, 0)),
	('Soweto Blues', 4, 8, 11, ROUND(RAND() * 100, 0)),

	('You Are the Sunshine of My Life', 1, 10, 4, ROUND(RAND() * 100, 0)),
	('Superstition', 2, 10, 4, ROUND(RAND() * 100, 0)),
	('Big Brother', 3, 10, 4, ROUND(RAND() * 100, 0)),
	('I Believe (When I Fall in Love It Will Be Forever)', 4, 10, 4, ROUND(RAND() * 100, 0)),

	('Pata Pata', 1, 11, 11, ROUND(RAND() * 100, 0)),
	('Ha Po Zamani', 2, 11, 11, ROUND(RAND() * 100, 0)),
	('What is Love', 3, 11, 11, ROUND(RAND() * 100, 0)),
	('Soweto Blues', 4, 11, 11, ROUND(RAND() * 100, 0)),

	('Imidiwan Ma Tenam', 1, 12, 8, ROUND(RAND() * 100, 0)),
	('Ya Messinagh', 2, 12, 8, ROUND(RAND() * 100, 0)),
	('Tameyawt', 3, 12, 8, ROUND(RAND() * 100, 0)),
	('Wallen', 4, 12, 8, ROUND(RAND() * 100, 0)),

	('Neria', 1, 13, 11, ROUND(RAND() * 100, 0)),
	('Wasakara', 2, 13, 11, ROUND(RAND() * 100, 0)),
	('Dzoka Uyamwe', 3, 13, 11, ROUND(RAND() * 100, 0)),
	('Pindurai Mambo', 4, 13, 11, ROUND(RAND() * 100, 0)),

	('Give Life Back to Music', 1, 14, 5, ROUND(RAND() * 100, 0)),
	('The Game of Love', 2, 14, 5, ROUND(RAND() * 100, 0)),
	('Giorgio by Moroder', 3, 14, 5, ROUND(RAND() * 100, 0)),
	('Within', 4, 14, 5, ROUND(RAND() * 100, 0)),
	('Instant Crush (feat. Julian Casablancas)', 5, 14, 5, ROUND(RAND() * 100, 0)),
	('Lose Yourself to Dance (feat. Pharrell Williams)', 6, 14, 5, ROUND(RAND() * 100, 0)),
	('Touch (feat. Paul Williams)', 7, 14, 5, ROUND(RAND() * 100, 0)),
	('Get Lucky (feat. Pharrell Williams)', 8, 14, 5, ROUND(RAND() * 100, 0)),
	('Beyond', 9, 14, 5, ROUND(RAND() * 100, 0)),
	('Motherboard', 10, 14, 5, ROUND(RAND() * 100, 0)),
	('Fragments of Time (feat. Todd Edwards)', 11, 14, 5, ROUND(RAND() * 100, 0)),

	('iT', 1, 15, 7, ROUND(RAND() * 100, 0)),
	('Saint Claude', 2, 15, 7, ROUND(RAND() * 100, 0)),
	('Tilted', 3, 15, 7, ROUND(RAND() * 100, 0)),
	('No Harm Is Done (feat. Tunji Ige)', 4, 15, 7, ROUND(RAND() * 100, 0)),
	('Science Fiction', 5, 15, 7, ROUND(RAND() * 100, 0)),
	('Paradis Perdus', 6, 15, 7, ROUND(RAND() * 100, 0)),
	('Half Ladies', 7, 15, 7, ROUND(RAND() * 100, 0)),
	('Jonathan (feat. Perfume Genius)', 8, 15, 7, ROUND(RAND() * 100, 0)),
	('Narcissus Is Back', 9, 15, 7, ROUND(RAND() * 100, 0)),
	('Safe and Holy', 10, 15, 7, ROUND(RAND() * 100, 0)),

	('Spartiate Spirit', 1, 16, 6, ROUND(RAND() * 100, 0)),
	('Orthodoxes', 2, 16, 6, ROUND(RAND() * 100, 0)),
	('Monnaie de singe', 3, 16, 6, ROUND(RAND() * 100, 0)),
	('Nés sous la même étoile', 4, 16, 6, ROUND(RAND() * 100, 0)),
	('Lempire du côté obscur', 5, 16, 6, ROUND(RAND() * 100, 0)),

	('A contre-courant', 1, 17, 2, ROUND(RAND() * 100, 0)),
	('Lui ou toi', 2, 17, 2, ROUND(RAND() * 100, 0)),
	('Jen ai marre !', 3, 17, 2, ROUND(RAND() * 100, 0)),
	('Toc de mac', 4, 17, 2, ROUND(RAND() * 100, 0)),

	('Ta fête', 1, 18, 6, ROUND(RAND() * 100, 0)),
	('Papaoutai', 2, 18, 6, ROUND(RAND() * 100, 0)),
	('Bâtard', 3, 18, 6, ROUND(RAND() * 100, 0)),
	('Ave', 4, 18, 6, ROUND(RAND() * 100, 0));

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
	(1, 1),
	(1, 102),
	(1, 105),
	(1, 10),
	(1, 15),
	(1, 19),
	(1, 17),
	(1, 18),
	(1, 108),
    (2, 25),
	(2, 24),
	(2, 23),
	(2, 22),
	(2, 21),
	(2, 20),
	(2, 29),
	(2, 28),
	(2, 108),
	(2, 27),
    (3, 37),
	(3, 63),
	(3, 39),
	(3, 38),
	(3, 35),
	(3, 45),
	(3, 33),
	(3, 32),
	(3, 108),
	(3, 31),
	(3, 30),
    (4, 1),
	(4, 40),
	(4, 49),
	(4, 48),
	(4, 47),
	(4, 44),
	(4, 42),
	(4, 43),
	(4, 108),
    (5, 54),
	(5, 111),
	(5, 32),
	(5, 102),
	(5, 56),
	(5, 59),
	(5, 1),
	(5, 57),
	(5, 108),
	(5, 122),
	(5, 51),
	(5, 52),
	(5, 15),
    (6, 120),
	(6, 84),
	(6, 102),
	(6, 65),
	(6, 67),
	(6, 60),
	(6, 63),
	(6, 62),
	(6, 61),
	(6, 108),
    (7, 1),
	(7, 71),
	(7, 74),
	(7, 75),
	(7, 102),
	(7, 79),
	(7, 78),
	(7, 108),
    (8, 14),
	(8, 65),
	(8, 87),
	(8, 82),
	(8, 81),
	(8, 85),
	(8, 83),
	(8, 74),
	(8, 108),
    (9, 1),
	(9, 96),
	(9, 93),
	(9, 91),
	(9, 95),
	(9, 92),
	(9, 108),
	(10, 105),
	(10, 102),
	(10, 107),
	(10, 108),
	(10, 104),
	(10, 106),
	(10, 103),
	(10, 1),
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