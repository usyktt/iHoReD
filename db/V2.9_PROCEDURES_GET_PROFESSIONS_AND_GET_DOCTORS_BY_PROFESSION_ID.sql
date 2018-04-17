GO
CREATE PROCEDURE GET_PROFESSIONS AS 
	(SELECT * FROM PROFESSIONS);
GO
CREATE PROCEDURE GET_DOCTORS_BY_PROFESSION_ID
	@PROFESSION_ID INT
AS
	(SELECT FIRSTNAME, LASTNAME
	FROM USERS
	INNER JOIN DOCTORS ON  USERS.IDUSERS = DOCTORS.IDDOCTORS
	WHERE DOCTORS.IDPROFESSION = @PROFESSION_ID);
GO
