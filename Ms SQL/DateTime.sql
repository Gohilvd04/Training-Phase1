--Date Time

create table tblDateTime(
c_time time(7),
c_date date,
c_smalldatetime smalldatetime,
c_datetime datetime,
c_datetime2 datetime2(7),
c_datetimeoffset datetimeoffset(7));

select * from tblDateTime;

INSERT INTO tblDateTime VALUES (GETDATE(),GETDATE(),GETDATE(),GETDATE(),GETDATE(),GETDATE());

 