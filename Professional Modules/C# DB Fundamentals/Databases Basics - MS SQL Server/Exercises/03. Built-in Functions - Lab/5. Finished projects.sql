SELECT ProjectID, Name,
       ISNULL(CAST(EndDate AS varchar), 'Not Finished')
  FROM Projects;
