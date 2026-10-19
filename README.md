Lê Thị Anh Thư - 33254020040
Bài 1. Thống kê và đảo ngược mảng
Mục tiêu: Nhập mảng gồm \(n\) số nguyên, thống kê các giá trị và đảo ngược thứ tự phần tử trong mảng.
Mô tả thuật toán
Bước 1: Nhập dữ liệu
- Nhập số phần tử \(n\).
- Kiểm tra \(n\) nằm trong khoảng từ 1 đến 100000. Nếu không hợp lệ, thông báo lỗi và kết thúc chương trình.
- Khởi tạo mảng số nguyên a có \(n\) phần tử.
- Nhập lần lượt các phần tử của mảng.
Bước 2: Khởi tạo các biến thống kê
- Gán min và max bằng phần tử đầu tiên của mảng.
- Khởi tạo sum = 0 để tính tổng.
- Khởi tạo negative = 0, positive = 0, zero = 0 để đếm số phần tử âm, dương và bằng 0.
Bước 3: Duyệt mảng để thống kê
Duyệt lần lượt từng phần tử từ vị trí 0 đến \(n-1\):
- Cộng giá trị phần tử vào sum.
- Nếu phần tử nhỏ hơn min, cập nhật min.
- Nếu phần tử lớn hơn max, cập nhật max.
- Nếu phần tử âm, tăng negative lên 1.
- Nếu phần tử dương, tăng positive lên 1.
- Nếu phần tử bằng 0, tăng zero lên 1.
Sau khi duyệt xong, tính trung bình cộng bằng sum / n, trong đó ép sum sang kiểu double trước khi chia.
Bước 4: Hiển thị kết quả thống kê
In tổng, giá trị nhỏ nhất, giá trị lớn nhất, trung bình cộng và số lượng phần tử âm, dương, bằng 0.
Bước 5: Đảo ngược mảng
- Khởi tạo left = 0, right = n - 1.
- Khi left < right, hoán đổi hai phần tử a[left] và a[right] thông qua biến tạm temp.
- Tăng left lên 1 và giảm right đi 1.
- Lặp lại đến khi left >= right.
Bước 6: Xuất mảng sau khi đảo ngược.
Độ phức tạp
- Thời gian: \(\Theta(n)\), vì thống kê mảng mất \(\Theta(n)\), đảo mảng mất \(\Theta(n)\); hai công việc thực hiện nối tiếp nên tổng vẫn là \(\Theta(n)\).
- Bộ nhớ phụ: \(O(1)\), không tính mảng đầu vào vì đảo trực tiếp trên mảng ban đầu.

Bài 2. Chèn và xóa phần tử trong mảng
Mục tiêu: Thực hiện chèn và xóa phần tử tại vị trí xác định trong mảng có kích thước cố định.
Mô tả thuật toán
Bước 1: Khởi tạo dữ liệu
- Tạo mảng data có 8 ô nhớ.
- Gán 5 phần tử ban đầu là 4, 7, 2, 9, 5.
- Đặt count = 5 để xác định số phần tử hợp lệ đang có trong mảng.
- Hiển thị các phần tử hợp lệ.
Bước 2: Chèn phần tử bằng hàm Insert
- Nhận mảng, số phần tử hiện có count, vị trí chèn index và giá trị cần chèn value.
- Kiểm tra index nằm trong khoảng từ 0 đến count. Nếu không hợp lệ, phát sinh ngoại lệ.
- Kiểm tra mảng còn chỗ trống hay không. Nếu count == data.Length, thông báo mảng đã đầy.
- Duyệt từ cuối phần tử hợp lệ về vị trí chèn, dịch từng phần tử sang phải một ô để tạo khoảng trống.
- Gán value vào data[index].
- Tăng count lên 1.
- Hiển thị mảng sau khi chèn.
Bước 3: Xóa phần tử bằng hàm RemoveAt
- Nhận mảng, số phần tử hợp lệ count và vị trí cần xóa index.
- Kiểm tra index nằm trong khoảng từ 0 đến count - 1. Nếu không hợp lệ, phát sinh ngoại lệ.
- Duyệt từ vị trí cần xóa đến phần tử kế cuối, lần lượt sao chép phần tử bên phải sang trái một ô.
- Giảm count đi 1 để loại phần tử cuối khỏi phạm vi dữ liệu hợp lệ.
- Hiển thị mảng sau khi xóa.
Bước 4: Kiểm tra các trường hợp khác
Chương trình lần lượt thực hiện:
- Chèn 99 tại vị trí 2.
- Xóa phần tử tại vị trí 1.
- Chèn 10 vào đầu mảng.
- Chèn 20 vào cuối phần tử hợp lệ.
- Xóa phần tử đầu tiên.
- Xóa phần tử cuối cùng.
Sau mỗi thao tác, gọi PrintArray để hiển thị các phần tử từ vị trí 0 đến count - 1.
Độ phức tạp
- Chèn: \(O(n)\) trong trường hợp xấu nhất do phải dịch chuyển phần tử.
- Xóa: \(O(n)\) trong trường hợp xấu nhất do phải dịch chuyển phần tử.
- Bộ nhớ phụ: \(O(1)\), vì thao tác trực tiếp trên mảng có sẵn.
Lưu ý: data.Length là tổng sức chứa cố định bằng 8; count là số phần tử hợp lệ và thay đổi sau khi chèn hoặc xóa.

Bài 3. Quản lý sinh viên bằng List<Student>
Mục tiêu: Xây dựng chương trình quản lý sinh viên, hỗ trợ thêm, cập nhật, xóa, tìm kiếm và thống kê danh sách.
Mô tả thuật toán
Bước 1: Khởi tạo dữ liệu
- Xây dựng lớp Student gồm mã sinh viên Id, họ tên FullName và điểm Score.
- Tạo danh sách students kiểu List<Student>.
- Thêm 5 sinh viên mẫu vào danh sách.
Bước 2: Hiển thị menu chức năng
Hiển thị menu gồm:
- 1: Thêm sinh viên.
- 2: Cập nhật sinh viên.
- 3: Xóa sinh viên.
- 4: Tìm kiếm theo họ tên.
- 5: Hiển thị danh sách và thống kê.
- 0: Thoát chương trình.
Nhận lựa chọn từ bàn phím. Nếu dữ liệu nhập không phải số nguyên, thông báo lỗi và yêu cầu nhập lại. Dùng switch-case để gọi chức năng tương ứng. Menu tiếp tục hiển thị cho đến khi người dùng chọn 0.
Bước 3: Thêm sinh viên
- Nhập mã sinh viên.
- Kiểm tra mã không được để trống và chưa tồn tại trong danh sách bằng FindStudentById.
- Nhập họ tên và kiểm tra không được để trống.
- Nhập điểm, kiểm tra đúng định dạng số và nằm trong khoảng từ 0 đến 10.
- Nếu dữ liệu hợp lệ, tạo đối tượng Student mới và thêm vào danh sách bằng students.Add().
- Thông báo thêm thành công.
Bước 4: Cập nhật sinh viên
- Nhập mã sinh viên cần cập nhật.
- Tìm sinh viên bằng FindStudentById.
- Nếu không tìm thấy, thông báo lỗi.
- Nếu tìm thấy, cho phép chọn cập nhật họ tên hoặc điểm.
- Kiểm tra dữ liệu mới hợp lệ rồi gán giá trị vào thuộc tính tương ứng của đối tượng.
- Thông báo kết quả cập nhật.
Bước 5: Xóa sinh viên
- Nhập mã sinh viên cần xóa.
- Tìm sinh viên trong danh sách.
- Nếu không tìm thấy, thông báo lỗi.
- Nếu tìm thấy, gọi students.Remove(student) để xóa đối tượng khỏi danh sách.
- Thông báo xóa thành công.
Bước 6: Tìm kiếm sinh viên theo họ tên
- Nhập từ khóa tìm kiếm.
- Khởi tạo biến found = false.
- Duyệt lần lượt các sinh viên trong danh sách.
- Sử dụng IndexOf kết hợp StringComparison.OrdinalIgnoreCase để kiểm tra họ tên có chứa từ khóa, không phân biệt chữ hoa và chữ thường.
- Nếu tìm thấy, hiển thị mã sinh viên, họ tên và điểm, đồng thời đặt found = true.
- Nếu duyệt hết danh sách mà found vẫn bằng false, thông báo không tìm thấy sinh viên.
Bước 7: Hiển thị danh sách và thống kê
- Nếu students.Count == 0, thông báo danh sách rỗng và kết thúc chức năng.
- Nếu danh sách có dữ liệu, khởi tạo total = 0 và countPassed = 0.
- Duyệt từng sinh viên, hiển thị thông tin, cộng điểm vào total.
- Nếu điểm sinh viên lớn hơn hoặc bằng 5, tăng countPassed lên 1.
- Tính điểm trung bình bằng total / students.Count.
- Hiển thị điểm trung bình và số sinh viên có điểm từ 5 trở lên.
Bài 4. Xây dựng mảng động DynamicArray<T>
Mục tiêu: Tự xây dựng cấu trúc mảng động bằng mảng thông thường, cho phép thêm phần tử, truy cập và cập nhật phần tử, đồng thời tự tăng sức chứa khi cần.
Mô tả thuật toán
Bước 1: Khởi tạo mảng động
- Khai báo lớp tổng quát DynamicArray<T>.
- Tạo mảng nội bộ items có sức chứa ban đầu là 4.
- Khởi tạo count = 0 để biểu thị chưa có phần tử nào.
- Xây dựng thuộc tính Count trả về số phần tử hợp lệ.
- Xây dựng thuộc tính Capacity trả về sức chứa hiện tại của mảng.
Bước 2: Thêm phần tử bằng hàm Add
- Nhận giá trị cần thêm item.
- Kiểm tra nếu count == items.Length, nghĩa là mảng đã đầy.
- Nếu đầy, sử dụng Array.Resize để tăng sức chứa lên gấp đôi.
- Gán phần tử mới vào vị trí items[count].
- Tăng count lên 1.
Bước 3: Truy cập phần tử bằng indexer
Khi sử dụng cú pháp arr[index] để đọc dữ liệu:
- Kiểm tra index không âm và nhỏ hơn count.
- Nếu chỉ số không hợp lệ, phát sinh ArgumentOutOfRangeException.
- Nếu hợp lệ, trả về items[index].
Bước 4: Cập nhật phần tử bằng indexer
Khi sử dụng cú pháp arr[index] = value:
- Kiểm tra chỉ số nằm trong phạm vi hợp lệ.
- Nếu không hợp lệ, phát sinh ngoại lệ.
- Nếu hợp lệ, gán value vào items[index].
- Việc cập nhật không làm thay đổi count hoặc Capacity.
Bước 5: Kiểm tra hoạt động
- Tạo đối tượng DynamicArray<int>.
- Thêm lần lượt các số từ 1 đến 10.
- Sau mỗi lần thêm, hiển thị Count và Capacity.
- In các phần tử trong mảng.
- Đọc phần tử tại arr[2].
- Cập nhật arr[2] = 100 và in lại mảng.
- Thử truy cập arr[-1] và arr[arr.Count] để kiểm tra cơ chế xử lý chỉ số không hợp lệ.
