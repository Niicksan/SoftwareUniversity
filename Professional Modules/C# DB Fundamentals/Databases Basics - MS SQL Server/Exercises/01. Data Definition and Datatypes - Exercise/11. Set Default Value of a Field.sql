ALTER TABLE Users 
  ADD CONSTRAINT DF_Time DEFAULT GETDATE() FOR LastLoginTime;