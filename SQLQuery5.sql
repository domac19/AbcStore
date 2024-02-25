-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Join_Tables 
AS
BEGIN
SELECT
    p.People,
    pe.Persons
FROM
    -- this is your "base" table - where most of the info exists
    People.People p
INNER JOIN 
    -- join to the e-mail table - based on "BusinessEntityID", to get e-mail address
    People.Persons pe ON pe.KorisnikId = p.Id
END
GO
