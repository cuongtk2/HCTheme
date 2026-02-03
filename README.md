# HCTheme - Professional WPF UI Library for AutoCAD .NET API

**HCTheme** là bộ thư viện giao diện (UI Library) được thiết kế đặc chủng cho các nhà phát triển Plugin AutoCAD sử dụng công nghệ WPF (Windows Presentation Foundation). Thư viện cung cấp các Custom Controls và Styles hiện đại, giúp thay thế vẻ ngoài thô cứng mặc định của Windows bằng một giao diện chuyên nghiệp và mượt mà.
---
## 🚀 Tính năng nổi bật (Key Features)

* **HcWindow**: Cửa sổ kế thừa chuẩn, tối ưu hóa việc quản lý Focus và Owner trong môi trường AutoCAD.
* **HcGrid**: Custom DataGrid với hiệu suất cao, phù hợp hiển thị bảng dữ liệu lớn (Layer, Object Data, tọa độ...).
* **HcSwitch**: Control bật/tắt hiện đại, thay thế CheckBox truyền thống.
* **Rich Converters**: Bộ sưu tập hơn 20 Converters chuyên dụng giúp việc Data Binding trở nên cực kỳ đơn giản.
* **Modern Styles**: Hệ thống ResourceDictionary (Blue theme) dễ dàng tích hợp và tùy biến.
---
## 🛠 Cấu trúc thư mục (Project Structure)

* `/Controls`: Chứa các mã nguồn của Custom Controls (`HcGrid`, `HcWindow`, `HcSwitch`).
* `/Converters`: Các bộ chuyển đổi dữ liệu phục vụ MVVM.
* `/Styles`: File XAML chứa ResourceDictionary và Style cho từng loại Control.
* `/Icons`: Tài nguyên hình ảnh, vector cho giao diện.
---
## 📦 Hướng dẫn cài đặt (Installation)
1. **Clone repository**:
   ```bash
   git clone [https://github.com/cuongtk2/HCTheme.git](https://github.com/cuongtk2/HCTheme.git)
