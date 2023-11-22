namespace HandMPRSystem.Models
{
    public class Quilt
    {
        public int Id { get; set; }
        private decimal Width {  get; set; } = 0;
        private decimal Height { get; set; } = 0;
        private string Size {  get; set; } = string.Empty;
        private decimal Area => Width * Height;
        private decimal Parimeter => Width + Width + Height + Height;
        private decimal? PantographPrice { get; set; } = 0;
        private decimal? PantographCost => Area * PantographPrice;
        private decimal? QuiltingPrice { get; set; } = 0;
        private decimal? QuiltingCost => Area * QuiltingPrice;
        private string QuiltingDescription { get; set; } = string.Empty;
        private decimal? BindingPrice {  get; set; } = 0;
        private decimal? BindingCost => Parimeter * BindingPrice;
        private decimal? BindingStripsNeeded => Parimeter / 44;
        private //decimal? BindingYardageNeeded => BindingStripsNeeded * 2.5;
        private decimal? BackingPrice { get; set; } = 0;
        private decimal? BackingCost => (Width + 6) / 36 * BackingPrice;
        private decimal? BackingAmountNeeded => Width + 6;
        private decimal? BattingPrice { get; set; } = 0;
        private decimal? BattingCost => (Width + 6) / 36 * BattingPrice;
        private decimal? BattingAmountNeeded => Width + 6;
        private string ThreadColor {  get; set; } = string.Empty;   
        private decimal? Embroidery { get; set;} = 0;
        private string EmbroideryDescription { get; set; } = string.Empty;
        private DateOnly DropOffDate {  get; set; } = new DateOnly();
    }
}
