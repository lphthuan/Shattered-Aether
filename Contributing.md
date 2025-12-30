# Hướng dẫn Đóng góp (Contributor Guidelines)

Tài liệu này tóm tắt các điểm quan trọng nhất dành cho những người quan tâm đến việc đóng góp vào dự án, đặc biệt là thông qua báo cáo lỗi (Bug Reports) hoặc gửi yêu cầu (Pull Requests).

## Mục lục
- [Tạo vấn đề](#Tạo-vấn-đề)
- [Quy trình gửi Pull Request](#Quy-trình-gửi-Pull-Request)
- [Quy tắc viết Commit Message](#Quy-tắc-viết-Commit-Message)
- [Lưu ý](#lưu-ý)

## Tạo vấn đề

**Báo cáo lỗi**

Vui lòng báo cáo lỗi thông qua Issue Tracker. Hãy tuân theo hướng dẫn trong mẫu (template) khi tạo báo cáo.

**Đề xuất tính năng**

Issue Tracker chủ yếu dành cho việc báo cáo lỗi. Nếu bạn muốn đề xuất một tính năng mới hoặc cải tiến lớn:
1.  Mở một Issue dạng "Feature Request" hoặc thảo luận với chúng tôi trước.
2.  Đảm bảo tính năng này giải quyết một trường hợp sử dụng phổ biến cần thiết cho dự án.

## Quy trình gửi Pull Request

Nếu bạn muốn thêm tính năng mới hoặc sửa lỗi, hãy đảm bảo rằng:
- Bạn đã thảo luận về giải pháp cài đặt với các thành viên khác, đặc biệt là đối với các tính năng phức tạp.
- Pull Request (PR) chỉ giải quyết **một chủ đề cụ thể**. Tốt hơn là nên mở 3 PR khác nhau cho 3 vấn đề khác nhau thay vì gộp chung vào một PR lớn.

**Quy trình làm việc (Workflow)**
- Khi cập nhật nhánh của bạn với các thay đổi từ `main`, vui lòng sử dụng `git pull --rebase` để tránh tạo ra các "merge commit" không cần thiết.
- Cố gắng gộp (squash) các sửa lỗi nhỏ thành một commit ổn định trước khi tạo PR (ví dụ: gộp các commit sửa lỗi chính tả hoặc lỗi build vào cùng một PR).

## Quy tắc viết Commit Message

Việc định dạng thông điệp commit (commit message) đúng chuẩn là rất quan trọng để lịch sử dự án và nhật ký thay đổi (changelog) dễ đọc, dễ hiểu.

**Định dạng**
Một commit message bao gồm tiêu đề ngắn (dòng đầu tiên) và mô tả chi tiết (tùy chọn).
- **Tiêu đề:** Giữ dưới 72 ký tự. Sử dụng thì mệnh lệnh (ví dụ: dùng "Fix", "Add", KHÔNG dùng "Fixed" hoặc "Added").
- **Mô tả:** Ngắt dòng ở ký tự thứ 80. Giải thích *cái gì* đã thay đổi và *tại sao*.

**Tiền tố (Prefix)**
Sử dụng tiền tố để chỉ định khu vực bị ảnh hưởng:
- `Feat`: Thêm tính năng mới
- `Fix`: Sửa lỗi
- `Refactor`: Thay đổi code (tối ưu hóa) nhưng không sửa lỗi hay thêm tính năng
- `Chore`: Các tác vụ bảo trì, việc vặt (VD: đổi tên file, setup, xóa rác, update setting)

**Ví dụ mẫu**
```text
Feat: Add hearing sensor to Enemy AI

Implement a noise detection system using the NoiseManager event.
This allows the enemy to investigate sounds within a defined radius.
```

## Lưu ý

* **File Conflict**

  * File `.unity` (Scene) là file nhị phân phức tạp, rất khó merge nếu 2 người sửa cùng lúc.
  
**Giải pháp:**
  * Thông báo cho team trước khi bạn định sửa một Scene nào đó.
  * Ưu tiên làm việc trên **Prefabs**. Biến mọi thứ thành Prefab và sửa Prefab đó, hạn chế sửa trực tiếp trên Scene.

* **File nặng (Assets)**
   * Dự án sử dụng **Git LFS** cho các file lớn (Model, Texture, Audio).
   * Không commit toàn bộ asset, hãy ignore và chỉ kéo những file cần sử dụng.
   * Hạn chế commit các file nháp, file PSD/Blend nặng nếu không cần thiết.
