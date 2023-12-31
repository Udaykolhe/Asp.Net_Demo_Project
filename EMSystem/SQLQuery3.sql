USE [EMSystem]
GO
/****** Object:  StoredProcedure [dbo].[usp_employee_Get_Insert_Update_Delete]    Script Date: 04/28/2023 12:24:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER PROC	[dbo].[usp_employee_Get_Insert_Update_Delete]
(
@id int =0 ,
@name nvarchar(50) =null ,
@code nvarchar(50) =null,
@email nvarchar(50) = null,
@mobile nvarchar(50)= null,
@workingtype nvarchar(50)= null ,
@day nvarchar(50) = null,
@query int 
)
AS
BEGIN
IF(@query = 1)
BEGIN
---------Insert Query--------------------
INSERT INTO [employeeDetails]
(
Name,
Code,
Email,
Mobile,
Working_Type,
[Day]
)
VALUES
(
@name,
@code,
@email,
@mobile,
@workingtype,
@day
)
END

---------Select Query--------------------
ELSE IF(@query = 2)
BEGIN
SELECT *  FROM employeeDetails
END

---------Update Query--------------------
ELSE IF(@query = 3)
BEGIN
UPDATE employeeDetails
SET	
Name = @name,
Code = @code,
Email = @email,
Mobile = @mobile,
Working_Type = @workingtype,
[Day] = @day
WHERE
Id = @id
END


---------Delete Query--------------------
ELSE IF(@query = 4)
BEGIN
 DELETE
 FROM employeeDetails
 WHERE 
 employeeDetails.Id = @id
END

-----------SearchByName-------
ELSE IF(@query = 5)
BEGIN
  SELECT * 
  FROM  [employeeDetails]
  WHERE Name LIKE  '%' +@name+  '%'
END	
END







