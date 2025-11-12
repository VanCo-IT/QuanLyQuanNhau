--không cần tạo, gọi database vì chỉ 1 database duy nhất
PRAGMA foreign_keys = ON;

--------------------------------------------------
-- BANG NHANVIEN
--------------------------------------------------
CREATE TABLE NhanVien (
  MaNV TEXT PRIMARY KEY,
  TenNV TEXT NOT NULL,
  SDT TEXT,
  TenDN TEXT NOT NULL UNIQUE,
  Email TEXT NOT NULL UNIQUE,
  MatKhau TEXT NOT NULL,
  VaiTro INTEGER NOT NULL,     -- 1: Quan ly, 0: Nhan vien
  TrangThai INTEGER NOT NULL DEFAULT 1
);

INSERT INTO NhanVien VALUES
('NV01', 'Nguyen Van A', '0901111222', 'admin', 'a', '1', 1, 1), 
('NV02', 'Tran Thi B', '0902222333', 'btran', 'b@quan.vn', '123456', 0, 1),
('NV03', 'Le Van C', '0903333444', 'cle', 'c@quan.vn', '123456', 0, 1),
('NV04', 'Pham Thi D', '0904444555', 'dpham', 'd@quan.vn', '123456', 0, 0),
('NV05', 'Vo Van E', '0905555666', 'evo', 'e@quan.vn', '123456', 1, 1);

--------------------------------------------------
-- BANG BAN
--------------------------------------------------
CREATE TABLE Ban (
  MaBan TEXT PRIMARY KEY,
  TenBan TEXT NOT NULL,
  SoGhe INTEGER NOT NULL,
  TrangThai TEXT NOT NULL DEFAULT 'trong' -- trong, co_khach, dat_truoc
);

INSERT INTO Ban VALUES
('B01', 'Ban 1', 4, 'trong'),
('B02', 'Ban 2', 6, 'co_khach'),
('B03', 'Ban 3', 4, 'trong'),
('B04', 'Ban 4', 8, 'dat_truoc'),
('B05', 'Ban 5', 10, 'trong');

--------------------------------------------------
-- BANG NHACUNGCAP
--------------------------------------------------
CREATE TABLE NhaCungCap (
  --MaCungCap
  MaCungCap TEXT PRIMARY KEY,
  TenNCC TEXT NOT NULL,
  SDT TEXT,
  Email TEXT,
  DiaChi TEXT
);

INSERT INTO NhaCungCap VALUES
('MCC01', 'Cong ty Bia ABC', '02899990000', 'bia@abc.vn', '12 Nguyen Trai'),
('MCC02', 'Cho Hai San Q1', '0281234567', NULL, '45 Hai Ba Trung'),
('MCC03', 'CTY Rau Sach Xanh', '0282222333', 'rau@sach.vn', '99 Vo Van Tan'),
('MCC04', 'Nha Phan Phoi Pepsi', '0284444555', 'pepsi@vn.vn', '88 Le Loi'),
('MCC05', 'Cong ty Da Lat Food', '0285555666', 'dalat@food.vn', '15 Nguyen Dinh Chieu');

--------------------------------------------------
-- BANG KHO
--------------------------------------------------
CREATE TABLE Kho (
  MaKho TEXT PRIMARY KEY,
  TenSanPham TEXT NOT NULL,
  SoLuong REAL NOT NULL DEFAULT 0,
  DonVi TEXT NOT NULL,
  GiaNhap REAL NOT NULL DEFAULT 0,
  ThoiGianNhap TEXT DEFAULT (DATETIME('NOW')),
  MaCungCap TEXT NOT NULL,
  FOREIGN KEY(MaCungCap) REFERENCES NhaCungCap(MaCungCap)
);

INSERT INTO Kho VALUES
('MK01', 'Bia 500ml (thung)', 10,'thung',  600000, '2025-01-01' ,'MCC01'),
('MK02', 'Tom tuoi (kg)', 20, 'kg', 120000,'2025-01-02' , 'MCC02'),
('MK03', 'Rau salad (kg)', 15, 'kg', 40000,'2025-01-03' , 'MCC03'),
('MK04', 'Nuoc ngot 330ml (thung)', 8, 'thung', 300000, '2025-01-04' ,'MCC04'),
('MK05', 'Ca basa (kg)',  12,'kg', 90000,'2025-01-05' , 'MCC05');

--------------------------------------------------
-- BANG MON
--------------------------------------------------
CREATE TABLE Mon (
  MaMon TEXT PRIMARY KEY,
  TenMon TEXT NOT NULL,
  Gia REAL NOT NULL,
  ConBan INTEGER NOT NULL DEFAULT 1
);

INSERT INTO Mon VALUES
('M01', 'Tom chien gion', 120000, 1),
('M02', 'Ga nuong muoi ot', 150000, 1),
('M03', 'Bia hoi 500ml', 30000, 1),
('M04', 'Nuoc ngot 330ml', 15000, 1),
('M05', 'Khoai tay chien', 50000, 1);
--------------------------------------------------
-- BANG KHACHHANG (CAP NHAT)
--------------------------------------------------
CREATE TABLE KhachHang (
  MaKH TEXT PRIMARY KEY,
  TenKH TEXT NOT NULL,
  SDT TEXT,
  Email TEXT,
  DiaChi TEXT,
  LoaiKH TEXT NOT NULL, -- Khách quen, Khách VIP, Khách tiềm năng, Khách khó tính, Sổ đen, Khác
  MoTa TEXT              -- Ghi chú/mô tả thêm về khách hàng
);

INSERT INTO KhachHang VALUES
('KH01', 'Nguyen Minh', '0909000111', 'minh@gmail.com', '1 Nguyen Trai', 'Khách quen', 'Thường đi 2 người, thích bàn gần cửa sổ'),
('KH02', 'Tran Hoa', '0908000222', 'hoa@gmail.com', '2 Le Loi', 'Khách VIP', 'Đặt bàn cố định cuối tuần, thanh toán qua Momo'),
('KH03', 'Le Tuan', '0907000333', 'tuan@gmail.com', '3 Vo Van Tan', 'Khách tiềm năng', 'Mới đến 2 lần, hay hỏi món mới'),
('KH04', 'Pham Thi Lan', '0906000444', 'lan@gmail.com', '4 Nguyen Van Cu', 'Khách khó tính', 'Hay đổi món và phàn nàn về tốc độ phục vụ'),
('KH05', 'Do Van Hung', '0905000555', 'hung@gmail.com', '5 Tran Hung Dao', 'Sổ đen', 'Từng hủy đơn, nợ thanh toán 1 lần');

--------------------------------------------------
-- BANG THANHTOAN (CAP NHAT)
--------------------------------------------------
CREATE TABLE ThanhToan (
  MaTT TEXT PRIMARY KEY,
  MaKH TEXT NOT NULL,
  NgayGiaoDich TEXT NOT NULL DEFAULT (datetime('now')),
  SoTien REAL NOT NULL,
  HinhThuc TEXT NOT NULL, -- tien_mat, the, momo
  MoTa TEXT,
  TrangThai TEXT NOT NULL DEFAULT 'hoan_tat', -- hoan_tat, cho_xu_ly, huy
  FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
);

INSERT INTO ThanhToan VALUES
('TT01', 'KH01', datetime('now','-1 day'), 500000, 'tien_mat', 'Thanh toan bua toi', 'hoan_tat'),
('TT02', 'KH02', datetime('now','-2 day'), 300000, 'momo', 'Dat truoc tiec sinh nhat', 'hoan_tat'),
('TT03', 'KH03', datetime('now','-3 day'), 150000, 'the', 'Thanh toan mon le', 'cho_xu_ly');

--------------------------------------------------
-- BANG LICHSUDANGNHAP
--------------------------------------------------
CREATE TABLE LichSuDangNhap (
  ID INTEGER PRIMARY KEY AUTOINCREMENT,
  MaNV TEXT NOT NULL,
  ThoiGianDangNhap TEXT NOT NULL DEFAULT (datetime('now')),
  DiaChiIP TEXT,
  ThanhCong INTEGER NOT NULL DEFAULT 1,
  FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

INSERT INTO LichSuDangNhap(MaNV, ThoiGianDangNhap, DiaChiIP, ThanhCong) VALUES
('NV01', datetime('now','-1 day'), '192.168.1.10', 1),
('NV02', datetime('now','-2 day'), '192.168.1.11', 1),
('NV03', datetime('now','-3 day'), '192.168.1.12', 0),
('NV04', datetime('now','-1 hour'), '192.168.1.13', 1),
('NV05', datetime('now','-4 day'), '192.168.1.14', 1);
