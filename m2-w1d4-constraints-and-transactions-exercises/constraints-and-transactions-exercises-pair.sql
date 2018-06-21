-- Write queries to return the following:
-- Make the following changes in the "world" database.

-- 1. Add Superman's hometown, Smallville, Kansas to the city table. The 
-- countrycode is 'USA', and population of 45001. (Yes, I looked it up on 
-- Wikipedia.)
SELECT *
FROM city
ORDER BY id DESC


INSERT INTO [dbo].[city]
           ([id]
           ,[name]
           ,[countrycode]
           ,[district]
           ,[population])
     VALUES
           ((SELECT TOP 1 id+1 FROM city ORDER by id DESC)
           ,'Smallville'
           ,'USA'
           ,'Kansas'
           ,45001)
-- AUSTIN NOTE - the city primary key cannot auto-index

-- 2. Add Kryptonese to the countrylanguage table. Kryptonese is spoken by 0.0001
-- percentage of the 'USA' population.
SELECT *
FROM countrylanguage
WHERE countrycode = 'usa'

INSERT INTO [dbo].[countrylanguage]
           ([countrycode]
           ,[language]
           ,[isofficial]
           ,[percentage])
     VALUES
           ('USA'
           ,'Kryptonese'
           ,0
           ,0.0001)


-- 3. After heated debate, "Kryptonese" was renamed to "Krypto-babble", change 
-- the appropriate record accordingly.
SELECT *
FROM countrylanguage
WHERE countrycode = 'usa' AND language = 'Kryptonese'

UPDATE [dbo].[countrylanguage]
   SET [language] = 'Krypto-babble'
 WHERE countrycode = 'usa' AND language = 'Kryptonese'

 SELECT *
FROM countrylanguage
WHERE countrycode = 'usa' AND language = 'Krypto-babble'

-- 4. Set the US captial to Smallville, Kansas in the country table.
SELECT *
FROM country
WHERE code = 'USA'

UPDATE [dbo].[country]
   SET [capital] = (SELECT id FROM city WHERE name = 'smallville')
 WHERE code = 'USA'

SELECT name, capital
FROM country
WHERE code = 'USA'

-- 5. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)
SELECT *
--DELETE
FROM city
WHERE name = 'Smallville'
-- The delete did work because the capital is not set as a foreign key in city which culd prevent deletion

-- 6. Return the US captial to Washington.
SELECT *
FROM city
WHERE name = 'Washington'

UPDATE [dbo].[country]
   SET [capital] = (SELECT id FROM city WHERE name = 'Washington')
 WHERE code = 'USA'

-- 7. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)
SELECT *
--DELETE
FROM city
WHERE name = 'Smallville'
-- if the capital was a foreign key using the city id and Smallville's city id
-- was not written into the capital column it could be deleted 

-- 8. Reverse the "is the official language" setting for all languages where the
-- country's year of independence is within the range of 1800 and 1972 
-- (exclusive). 
-- (590 rows affected)
SELECT cl.*, c.indepyear
FROM countrylanguage cl
JOIN country c ON c.code = cl.countrycode
WHERE C.indepyear >=1800 AND C.indepyear < 1972

UPDATE [dbo].[countrylanguage]
   SET [isofficial] = ~ isofficial
   WHERE countrycode IN (select code FROM country c WHERE C.indepyear >=1800 AND C.indepyear < 1972)
   
-- 9. Convert population so it is expressed in 1,000s for all cities. (Round to
-- the nearest integer value greater than 0.)
-- (4079 rows affected)
SELECT *
FROM city
ORDER BY id, countrycode

BEGIN TRAN
UPDATE [dbo].[city]
	SET [population] = ceiling(population / 1000.0) 
COMMIT TRAN
ROLLBACK TRAN

SELECT population as 'population in the 1000s'
FROM city
ORDER BY id, countrycode

-- 10. Assuming a country's surfacearea is expressed in miles, convert it to 
-- meters for all countries where French is spoken by more than 20% of the 
-- population.
-- (7 rows affected)
SELECT *
FROM countrylanguage

SELECT c.name, cl.percentage, c.surfacearea
FROM country c
JOIN countrylanguage cl ON cl.countrycode = c.code
WHERE cl.language = 'French' AND cl.percentage > 20.0
ORDER BY cl.percentage

BEGIN TRAN 
UPDATE [dbo].[country]
   SET [surfacearea] = ceiling(surfacearea * 2.589)
 WHERE code IN (SELECT countrycode FROM countrylanguage cl WHERE cl.language = 'French' AND cl.percentage > 20.0)

 COMMIT TRAN


SELECT c.name, cl.percentage, c.surfacearea
FROM country c
JOIN countrylanguage cl ON cl.countrycode = c.code
WHERE cl.language = 'French' AND cl.percentage > 20.0
ORDER BY cl.percentage

