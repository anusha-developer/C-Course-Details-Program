Create table Coursedetails1(
Sno int Identity(1,1),
Coursename varchar(100),
Coursefee int,
Courseduration varchar(800),
Specialization varchar(500),
)
drop table Coursedetails1;
 
 insert into Coursedetails1 values('Btech',100000,'4Years','CSE');
 insert into Coursedetails1 values('Mtech',10000,'2Years','EEE');
 insert into Coursedetails1 values('PG',20000,'1Years','xyz');
 insert into Coursedetails1 values('Degree',30000,'3Years','Ece');
 select * from Coursedetails1;
