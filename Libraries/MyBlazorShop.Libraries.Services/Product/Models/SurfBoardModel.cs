using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyBlazorShop.Libraries.Services.Product.Models
{
    public class SurfBoardModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public float Thickness { get; set; }

        public double Volume { get; set; }

        public decimal Price { get; set; }

        public BoardTypeModel BoardType { get; set; } //Has reference to class BoardTypeModel (Many to one relation)

        public ICollection<EquipmentModel>? Equipments { get; set; } = new List<EquipmentModel>(); //Collection of equipment (Many to many relation)
        
        /// <summary>
        /// The route slug of the product.
        /// </summary>
        public string Slug
        {
            get
            {
                return Id.ToString();
            }
        }

        /// <summary>
        /// The full URL of the product
        /// </summary>
        public string FullUrl
        {
            get
            {
                return string.Format("/product/{0}", Slug);
            }
        }

    }
}
