using Example.Models;
using Microsoft.AspNetCore.Mvc;
namespace Example.Controllers
{
    public class StudentController : Controller
    {
        [Route("HomeStudent")]
        [Route("Student")]
        [Route("Student/ListAll")]
        [Route("Liet-Ke-Danh-Sach-Sinh-Vien")]

        public IActionResult ListAll()
        {
            // Gọi model => kết nối CSDL lấy thông tin sinh viên
            List<Student> ListStudents = new List<Student>()
    {
        new Student{ Id = 1, Name = "Đức Đạt", Age = 19, Gender = true,
            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSQxDnEkqD0BQctvxiaX6DyEPuEts1XxOHE83zGbEyGDoZinHvLksseS",
            Des = "Mô tả thông tin sinh viên"},

        new Student{ Id = 2, Name = "Thùy Trâm", Age = 25, Gender = false,
            ImgUrl = "https://clipart-library.com/images/zi8n1105c.png",
            Des = "Mô tả thông tin sinh viên"},

        new Student{ Id = 3, Name = "Nhà Phương", Age = 23, Gender = false,
            ImgUrl = "https://clipart-library.com/images/zi8n1105c.png",
            Des = "Mô tả thông tin sinh viên"},

        new Student{ Id = 4, Name = "Thành Viễn", Age = 20, Gender = true,
            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSQxDnEkqD0BQctvxiaX6DyEPuEts1XxOHE83zGbEyGDoZinHvLksseS",
            Des = "Mô tả thông tin sinh viên"},

        new Student{ Id = 5, Name = "Hoàng Việt", Age = 19, Gender = true,
            ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSQxDnEkqD0BQctvxiaX6DyEPuEts1XxOHE83zGbEyGDoZinHvLksseS",
            Des = "Mô tả thông tin sinh viên"}
    };

            return View(ListStudents);
        }

        public string ListOnlyStudent()
        {
            return "Liệt kê một sinh viên có id cụ thể";
        }

        public string EditStudent()
        {
            return "Chỉnh sửa thông tin một sinh viên có id cụ thể";
        }

        public string AddStudent()
        {
            return "Thêm thông tin một sinh viên";
        }

        public string DelStudent()
        {
            return "Xóa thông tin một sinh viên";
        }

    }
}
