using CRUD_Kopilovs.Models;

namespace CRUD_Kopilovs.Models.ViewModels // Или просто CRUD_Kopilovs.Models, если нет папки ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }           // Идентификатор заказа
        public string ProductTitle { get; set; } // Название продукта
        public int Quantity { get; set; }     // Количество
        public Status Status { get; set; }    // Статус заказа
    }
}
