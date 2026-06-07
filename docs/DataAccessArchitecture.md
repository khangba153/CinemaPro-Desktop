# CinemaPro Data Access Architecture

Project nay dung song song 2 mo hinh truy cap du lieu:

- ADO.NET
- Entity Framework Core

## Entity Framework Core

EF Core duoc dung cho cac nghiep vu CRUD quan tri, noi code can doc gon va de map object:

- Dang nhap va quan ly nhan vien
- Quan ly phim va the loai phim
- Man hinh cai dat he thong

File chinh:

- `CinemaPro.WinForms.DesignFirst/Data/Ef/CinemaProDbContext.cs`
- `CinemaPro.WinForms.DesignFirst/Data/Ef/Entities/*Entity.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/Ef/EfUserRepository.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/Ef/EfMovieRepository.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/Ef/EfAppSettingRepository.cs`

Huong EF cua project la database-first: database van duoc tao bang script SQL trong thu muc `database`, con EF chi map vao cac bang co san. Project khong dung EF migration de tranh lam lech voi script demo.

## ADO.NET

ADO.NET duoc giu cho cac nghiep vu can SQL ro rang, transaction va rang buoc ban ve:

- Ban ve
- Chi tiet ve va ghe
- Thanh toan
- Kiem ve
- Lich chieu
- Bao cao
- So do ghe

File chinh:

- `CinemaPro.WinForms.DesignFirst/Data/DatabaseHelper.cs`
- `CinemaPro.WinForms.DesignFirst/Data/DbConnectionFactory.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/TicketRepository.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/TicketDetailRepository.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/PaymentRepository.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/SeatRepository.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/SeatLayoutRepository.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/ShowtimeRepository.cs`
- `CinemaPro.WinForms.DesignFirst/Repositories/ReportRepository.cs`

## Ly do tach nhu vay

EF Core phu hop voi CRUD vi code ngan, de doc va the hien quan he bang qua entity. ADO.NET phu hop voi phan ban ve vi can kiem soat SQL, transaction, trigger, index va cac cau query report/view ro rang.
