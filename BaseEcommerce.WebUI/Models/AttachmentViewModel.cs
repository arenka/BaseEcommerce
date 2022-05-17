namespace BaseEcommerce.WebUI.Models
{
    public class AttachmentViewModel
    {
        public string? AttachmentUrl { get; set; }
        public int? ProductId { get; set; }

        public virtual ProductViewModel? Product { get; set; }
    }
}
