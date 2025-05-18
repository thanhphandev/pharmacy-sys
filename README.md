# 💊 Pharmacy Management System | Hệ thống Quản lý Nhà thuốc

**Pharmacy Management System** là phần mềm desktop được thiết kế dành riêng cho các nhà thuốc, giúp tối ưu hóa hoạt động vận hành như quản lý kho thuốc, hóa đơn, nhà cung cấp, người dùng, báo cáo doanh thu và nhiều hơn nữa.  
Ứng dụng mang lại trải nghiệm thân thiện, bảo mật và hiệu quả cho người sử dụng, hỗ trợ theo dõi toàn diện các hoạt động của hiệu thuốc.

---

## 🧩 Tính năng Chính

### 1. 🏢 Quản lý Nhà cung cấp
- Thêm, sửa, xóa thông tin nhà cung cấp
- Nhập/xuất dữ liệu nhà cung cấp, hỗ trợ ghi đè dữ liệu
- Tìm kiếm nhà cung cấp theo từ khóa

### 2. 💊 Quản lý Thuốc & Danh mục
- Thêm, sửa, xóa thuốc và đơn vị tính
- Tự động điền thông tin thuốc nếu đã tồn tại trong hệ thống
- Quản lý chi tiết từng **lô thuốc** (số lượng, ngày sản xuất, hạn sử dụng)
- Phân loại theo danh mục, nhóm thuốc
- Tìm kiếm theo tên, mã thuốc, danh mục
- Theo dõi số lượng thuốc trong kho theo thời gian thực

### 3. 🧾 Quản lý Hóa đơn
- Tạo, xem, chỉnh sửa hóa đơn bán thuốc
- Giao diện bán hàng kiểu POS: tìm thuốc, thêm vào giỏ hàng, thay đổi số lượng
- Tự động tính tổng tiền, in hóa đơn
- Lưu trữ lịch sử hóa đơn để tra cứu lại

### 4. 👥 Quản lý Người dùng
- Đăng ký, đăng nhập, đăng xuất người dùng
- Phân quyền theo vai trò (quản trị viên, nhân viên, v.v.)
- Đổi mật khẩu, xác thực 2 bước (2FA) cho các thao tác quan trọng
- Nhật ký hoạt động người dùng (log hệ thống)

### 5. 📦 Quản lý Dữ liệu
- Chức năng **backup** và **khôi phục (restore)** dữ liệu
- Bảo vệ dữ liệu người dùng và giảm thiểu rủi ro mất mát

### 6. 📈 Báo cáo & Thống kê
- Báo cáo doanh thu theo ngày / tháng / năm
- Thống kê chi tiết tồn kho, thuốc sắp hết hạn, đã hết hàng
- Giao diện báo cáo trực quan

### 7. 🖥️ Giao diện POS hiện đại
- Bán thuốc nhanh chóng, thân thiện người dùng
- Hiển thị hình ảnh thuốc, thao tác giỏ hàng trực quan
- Tự động tính tiền và hỗ trợ in hóa đơn ngay lập tức

### 8. 🙋‍♂️ Hỗ trợ người dùng
- Tích hợp trung tâm hỗ trợ / trợ giúp ngay trong phần mềm
- Cung cấp thông tin liên hệ để bảo trì, cập nhật phần mềm

### 9. 🔒 Bảo mật & An toàn Dữ liệu
- Mã hóa mật khẩu người dùng
- Sử dụng Entity Framework để ngăn chặn lỗi SQL Injection
- Kiểm soát truy cập theo vai trò, xác thực 2FA
- Kiểm tra và ghi log truy cập hệ thống

### 10. ℹ️ Thông tin phần mềm
- Hiển thị phiên bản phần mềm, ngày cập nhật
- Thông tin hệ thống: tình trạng hoạt động, ngày giờ hệ thống

---

## 🛠 Công nghệ Sử dụng

| Thành phần              | Mô tả                                                                 |
|------------------------|-----------------------------------------------------------------------|
| **WinForms (C#)**      | Giao diện người dùng thân thiện, dễ phát triển trên nền Windows      |
| **SQL Server**         | Hệ quản trị cơ sở dữ liệu mạnh mẽ, hỗ trợ lưu trữ và bảo mật dữ liệu |
| **Entity Framework**   | ORM giúp truy xuất dữ liệu hiệu quả, dễ bảo trì, hạn chế lỗi SQL      |
| **MVP Architecture**   | Phân tách rõ Model, View, Presenter giúp mã sạch, dễ test, mở rộng    |

---

## 🧱 Kiến trúc Dự án: MVP (Model - View - Presenter)


Dự án được tổ chức theo mô hình **MVP Pattern** (Model-View-Presenter), một kiến trúc phần mềm hiệu quả cho phép tách biệt rõ ràng giữa phần logic và giao diện người dùng. Mô hình này đặc biệt hiệu quả với công nghệ Winform C#. Mô hình MVP giúp dễ dàng phát triển và duy trì mã nguồn mà không bị phụ thuộc vào giao diện cụ thể. Các thành phần chính trong mô hình MVP bao gồm:

1. **Model**: Chịu trách nhiệm quản lý dữ liệu và logic ứng dụng, bao gồm xử lý thông tin và quản lý trạng thái.
2. **View**: Phần giao diện người dùng, nơi hiển thị dữ liệu và nhận tương tác từ người dùng.
3. **Presenter**: Kết nối giữa Model và View, xử lý các yêu cầu từ View và cập nhật Model, đảm bảo logic ứng dụng hoạt động một cách chính xác.

Để nâng cao khả năng bảo trì và mở rộng cho dự án, Model được chia thành hai phần:
1. **Service**: Chứa các phương thức xử lý logic nghiệp vụ và tương tác với cơ sở dữ liệu thông qua các repository.
2. **Repositories**: Cung cấp các phương thức truy xuất dữ liệu từ cơ sở dữ liệu.

![MVP Pattern](https://i.ibb.co/G0ZFkcB/mvp-pattern.png)
---

## 🚀 Lợi ích nổi bật

- ✅ Quản lý nhà thuốc đầy đủ từ A-Z
- ✅ Giao diện bán thuốc POS trực quan, nhanh chóng
- ✅ Báo cáo rõ ràng, hỗ trợ quyết định kinh doanh
- ✅ Bảo mật mạnh, hỗ trợ 2FA
- ✅ Kiến trúc dễ mở rộng và bảo trì

---

## 💡 Kế hoạch Phát triển trong Tương Lai

- [ ] Tích hợp thanh toán điện tử
- [ ] Giao diện tối (Dark Mode)
- [ ] Đồng bộ dữ liệu qua đám mây (cloud sync)
- [ ] Tính năng nhắc lịch nhập thuốc

---

## 📎 Thông tin Dự án

- **Tên phần mềm**: Pharmacy Management System
- **Phiên bản**: 1.0.0
- **Ngày phát hành**: 2025-05
- **Nhà phát triển**: Phan Văn Thành

---

## 📞 Liên hệ Hỗ trợ

Mọi góp ý, báo lỗi hoặc yêu cầu tính năng mới, vui lòng liên hệ:
https://t.me/thanhphandev

---

> ✅ *Phần mềm không chỉ giúp quản lý hiệu quả, mà còn là trợ thủ đắc lực trong việc nâng cao năng suất và sự chuyên nghiệp của nhà thuốc.*


