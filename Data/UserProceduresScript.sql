--Procedure for the User

--Takes an email and a password, then returns the corresponding user if found
DROP PROCEDURE IF EXISTS LoginFetch
GO
CREATE PROCEDURE LoginFetch @Email NVARCHAR(100), @Password NVARCHAR(100)
AS
SELECT U.UserID,
		U.[Name]
FROM MusicManager.[User] AS U
WHERE U.Email = @Email
AND U.[Password] = @Password
GO
-- EXEC LoginFecth @UserEmail = 'ben@ben.com', @UserPassword = 'passwordB560';
-- EXEC LoginFecth @UserEmail = 'dang@dang.com', @UserPassword = 'passwordD560';


--Takes a name, an email and a password, then creates an user base on those attributs
DROP PROCEDURE IF EXISTS UserSignIn
GO
CREATE PROCEDURE UserSignIn @Name NVARCHAR(100), @Email NVARCHAR(100), @Password NVARCHAR(100), @UserID INT OUTPUT
AS
WITH SourceCte(UserName, UserEmail, UserPassword) AS
   (
	SELECT *
	FROM(
		VALUES(@Name, @Email, @Password)
	)NA(UserName, UserEmail, UserPassword)     
   )
MERGE MusicManager.[User] U
USING SourceCte S ON S.UserEmail = U.Email
WHEN NOT MATCHED THEN
   INSERT([Name], Email, [Password])
   VALUES(@Name, @Email, @Password);

SET @UserID = SCOPE_IDENTITY()
GO
-- EXEC UserSignIn @UserName = Ben, @UserEmail = 'ben@ben.com', @UserPassword = 'passwordB560';
-- EXEC UserSignIn @UserName = Dan, @UserEmail = 'dang@dang.com', @UserPassword = 'passwordD560';



DROP PROCEDURE IF EXISTS UserOwnedPlaylistFecth
GO
CREATE PROCEDURE UserOwnedPlaylistFecth @UserId INT
AS
SELECT P.PlaylistID,
		P.PlaylistName,
		P.IsPrivate,
		P.IsDeleted
FROM MusicManager.Playlist AS P
WHERE P.PlaylistOwnerID = @UserId
AND P.IsDeleted = 0
GO
-- EXEC UserOwnedPlaylistFecth @UserId = 1;
-- EXEC UserOwnedPlaylistFecth @UserId = 2;


DROP PROCEDURE IF EXISTS SharedPlaylistFecth
GO
CREATE PROCEDURE SharedPlaylistFecth @UserId INT
AS
SELECT P.PlaylistID,
		P.PlaylistName,
		P.IsPrivate
FROM MusicManager.Playlist AS P
WHERE P.PlaylistID IN
(
	SELECT SUP.PlaylistID
	FROM MusicManager.SharedUserPlaylist AS SUP
	WHERE SUP.UserID = @UserId
)
AND P.IsDeleted = 0
AND P.IsPrivate = 0
GO
-- EXEC SharedPlaylistFecth @UserId = 1;
-- EXEC SharedPlaylistFecth @UserId = 3;



DROP PROCEDURE IF EXISTS RetrieveAllUserPlaylists
GO
CREATE PROCEDURE RetrieveAllUserPlaylists @UserId INT 
AS
SELECT P.PlaylistID,
		P.PlaylistName,
		P.PlaylistOwnerID,
		P.IsPrivate,
		P.IsDeleted
FROM MusicManager.Playlist AS P
WHERE P.PlaylistOwnerID = @UserId
AND P.IsDeleted = 0
UNION
SELECT DISTINCT P.PlaylistID,
		P.PlaylistName,
		P.PlaylistOwnerID,
		P.IsPrivate,
		P.IsDeleted
FROM MusicManager.Playlist AS P
WHERE P.PlaylistID IN
(
	SELECT SUP.PlaylistID
	FROM MusicManager.SharedUserPlaylist AS SUP
	WHERE SUP.UserID = @UserId
)
AND P.IsDeleted = 0
AND P.IsPrivate = 0
GO
-- EXEC RetrieveAllUserPlaylists @UserId = 1;


DROP PROCEDURE IF EXISTS RetrieveAllUsers
GO
CREATE PROCEDURE RetrieveAllUsers 
AS
SELECT U.UserID, U.[Name], U.Email, U.[Password]
FROM MusicManager.[User] AS U
GO
-- EXEC RetrieveAllUsers 


