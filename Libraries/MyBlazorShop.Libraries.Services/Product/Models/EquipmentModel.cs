using System.ComponentModel.DataAnnotations;

namespace MyBlazorShop.Libraries.Services.Product.Models
{
    public class EquipmentModel
    {
        
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) 
                return false;

            if (obj is EquipmentModel otherEquipmentModel)
                return Name.Equals(otherEquipmentModel.Name);

            return base.Equals(obj);
        }
    }
}
