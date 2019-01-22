--select * from information_schema.table_constraints
--where constraint_type = 'Primary Key';

ALTER TABLE Users
  DROP CONSTRAINT PK__Users__3214EC071AB832A4;

ALTER TABLE Users
  ADD CONSTRAINT PK_User PRIMARY KEY (Id, Username);




