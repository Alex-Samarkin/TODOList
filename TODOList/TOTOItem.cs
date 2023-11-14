using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList
{
    public class TOTOItem
    {
        public static int Id { get; set; } = 0;
        public string Title { get; set; } = "Задача";
        public string Description { get; set; } = "Описание";
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsDone { get; set; } = false;

        public TOTOItem()
        {
            Id+= 1;
        }
    }
}
