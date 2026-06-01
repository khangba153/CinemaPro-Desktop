/*
    File: CinemaProDB_Full_Demo.sql
    Project: CinemaPro.WinForms.DesignFirst

    Muc dich:
    - Tao database demo cho project quan ly rap chieu phim CinemaPro.
    - Script nay co the chay lai nhieu lan vi no se xoa database cu va tao lai tu dau.
    - Phu hop de demo mon WinForms + SQL Server + mo hinh nhieu lop.

    Cach chay:
    1. Mo file nay bang SQL Server extension trong VS Code, Azure Data Studio hoac SSMS.
    2. Ket noi vao SQL Server local, vi du: 127.0.0.1,1433.
    3. Chay toan bo file.

    Luu y quan trong:
    - Script nay se DROP database CinemaProDB neu database da ton tai.
    - Khong chay tren database that/co du lieu quan trong.
    - PasswordHash hien tai dang luu plain text "123456" chi de demo tren lop.
      Sau nay neu lam that thi thay bang hash that ma khong can doi ten cot.
*/

/* ============================================================
   01. RESET DATABASE
   ============================================================

   Y tuong:
   - Chuyen sang database master vi khong the drop database dang duoc USE truc tiep.
   - Neu CinemaProDB da ton tai thi dua ve SINGLE_USER de ngat ket noi dang mo.
   - Drop database cu.
   - Tao database moi.

   GO la batch separator cua SQL Server tools.
   No giup tach cac khoi lenh lon, nhat la CREATE DATABASE, CREATE VIEW, CREATE TRIGGER.
*/

USE master;
GO

IF DB_ID(N'CinemaProDB') IS NOT NULL
BEGIN
    ALTER DATABASE [CinemaProDB]
    SET SINGLE_USER
    WITH ROLLBACK IMMEDIATE;

    DROP DATABASE [CinemaProDB];
END;
GO

CREATE DATABASE [CinemaProDB];
GO

USE [CinemaProDB];
GO

/* ============================================================
   02. CREATE TABLES
   ============================================================

   Quy uoc chung:
   - Cot Id dang INT IDENTITY dung lam khoa chinh va khoa ngoai.
   - Cot Code dung de hien thi tren UI, vi du: MV001, R001, TK000001.
   - Trang thai luu bang tieng Anh de code de xu ly va so sanh.
   - UI WinForms se map trang thai sang tieng Viet khi can.
*/

/* ------------------------------------------------------------
   02.01 Users

   Dung cho:
   - Dang nhap.
   - Phan quyen Admin/Staff.
   - Man hinh quan ly nhan vien.
------------------------------------------------------------ */

CREATE TABLE dbo.Users
(
    UserId INT IDENTITY(1,1) NOT NULL,
    UserCode NVARCHAR(20) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Username NVARCHAR(50) NOT NULL,

    -- Demo only: PasswordHash currently stores plain text password for classroom demo.
    PasswordHash NVARCHAR(255) NOT NULL,

    Role NVARCHAR(20) NOT NULL,
    UserStatus NVARCHAR(20) NOT NULL
        CONSTRAINT DF_Users_UserStatus DEFAULT N'Active',
    CreatedAt DATETIME2(0) NOT NULL
        CONSTRAINT DF_Users_CreatedAt DEFAULT SYSDATETIME(),
    UpdatedAt DATETIME2(0) NULL,

    CONSTRAINT PK_Users
        PRIMARY KEY (UserId),

    CONSTRAINT UQ_Users_UserCode
        UNIQUE (UserCode),

    CONSTRAINT UQ_Users_Username
        UNIQUE (Username),

    CONSTRAINT CK_Users_Role
        CHECK (Role IN (N'Admin', N'Staff')),

    CONSTRAINT CK_Users_UserStatus
        CHECK (UserStatus IN (N'Active', N'Locked'))
);
GO

/* ------------------------------------------------------------
   02.02 Genres

   Dung cho:
   - Danh muc the loai phim.
   - Movies se tham chieu den Genres bang GenreId.
------------------------------------------------------------ */

CREATE TABLE dbo.Genres
(
    GenreId INT IDENTITY(1,1) NOT NULL,
    GenreCode NVARCHAR(20) NOT NULL,
    GenreName NVARCHAR(100) NOT NULL,
    GenreStatus NVARCHAR(20) NOT NULL
        CONSTRAINT DF_Genres_GenreStatus DEFAULT N'Active',

    CONSTRAINT PK_Genres
        PRIMARY KEY (GenreId),

    CONSTRAINT UQ_Genres_GenreCode
        UNIQUE (GenreCode),

    CONSTRAINT UQ_Genres_GenreName
        UNIQUE (GenreName),

    CONSTRAINT CK_Genres_GenreStatus
        CHECK (GenreStatus IN (N'Active', N'Inactive'))
);
GO

/* ------------------------------------------------------------
   02.03 Movies

   Dung cho:
   - Quan ly phim.
   - Chon phim khi tao lich chieu.
------------------------------------------------------------ */

CREATE TABLE dbo.Movies
(
    MovieId INT IDENTITY(1,1) NOT NULL,
    MovieCode NVARCHAR(20) NOT NULL,
    MovieTitle NVARCHAR(200) NOT NULL,
    GenreId INT NOT NULL,
    DurationMinutes INT NOT NULL,
    AgeRating NVARCHAR(20) NOT NULL,
    Director NVARCHAR(120) NULL,
    MovieStatus NVARCHAR(30) NOT NULL
        CONSTRAINT DF_Movies_MovieStatus DEFAULT N'NowShowing',
    CreatedAt DATETIME2(0) NOT NULL
        CONSTRAINT DF_Movies_CreatedAt DEFAULT SYSDATETIME(),
    UpdatedAt DATETIME2(0) NULL,

    CONSTRAINT PK_Movies
        PRIMARY KEY (MovieId),

    CONSTRAINT UQ_Movies_MovieCode
        UNIQUE (MovieCode),

    CONSTRAINT FK_Movies_Genres
        FOREIGN KEY (GenreId)
        REFERENCES dbo.Genres(GenreId),

    CONSTRAINT CK_Movies_DurationMinutes
        CHECK (DurationMinutes > 0),

    CONSTRAINT CK_Movies_AgeRating
        CHECK (AgeRating IN (N'P', N'C13', N'C16', N'C18')),

    CONSTRAINT CK_Movies_MovieStatus
        CHECK (MovieStatus IN (N'NowShowing', N'ComingSoon', N'Stopped'))
);
GO

/* ------------------------------------------------------------
   02.04 Rooms

   Dung cho:
   - Quan ly phong chieu.
   - Moi phong co so hang ghe va so ghe moi hang.
------------------------------------------------------------ */

CREATE TABLE dbo.Rooms
(
    RoomId INT IDENTITY(1,1) NOT NULL,
    RoomCode NVARCHAR(20) NOT NULL,
    RoomName NVARCHAR(100) NOT NULL,
    RoomType NVARCHAR(20) NOT NULL,
    SeatRowCount INT NOT NULL,
    SeatsPerRow INT NOT NULL,
    RoomStatus NVARCHAR(30) NOT NULL
        CONSTRAINT DF_Rooms_RoomStatus DEFAULT N'Active',
    CreatedAt DATETIME2(0) NOT NULL
        CONSTRAINT DF_Rooms_CreatedAt DEFAULT SYSDATETIME(),
    UpdatedAt DATETIME2(0) NULL,

    CONSTRAINT PK_Rooms
        PRIMARY KEY (RoomId),

    CONSTRAINT UQ_Rooms_RoomCode
        UNIQUE (RoomCode),

    CONSTRAINT UQ_Rooms_RoomName
        UNIQUE (RoomName),

    CONSTRAINT CK_Rooms_RoomType
        CHECK (RoomType IN (N'2D', N'3D', N'IMAX', N'VIP')),

    CONSTRAINT CK_Rooms_SeatRowCount
        CHECK (SeatRowCount > 0),

    CONSTRAINT CK_Rooms_SeatsPerRow
        CHECK (SeatsPerRow > 0),

    CONSTRAINT CK_Rooms_RoomStatus
        CHECK (RoomStatus IN (N'Active', N'Maintenance', N'Inactive'))
);
GO

/* ------------------------------------------------------------
   02.05 Seats

   Dung cho:
   - So do ghe.
   - Ban ve theo tung ghe.

   Luu y:
   - SeatStatus chi co Active/Maintenance.
   - Trang thai Sold khong luu o Seats, vi ghe chi Sold theo tung suat chieu.
   - Ghe da ban se duoc xac dinh qua TicketDetails.
------------------------------------------------------------ */

CREATE TABLE dbo.Seats
(
    SeatId INT IDENTITY(1,1) NOT NULL,
    RoomId INT NOT NULL,
    SeatCode NVARCHAR(20) NOT NULL,
    RowLabel NVARCHAR(5) NOT NULL,
    SeatNumber INT NOT NULL,
    SeatStatus NVARCHAR(30) NOT NULL
        CONSTRAINT DF_Seats_SeatStatus DEFAULT N'Active',

    CONSTRAINT PK_Seats
        PRIMARY KEY (SeatId),

    CONSTRAINT FK_Seats_Rooms
        FOREIGN KEY (RoomId)
        REFERENCES dbo.Rooms(RoomId),

    CONSTRAINT UQ_Seats_Room_SeatCode
        UNIQUE (RoomId, SeatCode),

    CONSTRAINT CK_Seats_SeatNumber
        CHECK (SeatNumber > 0),

    CONSTRAINT CK_Seats_SeatStatus
        CHECK (SeatStatus IN (N'Active', N'Maintenance'))
);
GO

/* ------------------------------------------------------------
   02.06 Showtimes

   Dung cho:
   - Quan ly lich chieu.
   - Staff chon suat chieu de ban ve.
------------------------------------------------------------ */

CREATE TABLE dbo.Showtimes
(
    ShowtimeId INT IDENTITY(1,1) NOT NULL,
    ShowtimeCode NVARCHAR(20) NOT NULL,
    MovieId INT NOT NULL,
    RoomId INT NOT NULL,
    StartAt DATETIME2(0) NOT NULL,
    EndAt DATETIME2(0) NOT NULL,
    BasePrice DECIMAL(18,2) NOT NULL,
    ShowtimeFormat NVARCHAR(20) NOT NULL,
    ShowtimeStatus NVARCHAR(30) NOT NULL
        CONSTRAINT DF_Showtimes_ShowtimeStatus DEFAULT N'Open',
    CreatedAt DATETIME2(0) NOT NULL
        CONSTRAINT DF_Showtimes_CreatedAt DEFAULT SYSDATETIME(),
    UpdatedAt DATETIME2(0) NULL,

    CONSTRAINT PK_Showtimes
        PRIMARY KEY (ShowtimeId),

    CONSTRAINT UQ_Showtimes_ShowtimeCode
        UNIQUE (ShowtimeCode),

    CONSTRAINT FK_Showtimes_Movies
        FOREIGN KEY (MovieId)
        REFERENCES dbo.Movies(MovieId),

    CONSTRAINT FK_Showtimes_Rooms
        FOREIGN KEY (RoomId)
        REFERENCES dbo.Rooms(RoomId),

    CONSTRAINT CK_Showtimes_Time
        CHECK (EndAt > StartAt),

    CONSTRAINT CK_Showtimes_BasePrice
        CHECK (BasePrice >= 0),

    CONSTRAINT CK_Showtimes_ShowtimeFormat
        CHECK (ShowtimeFormat IN (N'2D', N'3D', N'IMAX', N'VIP')),

    CONSTRAINT CK_Showtimes_ShowtimeStatus
        CHECK (ShowtimeStatus IN (N'Open', N'Closed', N'Cancelled', N'Finished'))
);
GO

/* ------------------------------------------------------------
   02.07 Tickets

   Dung cho:
   - Ve da ban.
   - Kiem tra ve.
   - Bao cao doanh thu.

   TicketStatus:
   - Unused: ve hop le, chua vao rap.
   - Used: ve da duoc kiem.
   - Cancelled: ve da huy.

   PaymentStatus:
   - Unpaid: chua thanh toan.
   - Paid: da thanh toan thanh cong.
   - Failed: thanh toan loi.
   - Refunded: da hoan tien.
------------------------------------------------------------ */

CREATE TABLE dbo.Tickets
(
    TicketId INT IDENTITY(1,1) NOT NULL,
    TicketCode NVARCHAR(30) NOT NULL,
    ShowtimeId INT NOT NULL,
    SoldByUserId INT NOT NULL,
    CustomerName NVARCHAR(100) NOT NULL
        CONSTRAINT DF_Tickets_CustomerName DEFAULT N'Khách lẻ',
    CustomerPhone NVARCHAR(20) NULL,
    TotalAmount DECIMAL(18,2) NOT NULL,
    TicketStatus NVARCHAR(30) NOT NULL
        CONSTRAINT DF_Tickets_TicketStatus DEFAULT N'Unused',
    PaymentStatus NVARCHAR(30) NOT NULL
        CONSTRAINT DF_Tickets_PaymentStatus DEFAULT N'Unpaid',
    SoldAt DATETIME2(0) NOT NULL
        CONSTRAINT DF_Tickets_SoldAt DEFAULT SYSDATETIME(),
    CancelledAt DATETIME2(0) NULL,

    CONSTRAINT PK_Tickets
        PRIMARY KEY (TicketId),

    CONSTRAINT UQ_Tickets_TicketCode
        UNIQUE (TicketCode),

    CONSTRAINT FK_Tickets_Showtimes
        FOREIGN KEY (ShowtimeId)
        REFERENCES dbo.Showtimes(ShowtimeId),

    CONSTRAINT FK_Tickets_Users
        FOREIGN KEY (SoldByUserId)
        REFERENCES dbo.Users(UserId),

    CONSTRAINT CK_Tickets_TotalAmount
        CHECK (TotalAmount >= 0),

    CONSTRAINT CK_Tickets_TicketStatus
        CHECK (TicketStatus IN (N'Unused', N'Used', N'Cancelled')),

    CONSTRAINT CK_Tickets_PaymentStatus
        CHECK (PaymentStatus IN (N'Unpaid', N'Paid', N'Failed', N'Refunded'))
);
GO

/* ------------------------------------------------------------
   02.08 TicketDetails

   Dung cho:
   - Luu tung ghe trong mot ve.
   - Mot ve co the co nhieu ghe.

   TicketDetailStatus:
   - Active: ghe dang duoc giu/ban cho ve nay.
   - Cancelled: chi tiet ve da huy, ghe co the ban lai.
------------------------------------------------------------ */

CREATE TABLE dbo.TicketDetails
(
    TicketDetailId INT IDENTITY(1,1) NOT NULL,
    TicketId INT NOT NULL,
    ShowtimeId INT NOT NULL,
    SeatId INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    TicketDetailStatus NVARCHAR(30) NOT NULL
        CONSTRAINT DF_TicketDetails_TicketDetailStatus DEFAULT N'Active',
    CreatedAt DATETIME2(0) NOT NULL
        CONSTRAINT DF_TicketDetails_CreatedAt DEFAULT SYSDATETIME(),

    CONSTRAINT PK_TicketDetails
        PRIMARY KEY (TicketDetailId),

    CONSTRAINT FK_TicketDetails_Tickets
        FOREIGN KEY (TicketId)
        REFERENCES dbo.Tickets(TicketId),

    CONSTRAINT FK_TicketDetails_Showtimes
        FOREIGN KEY (ShowtimeId)
        REFERENCES dbo.Showtimes(ShowtimeId),

    CONSTRAINT FK_TicketDetails_Seats
        FOREIGN KEY (SeatId)
        REFERENCES dbo.Seats(SeatId),

    CONSTRAINT CK_TicketDetails_UnitPrice
        CHECK (UnitPrice >= 0),

    CONSTRAINT CK_TicketDetails_TicketDetailStatus
        CHECK (TicketDetailStatus IN (N'Active', N'Cancelled'))
);
GO

/* ------------------------------------------------------------
   02.09 Payments

   Dung cho:
   - Luu giao dich thanh toan cua ve.
   - V1 moi ve chi co mot payment, nen TicketId duoc UNIQUE.

   Status cua Payments khac PaymentStatus cua Tickets:
   - Payments.Status la trang thai giao dich.
   - Tickets.PaymentStatus la trang thai thanh toan tong quat cua ve.
------------------------------------------------------------ */

CREATE TABLE dbo.Payments
(
    PaymentId INT IDENTITY(1,1) NOT NULL,
    PaymentCode NVARCHAR(30) NOT NULL,
    TicketId INT NOT NULL,
    PaymentMethod NVARCHAR(30) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Status NVARCHAR(30) NOT NULL
        CONSTRAINT DF_Payments_Status DEFAULT N'Pending',
    TransactionRef NVARCHAR(100) NULL,
    PaidAt DATETIME2(0) NULL,
    CreatedAt DATETIME2(0) NOT NULL
        CONSTRAINT DF_Payments_CreatedAt DEFAULT SYSDATETIME(),

    CONSTRAINT PK_Payments
        PRIMARY KEY (PaymentId),

    CONSTRAINT UQ_Payments_PaymentCode
        UNIQUE (PaymentCode),

    CONSTRAINT UQ_Payments_TicketId
        UNIQUE (TicketId),

    CONSTRAINT FK_Payments_Tickets
        FOREIGN KEY (TicketId)
        REFERENCES dbo.Tickets(TicketId),

    CONSTRAINT CK_Payments_PaymentMethod
        CHECK (PaymentMethod IN (N'Cash', N'VNPAY_SANDBOX')),

    CONSTRAINT CK_Payments_Amount
        CHECK (Amount >= 0),

    CONSTRAINT CK_Payments_Status
        CHECK (Status IN (N'Pending', N'Success', N'Failed', N'Refunded'))
);
GO

/* ------------------------------------------------------------
   02.10 TicketChecks

   Dung cho:
   - Luu lich su nhan vien kiem ve.
   - TicketId cho phep NULL de luu ca truong hop nhap ma khong ton tai.
------------------------------------------------------------ */

CREATE TABLE dbo.TicketChecks
(
    TicketCheckId INT IDENTITY(1,1) NOT NULL,
    TicketId INT NULL,
    TicketCodeInput NVARCHAR(30) NOT NULL,
    CheckedByUserId INT NOT NULL,
    CheckResult NVARCHAR(30) NOT NULL,
    Note NVARCHAR(255) NULL,
    CheckedAt DATETIME2(0) NOT NULL
        CONSTRAINT DF_TicketChecks_CheckedAt DEFAULT SYSDATETIME(),

    CONSTRAINT PK_TicketChecks
        PRIMARY KEY (TicketCheckId),

    CONSTRAINT FK_TicketChecks_Tickets
        FOREIGN KEY (TicketId)
        REFERENCES dbo.Tickets(TicketId),

    CONSTRAINT FK_TicketChecks_Users
        FOREIGN KEY (CheckedByUserId)
        REFERENCES dbo.Users(UserId),

    CONSTRAINT CK_TicketChecks_CheckResult
        CHECK (CheckResult IN (N'Valid', N'Used', N'Cancelled', N'NotFound'))
);
GO

/* ------------------------------------------------------------
   02.11 AppSettings

   Dung cho:
   - Luu cau hinh he thong dang key-value.
   - V1 chi can don gian de phuc vu man hinh Cai dat.
------------------------------------------------------------ */

CREATE TABLE dbo.AppSettings
(
    AppSettingId INT IDENTITY(1,1) NOT NULL,
    SettingKey NVARCHAR(100) NOT NULL,
    SettingValue NVARCHAR(500) NULL,
    Description NVARCHAR(255) NULL,
    UpdatedAt DATETIME2(0) NOT NULL
        CONSTRAINT DF_AppSettings_UpdatedAt DEFAULT SYSDATETIME(),

    CONSTRAINT PK_AppSettings
        PRIMARY KEY (AppSettingId),

    CONSTRAINT UQ_AppSettings_SettingKey
        UNIQUE (SettingKey)
);
GO

/* ============================================================
   03. CREATE INDEXES
   ============================================================

   Index giup truy van nhanh hon khi join/filter theo khoa ngoai.
   Unique filtered index ben duoi la rang buoc quan trong nhat cua ban ve:
   - Cung mot suat chieu, mot ghe chi duoc co mot TicketDetail dang Active.
   - Neu TicketDetailStatus = Cancelled thi ghe co the ban lai.
*/

CREATE INDEX IX_Movies_GenreId
ON dbo.Movies (GenreId);
GO

CREATE INDEX IX_Seats_RoomId
ON dbo.Seats (RoomId);
GO

CREATE INDEX IX_Showtimes_MovieId
ON dbo.Showtimes (MovieId);
GO

CREATE INDEX IX_Showtimes_Room_StartAt
ON dbo.Showtimes (RoomId, StartAt, EndAt);
GO

CREATE INDEX IX_Tickets_ShowtimeId
ON dbo.Tickets (ShowtimeId);
GO

CREATE INDEX IX_Tickets_SoldAt
ON dbo.Tickets (SoldAt);
GO

CREATE INDEX IX_TicketDetails_TicketId
ON dbo.TicketDetails (TicketId);
GO

CREATE INDEX IX_TicketDetails_SeatId
ON dbo.TicketDetails (SeatId);
GO

CREATE INDEX IX_Payments_TicketId
ON dbo.Payments (TicketId);
GO

CREATE UNIQUE INDEX UX_TicketDetails_Showtime_Seat_Active
ON dbo.TicketDetails (ShowtimeId, SeatId)
WHERE TicketDetailStatus = N'Active';
GO

/* ============================================================
   04. CREATE TRIGGERS
   ============================================================

   V1 chi dung 2 trigger de tranh lam database qua kho hieu.
   Cac nghiep vu con lai se xu ly o Service trong code C#.
*/

/* ------------------------------------------------------------
   04.01 Trigger: chan lich chieu trung phong

   inserted la bang tam cua SQL Server.
   Khi INSERT/UPDATE Showtimes, SQL Server bo cac dong moi vao inserted.

   Dieu kien trung lich:
   - Cung RoomId.
   - Khac ShowtimeId.
   - Suat moi va suat cu deu khong bi Cancelled.
   - StartAt moi < EndAt cu.
   - EndAt moi > StartAt cu.
------------------------------------------------------------ */

CREATE TRIGGER dbo.trg_Showtimes_PreventRoomConflict
ON dbo.Showtimes
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS
    (
        SELECT
            1
        FROM inserted AS InsertedShowtime
        INNER JOIN dbo.Showtimes AS ExistingShowtime
            ON ExistingShowtime.RoomId = InsertedShowtime.RoomId
        WHERE ExistingShowtime.ShowtimeId <> InsertedShowtime.ShowtimeId
            AND ExistingShowtime.ShowtimeStatus <> N'Cancelled'
            AND InsertedShowtime.ShowtimeStatus <> N'Cancelled'
            AND InsertedShowtime.StartAt < ExistingShowtime.EndAt
            AND InsertedShowtime.EndAt > ExistingShowtime.StartAt
    )
    BEGIN
        RAISERROR(N'Phòng chiếu đã có lịch chiếu trùng thời gian.', 16, 1);
        RETURN;
    END;
END;
GO

/* ------------------------------------------------------------
   04.02 Trigger: kiem tra ghe khi ban ve

   Trigger nay chan 3 loi:
   1. ShowtimeId trong TicketDetails khong khop ShowtimeId cua Tickets.
   2. Ghe khong thuoc phong cua suat chieu.
   3. Ghe dang Maintenance nhung van bi ban.
------------------------------------------------------------ */

CREATE TRIGGER dbo.trg_TicketDetails_ValidateSeat
ON dbo.TicketDetails
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Loi 1: chi tiet ve phai thuoc cung suat chieu voi ve.
    IF EXISTS
    (
        SELECT
            1
        FROM inserted AS InsertedTicketDetail
        INNER JOIN dbo.Tickets AS Ticket
            ON Ticket.TicketId = InsertedTicketDetail.TicketId
        WHERE InsertedTicketDetail.ShowtimeId <> Ticket.ShowtimeId
    )
    BEGIN
        RAISERROR(N'Suất chiếu trong chi tiết vé không khớp với vé.', 16, 1);
        RETURN;
    END;

    -- Loi 2: ghe phai nam trong dung phong cua suat chieu.
    IF EXISTS
    (
        SELECT
            1
        FROM inserted AS InsertedTicketDetail
        INNER JOIN dbo.Showtimes AS Showtime
            ON Showtime.ShowtimeId = InsertedTicketDetail.ShowtimeId
        INNER JOIN dbo.Seats AS Seat
            ON Seat.SeatId = InsertedTicketDetail.SeatId
        WHERE Seat.RoomId <> Showtime.RoomId
    )
    BEGIN
        RAISERROR(N'Ghế không thuộc phòng của suất chiếu.', 16, 1);
        RETURN;
    END;

    -- Loi 3: ghe dang bao tri thi khong duoc ban neu TicketDetail dang Active.
    IF EXISTS
    (
        SELECT
            1
        FROM inserted AS InsertedTicketDetail
        INNER JOIN dbo.Seats AS Seat
            ON Seat.SeatId = InsertedTicketDetail.SeatId
        WHERE InsertedTicketDetail.TicketDetailStatus = N'Active'
            AND Seat.SeatStatus = N'Maintenance'
    )
    BEGIN
        RAISERROR(N'Ghế đang bảo trì, không được bán vé.', 16, 1);
        RETURN;
    END;
END;
GO

/* ============================================================
   05. SEED DATA
   ============================================================

   Seed data giup app co san du lieu de demo sau khi chay script.
*/

/* ------------------------------------------------------------
   05.01 Seed Users
------------------------------------------------------------ */

INSERT INTO dbo.Users
(
    UserCode,
    FullName,
    Username,
    PasswordHash,
    Role,
    UserStatus
)
VALUES
(
    N'U001',
    N'Nguyễn Văn Quản',
    N'admin',
    N'123456',
    N'Admin',
    N'Active'
),
(
    N'U002',
    N'Trần Thị Mai',
    N'staff01',
    N'123456',
    N'Staff',
    N'Active'
),
(
    N'U003',
    N'Lê Minh Khang',
    N'staff02',
    N'123456',
    N'Staff',
    N'Locked'
);
GO

/* ------------------------------------------------------------
   05.02 Seed Genres
------------------------------------------------------------ */

INSERT INTO dbo.Genres
(
    GenreCode,
    GenreName
)
VALUES
    (N'G001', N'Hành động'),
    (N'G002', N'Hoạt hình'),
    (N'G003', N'Tâm lý'),
    (N'G004', N'Khoa học viễn tưởng'),
    (N'G005', N'Gia đình'),
    (N'G006', N'Kinh dị');
GO

/* ------------------------------------------------------------
   05.03 Seed Movies

   De cau lenh INSERT de doc hon, ta lay GenreId ra bien truoc.
------------------------------------------------------------ */

DECLARE @GenreActionId INT;
DECLARE @GenreAnimationId INT;
DECLARE @GenreDramaId INT;
DECLARE @GenreSciFiId INT;
DECLARE @GenreFamilyId INT;

SELECT @GenreActionId = GenreId
FROM dbo.Genres
WHERE GenreCode = N'G001';

SELECT @GenreAnimationId = GenreId
FROM dbo.Genres
WHERE GenreCode = N'G002';

SELECT @GenreDramaId = GenreId
FROM dbo.Genres
WHERE GenreCode = N'G003';

SELECT @GenreSciFiId = GenreId
FROM dbo.Genres
WHERE GenreCode = N'G004';

SELECT @GenreFamilyId = GenreId
FROM dbo.Genres
WHERE GenreCode = N'G005';

INSERT INTO dbo.Movies
(
    MovieCode,
    MovieTitle,
    GenreId,
    DurationMinutes,
    AgeRating,
    Director,
    MovieStatus
)
VALUES
(
    N'MV001',
    N'Avengers: Endgame',
    @GenreActionId,
    182,
    N'C13',
    N'Anthony Russo',
    N'NowShowing'
),
(
    N'MV002',
    N'Mai',
    @GenreDramaId,
    131,
    N'C18',
    N'Trấn Thành',
    N'NowShowing'
),
(
    N'MV003',
    N'Dune: Part Two',
    @GenreSciFiId,
    166,
    N'C13',
    N'Denis Villeneuve',
    N'NowShowing'
),
(
    N'MV004',
    N'Kung Fu Panda 4',
    @GenreAnimationId,
    94,
    N'P',
    N'Mike Mitchell',
    N'NowShowing'
),
(
    N'MV005',
    N'Lật Mặt 7',
    @GenreFamilyId,
    138,
    N'C13',
    N'Lý Hải',
    N'ComingSoon'
),
(
    N'MV006',
    N'Inside Out 2',
    @GenreAnimationId,
    96,
    N'P',
    N'Kelsey Mann',
    N'ComingSoon'
);
GO

/* ------------------------------------------------------------
   05.04 Seed Rooms
------------------------------------------------------------ */

INSERT INTO dbo.Rooms
(
    RoomCode,
    RoomName,
    RoomType,
    SeatRowCount,
    SeatsPerRow,
    RoomStatus
)
VALUES
(
    N'R001',
    N'Phòng 1',
    N'2D',
    6,
    8,
    N'Active'
),
(
    N'R002',
    N'Phòng 2',
    N'3D',
    6,
    8,
    N'Active'
),
(
    N'R003',
    N'IMAX 1',
    N'IMAX',
    7,
    10,
    N'Active'
),
(
    N'R004',
    N'VIP 1',
    N'VIP',
    5,
    6,
    N'Maintenance'
),
(
    N'R005',
    N'Phòng 5',
    N'2D',
    6,
    8,
    N'Active'
);
GO

/* ------------------------------------------------------------
   05.05 Generate Seats

   Muc tieu:
   - Tu dong tao ghe theo SeatRowCount va SeatsPerRow cua moi phong.
   - Vi du SeatRowCount = 6, SeatsPerRow = 8 se tao A1...A8, B1...B8...

   Cach lam:
   - Dung cursor de duyet tung phong.
   - Dung WHILE de tao tung hang va tung ghe.
   - Cach nay de doc voi nguoi moi hoc SQL hon so voi query sinh so phuc tap.
------------------------------------------------------------ */

DECLARE @CurrentRoomId INT;
DECLARE @CurrentRoomRowCount INT;
DECLARE @CurrentRoomSeatsPerRow INT;
DECLARE @CurrentRowIndex INT;
DECLARE @CurrentSeatNumber INT;
DECLARE @CurrentRowLabel NVARCHAR(5);
DECLARE @CurrentSeatCode NVARCHAR(20);

DECLARE RoomCursor CURSOR LOCAL FAST_FORWARD FOR
    SELECT
        RoomId,
        SeatRowCount,
        SeatsPerRow
    FROM dbo.Rooms;

OPEN RoomCursor;

FETCH NEXT FROM RoomCursor
INTO
    @CurrentRoomId,
    @CurrentRoomRowCount,
    @CurrentRoomSeatsPerRow;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @CurrentRowIndex = 1;

    WHILE @CurrentRowIndex <= @CurrentRoomRowCount
    BEGIN
        SET @CurrentRowLabel = NCHAR(64 + @CurrentRowIndex);
        SET @CurrentSeatNumber = 1;

        WHILE @CurrentSeatNumber <= @CurrentRoomSeatsPerRow
        BEGIN
            SET @CurrentSeatCode = @CurrentRowLabel + CAST(@CurrentSeatNumber AS NVARCHAR(10));

            INSERT INTO dbo.Seats
            (
                RoomId,
                SeatCode,
                RowLabel,
                SeatNumber,
                SeatStatus
            )
            VALUES
            (
                @CurrentRoomId,
                @CurrentSeatCode,
                @CurrentRowLabel,
                @CurrentSeatNumber,
                N'Active'
            );

            SET @CurrentSeatNumber = @CurrentSeatNumber + 1;
        END;

        SET @CurrentRowIndex = @CurrentRowIndex + 1;
    END;

    FETCH NEXT FROM RoomCursor
    INTO
        @CurrentRoomId,
        @CurrentRoomRowCount,
        @CurrentRoomSeatsPerRow;
END;

CLOSE RoomCursor;
DEALLOCATE RoomCursor;
GO

/* ------------------------------------------------------------
   05.06 Mark Maintenance Seats

   - Dat ghe C2 cua cac phong thanh Maintenance de test chan ban ghe bao tri.
   - Dat them A1, A2 cua phong VIP 1 thanh Maintenance.
------------------------------------------------------------ */

UPDATE dbo.Seats
SET SeatStatus = N'Maintenance'
WHERE SeatCode = N'C2';
GO

DECLARE @VipRoomId INT;

SELECT @VipRoomId = RoomId
FROM dbo.Rooms
WHERE RoomCode = N'R004';

UPDATE dbo.Seats
SET SeatStatus = N'Maintenance'
WHERE RoomId = @VipRoomId
    AND SeatCode IN (N'A1', N'A2');
GO

/* ------------------------------------------------------------
   05.07 Seed Showtimes

   Dung ngay hien tai cua may SQL Server de tao lich chieu hom nay.
------------------------------------------------------------ */

DECLARE @Today DATE;
DECLARE @MovieAvengersId INT;
DECLARE @MovieMaiId INT;
DECLARE @MovieDuneId INT;
DECLARE @MovieKungFuPandaId INT;
DECLARE @MovieLatMatId INT;
DECLARE @RoomOneId INT;
DECLARE @RoomTwoId INT;
DECLARE @RoomImaxId INT;

SET @Today = CAST(GETDATE() AS DATE);

SELECT @MovieAvengersId = MovieId
FROM dbo.Movies
WHERE MovieCode = N'MV001';

SELECT @MovieMaiId = MovieId
FROM dbo.Movies
WHERE MovieCode = N'MV002';

SELECT @MovieDuneId = MovieId
FROM dbo.Movies
WHERE MovieCode = N'MV003';

SELECT @MovieKungFuPandaId = MovieId
FROM dbo.Movies
WHERE MovieCode = N'MV004';

SELECT @MovieLatMatId = MovieId
FROM dbo.Movies
WHERE MovieCode = N'MV005';

SELECT @RoomOneId = RoomId
FROM dbo.Rooms
WHERE RoomCode = N'R001';

SELECT @RoomTwoId = RoomId
FROM dbo.Rooms
WHERE RoomCode = N'R002';

SELECT @RoomImaxId = RoomId
FROM dbo.Rooms
WHERE RoomCode = N'R003';

INSERT INTO dbo.Showtimes
(
    ShowtimeCode,
    MovieId,
    RoomId,
    StartAt,
    EndAt,
    BasePrice,
    ShowtimeFormat,
    ShowtimeStatus
)
VALUES
(
    N'SC001',
    @MovieKungFuPandaId,
    @RoomOneId,
    DATEADD(MINUTE, 9 * 60, CAST(@Today AS DATETIME2(0))),
    DATEADD(MINUTE, 10 * 60 + 34, CAST(@Today AS DATETIME2(0))),
    75000,
    N'2D',
    N'Open'
),
(
    N'SC002',
    @MovieMaiId,
    @RoomTwoId,
    DATEADD(MINUTE, 10 * 60 + 30, CAST(@Today AS DATETIME2(0))),
    DATEADD(MINUTE, 12 * 60 + 41, CAST(@Today AS DATETIME2(0))),
    85000,
    N'2D',
    N'Open'
),
(
    N'SC003',
    @MovieDuneId,
    @RoomImaxId,
    DATEADD(MINUTE, 14 * 60, CAST(@Today AS DATETIME2(0))),
    DATEADD(MINUTE, 16 * 60 + 46, CAST(@Today AS DATETIME2(0))),
    130000,
    N'IMAX',
    N'Open'
),
(
    N'SC004',
    @MovieAvengersId,
    @RoomTwoId,
    DATEADD(MINUTE, 19 * 60 + 30, CAST(@Today AS DATETIME2(0))),
    DATEADD(MINUTE, 22 * 60 + 32, CAST(@Today AS DATETIME2(0))),
    90000,
    N'3D',
    N'Open'
),
(
    N'SC005',
    @MovieLatMatId,
    @RoomOneId,
    DATEADD(DAY, 1, DATEADD(MINUTE, 19 * 60, CAST(@Today AS DATETIME2(0)))),
    DATEADD(DAY, 1, DATEADD(MINUTE, 21 * 60 + 18, CAST(@Today AS DATETIME2(0)))),
    85000,
    N'2D',
    N'Open'
);
GO

/* ------------------------------------------------------------
   05.08 Seed Tickets
------------------------------------------------------------ */

DECLARE @StaffMaiId INT;
DECLARE @ShowtimeSc001Id INT;
DECLARE @ShowtimeSc002Id INT;
DECLARE @ShowtimeSc003Id INT;
DECLARE @ShowtimeSc004Id INT;

SELECT @StaffMaiId = UserId
FROM dbo.Users
WHERE UserCode = N'U002';

SELECT @ShowtimeSc001Id = ShowtimeId
FROM dbo.Showtimes
WHERE ShowtimeCode = N'SC001';

SELECT @ShowtimeSc002Id = ShowtimeId
FROM dbo.Showtimes
WHERE ShowtimeCode = N'SC002';

SELECT @ShowtimeSc003Id = ShowtimeId
FROM dbo.Showtimes
WHERE ShowtimeCode = N'SC003';

SELECT @ShowtimeSc004Id = ShowtimeId
FROM dbo.Showtimes
WHERE ShowtimeCode = N'SC004';

INSERT INTO dbo.Tickets
(
    TicketCode,
    ShowtimeId,
    SoldByUserId,
    CustomerName,
    TotalAmount,
    TicketStatus,
    PaymentStatus,
    SoldAt,
    CancelledAt
)
VALUES
(
    N'TK000001',
    @ShowtimeSc004Id,
    @StaffMaiId,
    N'Khách lẻ',
    90000,
    N'Unused',
    N'Paid',
    DATEADD(MINUTE, -18, SYSDATETIME()),
    NULL
),
(
    N'TK000002',
    @ShowtimeSc003Id,
    @StaffMaiId,
    N'Khách lẻ',
    260000,
    N'Used',
    N'Paid',
    DATEADD(HOUR, -3, SYSDATETIME()),
    NULL
),
(
    N'TK000003',
    @ShowtimeSc002Id,
    @StaffMaiId,
    N'Khách lẻ',
    85000,
    N'Cancelled',
    N'Refunded',
    DATEADD(HOUR, -4, SYSDATETIME()),
    DATEADD(HOUR, -3, SYSDATETIME())
),
(
    N'TK000004',
    @ShowtimeSc001Id,
    @StaffMaiId,
    N'Khách lẻ',
    150000,
    N'Unused',
    N'Paid',
    DATEADD(MINUTE, -42, SYSDATETIME()),
    NULL
);
GO

/* ------------------------------------------------------------
   05.09 Seed TicketDetails

   Ta lay tung TicketId va SeatId ra bien de cau INSERT de doc hon.
------------------------------------------------------------ */

DECLARE @TicketTk000001Id INT;
DECLARE @TicketTk000002Id INT;
DECLARE @TicketTk000003Id INT;
DECLARE @TicketTk000004Id INT;
DECLARE @SeatRoom2B6Id INT;
DECLARE @SeatImaxC4Id INT;
DECLARE @SeatImaxC5Id INT;
DECLARE @SeatRoom2A1Id INT;
DECLARE @SeatRoom1D2Id INT;
DECLARE @SeatRoom1D3Id INT;
DECLARE @TicketDetailShowtimeSc001Id INT;
DECLARE @TicketDetailShowtimeSc002Id INT;
DECLARE @TicketDetailShowtimeSc003Id INT;
DECLARE @TicketDetailShowtimeSc004Id INT;

SELECT @TicketTk000001Id = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000001';

SELECT @TicketTk000002Id = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000002';

SELECT @TicketTk000003Id = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000003';

SELECT @TicketTk000004Id = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000004';

SELECT @TicketDetailShowtimeSc001Id = ShowtimeId
FROM dbo.Showtimes
WHERE ShowtimeCode = N'SC001';

SELECT @TicketDetailShowtimeSc002Id = ShowtimeId
FROM dbo.Showtimes
WHERE ShowtimeCode = N'SC002';

SELECT @TicketDetailShowtimeSc003Id = ShowtimeId
FROM dbo.Showtimes
WHERE ShowtimeCode = N'SC003';

SELECT @TicketDetailShowtimeSc004Id = ShowtimeId
FROM dbo.Showtimes
WHERE ShowtimeCode = N'SC004';

SELECT @SeatRoom2B6Id = Seat.SeatId
FROM dbo.Seats AS Seat
INNER JOIN dbo.Rooms AS Room
    ON Room.RoomId = Seat.RoomId
WHERE Room.RoomCode = N'R002'
    AND Seat.SeatCode = N'B6';

SELECT @SeatImaxC4Id = Seat.SeatId
FROM dbo.Seats AS Seat
INNER JOIN dbo.Rooms AS Room
    ON Room.RoomId = Seat.RoomId
WHERE Room.RoomCode = N'R003'
    AND Seat.SeatCode = N'C4';

SELECT @SeatImaxC5Id = Seat.SeatId
FROM dbo.Seats AS Seat
INNER JOIN dbo.Rooms AS Room
    ON Room.RoomId = Seat.RoomId
WHERE Room.RoomCode = N'R003'
    AND Seat.SeatCode = N'C5';

SELECT @SeatRoom2A1Id = Seat.SeatId
FROM dbo.Seats AS Seat
INNER JOIN dbo.Rooms AS Room
    ON Room.RoomId = Seat.RoomId
WHERE Room.RoomCode = N'R002'
    AND Seat.SeatCode = N'A1';

SELECT @SeatRoom1D2Id = Seat.SeatId
FROM dbo.Seats AS Seat
INNER JOIN dbo.Rooms AS Room
    ON Room.RoomId = Seat.RoomId
WHERE Room.RoomCode = N'R001'
    AND Seat.SeatCode = N'D2';

SELECT @SeatRoom1D3Id = Seat.SeatId
FROM dbo.Seats AS Seat
INNER JOIN dbo.Rooms AS Room
    ON Room.RoomId = Seat.RoomId
WHERE Room.RoomCode = N'R001'
    AND Seat.SeatCode = N'D3';

INSERT INTO dbo.TicketDetails
(
    TicketId,
    ShowtimeId,
    SeatId,
    UnitPrice,
    TicketDetailStatus
)
VALUES
(
    @TicketTk000001Id,
    @TicketDetailShowtimeSc004Id,
    @SeatRoom2B6Id,
    90000,
    N'Active'
),
(
    @TicketTk000002Id,
    @TicketDetailShowtimeSc003Id,
    @SeatImaxC4Id,
    130000,
    N'Active'
),
(
    @TicketTk000002Id,
    @TicketDetailShowtimeSc003Id,
    @SeatImaxC5Id,
    130000,
    N'Active'
),
(
    @TicketTk000003Id,
    @TicketDetailShowtimeSc002Id,
    @SeatRoom2A1Id,
    85000,
    N'Cancelled'
),
(
    @TicketTk000004Id,
    @TicketDetailShowtimeSc001Id,
    @SeatRoom1D2Id,
    75000,
    N'Active'
),
(
    @TicketTk000004Id,
    @TicketDetailShowtimeSc001Id,
    @SeatRoom1D3Id,
    75000,
    N'Active'
);
GO

/* ------------------------------------------------------------
   05.10 Seed Payments
------------------------------------------------------------ */

DECLARE @TicketTk000001IdForPayment INT;
DECLARE @TicketTk000002IdForPayment INT;
DECLARE @TicketTk000003IdForPayment INT;
DECLARE @TicketTk000004IdForPayment INT;

SELECT @TicketTk000001IdForPayment = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000001';

SELECT @TicketTk000002IdForPayment = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000002';

SELECT @TicketTk000003IdForPayment = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000003';

SELECT @TicketTk000004IdForPayment = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000004';

INSERT INTO dbo.Payments
(
    PaymentCode,
    TicketId,
    PaymentMethod,
    Amount,
    Status,
    TransactionRef,
    PaidAt
)
VALUES
(
    N'PM000001',
    @TicketTk000001IdForPayment,
    N'Cash',
    90000,
    N'Success',
    NULL,
    DATEADD(MINUTE, -18, SYSDATETIME())
),
(
    N'PM000002',
    @TicketTk000002IdForPayment,
    N'VNPAY_SANDBOX',
    260000,
    N'Success',
    N'VNPAY-DEMO-000002',
    DATEADD(HOUR, -3, SYSDATETIME())
),
(
    N'PM000003',
    @TicketTk000003IdForPayment,
    N'Cash',
    85000,
    N'Refunded',
    NULL,
    DATEADD(HOUR, -4, SYSDATETIME())
),
(
    N'PM000004',
    @TicketTk000004IdForPayment,
    N'Cash',
    150000,
    N'Success',
    NULL,
    DATEADD(MINUTE, -42, SYSDATETIME())
);
GO

/* ------------------------------------------------------------
   05.11 Seed TicketChecks
------------------------------------------------------------ */

DECLARE @TicketTk000002IdForCheck INT;
DECLARE @TicketTk000003IdForCheck INT;
DECLARE @StaffMaiIdForCheck INT;

SELECT @TicketTk000002IdForCheck = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000002';

SELECT @TicketTk000003IdForCheck = TicketId
FROM dbo.Tickets
WHERE TicketCode = N'TK000003';

SELECT @StaffMaiIdForCheck = UserId
FROM dbo.Users
WHERE UserCode = N'U002';

INSERT INTO dbo.TicketChecks
(
    TicketId,
    TicketCodeInput,
    CheckedByUserId,
    CheckResult,
    Note,
    CheckedAt
)
VALUES
(
    @TicketTk000002IdForCheck,
    N'TK000002',
    @StaffMaiIdForCheck,
    N'Used',
    N'Ve da duoc su dung truoc do',
    DATEADD(HOUR, -1, SYSDATETIME())
),
(
    @TicketTk000003IdForCheck,
    N'TK000003',
    @StaffMaiIdForCheck,
    N'Cancelled',
    N'Ve da huy',
    DATEADD(MINUTE, -50, SYSDATETIME())
),
(
    NULL,
    N'TK999999',
    @StaffMaiIdForCheck,
    N'NotFound',
    N'Khong tim thay ve',
    DATEADD(MINUTE, -25, SYSDATETIME())
);
GO

/* ------------------------------------------------------------
   05.12 Seed AppSettings
------------------------------------------------------------ */

INSERT INTO dbo.AppSettings
(
    SettingKey,
    SettingValue,
    Description
)
VALUES
(
    N'CinemaName',
    N'CinemaPro Demo Cinema',
    N'Ten rap hien thi trong phan mem'
),
(
    N'DefaultCurrency',
    N'VND',
    N'Don vi tien te mac dinh'
),
(
    N'AllowVnPaySandbox',
    N'true',
    N'Bat/tat thanh toan VNPAY Sandbox gia lap'
),
(
    N'TicketCodePrefix',
    N'TK',
    N'Tien to ma ve'
),
(
    N'BusinessDateMode',
    N'LocalDate',
    N'Cach tinh ngay bao cao demo'
);
GO

/* ============================================================
   06. CREATE VIEWS
   ============================================================

   View la cau SELECT da dat ten.
   WinForms/Report co the SELECT tu view de do vao DataGridView hoac ReportViewer.
*/

/* ------------------------------------------------------------
   06.01 v_TodayShowtimes

   Dung cho:
   - TodayShowtimeForm.
   - StaffDashboardForm.
------------------------------------------------------------ */

CREATE VIEW dbo.v_TodayShowtimes
AS
SELECT
    Showtime.ShowtimeId,
    Showtime.ShowtimeCode,
    Movie.MovieCode,
    Movie.MovieTitle,
    Room.RoomCode,
    Room.RoomName,
    Showtime.StartAt,
    Showtime.EndAt,
    CONVERT(CHAR(5), Showtime.StartAt, 108) AS StartTimeText,
    CONVERT(CHAR(5), Showtime.EndAt, 108) AS EndTimeText,
    Showtime.BasePrice,
    Showtime.ShowtimeFormat,
    Showtime.ShowtimeStatus,
    COUNT(TicketDetail.TicketDetailId) AS SoldSeatCount
FROM dbo.Showtimes AS Showtime
INNER JOIN dbo.Movies AS Movie
    ON Movie.MovieId = Showtime.MovieId
INNER JOIN dbo.Rooms AS Room
    ON Room.RoomId = Showtime.RoomId
LEFT JOIN dbo.TicketDetails AS TicketDetail
    ON TicketDetail.ShowtimeId = Showtime.ShowtimeId
    AND TicketDetail.TicketDetailStatus = N'Active'
WHERE CAST(Showtime.StartAt AS DATE) = CAST(GETDATE() AS DATE)
GROUP BY
    Showtime.ShowtimeId,
    Showtime.ShowtimeCode,
    Movie.MovieCode,
    Movie.MovieTitle,
    Room.RoomCode,
    Room.RoomName,
    Showtime.StartAt,
    Showtime.EndAt,
    Showtime.BasePrice,
    Showtime.ShowtimeFormat,
    Showtime.ShowtimeStatus;
GO

/* ------------------------------------------------------------
   06.02 v_SoldTickets

   Dung cho:
   - SoldTicketsForm.
   - TicketCheckForm.

   Do mot ve co the co nhieu ghe, view can gom nhieu SeatCode thanh mot chuoi.

   O day khong dung STRING_AGG de tranh loi tren SQL Server cu.
   Thay vao do dung STUFF + FOR XML PATH:
   - FOR XML PATH tao chuoi ghe dang ", C4, C5".
   - STUFF xoa dau phay va khoang trang dau tien.
------------------------------------------------------------ */

CREATE VIEW dbo.v_SoldTickets
AS
SELECT
    Ticket.TicketId,
    Ticket.TicketCode,
    Movie.MovieTitle,
    Room.RoomName,
    Showtime.StartAt,
    Showtime.EndAt,
    CONVERT(CHAR(5), Showtime.StartAt, 108) + N' - ' + CONVERT(CHAR(5), Showtime.EndAt, 108) AS ShowtimeText,
    STUFF
    (
        (
            SELECT
                N', ' + SeatInTicket.SeatCode
            FROM dbo.TicketDetails AS TicketDetailInTicket
            INNER JOIN dbo.Seats AS SeatInTicket
                ON SeatInTicket.SeatId = TicketDetailInTicket.SeatId
            WHERE TicketDetailInTicket.TicketId = Ticket.TicketId
            ORDER BY
                SeatInTicket.RowLabel,
                SeatInTicket.SeatNumber
            FOR XML PATH(N''), TYPE
        ).value(N'.', N'NVARCHAR(MAX)'),
        1,
        2,
        N''
    ) AS SeatCodes,
    Ticket.TotalAmount,
    Payment.PaymentMethod,
    Payment.Status AS PaymentTransactionStatus,
    Ticket.PaymentStatus,
    Ticket.TicketStatus,
    Ticket.SoldAt,
    Seller.FullName AS SoldBy
FROM dbo.Tickets AS Ticket
INNER JOIN dbo.Showtimes AS Showtime
    ON Showtime.ShowtimeId = Ticket.ShowtimeId
INNER JOIN dbo.Movies AS Movie
    ON Movie.MovieId = Showtime.MovieId
INNER JOIN dbo.Rooms AS Room
    ON Room.RoomId = Showtime.RoomId
INNER JOIN dbo.Users AS Seller
    ON Seller.UserId = Ticket.SoldByUserId
LEFT JOIN dbo.Payments AS Payment
    ON Payment.TicketId = Ticket.TicketId
GO

/* ------------------------------------------------------------
   06.03 v_RevenueReport

   Dung cho:
   - RevenueReportForm.
   - Crystal Report/ReportViewer neu lam o buoc sau.
------------------------------------------------------------ */

CREATE VIEW dbo.v_RevenueReport
AS
SELECT
    CAST(COALESCE(Payment.PaidAt, Ticket.SoldAt) AS DATE) AS RevenueDate,
    Movie.MovieTitle,
    Payment.PaymentMethod,
    COUNT(DISTINCT Ticket.TicketId) AS TicketCount,
    SUM(Payment.Amount) AS RevenueAmount
FROM dbo.Payments AS Payment
INNER JOIN dbo.Tickets AS Ticket
    ON Ticket.TicketId = Payment.TicketId
INNER JOIN dbo.Showtimes AS Showtime
    ON Showtime.ShowtimeId = Ticket.ShowtimeId
INNER JOIN dbo.Movies AS Movie
    ON Movie.MovieId = Showtime.MovieId
WHERE Payment.Status = N'Success'
    AND Ticket.TicketStatus <> N'Cancelled'
GROUP BY
    CAST(COALESCE(Payment.PaidAt, Ticket.SoldAt) AS DATE),
    Movie.MovieTitle,
    Payment.PaymentMethod;
GO

/* ------------------------------------------------------------
   06.04 v_DashboardSummary

   Dung cho:
   - AdminDashboardForm.
   - StaffDashboardForm.
------------------------------------------------------------ */

CREATE VIEW dbo.v_DashboardSummary
AS
SELECT
    (
        SELECT COUNT(*)
        FROM dbo.Movies
        WHERE MovieStatus <> N'Stopped'
    ) AS TotalMovies,

    (
        SELECT COUNT(*)
        FROM dbo.Rooms
        WHERE RoomStatus <> N'Inactive'
    ) AS TotalRooms,

    (
        SELECT COUNT(*)
        FROM dbo.Showtimes
        WHERE CAST(StartAt AS DATE) = CAST(GETDATE() AS DATE)
            AND ShowtimeStatus <> N'Cancelled'
    ) AS TodayShowtimes,

    (
        SELECT COUNT(DISTINCT Ticket.TicketId)
        FROM dbo.Tickets AS Ticket
        WHERE CAST(Ticket.SoldAt AS DATE) = CAST(GETDATE() AS DATE)
            AND Ticket.TicketStatus <> N'Cancelled'
    ) AS TodaySoldTickets,

    (
        SELECT COALESCE(SUM(Payment.Amount), 0)
        FROM dbo.Payments AS Payment
        INNER JOIN dbo.Tickets AS Ticket
            ON Ticket.TicketId = Payment.TicketId
        WHERE CAST(COALESCE(Payment.PaidAt, Ticket.SoldAt) AS DATE) = CAST(GETDATE() AS DATE)
            AND Payment.Status = N'Success'
            AND Ticket.TicketStatus <> N'Cancelled'
    ) AS TodayRevenue;
GO

/* ============================================================
   07. VERIFICATION QUERIES
   ============================================================

   Cac cau SELECT nay giup kiem tra nhanh sau khi chay script.
   Neu cac SELECT ben duoi co du lieu thi database da duoc seed thanh cong.
*/

PRINT N'CinemaProDB was recreated successfully.';
GO

SELECT
    UserCode,
    FullName,
    Username,
    Role,
    UserStatus
FROM dbo.Users
ORDER BY UserId;
GO

SELECT
    *
FROM dbo.v_TodayShowtimes
ORDER BY StartAt;
GO

SELECT
    *
FROM dbo.v_SoldTickets
ORDER BY SoldAt DESC;
GO

SELECT
    *
FROM dbo.v_RevenueReport
ORDER BY
    RevenueDate DESC,
    MovieTitle;
GO

SELECT
    *
FROM dbo.v_DashboardSummary;
GO

/* ============================================================
   08. INTENTIONAL ERROR TESTS
   ============================================================

   Cac test ben duoi co muc dich tao loi de chung minh trigger/index hoat dong.

   Moi test duoc boc trong:
   - BEGIN TRY / END TRY
   - BEGIN CATCH / END CATCH
   - BEGIN TRANSACTION / ROLLBACK TRANSACTION

   Nghia la:
   - Neu loi xay ra dung nhu mong doi, script se in thong bao Expected...
   - Neu khong loi, script se in ERROR...
   - Du co loi hay khong, transaction van rollback de khong lam ban du lieu demo.
*/

/* ------------------------------------------------------------
   08.01 Test trigger chan trung lich chieu

   SC004 dang chieu o Phong 2 tu 19:30 den 22:32.
   Test nay thu them suat 20:00 den 21:00 cung Phong 2.
   Ket qua mong doi: trigger trg_Showtimes_PreventRoomConflict phai chan.
------------------------------------------------------------ */

BEGIN TRY
    BEGIN TRANSACTION;

    DECLARE @ConflictMovieId INT;
    DECLARE @ConflictRoomId INT;
    DECLARE @ConflictDate DATE;

    SELECT @ConflictMovieId = MovieId
    FROM dbo.Movies
    WHERE MovieCode = N'MV001';

    SELECT @ConflictRoomId = RoomId
    FROM dbo.Rooms
    WHERE RoomCode = N'R002';

    SET @ConflictDate = CAST(GETDATE() AS DATE);

    INSERT INTO dbo.Showtimes
    (
        ShowtimeCode,
        MovieId,
        RoomId,
        StartAt,
        EndAt,
        BasePrice,
        ShowtimeFormat,
        ShowtimeStatus
    )
    VALUES
    (
        N'SC_TEST_CONFLICT',
        @ConflictMovieId,
        @ConflictRoomId,
        DATEADD(MINUTE, 20 * 60, CAST(@ConflictDate AS DATETIME2(0))),
        DATEADD(MINUTE, 21 * 60, CAST(@ConflictDate AS DATETIME2(0))),
        90000,
        N'3D',
        N'Open'
    );

    PRINT N'ERROR: Room conflict test did not fail as expected.';

    ROLLBACK TRANSACTION;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
    END;

    PRINT N'Expected room conflict error: ' + ERROR_MESSAGE();
END CATCH;
GO

/* ------------------------------------------------------------
   08.02 Test trigger chan ban ghe bao tri

   C2 da duoc dat SeatStatus = Maintenance.
   Test nay thu ban ghe C2 cua Phong 2 cho SC004.
   Ket qua mong doi: trigger trg_TicketDetails_ValidateSeat phai chan.
------------------------------------------------------------ */

BEGIN TRY
    BEGIN TRANSACTION;

    DECLARE @MaintenanceTicketId INT;
    DECLARE @MaintenanceShowtimeId INT;
    DECLARE @MaintenanceSeatId INT;
    DECLARE @MaintenanceStaffId INT;

    SELECT @MaintenanceShowtimeId = ShowtimeId
    FROM dbo.Showtimes
    WHERE ShowtimeCode = N'SC004';

    SELECT @MaintenanceStaffId = UserId
    FROM dbo.Users
    WHERE UserCode = N'U002';

    SELECT @MaintenanceSeatId = Seat.SeatId
    FROM dbo.Seats AS Seat
    INNER JOIN dbo.Rooms AS Room
        ON Room.RoomId = Seat.RoomId
    WHERE Room.RoomCode = N'R002'
        AND Seat.SeatCode = N'C2';

    INSERT INTO dbo.Tickets
    (
        TicketCode,
        ShowtimeId,
        SoldByUserId,
        CustomerName,
        TotalAmount,
        TicketStatus,
        PaymentStatus
    )
    VALUES
    (
        N'TK_TEST_MAINT',
        @MaintenanceShowtimeId,
        @MaintenanceStaffId,
        N'Khách lẻ',
        90000,
        N'Unused',
        N'Unpaid'
    );

    SELECT @MaintenanceTicketId = TicketId
    FROM dbo.Tickets
    WHERE TicketCode = N'TK_TEST_MAINT';

    INSERT INTO dbo.TicketDetails
    (
        TicketId,
        ShowtimeId,
        SeatId,
        UnitPrice,
        TicketDetailStatus
    )
    VALUES
    (
        @MaintenanceTicketId,
        @MaintenanceShowtimeId,
        @MaintenanceSeatId,
        90000,
        N'Active'
    );

    PRINT N'ERROR: Maintenance seat test did not fail as expected.';

    ROLLBACK TRANSACTION;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
    END;

    PRINT N'Expected maintenance seat error: ' + ERROR_MESSAGE();
END CATCH;
GO

/* ------------------------------------------------------------
   08.03 Test unique filtered index chan ban trung ghe

   B6 cua Phong 2 da duoc ban trong TK000001 cho SC004.
   Test nay thu ban lai B6 cho cung SC004 voi TicketDetailStatus = Active.
   Ket qua mong doi: unique index UX_TicketDetails_Showtime_Seat_Active phai chan.
------------------------------------------------------------ */

BEGIN TRY
    BEGIN TRANSACTION;

    DECLARE @DuplicateTicketId INT;
    DECLARE @DuplicateShowtimeId INT;
    DECLARE @DuplicateSeatId INT;
    DECLARE @DuplicateStaffId INT;

    SELECT @DuplicateShowtimeId = ShowtimeId
    FROM dbo.Showtimes
    WHERE ShowtimeCode = N'SC004';

    SELECT @DuplicateStaffId = UserId
    FROM dbo.Users
    WHERE UserCode = N'U002';

    SELECT @DuplicateSeatId = Seat.SeatId
    FROM dbo.Seats AS Seat
    INNER JOIN dbo.Rooms AS Room
        ON Room.RoomId = Seat.RoomId
    WHERE Room.RoomCode = N'R002'
        AND Seat.SeatCode = N'B6';

    INSERT INTO dbo.Tickets
    (
        TicketCode,
        ShowtimeId,
        SoldByUserId,
        CustomerName,
        TotalAmount,
        TicketStatus,
        PaymentStatus
    )
    VALUES
    (
        N'TK_TEST_DUP',
        @DuplicateShowtimeId,
        @DuplicateStaffId,
        N'Khách lẻ',
        90000,
        N'Unused',
        N'Unpaid'
    );

    SELECT @DuplicateTicketId = TicketId
    FROM dbo.Tickets
    WHERE TicketCode = N'TK_TEST_DUP';

    INSERT INTO dbo.TicketDetails
    (
        TicketId,
        ShowtimeId,
        SeatId,
        UnitPrice,
        TicketDetailStatus
    )
    VALUES
    (
        @DuplicateTicketId,
        @DuplicateShowtimeId,
        @DuplicateSeatId,
        90000,
        N'Active'
    );

    PRINT N'ERROR: Duplicate active seat test did not fail as expected.';

    ROLLBACK TRANSACTION;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
    END;

    PRINT N'Expected duplicate active seat error: ' + ERROR_MESSAGE();
END CATCH;
GO

PRINT N'CinemaProDB demo script finished.';
GO
