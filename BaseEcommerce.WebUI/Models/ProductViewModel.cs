namespace BaseEcommerce.WebUI.Models
{
    public class ProductViewModel
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public int Discount { get; set; }
        public double? Price { get; set; }

        public virtual ICollection<CommentViewModel>? Comments { get; set; }
        public virtual AttachmentViewModel? Attachment { get; set; }
    }
}
