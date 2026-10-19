
using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi2_BoSung_33254020040.bai3
{
    public class Program
    {
        // tạo danh sách sinh viên
        static List<Student> students = new List<Student>();

        static void Main444(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Thêm 5 sinh viên vào danh sách
            students.Add(new Student("123456", "Trần Thị A", 8.5));
            students.Add(new Student("123457", "Nguyễn Văn B", 7.0));
            students.Add(new Student("123458", "Phạm Thị C", 9.0));
            students.Add(new Student("123459", "Lê Văn D", 4.5));
            students.Add(new Student("123460", "Hoàng Thị E", 8.0));

            //tạo biến n để lưu lựa chọn
            int n;

            //hiển thị menu lựa chọn chức năng dùng
            do
            {
                Console.WriteLine("\n===== QUẢN LÝ SINH VIÊN =====");
                Console.WriteLine("1: Thêm sinh viên");
                Console.WriteLine("2: Cập nhật sinh viên");
                Console.WriteLine("3: Xóa sinh viên");
                Console.WriteLine("4: Tìm kiếm theo họ tên");
                Console.WriteLine("5: Hiển thị danh sách va thống kê");
                Console.WriteLine("0: Thoat");
                Console.Write("Chọn chức năng: ");
                
                //nhập lựa chọn
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Nhập số cần thực hiện");
                    
                    //nhập lại lựa chọn
                    n = -1;
                    continue;
                }

                //dùng switch-case để thực hiện chức năng theo lựa chọn
                switch (n)
                {
                    //trường hợp 1 thêm sinh viên
                    case 1:
                        AddStudent();
                        break;

                    //trường hợp 2 cập nhật thông tin sinh viên
                    case 2:
                        UpdateStudent();
                        break;

                    //trường hợp 3 xóa sinh viên
                    case 3:
                        DeleteStudent();
                        break;

                    //trường hợp 4 tìm kiếm theo họ tên sinh viên
                    case 4:
                        SearchStudentByName();
                        break;

                    ///trường hợp 5 hiển thị danh sách sinh viên và thống kê
                    case 5:
                        DisplayStudent();
                        break;
                   
                    //trường hợp nếu bấm số 0  sẽ thoát chương trình
                    case 0:
                        Console.WriteLine("Thoát chương trình");
                        break;

                    //nếu bấm số ko đúng yêu cầu sẽ hiển thị và thoát chương trình
                    default:
                        Console.WriteLine("Chức năng không hợp lệ - cần nhập lại!");
                        break;
                }

            } 
            //Nhập số nằm trong khoảng từ 1-6 thì chương trình sẽ tiếp tục chạy
            while (n != 0);
        }

        // tìm sinh viên theo mã sinh viên
        static Student FindStudentById(string id)
        {
            //xét qua từng sinh viên trong danh sách
            foreach (var student in students)
            {
                //đối chiếu với mã sinh viên nhập vào nếu trùng thì trả về sinh viên đó
                if (student.Id == id)
                    return student;
            }

            //không tìm thấy sinh viên thì trả về null
            return null;
        }

        // chức năng 1. thêm sinh viên
        static void AddStudent()
        {
            Console.Write("Nhập MSSV: ");

            //nhập mã sinh viên từ bàn phím dạng chuỗi
            string id = Console.ReadLine();

            //nếu mã sinh viên trống thì thông báo và chọn lại
            if (string.IsNullOrWhiteSpace(id))
            {
                Console.WriteLine("MSSV không được để trống!");
                return;
            }

            //kiểm tra mã sv nhập vào đã tồn tại trong danh sách chưa
            if (FindStudentById(id) != null)
            {
                Console.WriteLine("MSSV đã tồn tại!");
                return;
            }

            //chưa tồn tại sinh viên thì nhập họ tên
            Console.Write("Nhập họ tên: ");
            string fullName = Console.ReadLine() ?? "";

            //kiểm tra tên có để trống không
            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Họ tên không được để trống!");
                return;
            }

            //Nhập điểm sinh viên
            Console.Write("Nhập điểm từ 0-10đ: ");

            //kiểm tra điểm nhập vào có hợp lệ không, nếu không hợp lệ thì thông báo và chọn lại
            if (!double.TryParse(Console.ReadLine(), out double score)
                || score < 0 || score > 10)
            {
                Console.WriteLine("Điểm không hợp lệ");
                return;
            }

            //thêm sinh viên mới vào danh sách sinh viên
            students.Add(new Student(id, fullName, score));
            Console.WriteLine("Thêm sinh viên thành công!");
        }

        // 2. cập nhật họ tên hoặc điểm của sinh viên
        static void UpdateStudent()
        {
            //Nhập mã sinh viên cần cập nhật
            Console.Write("Nhập MSSV cần cập nhật: ");

            //nhập mã sinh viên dạng chuỗi, nếu không sẽ gán giá trị rỗng
            string id = Console.ReadLine() ?? "";

            //tìm sinh viên theo mã sinh viên nhập vào
            Student student = FindStudentById(id);

            //nếu ko tìm thấy mã sinh viên thì thông báo
            if (student == null)
            {
                Console.WriteLine("Không tìm thấy mã sinh viên");
                return;
            }

            //Hiển thị lựa chọn Cập nhật họ tên hay điểm sinh viên
            Console.WriteLine("1. Cập nhật họ tên");
            Console.WriteLine("2. Cập nhật điểm");
            Console.Write("Chọn: ");

            //nhập từ bàn phím, nếu nhập sai thì thông báo và thoát
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
                return;
            }

            //nếu chọn 1 thì cập nhật họ tên
            if (choice == 1)
            {
                Console.Write("Nhập họ tên mới: ");
                string name = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Họ tên không được để trống");
                    return;
                }

                //biến name được gán giá trị tên mới và thông báo
                student.FullName = name;
                Console.WriteLine("Cập nhật tên thành công");
            }

            //lựa chọn 2 thì cập nhật điểm
            else if (choice == 2)
            {
                Console.Write("Nhập điểm mới (0-10): ");

                //kiểm tra điểm nhập mới có hợp lệ không
                if (!double.TryParse(Console.ReadLine(), out double score)
                    || score < 0 || score > 10)
                {
                    Console.WriteLine("điểm không hợp lệ!");
                    return;
                }

                //biến score được gián giá trị điểm mới nhập vào
                student.Score = score;
                Console.WriteLine("Cập nhật điểm thành công!");
            }
            
            //nếu lựa chọn khác 1 và 2, thì thông báo không hợp lệ và thoát chương trình
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ");
            }
        }

        // 3. Xóa sinh viên theo mã số sinh viên
        static void DeleteStudent()
        {
            Console.Write("Nhập MSSV cần xóa: ");
            //Nhập mã sinh viên cần xóa từ bàn phím, nếu không nhập gì thì gán giá trị rỗng
            string id = Console.ReadLine() ?? "";

            //tìm sinh viên theo mã sinh viên nhập vào
            Student student = FindStudentById(id);

            //nếu không tìm thấy sinh viên sẽ thông báo và thoát chương trình
            if (student == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên");
                return;
            }

            //nếu tìm thấy thì tiến hành xóa sinh viên khỏi danh sách students và thông báo
            students.Remove(student);
            Console.WriteLine("Xóa sinh viên thành công!");
        }

        // 4. Tìm kiếm thông tin sinh viên bằng 1 phần tên
        static void SearchStudentByName()
        {
            Console.Write("Nhập tên sinh viên: ");
            //Nhập tên sinh viên cần tìm kiếm từ bàn phím, nếu không nhập gì thì gán giá trị rỗng
            string keyword = Console.ReadLine() ?? "";
            keyword = keyword.ToLower();
            //gán biến found để kiểm tra có tìm thấy sinh viên không 
            bool found = false;

            //duyệt qua từng sinh viên trong danh sách students
            foreach (var student in students)
            {
                //kiểm tra từ khóa nhập vào có trong tên sinh viên không, có thì hiển thị thông tin của sinh viên
                if (student.FullName.IndexOf(
                    keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(
                        $"MSSV: {student.Id} - Họ tên: {student.FullName} - Điểm: {student.Score}");
                    //trả về kết quả true nếu tìm thấy sinh viên
                    found = true;
                }
            }
            //nếu không tìm thấy, thông báo và thoát chương trình
            if (!found)
                Console.WriteLine("Không tìm thấy sinh viên");
        }

        // 5. Hiển thị danh sách sinh viên, điểm trung bình và điểm >=5
        static void DisplayStudent()
        {
            //đếm số sinh viên trong danh sách, nếu không có hiển thị thông báo và thoát chương trình
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên rỗng!");
                return;
            }

            //khai báo biến total tính điểm tổng của mỗi sinh viên
            double total = 0;

            // khai báo biến contPassed để đếm số sinh viên đạt >=5
            int countPassed = 0;

            Console.WriteLine("\nDanh sách sinh viên:");

            //duyệt từng sinh viên trong danh sách
            foreach (var student in students)
            {
                Console.WriteLine(
                    $"MSSV: {student.Id} - Họ tên: {student.FullName} - Điểm: {student.Score}");

                total += student.Score;

                if (student.Score >= 5)
                    countPassed++;
            }

            Console.WriteLine($"Điểm trung bình: {total / students.Count}");
            Console.WriteLine($"Sinh viên có điểm 5 trở lên là: {countPassed}");
        }

      
    }
}
