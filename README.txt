BÁO CÁO KẾT QUẢ THỰC HÀNH LAB 1 - LẬP TRÌNH CONSOLE (.NET)
Học phần: Lập trình .NET (IT3212)
Trường Đại học Công nghệ Đông Á - Khoa CNTT


THÔNG TIN SINH VIÊN:
- Họ và tên: Nguyễn Tiến Hùng
- Mã sinh viên: 24000091
- Lớp: Lập trình .NET-1-1-26(N03)
- Solution: IT3212_Labs
- Project: Lab01_Console

1. DANH SÁCH BÀI TẬP ĐÃ HOÀN THÀNH

[x] Bài 1: Nhập thông tin cá nhân và tính tuổi
[x] Bài 2: Tính diện tích xung quanh & thể tích hình trụ
[x] Bài 3: Xếp loại kết quả học tập
[x] Bài 4: Menu xử lý tính tổng 1..n & Bảng cửu chương (switch-case)
[x] Bài 5: Xử lý ngoại lệ phép chia (try-catch)
[x] Bài 6: Giải phương trình bậc hai
[x] Bài 7: Thống kê dãy số (Tong, TB, Max, Min, SoLuongChan)
[x] Bài 8: Kiểm tra và in danh sách số nguyên tố <= n
[x] Bài 9: Đọc số nguyên từ 0 đến 99 bằng tiếng Việt
[x] Bài 10: Vẽ hình bằng ký tự * (Tam giác đặc, Tam giác rỗng, Hình vuông rỗng)

Tình trạng: Hoàn thành 100% yêu cầu Bài 1 -> Bài 10.

------------------------------------------------------------------------
2. HƯỚNG DẪN CÁCH CHẠY CHƯƠNG TRÌNH
------------------------------------------------------------------------
Yêu cầu môi trường:
- Visual Studio 2026 (đã cài workload .NET desktop development).
- .NET Framework 4.8 hoặc .NET 8.0/9.0.

Các bước thực hiện:
1. Mở file solution "IT3212_Labs.slnx" (hoặc "IT3212_Labs.sln") bằng Visual Studio 2026.
2. Đảm bảo project "Lab01_Console" được chọn làm Startup Project.
3. Nhấn Ctrl + F5 (hoặc ấn Start) để biên dịch và chạy chương trình.

------------------------------------------------------------------------
3. DỮ LIỆU THỬ VÀ KẾT QUẢ MẪU (TEST DATA)
------------------------------------------------------------------------
* Bài 1:
  - Input: Họ và tên = "Nguyễn Tiến Hùng", Nhập năm sinh = 2006
  - Output: Tên của bạn là: "Nguyễn Tiến Hùng", Tuổi của bạn là: 20

* Bài 2:
  - Input: Nhập bán kính r = 3.5, Nhập chiều cao h = 10
  - Output: Diện tích xung quanh là: 219.91, Thể tích là: 384.85

* Bài 3:
  - Input: Nhập điểm 1-10: 8.5 -> Output: Giỏi
  - Input: diem = -1  -> Output: Điểm không hợp lệ.

* Bài 4:
  - Input: Chon = 1, n = 5 -> Output: Tổng = 15
  - Input: Chon = 2, n = 4 -> Output: In bảng cửu chương 4

* Bài 5:
  - Input: a = 10, b = 0 -> Output: Khống thể chia cho 0. (DivideByZeroException)
  - Input: a = "abc"     -> Output: Dữ liệu phải là số nguyên. (FormatException)

 * Bài 6:
  - Input: a = 1, b = -3, c = 2 -> Output: x1 = 2.00, x2 = 1.00
  - Input: a = 1, b = 2, c = 5  -> Output: Phương trình vô nghiệm

* Bài 7:
  - Input: n = 5, dãy số = [4, 7, 2, 9, 10]
  - Output: Tong = 32, TB = 6.40, Max = 10, Min = 2, SoLuongChan = 3

* Bài 8:
  - Input: n = 20
  - Output: Các số nguyên tố <= 20: 2, 3, 5, 7, 11, 13, 17, 19

* Bài 9:
  - Input: n = 45 -> Output: Bốn mươi lăm
  - Input: n = 5  -> Output: Năm

* Bài 10:
  - Input: Chon = 3, h = 4
  - Output: In ra khung hình vuông rỗng kích thước 4x4 bằng dấu '*'.