CREATE DATABASE DB_QLyChiTieu;
GO

USE DB_QLyChiTieu;
GO

CREATE TABLE TaiKhoan
(
    Username NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100),

    HoTen NVARCHAR(100) NULL,
    SoDienThoai NVARCHAR(20) NULL,
    ThanhPho NVARCHAR(100) NULL,
    Avatar NVARCHAR(MAX) NULL,

    Role NVARCHAR(20) DEFAULT 'user'
);
GO

CREATE TABLE ViTien
(
    MaVi INT IDENTITY(1,1) PRIMARY KEY,
    TenVi NVARCHAR(100) NOT NULL,
    SoDu DECIMAL(18,2) DEFAULT 0,

    Username NVARCHAR(50) NOT NULL,

    FOREIGN KEY (Username)
    REFERENCES TaiKhoan(Username)
);
GO

CREATE TABLE DanhMuc
(
    MaDanhMuc INT IDENTITY(1,1) PRIMARY KEY,
    TenDanhMuc NVARCHAR(100) NOT NULL,

    Username NVARCHAR(50) NOT NULL,

    FOREIGN KEY (Username)
    REFERENCES TaiKhoan(Username)
);
GO

CREATE TABLE ThuNhap
(
    MaThuNhap INT IDENTITY(1,1) PRIMARY KEY,

    TenThuNhap NVARCHAR(100) NOT NULL,
    SoTien DECIMAL(18,2) NOT NULL,
    Ngay DATE NOT NULL,

    GhiChu NVARCHAR(255),

    MaDanhMuc INT,
    MaVi INT,

    Username NVARCHAR(50) NOT NULL,

    FOREIGN KEY (MaDanhMuc)
    REFERENCES DanhMuc(MaDanhMuc),

    FOREIGN KEY (MaVi)
    REFERENCES ViTien(MaVi),

    FOREIGN KEY (Username)
    REFERENCES TaiKhoan(Username)
);
GO

CREATE TABLE ChiTieu
(
    MaChiTieu INT IDENTITY(1,1) PRIMARY KEY,

    TenChiTieu NVARCHAR(100) NOT NULL,
    SoTien DECIMAL(18,2) NOT NULL,
    Ngay DATE NOT NULL,

    Loai NVARCHAR(50),
    GhiChu NVARCHAR(255),

    MaDanhMuc INT,
    MaVi INT,

    Username NVARCHAR(50) NOT NULL,

    FOREIGN KEY (MaDanhMuc)
    REFERENCES DanhMuc(MaDanhMuc),

    FOREIGN KEY (MaVi)
    REFERENCES ViTien(MaVi),

    FOREIGN KEY (Username)
    REFERENCES TaiKhoan(Username)
);
GO

CREATE TABLE TietKiem
(
    MaTietKiem INT IDENTITY(1,1) PRIMARY KEY,

    TenMucTieu NVARCHAR(100),
    SoTienMucTieu DECIMAL(18,2),
    SoTienHienCo DECIMAL(18,2),

    NgayBatDau DATE,
    NgayHanChot DATE,

    Username NVARCHAR(50) NOT NULL,

    FOREIGN KEY (Username)
    REFERENCES TaiKhoan(Username)
);
GO

CREATE TABLE NhacNho
(
    MaNhacNho INT IDENTITY(1,1) PRIMARY KEY,

    NoiDung NVARCHAR(255),
    ThoiGianThongBao DATETIME,

    TrangThai BIT DEFAULT 0,

    Username NVARCHAR(50) NOT NULL,

    FOREIGN KEY (Username)
    REFERENCES TaiKhoan(Username)
);
GO

CREATE TABLE KhoanVay
(
    MaVay INT IDENTITY(1,1) PRIMARY KEY,

    TenKhoanVay NVARCHAR(100) NOT NULL,

    SoTienVay DECIMAL(18,2) NOT NULL,

    NgayVay DATE NOT NULL,

    HanTra DATE NOT NULL,

    TrangThai NVARCHAR(50)
    DEFAULT N'Chưa thanh toán',

    GhiChu NVARCHAR(255),

    MaVi INT,

    Username NVARCHAR(50) NOT NULL,

    FOREIGN KEY (MaVi)
    REFERENCES ViTien(MaVi),

    FOREIGN KEY (Username)
    REFERENCES TaiKhoan(Username)
);
GO
SELECT * FROM KhoanVay;
--tnhep 7 ngay
SELECT *
FROM ThuNhap
WHERE Ngay >= DATEADD(DAY,-7,GETDATE())
ORDER BY Ngay DESC;

--chi tieu 7 ngay
SELECT *
FROM ChiTieu
WHERE Ngay >= DATEADD(DAY,-7,GETDATE())
ORDER BY Ngay DESC;

--tong tnhap 7 nagy
SELECT SUM(SoTien) AS TongThuNhap7Ngay
FROM ThuNhap
WHERE Ngay >= DATEADD(DAY,-7,GETDATE());

--tong ctieu 7 ngay
SELECT SUM(SoTien) AS TongChiTieu7Ngay
FROM ChiTieu
WHERE Ngay >= DATEADD(DAY,-7,GETDATE());

--thunhap thang 
SELECT *
FROM ThuNhap
WHERE MONTH(Ngay) = MONTH(GETDATE())
AND YEAR(Ngay) = YEAR(GETDATE())
ORDER BY Ngay DESC;

--ctieu thang 
SELECT *
FROM ChiTieu
WHERE MONTH(Ngay) = MONTH(GETDATE())
AND YEAR(Ngay) = YEAR(GETDATE())
ORDER BY Ngay DESC;

--tnhep nam
SELECT *
FROM ThuNhap
WHERE YEAR(Ngay) = YEAR(GETDATE())
ORDER BY Ngay DESC;

--ctieu nam 
SELECT *
FROM ChiTieu
WHERE YEAR(Ngay) = YEAR(GETDATE())
ORDER BY Ngay DESC;