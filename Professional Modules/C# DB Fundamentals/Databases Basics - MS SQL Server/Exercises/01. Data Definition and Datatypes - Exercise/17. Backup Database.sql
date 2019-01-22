BACKUP DATABASE SoftUni
	TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\Backup\softuni-backup.bak';


BACKUP DATABASE SoftUni  
TO DISK = 'C:\Users\Nik\Desktop\01. Data Definition and Datatypes - Exercise\softuni-backup.bak'
   WITH FORMAT,  
      MEDIANAME = 'Z_SQLServerBackups',  
      NAME = 'Full Backup of SoftUni'; 