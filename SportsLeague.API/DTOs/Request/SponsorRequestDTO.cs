namespace SportsLeague.API.DTOs.Request
{
    public class SponsorRequestDTO
    {
        public string Name { get; set; } = string.Empty;

        public string ContactEmail { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string WebsiteUrl { get; set; } = string.Empty;

        // Según tu guía (Imagen 11), Category es un int (probablemente un Enum)
        public int Category { get; set; }
    }
}