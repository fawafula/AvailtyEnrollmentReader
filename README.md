# AvailtyEnrollmentReader
Reads CSV files from an input directory.
Sorts the CSV files as follows:
  Grouping records from all the files by insurance company.
  Ordering the records in each group by ascending order using last name.
  Removing duplcated recrods and retaining the record that has a higher version in the group.
Writes the data for each group in its own new CSV file.
