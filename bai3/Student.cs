using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi2_BoSung_33254020040.bai3
{
    public class Student
    {
        // Lưu mã duy nhất dùng để nhận diện sinh viên.
        public string Id { get; set; } = "";

        // Lưu họ tên dùng cho hiển thị và tìm kiếm.
        public string FullName { get; set; } = "";

        // Lưu điểm tổng kết trong đoạn từ 0 đến 10.
        public double Score { get; set; }


        public Student(string id, string fullName, double score)
        {
            Id = id;
            FullName = fullName;
            Score = score;
        }
    }
}
