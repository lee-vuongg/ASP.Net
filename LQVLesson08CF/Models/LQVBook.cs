using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LQVLesson08CF.Models
{
    /// <summary>
    /// tạo ra cấu trúc bảng Book
    /// </summary>
    public class LQVBook
    {
        [Key]
        public int LQVBookId { get; set; }
        public string LQVTitle { get; set; }
        public string LQVAuthor { get; set; }
        public int LQVYear { get; set; }
        public string LQVPublisher { get; set; }
        public string LQVPicture { get; set; }
        public int LQVCategoryId { get; set; }

        // Thuộc tính quan hệ
        public virtual LQVCategory LQVCategory { get; set; }
    }
}