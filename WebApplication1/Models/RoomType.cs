using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class RoomType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomTypeId{ get; set; }
        public string RoomTypeName {  get; set; }
        public int Area {  get; set; }
        public float Price {  get; set; }
        public string Bed{ get; set; }
        public string linkimg1{get; set; }
        public string linkimg2 { get; set; }
        public string linkimg3 { get; set; }
        public string linkimg4 { get; set; }
        public string linkimg5 { get; set; }
    }
}
