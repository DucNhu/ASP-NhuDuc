create table dbo.Employee (
EmployeeId int identity(1,1),
EmployeeName varchar(500),
Department varchar(500),
DateOfJoining date,
PhotoFileName varchar(1000)
)

insert into dbo.Employee values
('DUCNHU', 'IT', '2020-11-20', 'https://scontent-hkg4-1.xx.fbcdn.net/v/t1.0-9/121015879_1216157128741953_2257706875469270967_n.jpg?_nc_cat=108&ccb=2&_nc_sid=09cbfe&_nc_ohc=0_hDimWJGhUAX81cs62&_nc_ht=scontent-hkg4-1.xx&oh=9d7c37bce91886ed3f3060aecb33a037&oe=5FC89336')