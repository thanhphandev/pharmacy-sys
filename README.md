# 💊 Pharmacy Management System | Hệ thống Quản lý Nhà thuốc

**Pharmacy Management System** is a comprehensive desktop application tailored for pharmacies, aiming to streamline operations and enhance business efficiency. The system integrates key modules such as medicine inventory, warehouse tracking, sales management, and user access control.  
**Hệ thống Quản lý Nhà thuốc** là một ứng dụng desktop toàn diện dành cho hiệu thuốc, với mục tiêu tự động hóa quy trình vận hành và nâng cao hiệu quả kinh doanh. Hệ thống tích hợp các phân hệ chính như quản lý thuốc, theo dõi kho, quản lý bán hàng và phân quyền người dùng.

---

## 🛠 Technologies Used | Công nghệ Sử dụng

- **WinForms (C#)** – for building a rich and responsive desktop UI  
- **SQL Server** – robust relational database for structured data storage  
- **Entity Framework (ORM)** – for efficient data access and abstraction

> ✅ The use of **WinForms** ensures rapid development with native Windows performance, while **SQL Server** provides a reliable backend for data consistency and integrity.  
> ✅ Việc sử dụng **WinForms** giúp phát triển nhanh chóng với hiệu suất mạnh mẽ trên Windows, kết hợp với **SQL Server** để đảm bảo tính toàn vẹn và nhất quán dữ liệu.

---

## 🧱 Project Architecture | Kiến trúc Dự án

The application follows the **MVP Pattern (Model - View - Presenter)**, a proven architectural pattern ideal for Windows Forms. This structure ensures separation of concerns, testability, and maintainability.  
Ứng dụng áp dụng mô hình kiến trúc **MVP (Model - View - Presenter)**, phù hợp với WinForms để đảm bảo tính rõ ràng trong thiết kế, dễ kiểm thử và bảo trì.

### 🔹 Model
- Business logic and data processing  
- Xử lý nghiệp vụ và quản lý dữ liệu

### 🔹 View
- UI layer that interacts with end-users  
- Giao diện người dùng và tương tác người dùng

### 🔹 Presenter
- Mediator between View and Model, handles input logic  
- Trung gian giữa View và Model, xử lý logic tương tác

#### 🧩 Model Sub-layers | Phân lớp Model
- **Services**: Implements business rules and workflows  
- **Repositories**: Abstracts direct database operations via Entity Framework

![MVP Pattern](https://i.ibb.co/G0ZFkcB/mvp-pattern.png)

---

## ⚙️ Core Features | Tính năng Chính

### 1. 🔐 Authentication & Authorization | Xác thực & Phân quyền
- **User login & registration** | Đăng nhập và đăng ký người dùng
- **Role-based access control (RBAC)** | Phân quyền theo vai trò
- **Forgot password** (in development) | Quên mật khẩu (đang phát triển)
- **Secure logout mechanism** | Cơ chế đăng xuất an toàn

### 2. 💊 Medicine Management | Quản lý Thuốc
- Add new medicines with image upload  
- Thêm thuốc mới kèm ảnh đại diện  
- Edit or remove medicine records  
- Cập nhật và xóa thuốc  
- Categorize by type, manufacturer, price  
- Phân loại theo loại, nhà sản xuất, giá

### 3. 🛒 Sales Module | Quản lý Bán hàng
- Select and sell medicines  
- Chọn sản phẩm và xử lý bán thuốc  
- Auto calculation of total and invoice generation  
- Tự động tính tiền và in hóa đơn  
- Real-time inventory update  
- Cập nhật kho theo thời gian thực  
- Revenue and sales statistics  
- Thống kê doanh thu và lịch sử bán hàng

### 4. 🏪 Inventory & Stock Control | Quản lý Kho hàng
- Manage purchase invoices  
- Nhập hóa đơn nhập thuốc  
- Monitor expiration dates and stock quantity  
- Theo dõi thuốc hết hạn, tồn kho  
- Search and filter by criteria  
- Tìm kiếm theo mã, tên, loại thuốc

---

## 🚧 Features in Development | Các chức năng đang phát triển

- Password reset functionality | Khôi phục mật khẩu
- Detailed financial reports | Báo cáo tài chính chi tiết
- Enhanced auditing and logs | Ghi log hệ thống và lịch sử thay đổi
- UI/UX improvements | Cải thiện trải nghiệm người dùng

---

## 📌 Highlights | Điểm nổi bật

- Clean MVP structure for maintainability  
- Kiến trúc MVP giúp dễ mở rộng và bảo trì
- Integrated with SQL Server for high-volume data  
- Tích hợp SQL Server cho khả năng xử lý dữ liệu lớn
- Native desktop experience via WinForms  
- Trải nghiệm người dùng mượt mà trên môi trường Windows

---

## 📞 Contact | Liên hệ

For any inquiries, contributions, or bug reports, feel free to reach out to the development team.  
Mọi thắc mắc, đóng góp hoặc báo lỗi, vui lòng liên hệ với nhóm phát triển.

---
