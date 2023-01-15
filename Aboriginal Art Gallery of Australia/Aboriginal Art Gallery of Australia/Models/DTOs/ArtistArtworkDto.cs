﻿namespace Aboriginal_Art_Gallery_of_Australia.Models.DTOs
{
    /// <summary>
    /// The ArtistArtworkDto class handles data and facilitates relationships between artists and artworks inside the database.
    /// </summary>
    public class ArtistArtworkDto
    {
        public int ArtistId { get; set; } = 0;
        public int ArtworkId { get; set; } = 0;

        public ArtistArtworkDto(int artistId, int artworkId)
        {
            ArtistId = artistId;
            ArtworkId = artworkId;
        }

        public ArtistArtworkDto()
        {
        }
    }
}