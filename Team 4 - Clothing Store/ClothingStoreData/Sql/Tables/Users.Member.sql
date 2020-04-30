IF OBJECT_ID(N'Users.Member') IS NULL
BEGIN
	CREATE TABLE Users.Member
	(
	    MemberID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		Email NVARCHAR(128) NOT NULL,
		FirstName NVARCHAR(32) NOT NULL,
		LastName NVARCHAR(32) NOT NULL,
		Phone NVARCHAR(32) NOT NULL,
		BillingAddress NVARCHAR(128) NOT NULL,
		Points INT NOT NULL,
		JoinedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		BirthDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		[Status] NVARCHAR(32) NOT NULL,

		CONSTRAINT [PK_Users_Member_MemberID] PRIMARY KEY CLUSTERED
		(
			MemberID ASC
		)
	);
END

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Member')
         AND kc.[name] = N'UK_Member_Email'
   )
BEGIN
   ALTER TABLE Users.Member
   ADD CONSTRAINT [UK_Member_Email] UNIQUE NONCLUSTERED
   (
      Email
   )
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Member')
         AND kc.[name] = N'UK_Member_Phone'
   )
BEGIN
   ALTER TABLE Users.Member
   ADD CONSTRAINT [UK_Member_Phone] UNIQUE NONCLUSTERED
   (
      Phone
   )
END;