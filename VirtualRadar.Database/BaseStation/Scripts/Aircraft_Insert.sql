﻿-- Note that not all columns are inserted, just the ones that VRS cares about
INSERT INTO [Aircraft] (
    [AircraftClass]
   ,[CofACategory]
   ,[CofAExpiry]
   ,[Country]
   ,[CurrentRegDate]
   ,[DeRegDate]
   ,[Engines]
   ,[FirstCreated]
   ,[FirstRegDate]
   ,[GenericName]
   ,[ICAOTypeCode]
   ,[InfoUrl]
   ,[Interested]
   ,[LastModified]
   ,[Manufacturer]
   ,[ModeS]
   ,[ModeSCountry]
   ,[MTOW]
   ,[OperatorFlagCode]
   ,[OwnershipStatus]
   ,[PictureUrl1]
   ,[PictureUrl2]
   ,[PictureUrl3]
   ,[PopularName]
   ,[PreviousID]
   ,[RegisteredOwners]
   ,[Registration]
   ,[SerialNo]
   ,[Status]
   ,[TotalHours]
   ,[Type]
   ,[UserNotes]
   ,[UserString1]
   ,[UserString2]
   ,[UserString3]
   ,[UserString4]
   ,[UserString5]
   ,[UserBool1]
   ,[UserBool2]
   ,[UserBool3]
   ,[UserBool4]
   ,[UserBool5]
   ,[UserInt1]
   ,[UserInt2]
   ,[UserInt3]
   ,[UserInt4]
   ,[UserInt5]
   ,[UserTag]
   ,[YearBuilt]
) VALUES (
    @aircraftClass
   ,@cofACategory
   ,@cofAExpiry
   ,@country
   ,@currentRegDate
   ,@deRegDate
   ,@engines
   ,@firstCreated
   ,@firstRegDate
   ,@genericName
   ,@iCAOTypeCode
   ,@infoUrl
   ,@interested
   ,@lastModified
   ,@manufacturer
   ,@modeS
   ,@modeSCountry
   ,@mtow
   ,@operatorFlagCode
   ,@ownershipStatus
   ,@pictureUrl1
   ,@pictureUrl2
   ,@pictureUrl3
   ,@popularName
   ,@previousID
   ,@registeredOwners
   ,@registration
   ,@serialNo
   ,@status
   ,@totalHours
   ,@type
   ,@userNotes
   ,@userString1
   ,@userString2
   ,@userString3
   ,@userString4
   ,@userString5
   ,@userBool1
   ,@userBool2
   ,@userBool3
   ,@userBool4
   ,@userBool5
   ,@userInt1
   ,@userInt2
   ,@userInt3
   ,@userInt4
   ,@userInt5
   ,@userTag
   ,@yearBuilt
);
SELECT [AircraftID] FROM [Aircraft] WHERE _ROWID_ = last_insert_rowid();
