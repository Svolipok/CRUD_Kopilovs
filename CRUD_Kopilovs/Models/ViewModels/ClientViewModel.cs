using CRUD_Kopilovs.Models;

namespace CRUD_Kopilovs.Models.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public int OrderCount { get; set; }
        public decimal AverageOrderAmount { get; set; }
        public List<OrderViewModel> Orders { get; set; }
    }
}
