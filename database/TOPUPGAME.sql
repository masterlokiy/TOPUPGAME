CREATE DATABASE TOPUPGAME
use TOPUPGAME

CREATE TABLE [User]  (
    Id NUMERIC PRIMARY KEY NOT NULL,
    Username VARCHAR(40) NOT NULL,
    Email VARCHAR(40) NOT NULL,
	Password VARCHAR(40) NOT NULL,
    VerificationCode NUMERIC NOT NULL
)

CREATE TABLE [Produk] (
	IDProduk NUMERIC PRIMARY KEY NOT NULL,
	NamaGame VARCHAR(40) NOT NULL,
	NamaProduk VARCHAR(40) NOT NULL,
	Harga NUMERIC NOT NULL,
	Image VARCHAR(40) NOT NULL
)

CREATE TABLE AkunUserGame (
	IDAkun NUMERIC NOT NULL,
	Id NUMERIC NOT NULL,
	NamaGame VARCHAR (40) NOT NULL,
)

CREATE TABLE Pemesanan (
	IDPesan NUMERIC NOT NULL,
	IDProduk NUMERIC NOT NULL,
	Id NUMERIC NOT NULL,
	IDAkun NUMERIC NOT NULL,
	StatusBayar VARCHAR(10) CHECK (StatusBayar='Belum' or StatusBayar='Lunas'),
	StatusProses VARCHAR(20) CHECK (StatusProses IN ('Dalam Proses','Lunas','Batal')),
	TanggalPesan DATETIME
)

INSERT INTO [User] (Id, Username, Email, Password, VerificationCode)
VALUES
    (1, 'user1', 'user1@example.com', 'password1', 12345),
    (2, 'user2', 'user2@example.com', 'password2', 67890),
    (3, 'user3', 'user3@example.com', 'password3', 13579),
    (4, 'user4', 'user4@example.com', 'password4', 24680),
    (5, 'user5', 'user5@example.com', 'password5', 98765);

INSERT INTO [Produk] (IDProduk, NamaGame, NamaProduk, Harga, Image)
VALUES
    (1, 'Game1', 'Produk1', 29.99, 'image1.jpg'),
    (2, 'Game2', 'Produk2', 19.99, 'image2.jpg'),
    (3, 'Game3', 'Produk3', 39.99, 'image3.jpg'),
    (4, 'Game4', 'Produk4', 49.99, 'image4.jpg'),
    (5, 'Game5', 'Produk5', 59.99, 'image5.jpg');

INSERT INTO AkunUserGame (IDAkun, Id, NamaGame)
VALUES
    (6, 3, 'GameF'),
    (7, 4, 'GameG'),
    (8, 5, 'GameH'),
    (9, 3, 'GameI'),
    (10, 4, 'GameJ'),
    (11, 5, 'GameK'),
    (12, 3, 'GameL'),
    (13, 4, 'GameM'),
    (14, 5, 'GameN'),
    (15, 3, 'GameO'),
    (16, 4, 'GameP'),
    (17, 5, 'GameQ');

INSERT INTO Pemesanan (IDPesan, IDProduk, Id, IDAkun, StatusBayar, StatusProses, TanggalPesan)
VALUES
    (1, 1, 1, 1, 'Belum', 'Dalam Proses', CURRENT_TIMESTAMP),
    (2, 2, 2, 2, 'Lunas', 'Lunas', CURRENT_TIMESTAMP),
    (3, 3, 3, 3, 'Belum', 'Batal', CURRENT_TIMESTAMP),
    (4, 4, 4, 4, 'Lunas', 'Dalam Proses', CURRENT_TIMESTAMP),
    (5, 5, 5, 5, 'Belum', 'Lunas', CURRENT_TIMESTAMP),
    (6, 1, 1, 2, 'Lunas', 'Batal', CURRENT_TIMESTAMP),
    (7, 2, 2, 3, 'Belum', 'Lunas', CURRENT_TIMESTAMP),
    (8, 3, 3, 4, 'Lunas', 'Dalam Proses', CURRENT_TIMESTAMP),
    (9, 4, 4, 5, 'Belum', 'Batal', CURRENT_TIMESTAMP),
    (10, 5, 5, 1, 'Lunas', 'Dalam Proses', CURRENT_TIMESTAMP),
    (11, 1, 1, 2, 'Belum', 'Lunas', CURRENT_TIMESTAMP),
    (12, 2, 2, 3, 'Lunas', 'Dalam Proses', CURRENT_TIMESTAMP),
    (13, 3, 3, 4, 'Belum', 'Lunas', CURRENT_TIMESTAMP),
    (14, 4, 4, 5, 'Lunas', 'Batal', CURRENT_TIMESTAMP),
    (15, 5, 5, 1, 'Belum', 'Dalam Proses', CURRENT_TIMESTAMP),
    (16, 1, 1, 2, 'Lunas', 'Batal', CURRENT_TIMESTAMP),
    (17, 2, 2, 3, 'Belum', 'Lunas', CURRENT_TIMESTAMP),
    (18, 3, 3, 4, 'Lunas', 'Dalam Proses', CURRENT_TIMESTAMP),
    (19, 4, 4, 5, 'Belum', 'Lunas', CURRENT_TIMESTAMP),
    (20, 5, 5, 1, 'Lunas', 'Dalam Proses', CURRENT_TIMESTAMP);

SELECT
    Pemesanan.IDPesan,
    Produk.NamaProduk,
    Pemesanan.IDAkun,
    Pemesanan.StatusBayar,
    Pemesanan.StatusProses,
    Pemesanan.TanggalPesan
FROM
    Pemesanan
JOIN
    Produk ON Pemesanan.IDProduk = Produk.IDProduk
WHERE
    Pemesanan.Id = 1;