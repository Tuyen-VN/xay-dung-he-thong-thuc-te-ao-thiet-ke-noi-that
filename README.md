\# Xây dựng hệ thống thực tế ảo thiết kế nội thất



Hệ thống cho phép người dùng mô tả căn phòng mong muốn bằng ngôn ngữ tự nhiên, sau đó tự dựng không gian 3D có nội thất phù hợp để quan sát và chỉnh sửa trực tiếp trong thực tế ảo (VR). Chạy trên máy tính Windows và kính Meta Quest, build từ cùng một project Unity.



> Trạng thái: đang trong giai đoạn khởi tạo (dựng khung dự án).



\## Tính năng chính



\- Hiểu yêu cầu người dùng (gõ hoặc nói) và chuyển thành dữ liệu JSON có cấu trúc.

\- Hai chế độ làm việc:

&#x20; - \*\*Tự dựng:\*\* chỉ có sàn và tường, người dùng tự thiết kế.

&#x20; - \*\*Map có sẵn:\*\* hệ thống tìm nội thất phù hợp và đặt vào các vị trí (slot) cố định, người dùng chỉnh sửa sau.

\- Kho model nội thất có gắn nhãn (loại, chất liệu, màu, phong cách).

\- Kiểm tra ràng buộc bố cục (không chồng lấn, vừa vị trí, không chắn lối đi...).

\- Lưu và nạp lại thiết kế dưới dạng JSON.



\## Công nghệ



\- Unity 6000.2.2f1

\- XR Interaction Toolkit, OpenXR

\- Newtonsoft Json

\- Máy chủ trung gian Node.js/Express để gọi AI (dự kiến)



\## Cấu trúc thư mục (dự kiến)



```

Assets/\_Project/

&#x20; Scripts/   Core, Services, World, Interaction, Platform, UI, App

&#x20; Data/      Catalog, Maps, Schemas, Prompts, SampleWorlds

&#x20; Prefabs/   Furniture, Rooms, UI

&#x20; Scenes/    Boot, Main

&#x20; Tests/     EditMode, PlayMode

Server/      máy chủ trung gian (giữ khóa API)

Docs/        tài liệu thiết kế

```



\## Chạy dự án



1\. Cài \*\*Git\*\* và \*\*Git LFS\*\*, chạy `git lfs install` trước khi clone.

2\. Clone repo: `git clone <link-repo>`.

3\. Mở bằng Unity Hub, dùng đúng phiên bản \*\*Unity 6000.2.2f1\*\*.

4\. Mở scene `Main` rồi nhấn Play (chế độ máy tính), hoặc build ra `.exe` (Windows) / `.apk` (Meta Quest).



\## Ghi chú



\- Model, ảnh và âm thanh nặng được lưu bằng Git LFS.

\- File build (`.exe`, `.apk`) không commit vào repo.

