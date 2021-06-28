using System;

namespace DattingApp.API.Dtos
{
    public class PhotosForDetailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description  { get; set; }
        public DateTime Added { get; set; }
        public bool IsMain { get; set; }
    }
}