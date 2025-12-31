# 🌌 Shattered Aether - Bầu Trời Vỡ Vụn

<div align="center">

![Unity Version](https://img.shields.io/badge/Unity-6000.0.61f1-black?style=for-the-badge&logo=unity)
![URP](https://img.shields.io/badge/Render%20Pipeline-URP%2017.0.4-blue?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)
![Version](https://img.shields.io/badge/Version-0.1.0-orange?style=for-the-badge)

**Một tựa game thế giới mở, phiêu lưu hành động với độ khó cao kiểu Souls-like, kết hợp với phong cách nhân vật anime đặc sắc**

*An open-world action-adventure game with Souls-like difficulty, featuring distinctive anime-style characters*

[📥 Tải xuống](https://github.com/lphthuan/Shattered-Aether/releases) • [🐛 Báo lỗi](https://github.com/lphthuan/Shattered-Aether/issues) • [🤝 Đóng góp](CONTRIBUTING.md)

</div>

---

## 📖 Giới thiệu | About

**Shattered Aether** (Bầu Trời Vỡ Vụn) là một tựa game phiêu lưu hành động thế giới mở với cơ chế chiến đấu đầy thử thách. Lấy cảm hứng từ dòng game Souls-like nổi tiếng, game mang đến trải nghiệm chiến đấu căng thẳng, đòi hỏi kỹ năng và sự kiên nhẫn cao. Đồng thời, game thu hút người chơi với phong cách nghệ thuật anime độc đáo và thế giới rộng lớn đầy bí ẩn chờ khám phá.

**Shattered Aether** is an open-world action-adventure game featuring challenging combat mechanics. Inspired by the renowned Souls-like genre, it delivers intense combat experiences that demand skill and patience. The game captivates players with its unique anime art style and a vast, mysterious world waiting to be explored.

---

## ✨ Tính năng chính | Key Features

- 🎮 **Chiến đấu Souls-like** - Cơ chế chiến đấu đầy thử thách với độ khó cao
- 🌍 **Thế giới mở** - Khám phá môi trường rộng lớn, đa dạng
- 👹 **Hệ thống quái vật** - Đối đầu với nhiều loại quái vật đặc sắc
- 🎨 **Phong cách Anime** - Nghệ thuật nhân vật và thế giới theo phong cách anime
- ⚔️ **Hành động mạnh mẽ** - Chiến đấu động, kỹ năng đa dạng
- 🎯 **Thử thách cao** - Dành cho người chơi thích thách thức bản thân

---

## 🛠️ Thông tin kỹ thuật | Technical Specifications

### Engine & Pipeline
- **Unity Version:** 6000.0.61f1 (Unity 6)
- **Render Pipeline:** Universal Render Pipeline (URP) 17.0.4
- **Input System:** New Input System 1.14.2
- **Navigation:** AI Navigation 2.0.9

### Công nghệ sử dụng | Technologies Used
- **Physics:** Unity Physics & Physics2D
- **Animation:** Timeline 1.8.9
- **Cloth Simulation:** MagicaCloth2
- **Shader:** Shader Graph 17.0.4, lilToon
- **Collections:** Unity Collections 2.6.2
- **Mathematics:** Unity Mathematics 1.3.2

---

## 💻 Yêu cầu hệ thống | System Requirements

### 🔹 Cấu hình tối thiểu | Minimum Requirements

| Thành phần | Yêu cầu |
|-----------|---------|
| **HĐH** | Windows 10 64-bit |
| **CPU** | Intel Core i5-7400 / AMD Ryzen 3 3300X |
| **RAM** | 8 GB |
| **GPU** | NVIDIA GTX 1050 Ti / AMD RX 560 (4GB VRAM) |
| **DirectX** | Version 11 |
| **Ổ cứng** | 15 GB available space |

### 🔸 Cấu hình khuyến nghị | Recommended Requirements

| Thành phần | Yêu cầu |
|-----------|---------|
| **HĐH** | Windows 10/11 64-bit |
| **CPU** | Intel Core i7-9700K / AMD Ryzen 5 5600X |
| **RAM** | 16 GB |
| **GPU** | NVIDIA RTX 2060 / AMD RX 5700 XT (6GB+ VRAM) |
| **DirectX** | Version 12 |
| **Ổ cứng** | 20 GB available space (SSD recommended) |

---

## 📥 Cài đặt | Installation

### Phương pháp 1: Tải bản build sẵn | Download Pre-built Release

1. Truy cập trang [**Releases**](https://github.com/lphthuan/Shattered-Aether/releases)
2. Tải xuống phiên bản mới nhất (Latest Release)
3. Giải nén file ZIP vào thư mục bạn muốn
4. Chạy file `Shattered Aether.exe`
5. Tận hưởng trò chơi!

### Phương pháp 2: Build từ source code | Build from Source

**Yêu cầu | Requirements:**
- Unity 6000.0.61f1 hoặc cao hơn
- Git

**Các bước | Steps:**

```bash
# Clone repository
git clone https://github.com/lphthuan/Shattered-Aether.git

# Mở project bằng Unity Hub
# Open project with Unity Hub
# Add project → Chọn thư mục đã clone
```

**Cài đặt trong Unity | Unity Setup:**

1. Mở project trong Unity 6000.0.61f1
2. Đợi Unity import assets (có thể mất vài phút)
3. Đảm bảo Build Settings đã cấu hình đúng:
   - `File → Build Settings`
   - Platform: PC, Mac & Linux Standalone
   - Target Platform: Windows
   - Architecture: x86_64
4. Build game: `File → Build Settings → Build`

**Lưu ý cấu hình | Configuration Notes:**

- **Graphics API:** DirectX 11/12 (Windows)
- **Color Space:** Linear
- **Quality Level:** Thiết lập trong `Edit → Project Settings → Quality`
- **URP Asset:** Nằm trong `Assets/Settings/`

---

## 🎮 Cách chơi | How to Play

*(Sẽ được cập nhật khi game phát triển thêm)*

Thông tin chi tiết về điều khiển và gameplay sẽ được bổ sung trong các phiên bản tiếp theo.

---

## 📁 Cấu trúc dự án | Project Structure

```
Assets/
├── _Game/               # Game content chính
│   ├── Scenes/         # Các scene của game
│   ├── Scripts/        # C# scripts
│   ├── Art/            # Artwork, models, textures
│   └── Shaders/        # Custom shaders
├── _Tool/              # Third-party tools
│   └── MagicaCloth2/   # Cloth simulation
└── Settings/           # Project settings
    └── Input/          # Input system settings
```

---

## 🤝 Đóng góp | Contributing

Chúng tôi hoan nghênh mọi đóng góp! Vui lòng đọc [**CONTRIBUTING.md**](CONTRIBUTING.md) để biết thêm chi tiết về:

- Cách báo cáo lỗi
- Quy trình gửi Pull Request
- Quy tắc viết commit message
- Coding standards

---

## 📄 Giấy phép | License

Dự án này được phát hành dưới giấy phép **MIT License**. Xem file [**LICENSE**](LICENSE) để biết thêm chi tiết.

```
MIT License - Copyright (c) 2025 Le Phan Hoa Thuan
```

---

## 📧 Liên hệ | Contact

- **Developer:** Le Phan Hoa Thuan
- **Repository:** [github.com/lphthuan/Shattered-Aether](https://github.com/lphthuan/Shattered-Aether)
- **Issues:** [Báo cáo lỗi / Report bugs](https://github.com/lphthuan/Shattered-Aether/issues)

---

## 🙏 Cảm ơn | Credits

### Third-party Assets & Tools
- **MagicaCloth2** - Cloth simulation system
- **lilToon** - Toon shader for anime-style rendering
- **Unity Technologies** - Game engine and tools

---

<div align="center">

**⭐ Nếu bạn thích dự án này, hãy cho chúng tôi một star! ⭐**

**⭐ If you like this project, please give us a star! ⭐**

Made with ❤️ using Unity

</div>