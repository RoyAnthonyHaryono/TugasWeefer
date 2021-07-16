Create TABLE Finance(
Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
Tanggal date,
Tipe nvarchar(50),
Deskripsi nvarchar(100),
Jumlah bigint)

Select * From Finance





